-- film tablosunda bulunan rental_rate sütunundaki deðerlerin ortalamasý nedir?
SELECT ROUND(AVG(f.rental_rate),2) FROM film f;

-- film tablosunda bulunan filmlerden kaç tanesi 'C' karakteri ile baþlar?
SELECT COUNT(*) FROM film f
WHERE f.title LIKE 'C%';

-- film tablosunda bulunan filmlerden rental_rate deðeri 0.99 a eþit olan en uzun (length) film kaç dakikadýr?
SELECT f.length from film f
WHERE f.rental_rate = 0.99
ORDER BY f.length DESC
LIMIT 1;

-- film tablosunda bulunan filmlerin uzunluðu 150 dakikadan büyük olanlarýna ait kaç farklý replacement_cost deðeri vardýr?
SELECT COUNT(DISTINCT f.replacement_cost) FROM film f
WHERE f.length > 150;