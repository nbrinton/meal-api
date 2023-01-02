
-- DELETE ALL EXISTING ENTRIES PRIOR TO CREATING SEED DATA ENTRIES
delete from recipes;
delete from recipe_ingredients;
delete from recipe_steps;
delete from ingredients;
delete from sections;
delete from meals;


-- CREATE SEED MEALS

insert into meals (created, updated, name)
values (now(), now(), 'breakfast');

insert into meals (created, updated, name)
values (now(), now(), 'lunch');

insert into meals (created, updated, name)
values (now(), now(), 'dinner');

insert into meals (created, updated, name)
values (now(), now(), 'dessert');

insert into meals (created, updated, name)
values (now(), now(), 'snack');

insert into meals (created, updated, name)
values (now(), now(), 'brunch');

-- CREATE SEED SECTIONS

insert into sections (id, name, created, updated)
values (0, 'Produce', now(), now());

insert into sections (id, name, created, updated)
values (1, 'Dairy', now(), now());

insert into sections (id, name, created, updated)
values (2, 'Meats', now(), now());

insert into sections (id, name, created, updated)
values (3, 'Deli', now(), now());

insert into sections (id, name, created, updated)
values (4, 'Canned Goods', now(), now());

insert into sections (id, name, created, updated)
values (5, 'Baking', now(), now());

insert into sections (id, name, created, updated)
values (6, 'Bakery', now(), now());

insert into sections (id, name, created, updated)
values (7, 'Spices', now(), now());

insert into sections (id, name, created, updated)
values (8, 'Hispanic', now(), now());

insert into sections (id, name, created, updated)
values (9, 'Asian', now(), now());

insert into sections (id, name, created, updated)
values (10, 'Bulk', now(), now());

insert into sections (id, name, created, updated)
values (11, 'Frozen Goods', now(), now());

insert into sections (id, name, created, updated)
values (12, 'Cereal', now(), now());

insert into sections (id, name, created, updated)
values (13, 'Candy', now(), now());

insert into sections (id, name, created, updated)
values (14, 'Chips and Snacks', now(), now());

insert into sections (id, name, created, updated)
values (15, 'Beverages', now(), now());

insert into sections (id, name, created, updated)
values (16, 'Pasta', now(), now());

insert into sections (id, name, created, updated)
values (17, 'Condiments', now(), now());

select *
from sections;


-- CREATE SEED INGREDIENTS

insert into ingredients (id, name, section_id, created, updated)
values (0, 'Fettuccine', 16, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (1, 'Stewed Tomatoes', 4, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (2, 'Crushed Tomatoes', 4, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (3, 'Ground Beef', 2, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (4, 'Yellow Onion', 0, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (5, 'Garlic', 0, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (6, 'Sugar', 5, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (7, 'Dried Basil', 10, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (8, 'Dried Oregano', 10, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (9, 'Kidney Beans', 4, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (10, 'Tomato Sauce', 4, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (11, 'Chili Seasoning', 7, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (12, 'Great Northern Beans', 4, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (13, 'Canned Corn', 4, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (14, 'Chicken Broth', 4, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (15, 'Salsa Verde', 8, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (16, 'Chicken Thighs', 2, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (17, 'All-Purpose Flour', 5, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (18, 'Cumin', 7, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (19, 'Farfalle', 16, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (20, 'Parmesan', 3, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (21, 'Olive Oil', 5, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (22, 'Pine Nuts', 10, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (23, 'No-Salt Seasoning', 7, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (24, 'Butter', 1, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (25, 'Heavy Whipping Cream', 1, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (26, 'Eggs', 1, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (27, 'Russet Potatoes', 0, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (28, 'Frozen Vegetable Mix', 11, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (29, 'Stubs Chicken Rub', 7, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (30, 'Montreal Steak Seasoning', 7, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (31, 'Steak', 2, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (32, 'Yoshida Sauce', 9, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (33, 'Bell Peppers', 0, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (34, 'Corn Starch', 5, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (35, 'Lemon Juice', 0, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (36, 'Milk', 1, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (37, 'Salt', 5, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (38, 'Baking Soda', 5, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (39, 'Bacon', 2, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (40, 'Sliced Cheddar', 3, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (41, 'Hamburger Buns', 3, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (42, 'Iceberg Lettuce', 0, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (43, 'Heirloom Tomato', 0, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (44, 'Ketchup', 17, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (45, 'Hoisin Sauce', 9, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (46, 'Soy Sauce', 9, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (47, 'Oyster Sauce', 9, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (48, 'Sweet Chili Sauce', 9, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (49, 'Crushed Red Pepper', 7, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (50, 'Apple Cider Vinegar', 5, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (51, 'Green Cabbage', 0, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (52, 'Peanut Oil', 5, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (53, 'Chow Mein Noodles', 9, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (54, 'Carrot', 0, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (55, 'Bean Sprouts', 9, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (56, 'Green Onions', 0, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (57, 'Sesame Oil', 9, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (58, 'Croissant', 6, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (59, 'Sweet Smoked Ham', 3, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (60, 'Vanilla Extract', 5, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (61, 'Banana', 0, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (62, 'Lala Yogurt', 1, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (63, 'Cereal', 12, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (64, 'Hashbrowns', 11, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (65, 'Mexican Cheese Blend', 3, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (66, 'Tortillas', 8, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (67, 'Ground Cinnamon', 5, now(), now());

insert into ingredients (id, name, section_id, created, updated)
values (68, 'White Bread', 6, now(), now());


-- CREATE SEED RECIPE
insert into recipes (prep_time, cook_time, meal_id, created, updated, name)
values (100, 100, 1, now(), now(), 'Bacon & Eggs');

-- CREATE SEED RECIPE INGREDIENTS
insert into recipe_ingredients (units, quantity, is_staple, ingredient_id, recipe_id, created, updated)
values('egg', 3, false, 26, 1, now(), now());

insert into recipe_ingredients (units, quantity, is_staple, ingredient_id, recipe_id, created, updated)
values ('slice', 3, false, 39, 1, now(), now());


-- CREATE SEED RECIPE STEPS
insert into recipe_steps ("order", content, recipe_id, created, updated)
values (1, 'Fry bacon in a skillet', 1, now(), now());

insert into recipe_steps ("order", content, recipe_id, created, updated)
values (2, 'Fry eggs in a skillet', 1, now(), now());




--select *
--from meals;

--select *
--from sections;

--select *
--from ingredients;

--select *
--from recipe_ingredients;

--select *
--from recipes;

--select *
--from recipes
--join recipe_ingredients ri on recipes.id = ri.recipe_id
--join ingredients i on ri.ingredient_id = i.id;

--select i.id
--     , i.name
--     , s.id
--     , s.name
--from ingredients i
--         inner join sections s on i.section_id = s.id;
