CREATE TABLE PRODUCT(product_id int, product_name nvarchar(90),category_id int, model_year int,price int);
INSERT INTO PRODUCT VALUES(51,'SUZUKI',6790,2012,55000);
INSERT INTO PRODUCT VALUES(52,'YAMAHA',6540,2010,40000);
INSERT INTO PRODUCT VALUES(53,'BULLET',6600,2018,120000);
INSERT INTO PRODUCT VALUES(51,'SPLENDOR',6909,2014,50000);
INSERT INTO PRODUCT VALUES(51,'PEP+',6340,2016,60000);
INSERT INTO PRODUCT VALUES(51,'HONDA',680,2013,40000);
INSERT INTO PRODUCT VALUES(53,'TATA',NULL, 2019,53900);
INSERT INTO PRODUCT VALUES(54,'SPLENDOR',NULL,2015,45300);
INSERT INTO PRODUCT VALUES(55,NULL,345,2018,50000);

 SELECT * FROM PRODUCT WHERE price BETWEEN 50000 AND 200000 ORDER BY price ASC;
 SELECT * FROM PRODUCT WHERE price IN(50000,120000,60000,40000,55000) ORDER BY price;
 SELECT * FROM PRODUCT WHERE product_name LIKE '%e%' ORDER BY model_year;
 SELECT * FROM PRODUCT WHERE category_id IS NULL;
 SELECT * FROM PRODUCT WHERE product_name IS NULL;
 SELECT * FROM PRODUCT WHERE product_name IS NOT NULL;
 SELECT * FROM PRODUCT WHERE product_name LIKE 's%' AND category_id > 6500 ORDER BY price;
 SELECT * FROM PRODUCT WHERE product_id > 53 AND product_name IS NULL;

 SELECT * FROM PRODUCT WHERE product_id > 51 OR price > 50000 AND product_name IS NOT NULL;

 SELECT * FROM PRODUCT WHERE price IN(50000,120000,40000,60000);

 SELECT product_id,product_name,model_year FROM PRODUCT WHERE price = 40000 OR price = 120000 OR price = 55000;
 SELECT product_id,product_name,model_year FROM PRODUCT WHERE price NOT IN(40000,50000);
 SELECT * FROM PRODUCT WHERE product_name LIKE '%et';
 SELECT * FROM PRODUCT WHERE product_name LIKE 'su%';
 SELECT * FROM PRODUCT WHERE product_id BETWEEN 51 AND 55;