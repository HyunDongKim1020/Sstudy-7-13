#날짜:2022/7/19
#이름:김현동
#내용:테이블 설정

#실습하기 2-1
CREATE TABLE `User2` (
`uid` 	VARCHAR(10) PRIMARY KEY,
`name`	VARCHAR(10),
`hp`		CHAR(13),
`age`		INT
);

INSERT INTO `User2` VALUES ('a101','김유신','010-1234-1001',25);
INSERT INTO `User2` VALUES ('a102','장보고','010-1234-4321',23);
INSERT INTO `User2` VALUES ('a103','강감찬','010-1234-5678',45);
INSERT INTO `User2` VALUES ('a104','이정민','010-1234-9876',33);
INSERT INTO `User2` VALUES ('a105','이민수','010-1234-6789',66);
INSERT INTO `User2` VALUES ('a106','이민수병신','010-1234-5678',47);

#실습하기 2-2
CREATE TABLE `User3` (
`uid` 	VARCHAR(10) PRIMARY KEY,
`name`	VARCHAR(10),
`hp`		CHAR(13) UNIQUE,
`age`		INT
);

INSERT INTO `User3` VALUES ('a101','김유신','010-1234-1001',25);
INSERT INTO `User3` VALUES ('a102','장보고','010-1234-4321',23);
INSERT INTO `User3` VALUES ('a103','강감찬','010-1234-5678',45);
INSERT INTO `User3` VALUES ('a104','이정민','010-1234-9876',33);
INSERT INTO `User3` VALUES ('a105','이민수','010-1234-6789',66);
INSERT INTO `User3` VALUES ('a106','이민수병신','010-1234-5678',47);

CREATE TABLE `Parent` (
`pid` 	VARCHAR(10) PRIMARY KEY,
`name` 	VARCHAR(10),
`hp` 		CHAR(13)UNIQUE
);

child CREATE TABLE `Child` (
`cid`		VARCHAR(10) PRIMARY KEY,
`name`	VARCHAR(10),
`hp`		CHAR(13) UNIQUE,
`pid`		VARCHAR(10),
FOREIGN KEY(`pid`)REFERENCES `Parent`(`pid`)
); 

INSERT INTO `Parent` VALUES ('p101','김유신','010-1234-1001');
INSERT INTO `Parent` VALUES ('p102','이민수','010-1234-1002');
INSERT INTO `Parent` VALUES ('p103','이정민','010-1234-1003');

INSERT INTO `Child` VALUES ('c101','김현동','010-8698-6363','p101');
INSERT INTO `Child` VALUES ('c102','김채은','010-3566-0053','p101');
INSERT INTO `Child` VALUES ('c103','김현동','010-2462-0053','p103');
INSERT INTO `Child` VALUES ('c103','김영수','010-9353-5192','p105');

#실습하기 2-4
CREATE TABLE `User4` (
	`seq`		INT AUTO_INCREMENT PRIMARY KEY,
	`name`	VARCHAR(10),
	`gender`	TINYINT,
	`age`		INT,
	`addr`	VARCHAR(255)
);

INSERT INTO `User4` (`name`,`gender`,`age`,`addr`)VALUES ('김유신',1,25,'김해시');
INSERT INTO `User4` (`name`,`gender`,`age`,`addr`)VALUES ('김춘주',1,22,'경주시시');
INSERT INTO `User4` (`name`,`gender`,`age`,`addr`)VALUES ('이순신',1,35,'부산광역시');
INSERT INTO `User4` (`name`,`gender`,`age`,`addr`)VALUES ('심사임당',2,42,'김해시');

INSERT INTO `User4` SET `addr` = '부산시';

CREATE TABLE `User5` (
	`seq`		INT AUTO_INCREMENT PRIMARY KEY,
	`name`	VARCHAR(10) NOT NULL,
	`gender`	TINYINT DEFAULT 0,
	`age`		INT DEFAULT 1,
	`addr`	VARCHAR(255)
);

INSERT INTO `User5` (`name`,`gender`,`age`,`addr`)VALUES ('김유신',1,25,'김해시');
INSERT INTO `User5` (`name`,`gender`,`age`,`addr`)VALUES ('김춘주',1,22,'경주시시');
INSERT INTO `User5` (`name`,`gender`,`age`,`addr`)VALUES ('이순신',1,35,'부산광역시');
INSERT INTO `User5` (`name`,`gender`,`age`,`addr`)VALUES ('심사임당',2,42,'김해시');

INSERT INTO `User5` SET `name` ='김현동',`addr` = '부산시'; 

#실습2-6
CREATE TABLE `User6` LIKE `User5`;

#실습 2-7
INSERT INTO `User6` SELECT * FROM `User5`;
INSERT INTO `User6` (`name`,`gender`,`age`,`addr`)
							SELECT `name`,`gender`,`age`,`addr`FROM `User5`;

