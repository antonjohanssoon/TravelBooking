CREATE DATABASE travelbooking;
USE travelbooking;

CREATE TABLE booking (
booking_id INT PRIMARY KEY AUTO_INCREMENT,
booking_name VARCHAR (45),
username VARCHAR (45),
flight_id INT,
activity_id INT
);

CREATE TABLE person (
	username VARCHAR(45) PRIMARY KEY UNIQUE,
    first_name VARCHAR(45),
    sur_name VARCHAR (45),
    age INT,
    email VARCHAR (300),
    user_password VARCHAR (45)
);


CREATE TABLE flight(
flight_id INT PRIMARY KEY AUTO_INCREMENT,
flight_name VARCHAR (10),
flight_date DATETIME,
destination VARCHAR (45),
departure VARCHAR (45),
price INT,
destination_id INT
);

CREATE TABLE destination(
destination_id INT PRIMARY KEY AUTO_INCREMENT,
destination_name VARCHAR (45),
country VARCHAR (45),
hotel VARCHAR (80)
);

CREATE TABLE activity(
activity_id INT PRIMARY KEY AUTO_INCREMENT,
activity_name VARCHAR (45),
time_hours INT,
time_minutes INT,
price INT
);

CREATE TABLE activity_at_destination(
destination_id INT,
activity_id INT,
PRIMARY KEY (destination_id, activity_id)
);

DROP TABLE activity_at_destination;
DROP TABLE destination;
DROP TABLE activity;
DROP TABLE person;
DROP TABLE booking;
DROP TABLE flight;

INSERT INTO person VALUES 
("footballswede", "Anton", "Johansson", 26,"antonjohansson@gmail.com", "antonisthebest"),
("littlebird", "Oskar", "Andersson", 45,"singlikemarley@mail.com", "singingbird"),
("theflyingsofa", "Ida", "Martinsson", 33,"sofaisflying@mail.com", "qwerty");

INSERT INTO destination VALUES 
(DEFAULT, "Madrid", "Spain", "Super Hotel Madrid"),
(DEFAULT, "Tokyo", "Japan", "Tokyo Hotel"),
(DEFAULT, "Liverpool", "UK", "Holiday Hotel Liverpool"),
(DEFAULT, "Buenos Aires", "Argentina", "Boavista Hotel"),
(DEFAULT, "Cairo", "Egypt", "Pyramid Hotel");

INSERT INTO flight VALUES
(DEFAULT, "EU9977", "2024-04-03 19:00:00", "Madrid", "Stockholm", 3000, 1),
(DEFAULT, "AS2356", "2024-08-23 22:40:00", "Tokyo", "Gothenburg", 8000, 2),
(DEFAULT, "EU6798", "2024-03-09 08:10:00", "Liverpool", "Gothenburg", 2000, 3),
(DEFAULT, "SA4712", "2024-11-29 03:00:00", "Buenos Aires", "Stockholm", 11200, 4),
(DEFAULT, "AF4499", "2024-12-06 12:40:00", "Cairo", "Gothenburg", 5700, 5);

INSERT INTO activity VALUES 
(DEFAULT, "Bungee Jump", 0, 30, 700),
(DEFAULT, "Watch football", 4, 45, 3000),
(DEFAULT, "Sightseeing", 5, 0, 1200),
(DEFAULT, "Pyramid tour", 8, 30, 2500),
(DEFAULT, "Ancient museum", 3, 30, 500),
(DEFAULT, "Yoga lession", 1, 15, 250)
;

INSERT INTO booking VALUES 
(DEFAULT, "Dream Trip", "littlebird", 5, 4),
(DEFAULT, "Football trip", "footballswede", 3, 2),
(DEFAULT, "Discover Asia", "theflyingsofa", 2, 1);

INSERT INTO booking VALUES 
(DEFAULT, "Big trip!", "footballswede", 4, 1);

INSERT INTO activity_at_destination VALUES 
(1,1),
(1,2),
(1,3),
(1,5),
(1,6),
(2,1),
(2,3),
(2,6),
(3,2),
(3,3),
(4,1),
(4,5),
(4,6),
(5,4),
(5,5);

SELECT * FROM person;
SELECT * FROM booking;
SELECT * FROM activity;
SELECT * FROM flight;
SELECT * FROM destination;
SELECT * FROM activity_at_destination;



CREATE OR REPLACE VIEW all_activity_destination AS
SELECT
    ad.destination_id AS Destination_id,
    d.destination_name AS Destination,
    a.activity_name AS Activity,
    a.time_hours AS Hours,
    a.time_minutes AS Minutes,
    a.price AS Price
FROM
    activity_at_destination ad
JOIN
    destination d ON ad.destination_id = d.destination_id
JOIN
    activity a ON ad.activity_id = a.activity_id;

SELECT * FROM all_activity_destination
WHERE Destination = "Buenos Aires";

DELIMITER $$
CREATE PROCEDURE new_person (
	username_par VARCHAR(45),
    first_name_par VARCHAR(45),
    sur_name_par VARCHAR (45),
    age_par INT,
    email_par VARCHAR (300),
    user_password_par VARCHAR (45)
)
BEGIN 
INSERT INTO person 
VALUES (username_par, first_name_par, sur_name_par, age_par, email_par, user_password_par);
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE new_booking (
    IN booking_name_par VARCHAR (45),
    IN username_par VARCHAR (45),
    IN flight_id_par INT,
    IN activity_id_par INT
)
BEGIN 
    INSERT INTO booking (booking_name, username, flight_id, activity_id)
    VALUES (booking_name_par, username_par, flight_id_par, activity_id_par);
END $$
DELIMITER ;

DROP PROCEDURE new_person;
DROP PROCEDURE new_booking;

CREATE OR REPLACE VIEW users_bookingdetails AS
SELECT 
	p.username,
    b.booking_id,
    b.booking_name, 
    d.destination_name, 
    d.country, 
    f.departure, 
    f.flight_name, 
    f.flight_date, 
    d.hotel, 
    a.activity_name, 
    (f.price + a.price) AS total_price
FROM 
    booking b
JOIN 
    flight f ON b.flight_id = f.flight_id
JOIN 
    destination d ON f.destination_id = d.destination_id
JOIN 
    activity a ON b.activity_id = a.activity_id
JOIN 
    person p ON b.username = p.username;

SELECT * FROM users_bookingdetails;

    
CREATE OR REPLACE VIEW all_bookings_in_system AS
SELECT 
	b.booking_id,
    b.booking_name, 
    d.destination_name, 
    d.country, 
    f.departure, 
    f.flight_name, 
    f.flight_date, 
    d.hotel, 
    a.activity_name, 
    (f.price + a.price) AS total_price
FROM 
    booking b
JOIN 
    flight f ON b.flight_id = f.flight_id
JOIN 
    destination d ON f.destination_id = d.destination_id
JOIN 
    activity a ON b.activity_id = a.activity_id
JOIN 
    person p ON b.username = p.username;

SELECT * FROM all_bookings_in_system;

CREATE USER booking_customer IDENTIFIED BY "travelingcustomer";
GRANT SELECT, DELETE, UPDATE, INSERT, EXECUTE
ON travelbooking.*
TO booking_customer;


    