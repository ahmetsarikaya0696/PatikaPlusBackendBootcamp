-- film tablosunda bulunan filmleri rating de�erlerine g�re gruplay�n�z.
SELECT f.rating FROM film f
GROUP BY f.rating

-- film tablosunda bulunan filmleri replacement_cost s�tununa g�re gruplad���m�zda film say�s� 50 den fazla olan replacement_cost de�erini ve kar��l�k gelen film say�s�n� s�ralay�n�z.
SELECT f.replacement_cost, COUNT(*) FROM film f
GROUP BY f.replacement_cost
HAVING COUNT(f.replacement_cost) > 50;