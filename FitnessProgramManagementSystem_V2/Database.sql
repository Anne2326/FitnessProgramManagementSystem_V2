Create database FitnessProgramManagement ;
use FitnessProgramManagement ;

create table FitnessPrograms (	FitnessProgramId  NVARCHAR(20) PRIMARY KEY,
Title NVARCHAR(20),
Duration NVARCHAR(23),
Price DECIMAL (20));

INSERT INTO FitnessPrograms VALUES('f01','weight Training ', '6 months',  10); 