INSERT INTO Species VALUES ('PG', 'Peregrine');
INSERT INTO Species VALUES ('GF', 'Gyrfalcon');
INSERT INTO Species VALUES ('RF', 'Red-Footed');
INSERT INTO Species VALUES ('AK', 'American Kestrel');
INSERT INTO Species VALUES ('PR', 'Prarie');
INSERT INTO Species VALUES ('AP', 'Aplomado');
INSERT INTO Species VALUES ('MR', 'Merlin');
INSERT INTO Species VALUES ('SK', 'Saker');
INSERT INTO Species VALUES ('LN', 'Lanner');

INSERT INTO Genders VALUES ('M', 'Male');
INSERT INTO Genders VALUES ('F', 'Female');
INSERT INTO Genders VALUES ('O', 'Other');

INSERT INTO Trainers VALUES (1, 'Kass Smith', '20-Mar-2003', 'A', 'M');
INSERT INTO Trainers VALUES (2, 'Gemma Crowley', '19-Oct-2002', 'A', 'F');
INSERT INTO Trainers VALUES (3, 'Alex Doyle Kingston', '22-Jan-2003', 'A', 'O');
INSERT INTO Trainers VALUES (4, 'Drew Barret', '28-Apr-2001', 'A', 'F');

INSERT INTO Birds VALUES(1, 'Patricia', '07-Nov-2023', 'A', 2, 'PG', 'F');
INSERT INTO Birds VALUES(2, 'Gerry', '11-Nov-2023', 'A', 3, 'GF', 'M');
INSERT INTO Birds VALUES(3, 'Kes', '20-Mar-2023', 'A', 1, 'AK', 'M');

INSERT INTO Experiences VALUES ('HW', 'A', 50.00, 'Hawk Walk', 0);
INSERT INTO Experiences VALUES ('PR', 'A', 100.00, 'Private Experience', 0);
INSERT INTO Experiences VALUES ('PU', 'A', 70.00, 'Public Experience', 0);
INSERT INTO Experiences VALUES ('LE', 'A', 120.00, 'Lesson', 0);

INSERT INTO Bookings VALUES (1, '22-Oct-24 14:00:00', 2, 'Kass Smith', '0861686944', 'kass.smith@students.ittralee.ie', 60, 'HW', 2, 'R');
INSERT INTO Bookings VALUES (2, '16-Apr-24 14:00:00', 1, 'Eimear Kelly', '0857890123', 'eimear.kelly@gmail.com', 100, 'PR', 2, 'R');
INSERT INTO Bookings VALUES (3, '07-May-21 12:00:00', 8, 'Patrick Murphy', '0834567890', 'patrick.murphy@gmail.com', 190, 'LE', 3, 'R');
INSERT INTO Bookings VALUES (4, '28-Jun-22 10:00:00', 2, 'Saoirse Ryan', '0860123456', 'saoirse.ryan@gmail.com', 80, 'PU', 4, 'R');
INSERT INTO Bookings VALUES (5, '17-Aug-23 14:00:00', 5, 'Michael O''Connor', '0889876543', 'michael.oconnor@gmail.com', 90, 'HW', 1, 'R');
INSERT INTO Bookings VALUES (6, '05-Oct-24 15:00:00', 1, 'Sarah Fitzgerald', '0891237890', 'sarah.fitzgerald@gmail.com', 120, 'LE', 3, 'R');
INSERT INTO Bookings VALUES (7, '21-Jan-20 11:00:00', 4, 'Daniel Daly', '0874561234', 'daniel.daly@gmail.com', 80, 'HW', 2, 'R');
INSERT INTO Bookings VALUES (8, '10-Mar-21 10:00:00', 7, 'Aisling Brennan', '0852345678', 'aisling.brennan@gmail.com', 160, 'PR', 4, 'R');
INSERT INTO Bookings VALUES (9, '01-May-22 14:00:00', 10, 'Liam Nolan', '0865678901', 'liam.nolan@gmail.com', 210, 'LE', 1, 'R');
INSERT INTO Bookings VALUES (10, '22-Jul-23 11:00:00', 3, 'Fiona Burke', '0883456789', 'fiona.burke@gmail.com', 120, 'PR', 2, 'R');
INSERT INTO Bookings VALUES (11, '14-Sep-24 16:00:00', 2, 'David Walsh', '0897890123', 'david.walsh@gmail.com', 80, 'PU', 3, 'R');
INSERT INTO Bookings VALUES (12, '07-Feb-20 15:00:00', 6, 'Emer Higgins', '0878901234', 'emer.higgins@gmail.com', 120, 'PU', 4, 'R');
INSERT INTO Bookings VALUES (13, '24-Apr-21 09:00:00', 9, 'Brian O''Reilly', '0856789012', 'brian.oreilly@gmail.com', 200, 'LE', 1, 'R');
INSERT INTO Bookings VALUES (14, '15-Jun-22 16:00:00', 1, 'Grainne Kelly', '0869012345', 'grainne.kelly@gmail.com', 100, 'PR', 3, 'R');
INSERT INTO Bookings VALUES (15, '04-Aug-23 09:00:00', 5, 'Kevin Ryan', '0886785678', 'kevin.ryan@gmail.com', 110, 'PU', 4, 'R');
INSERT INTO Bookings VALUES (16, '28-Sep-24 13:00:00', 8, 'Catherine Fitzgerald', '0894560123', 'catherine.fitzgerald@gmail.com', 120, 'HW', 2, 'R');
INSERT INTO Bookings VALUES (17, '18-Jan-21 14:00:00', 7, 'Matthew Daly', '0872345678', 'matthew.daly@gmail.com', 160, 'PR', 1, 'R');
INSERT INTO Bookings VALUES (18, '02-Apr-22 11:00:00', 2, 'Louise Brennan', '0851234567', 'louise.brennan@gmail.com', 130, 'LE', 3, 'R');
INSERT INTO Bookings VALUES (19, '23-May-23 15:00:00', 4, 'Stephen Nolan', '0867890123', 'stephen.nolan@gmail.com', 100, 'PU', 4, 'R');
INSERT INTO Bookings VALUES (20, '16-Apr-24 14:00:00', 14, 'Lydia Sheehan', '0856969696', 'lydia.sheehan@gamail.com', 250, 'LE', 2, 'R');

