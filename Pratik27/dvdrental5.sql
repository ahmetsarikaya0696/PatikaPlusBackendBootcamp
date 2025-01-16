-- film tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en uzun (length) 5 filmi s�ralay�n�z.
SELECT * FROM film f
WHERE f.title LIKE '%n'
ORDER BY f.length DESC
LIMIT 5;

-- film tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en k�sa (length) ikinci(6,7,8,9,10) 5 filmi(6,7,8,9,10) s�ralay�n�z.
SELECT * FROM film f
WHERE f.title LIKE '%n'
ORDER BY f.length ASC
OFFSET 5
LIMIT 5;

-- customer tablosunda bulunan last_name s�tununa g�re azalan yap�lan s�ralamada store_id 1 olmak ko�uluyla ilk 4 veriyi s�ralay�n�z.
SELECT * FROM customer c
WHERE c.store_id = 1
ORDER BY c.last_name DESC
LIMIT 4;