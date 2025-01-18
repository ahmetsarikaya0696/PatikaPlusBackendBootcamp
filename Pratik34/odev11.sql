-- film tablosunda film uzunluğu length sütununda gösterilmektedir. Uzunluğu ortalama film uzunluğundan fazla kaç tane film vardır?
SELECT COUNT(*) FROM film f
WHERE f.length > 
(
SELECT AVG(length) FROM film
);

-- film tablosunda en yüksek rental_rate değerine sahip kaç tane film vardır?
SELECT COUNT(*) FROM film f
WHERE f.rental_rate = 
(
SELECT MAX(rental_rate) FROM film
);

-- film tablosunda en düşük rental_rate ve en düşün replacement_cost değerlerine sahip filmleri sıralayınız.
(
SELECT * FROM film f
WHERE f.rental_rate = 
	(
	SELECT MIN(rental_rate) FROM film
	)
)
UNION
(
SELECT * FROM film f
WHERE f.replacement_cost =
	(
	SELECT MIN(replacement_cost) FROM film
	)
);


-- payment tablosunda en fazla sayıda alışveriş yapan müşterileri(customer) sıralayınız.
SELECT * FROM payment
WHERE customer_id =
ANY
(
SELECT customer_id FROM
(
SELECT customer_id, COUNT(*) c FROM payment
GROUP BY customer_id
ORDER BY c DESC
LIMIT 10
) C
)
