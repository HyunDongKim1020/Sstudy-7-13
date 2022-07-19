#날짜 : 2022/07/18
#이름 : 김현동
#내용 : 교재 2장 테이블에서 데이터 검색

#------------------------------
#4강 Hello World 실행하기
#------------------------------
# 테이블 생성
CREATE TABLE `sample21` (
	`no`	     INT,
	`name`     VARCHAR(10),		
	`birthday` CHAR(10),	
	`address`  VARCHAR(100)
);

# 데이터 저장
INSERT INTO `sample21` ();
INSERT INTO `sample21` ();
INSERT INTO `sample21` ();

#p53
SELECT * FROM sample21;
#------------------------------
#5강 테이블 구조 참조하기
#------------------------------

#------------------------------
#6강 검색조건 지정하기
#------------------------------
#p66
SELECT `NO`,`name` FROM sample21;
#p68
SELECT * FROM sample21 WHERE `no` = 2;
#p70
SELECT * FROM sample21 WHERE NO <> 2;
#p71
SELECT * FROM sample21 WHERE NAME ='박준용'
#p72
SELECT * FROM sample21 WHERE `birthday` = NULL;
#p73
SELECT * FROM sample21 WHERE birthday IS NULL;
#------------------------------
#7강 조건 조합하기
#------------------------------
# 테이블 생성/데이터 저장
CREATE TABLE `sample24` (
	`no` INT,
	`a` INT,
	`b` INT,
	`c` INT 
);

INSERT INTO `sample24` (1,1,0,0);
INSERT INTO `sample24` (2,0,1,0);
INSERT INTO `sample24` (3,0,0,1);
INSERT INTO `sample24` (4,2,2,0);
INSERT INTO `sample24` (5,0,2,2);

#p76
SELECT * FROM sample24;
#p77
SELECT * FROM sample24 WHERE a<>0 and b <>0;
#p78
SELECT * FROM sample24 WHERE a<>0 OR b <>0;
#p80
SELECT * FROM sample24 WHERE a=1 OR a=2 AND b=1 OR b=2;
#p82

#------------------------------
#8강 패턴 매칭에 의한 검색
#------------------------------
# 테이블 생성/데이터 저장
CREATE TABLE `sample25` (
	`no` INT,
	`text` VARCHAR(255)
);

INSERT INTO `sample25` VALUES (1,'SQL은RDMBS를조작하는언어이다');
INSERT INTO `sample25` VALUES (2,'LIKE에서는 메타문자%와_를사용할수 있다');
INSERT INTO `sample25` VALUES (3,'LIKE에서는 SQL에서 사용할수 있는 술어 중 하나이다');


#p85
SELECT * FROM sample25 WHERE TEXT LIKE 'SQL%'
#p86
#ㄴSQL로 시작하는 문장 출력
SELECT * FROM sample25 WHERE TEXT LIKE '%SQL%';
#p88
#ㄴsql이 들어있는 문장 출력
SELECT * FROM sample25 WHERE TEXT LIKE '%SQL';
#ㄴsql로 끝나느 문장 출력
#p95
CREATE TABLE `sample31`(
`name`	VARCHAR(10),
`age` 	INT,
`address`CHAR(13)
);

INSERT INTO `sample31` VALUES('A씨',36,'대구광역시중구');
INSERT INTO `sample31` VALUES('B씨',18,'부산광역시연제구');
INSERT INTO `sample31` VALUES('C씨',25,'서울특별시중구');

SELECT * FROM sample31 ORDER BY age;
#ㄴ 나이순으로 정렬
SELECT * FROM sample31;

SELECT * FROM sample31 ORDER BY address;

SELECT * FROM sample31 ORDER BY age DESC;
#ㄴ내림차순
SELECT * FROM sample31 ORDER BY age ASC;
#ㄴ오름차순