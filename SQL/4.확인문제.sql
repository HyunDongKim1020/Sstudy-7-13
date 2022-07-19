#날짜 : 2022/07/19
#이름 : 김현동
#내용 : 확인문제

CREATE TABLE `tbl_member`(
`memberID` VARCHAR(10)PRIMARY KEY,
`memberName` VARCHAR(10)NOT null,
`memberHp`	CHAR(13)UNIQUE ,
`memberAge` TINYINT,
`memberAddr`VARCHAR(25)
);

CREATE TABLE `tbl_product`(
`productCode`  int AUTO_INCREMENT PRIMARY KEY,
`productName`  VARCHAR(10)NOT NULL,
`price`			INT NOT NULL,
`amount` 		INT NOT NULL,
`company` 		VARCHAR(10) DEFAULT 0,
`makeDate`		DATE
);

INSERT INTO `tbl_member`(
