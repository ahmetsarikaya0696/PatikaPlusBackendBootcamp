-- film tablosunda bulunan replacement_cost sütununda bulunan birbirinden farklı değerleri sıralayınız.
SELECT DISTINCT(f.replacement_cost) FROM film f;

-- film tablosunda bulunan replacement_cost sütununda birbirinden farklı kaç tane veri vardır?
SELECT COUNT(DISTINCT(f.replacement_cost)) FROM film f;

-- film tablosunda bulunan film isimlerinde (title) kaç tanesini T karakteri ile başlar ve aynı zamanda rating 'G' ye eşittir?
SELECT COUNT(*) FROM film f
WHERE f.title LIKE 'T%'
AND f.rating = 'G';

-- country tablosunda bulunan ülke isimlerinden (country) kaç tanesi 5 karakterden oluşmaktadır?
SELECT COUNT(*) FROM country c
WHERE LENGTH(c.country) = 5;

-- city tablosundaki şehir isimlerinin kaç tanesi 'R' veya r karakteri ile biter?
SELECT COUNT(*) FROM city c
WHERE c.city ILIKE '%r';