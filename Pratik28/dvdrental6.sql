-- film tablosunda bulunan rental_rate s�tunundaki de�erlerin ortalamas� nedir?
SELECT ROUND(AVG(f.rental_rate),2) FROM film f;

-- film tablosunda bulunan filmlerden ka� tanesi 'C' karakteri ile ba�lar?
SELECT COUNT(*) FROM film f
WHERE f.title LIKE 'C%';

-- film tablosunda bulunan filmlerden rental_rate de�eri 0.99 a e�it olan en uzun (length) film ka� dakikad�r?
SELECT f.length from film f
WHERE f.rental_rate = 0.99
ORDER BY f.length DESC
LIMIT 1;

-- film tablosunda bulunan filmlerin uzunlu�u 150 dakikadan b�y�k olanlar�na ait ka� farkl� replacement_cost de�eri vard�r?
SELECT COUNT(DISTINCT f.replacement_cost) FROM film f
WHERE f.length > 150;