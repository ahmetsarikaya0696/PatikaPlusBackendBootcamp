-- film tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en uzun (length) 5 filmi sýralayýnýz.
SELECT * FROM film f
WHERE f.title LIKE '%n'
ORDER BY f.length DESC
LIMIT 5;

-- film tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en kýsa (length) ikinci(6,7,8,9,10) 5 filmi(6,7,8,9,10) sýralayýnýz.
SELECT * FROM film f
WHERE f.title LIKE '%n'
ORDER BY f.length ASC
OFFSET 5
LIMIT 5;

-- customer tablosunda bulunan last_name sütununa göre azalan yapýlan sýralamada store_id 1 olmak koþuluyla ilk 4 veriyi sýralayýnýz.
SELECT * FROM customer c
WHERE c.store_id = 1
ORDER BY c.last_name DESC
LIMIT 4;