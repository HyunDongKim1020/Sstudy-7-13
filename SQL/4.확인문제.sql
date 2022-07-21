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

CREATE TABLE `Member` (
`uid` 	VARCHAR(10)  PRIMARY KEY,
`name`	VARCHAR(10)  NOT NULL,
`hp` 		CHAR(13)		 UNIQUE NOT NULL,
`pos` 	VARCHAR (10) NOT NULL,
`dep` 	TINYINT,
`rdate` 	DATETIME 	 NOT NULL
);

CREATE TABLE `Department` (
`depNo` TINYINT PRIMARY KEY NOT NULL,
`name`  VARCHAR (10) NOT NULL,
`tel`   char(12) NOT NULL
); 

CREATE TABLE `sales` (
`seq`   TINYINT AUTO_INCREMENT PRIMARY KEY,
`uid`   VARCHAR (10) NOT NULL,
`year`  YEAR NOT NULL,
`month` TINYINT NOT NULL,
`sale`  INT NOT NULL
);

INSERT INTO `member` VALUES ('a101','박혁거세','010-1234-1001','부장',101,'2020-11-19 11:39:48');
INSERT INTO `member` VALUES ('a102','김유신','010-1234-1002','차장',101,'2020-11-19 11:39:48');
INSERT INTO `member` VALUES ('a103','김춘추','010-1234-1003','사원',101,'2020-11-19 11:39:48');
INSERT INTO `member` VALUES ('a104','장보고','010-1234-1004','대리',102,'2020-11-19 11:39:48');
INSERT INTO `member` VALUES ('a105','강감찬','010-1234-1005','과장',102,'2020-11-19 11:39:48');
INSERT INTO `member` VALUES ('a106','이성계','010-1234-1006','차장',103,'2020-11-19 11:39:48');
INSERT INTO `member` VALUES ('a107','정철','010-1234-1007','차장',103,'2020-11-19 11:39:48');
INSERT INTO `member` VALUES ('a108','이순신','010-1234-1008','부장',104,'2020-11-19 11:39:48');
INSERT INTO `member` VALUES ('a109','허균','010-1234-1009','부장',104,'2020-11-19 11:39:48');
INSERT INTO `member` VALUES ('a110','정약용','010-1234-1010','사원',105,'2020-11-19 11:39:48');
INSERT INTO `member` VALUES ('a111','박지원','010-1234-1011','사원',105,'2020-11-19 11:39:48');

INSERT INTO `Department` VALUES (101,'영업1부','051-512-1001');
INSERT INTO `Department` VALUES (102,'영업2부','051-512-1002');
INSERT INTO `Department` VALUES (103,'영업3부','051-512-1003');
INSERT INTO `Department` VALUES (104,'영업4부','051-512-1004');
INSERT INTO `Department` VALUES (105,'영업5부','051-512-1005');
INSERT INTO `Department` VALUES (106,'영업지원부','051-512-1006');
INSERT INTO `Department` VALUES (107,'인사부','051-512-1007');

INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a101',2018,1,98100);
INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a102',2018,1,98100);
INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a103',2018,1,98100);

INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a104',2018,1,98100);
INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a105',2018,1,98100);
INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a101',2018,1,98100);

INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a102',2018,1,98100);
INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a103',2018,1,98100);
INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a105',2018,1,98100);

INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a106',2018,1,98100);
INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a101',2019,1,98100);
INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a102',2019,1,98100);

INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a103',2019,1,98100);
INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a104',2019,1,98100);
INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a107',2019,1,98100);

INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a102',2019,1,98100);
INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a103',2019,1,98100);
INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a104',2019,1,98100);

INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a105',2019,1,98100);
INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a106',2019,1,98100);
INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a102',2020,1,98100);

INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a104',2020,1,201000);
INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a105',2020,1,74000);
INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a106',2020,1,122000);

INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a107',2020,1,111000);
INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a102',2020,1,120000);
INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a103',2020,1,93000);

INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a104',2020,1,84000);
INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a105',2020,1,180000);
INSERT INTO `sales`(`uid`,`year`,`month`,`sale`) VALUES ('a108',2020,1,76000);
