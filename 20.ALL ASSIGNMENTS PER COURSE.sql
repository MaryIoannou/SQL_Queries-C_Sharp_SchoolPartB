USE SCHOOL;
SELECT C.IDCOURSE,C.TITLE,C.STREAM,C.TYPE,A.DESCRIPTION,A.SUBDATETIME
FROM COURSE_ASSIGNMENT CA
INNER JOIN COURSE C ON CA.IDC= C.IDCOURSE
INNER JOIN ASSIGNMENT A ON CA.IDA= A.IDASSIGNMENT;