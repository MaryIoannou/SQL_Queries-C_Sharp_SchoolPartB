USE SCHOOL;
CREATE TABLE STUDENT 
( IDSTUDENT INTEGER NOT NULL,  
  FIRSTNAME CHAR(30) NOT NULL, 
  LASTNAME CHAR(30) NOT NULL,
  DATEOFBIRTH DATE ,
  TUITIONFEES FLOAT ,
  CONSTRAINT pk3 PRIMARY KEY(IDSTUDENT) 
 );