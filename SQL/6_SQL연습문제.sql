#날짜:2022/7/21
#이름:김현동

CREATE TABLE `customer`(
`custld` VARCHAR(10) NOT NULL PRIMARY KEY,
`name` 	VARCHAR(10) NOT NULL,
`hp` 		CHAR(13) UNIQUE ,
`addr` 	varchar(100),
`rdate` 	DATE NOT NULL
);

CREATE TABLE `product`(
`prodNo`	  TINYINT 	  NOT NULL PRIMARY KEY,
`prodName` VARCHAR(10) NOT NULL,
`stock`	  INT		 	  NOT NULL,
`price` 	  INT 		  ,
`company`  VARCHAR(20) NOT NULL
);

CREATE TABLE `Order` (
`orderNo` 		TINYINT 			NOT NULL PRIMARY KEY,
`orderid` 		VARCHAR(10)		NOT NULL,
`orderProduct` TINYINT			NOT NULL,
`orderCount`	TINYINT			DEFAULT 1,
`orderDate`		DATETIME 		NOT NULL
);

INSERT INTO `Customer` VALUES ('heoj','허준',NULL,NULL,20220107);
INSERT INTO `Customer` VALUES ('jang','장보고','010-1234-1003','완도군청산면',20220103);
INSERT INTO `Customer` VALUES ('jeongc','정철','010-1234-1006','경기도용인시',20220106);
INSERT INTO `Customer` VALUES ('jeongyy','정약용','010-1234-1010','경기도광주시',20220110);
INSERT INTO `Customer` VALUES ('kang','강감찬','010-1234-1004','서울시마포구',20220104);
INSERT INTO `Customer` VALUES ('kimcc','김춘추','010-1234-1002','김해시봉황동',20220101);
INSERT INTO `Customer` VALUES ('kimys','김유신','010-1234-1001','경주시 보문동',20220102);
INSERT INTO `Customer` VALUES ('leesg','이성계',NULL,NULL,20220105);
INSERT INTO `Customer` VALUES ('leess','이순신','010-1234-1008','서울시영등포구',20220108);
INSERT INTO `Customer` VALUES ('songsh','송상현','010-1234-1009','부산시동래구',20220109);

INSERT INTO `Product`  VALUES (1,'새우깡',5000,1500,'농심');
INSERT INTO `Product`  VALUES (2,'초코파이',2500,2500,'오리온');
INSERT INTO `Product`  VALUES (3,'포카칩',3600,1700,'오리온');
INSERT INTO `Product`  VALUES (4,'양파링',1250,1800,'농심');
INSERT INTO `Product`  VALUES (5,'죠리퐁',2200,NULL,'크라운');
INSERT INTO `Product`  VALUES (6,'마카렛트',3500,3500,'롯데');
INSERT INTO `Product`  VALUES (7,'뿌셔뿌셔',1650,1200,'오뚜기');

INSERT INTO `Order` 	  VALUES (1,'kimcc',3,2,20220701131510);
INSERT INTO `Order` 	  VALUES (2,'kimys',4,1,20220701141611);
INSERT INTO `Order` 	  VALUES (3,'leess',1,1,20220701172318);
INSERT INTO `Order` 	  VALUES (4,'songsh',6,5,20220702104636);
INSERT INTO `Order` 	  VALUES (5,'kimcc',2,1,20220703091537);
INSERT INTO `Order` 	  VALUES (6,'kimys',7,3,20220703123512);
INSERT INTO `Order` 	  VALUES (7,'kjeongyy',1,2,20220703165536);
INSERT INTO `Order` 	  VALUES (8,'kang',2,4,20220704142323);
INSERT INTO `Order` 	  VALUES (9,'kimcc',1,3,20220704215434);
INSERT INTO `Order` 	  VALUES (10,'heoj',6,1,20220705142103);

#실습 6-4
SELECT * FROM `Customer`

#실습 6-5
SELECT custld,name,hp FROM `Customer`;

#실습6-6
SELECT * FROM `Product`;

#실습 6-7
SELECT `company` FROM `product`;

#실습 6-8
SELECT DISTINCT `company` FROM `product`;  

#실습 6-9
SELECT `prodname`,`price` FROM `product`;

#실습 6-10
SELECT `prodname`, `price`	+ 500 AS `조정단가` FROM `product`;

#실습 6-11
SELECT `prodname`,`stock`,`price` FROM `product` WHERE `company` = '오리온'

#실습6-12
SELECT `orderProduct`, `orderCount`, `orderDate` FROM `order` WHERE `orderid` ='kimcc';

#실습 6-13
SELECT `orderProduct`,`orderCount`,`orderDate` FROM `order` WHERE `orderid` = 'kimcc' AND `orderCount` >=2;

#실습 6-14
SELECT * FROM `product` WHERE `price` >= 1000 AND `price` <=2000;

실습 6-15
SELECT `custld`,`name`,`hp`,`addr` FROM `customer` WHERE `name` LIKE '김%';

SELECT `custid`, `name`, `hp`, `addr` FROM `customer` WHERE `name` LIKE '김%';

#실습 6-16
SELECT `custld`, `name`, `hp`, `addr` FROM `customer` WHERE `custld` LIKE '____';

실습 6-17
SELECT * FROM `customer` WHERE `hp` IS NULL;

#실습 6-18
SELECT * FROM `customer` WHERE `addr` IS NOT NULL;











