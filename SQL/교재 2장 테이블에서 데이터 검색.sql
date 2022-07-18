#날짜:2022/7/18일
#이름:김현동
#내용: 교제 2장 테이블에서 데이터 검색 

#테이블 생성
CREATE TABLE `sample21`(
	`no` 		INT,
	`name` 	VARCHAR(10),
	`birthday` CHAR(10),
	`address`	VARCHAR(100)
	);
	

	
	#데이터 저장
INSERT INTO `sample21` VALUES (1,'김현동','2001-10-20','경남 김해시');
INSERT INTO `sample21` (`no`,`name`,`address`)
					VALUES (2,'박준용','대구광역시 동구');
INSERT INTO `sample21` (`no`,`name`,`address`)
					VALUES (3,'홍길동','서울특별시 마포구');

#p53
SELECT * FROM `sample21`;
#---------------------------------
#5강 테이블 구조 참조하기
#----------------------------------
#62
mysql>DESC sample21;
#----------------------------------
#6강 검색조건 지정하기
#-----------------------------------
#p66
SELECT `no`,`name` FROM `sample21`
#p68
SELECT * FROM `sample21` WHERE `no` = 2;
#p70
SELECT * FROM `sample21` WHERE `no` <> 2;
#ㄴ2가 아닌것만 실행

#p71
SELECT * FROM `sample21` WHERE `name`  = '박준용'; 
#p72
SELECT * FROM `sample21` WHERE `birthday` = '2001-10-20';
SELECT * FROM `sample21` WHERE `birthday` = NULL;

#p73
SELECT * FROM `sample21` WHERE `birthday` IS NULL;
SELECT * FROM `sample21` WHERE `birthday` IS NOT NULL;
#----------------------------------------
#7강 조건 조합하기
#----------------------------------------
#테이블 생성/데이터 저장
CREATE TABLE `sample24`(
	`no` INT, 
	`a` INT,
	`b` INT,
	`c` int
	);
	
	INSERT INTO `sample24` VALUES (1,1,0,0);
	INSERT INTO `sample24` VALUES (2,0,1,0);
	INSERT INTO `sample24` VALUES (3,0,0,1);
	INSERT INTO `sample24` VALUES (4,2,2,0);
	INSERT INTO `sample24` VALUES (5,0,2,2);
	
#p76
SELECT * FROM `sample24`;

#p77
SELECT * FROM `sample24` WHERE a<>0 AND b<>0;
#ㄴa,b열 둘다 0이 아닌걸 출력

#p78
SELECT * FROM `sample24` WHERE a<> 0 OR b<>0;
#ㄴa,b열 중에 하나가 0이 아닌걸 출력

#p80
SELECT * FROM `sample24` WHERE a=1 OR a=2 AND b =1 OR b = 2;
#ㄴa열이 1또는 2이고 ,b 열이 1또는 2인 행을 검색

#p82
SELECT * FROM `sample24` WHERE NOT(a<>0 OR b<>0);
#ㄴa열이0이 아니거나 b열이 0이 아닌 행을 제외한 행을 출력

#---------------------------------
#8강 패턴 매칭에 의한 검색
#--------------------------------
#테이블 생성 테이블 저장

CREATE TABLE `sample25` (
		`no` INT,
		`text` VARCHAR(255)
		);
		
		INSERT INTO `sample25` VALUES (1,'SQL은RDBMS를 조작하는 언어이다' )  
		INSERT INTO `sample25` VALUES (2,'LIKE에서는 메타문자%와_를 사용할수 잇다');
		INSERT INTO `sample25` VALUES (3,'LIKE에서는 SQL에서 사용할수 있는 술어 중 하나이다');
		
		#p85
		#p86
		#p88
	
	
	
	
	
	
	
	
