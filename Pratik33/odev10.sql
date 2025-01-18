-- actor ve customer tablolarında bulunan first_name sütunları için tüm verileri sıralayalım.
(
SELECT first_name FROM customer
)
UNION ALL
(
SELECT first_name FROM actor
);

-- actor ve customer tablolarında bulunan first_name sütunları için kesişen verileri sıralayalım.
(
SELECT first_name FROM customer
)
INTERSECT
(
SELECT first_name FROM actor
);

-- actor ve customer tablolarında bulunan first_name sütunları için ilk tabloda bulunan ancak ikinci tabloda bulunmayan verileri sıralayalım.
(
SELECT first_name FROM actor
)
EXCEPT
(
SELECT first_name FROM customer
)

-- İlk 3 sorguyu tekrar eden veriler için de yapalım.
-- Soruyu anlayamadım.