ALTER TABLE Ratings 
DROP CONSTRAINT fk_rating_booking;

DROP TABLE Bookings;
DROP TABLE Experiences;
DROP TABLE Ratings;
DROP TABLE Birds;
DROP TABLE Trainers;
DROP TABLE Species;
DROP TABLE Genders;

CREATE TABLE Species (
    SpeciesID char(2) NOT NULL,
    Description varchar2(20) NOT NULL,
    CONSTRAINT pk_species PRIMARY KEY (SpeciesID)
);

CREATE TABLE Genders (
    GenderID char(1) NOT NULL,
    Description varchar2(10) NOT NULL,
    CONSTRAINT pk_gender PRIMARY KEY (GenderID)
);

CREATE TABLE Trainers(
    TrainerID number(7) NOT NULL,
    Name varchar2(20) NOT NULL,
    DOB date NOT NULL,
    Status char(1) DEFAULT 'A',
    GenderID char(1) NOT NULL,
    CONSTRAINT pk_trainer PRIMARY KEY (TrainerID),
    CONSTRAINT fk_trainer_gender FOREIGN KEY (GenderID) REFERENCES Genders
);

CREATE TABLE Birds(
    BirdID number(7) NOT NULL,
    Name varchar2(20) NOT NULL,
    DOB date NOT NULL,
    Status char(1) DEFAULT 'A',
    TrainerID number(7) NOT NULL,
    SpeciesID char(2) NOT NULL,
    GenderID char(1) NOT NULL,
    CONSTRAINT pk_bird PRIMARY KEY (BirdID),
    CONSTRAINT fk_bird_trainer FOREIGN KEY (TrainerID) REFERENCES Trainers,
    CONSTRAINT fk_bird_species FOREIGN KEY (SpeciesID) REFERENCES Species,
    CONSTRAINT fk_bird_gender FOREIGN KEY (GenderID) REFERENCES Genders
);

CREATE TABLE Ratings(
    RatingID number(3) NOT NULL,
    Feedback varchar2(250),
    Rating number(1) NOT NULL,
    Email varchar(100),
    DateOfRating timestamp NOT NULL,
    BookingID number(7) NOT NULL,
    CONSTRAINT ck_rating CHECK (Rating <= 5 AND Rating > 0),
    CONSTRAINT pk_rating PRIMARY KEY (RatingID)
);

CREATE TABLE Experiences(
    ExperienceID char(2) NOT NULL,
    Status char(1) DEFAULT 'A',
    Cost number(5,2) NOT NULL,
    Description varchar2(20) NOT NULL,
    Rating number(1),
    CONSTRAINT pk_experience PRIMARY KEY (ExperienceID)
);

CREATE TABLE Bookings(
    BookingID number(7) NOT NULL,
    DateAndTime timestamp NOT NULL,
    NoOfPersons number(2) NOT NULL,
    Name varchar2(20) NOT NULL,
    PhoneNumber varchar2(10) NOT NULL,
    Email varchar(100) NOT NULL,
    Cost number(5,2) NOT NULL,
    ExperienceID char(2) NOT NULL,
    TrainerID number(7) NOT NULL,
    Status char(1) DEFAULT 'R',
    CONSTRAINT pk_booking PRIMARY KEY (BookingID),
    CONSTRAINT fk_booking_experience FOREIGN KEY (ExperienceID) REFERENCES Experiences,
    CONSTRAINT fk_booking_trainer FOREIGN KEY (TrainerID) REFERENCES Trainers
);

ALTER TABLE Ratings 
ADD CONSTRAINT fk_rating_booking FOREIGN KEY (BookingID) REFERENCES Bookings;

COMMIT;
    