INSERT INTO Ratings VALUES (1, 'The falconry experience was absolutely thrilling! Interacting with the majestic birds up close was an unforgettable experience. The falconer was incredibly knowledgeable and made the whole experience educational and enjoyable. Highly recommend!', 5, 'kass.smith@students.ittralee.ie', '22-OCT-24 15:30:45', 1);
INSERT INTO Ratings VALUES (2, 'While the falconry experience was interesting, I expected more hands-on interaction with the birds. The demonstrations were informative, but I would have liked more opportunities to hold and fly the birds myself.', 3, 'eimear.kelly@gmail.com', '16-APR-24 15:45:12', 2);
INSERT INTO Ratings VALUES (3, 'The falconry experience exceeded all expectations! The falcons were magnificent, and the falconer''s passion for these birds was evident. It was a magical experience that I''ll cherish forever.', 5, 'patrick.murphy@gmail.com', '07-MAY-21 13:20:30', 3);
INSERT INTO Ratings VALUES (4, 'Disappointing falconry experience. The birds seemed disinterested, and the falconer lacked enthusiasm. It felt more like a rushed tourist attraction than an authentic falconry experience.', 2, 'saoirse.ryan@gmail.com', '28-JUN-22 11:45:20', 4);
INSERT INTO Ratings VALUES (5, 'The falconry experience was average. While the birds were impressive, the overall presentation felt lacking. It would have been better with more interactive demonstrations and detailed explanations about the birds.', 3, 'michael.oconnor@gmail.com', '17-AUG-23 15:10:55', 5);
INSERT INTO Ratings VALUES (6, 'The falconry experience was underwhelming. The birds seemed agitated, and the falconer appeared disorganized. It lacked the excitement and engagement that I was hoping for.', 2, 'sarah.fitzgerald@gmail.com', '05-OCT-24 16:25:18', 6);
INSERT INTO Ratings VALUES (7, 'Absolutely loved the falconry experience! The falcons were magnificent creatures, and the falconer''s passion and knowledge were inspiring. It was an enriching experience that I would highly recommend to others.', 4, 'daniel.daly@gmail.com', '21-JAN-20 12:30:40', 7);
INSERT INTO Ratings VALUES (8, 'While the falconry experience was enjoyable, it felt a bit rushed. More time with the birds and additional explanations about falconry techniques would have made it even better.', 3, 'aisling.brennan@gmail.com', '10-MAR-21 11:15:57', 8);
INSERT INTO Ratings VALUES (9, 'An incredible falconry experience! The falcons were awe-inspiring, and the falconer''s expertise made the whole experience unforgettable. Would definitely do it again!', 5, 'liam.nolan@gmail.com', '01-MAY-22 15:55:22', 9);
INSERT INTO Ratings VALUES (10, 'The falconry experience was okay. While it was interesting to see the birds up close, the overall experience felt a bit lacking. It needed more interaction and engagement to make it truly memorable.', 3, 'fiona.burke@gmail.com', '22-JUL-23 12:40:36', 10);

DECLARE
    v_HW number(1);
    v_LE number(1);
    v_PR number(1);
    v_PU number(1);
BEGIN
    SELECT AVG(R.rating) INTO v_HW FROM Ratings R JOIN Bookings B ON B.BookingID = R.BookingID WHERE B.ExperienceID = 'HW';
    SELECT AVG(R.rating) INTO v_LE FROM Ratings R JOIN Bookings B ON B.BookingID = R.BookingID WHERE B.ExperienceID = 'LE';
    SELECT AVG(R.rating) INTO v_PR FROM Ratings R JOIN Bookings B ON B.BookingID = R.BookingID WHERE B.ExperienceID = 'PR';
    SELECT AVG(R.rating) INTO v_PU FROM Ratings R JOIN Bookings B ON B.BookingID = R.BookingID WHERE B.ExperienceID = 'PU';
    
    UPDATE Experiences SET Rating = v_HW WHERE ExperienceID = 'HW';
    UPDATE Experiences SET Rating = v_LE WHERE ExperienceID = 'LE';
    UPDATE Experiences SET Rating = v_PR WHERE ExperienceID = 'PR';
    UPDATE Experiences SET Rating = v_PU WHERE ExperienceID = 'PU';
END;
/

COMMIT;