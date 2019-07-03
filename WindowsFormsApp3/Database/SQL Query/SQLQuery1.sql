
CREATE TABLE BackhoeDB(
	bookingID VARCHAR(20) PRIMARY  key,
	backhoeType VARCHAR(20)
);

INSERT	INTO BackhoeDB VALUES('100a', 'A');
INSERT	INTO BackhoeDB VALUES('101a', 'b');
INSERT	INTO BackhoeDB VALUES('102a', 'c');
INSERT	INTO BackhoeDB VALUES('103a', 'd');

SELECT * FROM dbo.BackhoeDB;