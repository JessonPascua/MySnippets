-- GET ALL COLUMNS NAME IN ONE ROW
SELECT string_agg(table_name || '.' || column_name, ', ')
FROM information_schema.columns
WHERE table_name = 'your_table'
  AND table_schema = 'your_chema';	
	
SELECT *
FROM manufacturing.products;

-- CREATE VIEW manufacturing.product_details AS
SELECT products.product_id,
	products.name AS products_name,
	products.manufacturing_cost,
	categories.name AS categories_name,
	categories.market
FROM manufacturing.products JOIN manufacturing.categories 
	ON categories.category_id = products.category_id
Where market = 'industrial';


SELECT employees.first_name,
	employees.last_name,
	employees.hire_date,
	departments.department_name,
	departments.building
FROM human_resources.employees JOIN human_resources.departments
	ON departments.deparment_id = employees.department_id
WHERE departments.building = 'South';

SELECT *
FROM human_resources.departments;
