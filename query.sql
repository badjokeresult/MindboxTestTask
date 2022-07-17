SELECT name_product, name_category
FROM 
	product
	LEFT JOIN product_category USING(id)
	JOIN category USING(id);
