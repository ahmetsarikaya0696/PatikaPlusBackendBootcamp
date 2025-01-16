-- film tablosunda bulunan filmleri rating deðerlerine göre gruplayýnýz.
SELECT f.rating FROM film f
GROUP BY f.rating

-- film tablosunda bulunan filmleri replacement_cost sütununa göre grupladýðýmýzda film sayýsý 50 den fazla olan replacement_cost deðerini ve karþýlýk gelen film sayýsýný sýralayýnýz.
SELECT f.replacement_cost, COUNT(*) FROM film f
GROUP BY f.replacement_cost
HAVING COUNT(f.replacement_cost) > 50;