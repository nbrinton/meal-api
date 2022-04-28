-- DELETE ALL EXISTING ENTRIES PRIOR TO CREATING SEED DATA ENTRIES
delete from recipes;
delete from recipe_ingredients;
delete from recipe_steps;
delete from ingredients;
delete from sections;

-- CREATE SEED SECTIONS

insert into sections ("Id", "Name", "Created", "Updated")
values (0, 'Produce', now(), now());

insert into sections ("Id", "Name", "Created", "Updated")
values (1, 'Dairy', now(), now());

insert into sections ("Id", "Name", "Created", "Updated")
values (2, 'Meats', now(), now());

insert into sections ("Id", "Name", "Created", "Updated")
values (3, 'Deli', now(), now());

insert into sections ("Id", "Name", "Created", "Updated")
values (4, 'Canned Goods', now(), now());

insert into sections ("Id", "Name", "Created", "Updated")
values (5, 'Baking', now(), now());

insert into sections ("Id", "Name", "Created", "Updated")
values (6, 'Bakery', now(), now());

insert into sections ("Id", "Name", "Created", "Updated")
values (7, 'Spices', now(), now());

insert into sections ("Id", "Name", "Created", "Updated")
values (8, 'Hispanic', now(), now());

insert into sections ("Id", "Name", "Created", "Updated")
values (9, 'Asian', now(), now());

insert into sections ("Id", "Name", "Created", "Updated")
values (10, 'Bulk', now(), now());

insert into sections ("Id", "Name", "Created", "Updated")
values (11, 'Frozen Goods', now(), now());

insert into sections ("Id", "Name", "Created", "Updated")
values (12, 'Cereal', now(), now());

insert into sections ("Id", "Name", "Created", "Updated")
values (13, 'Candy', now(), now());

insert into sections ("Id", "Name", "Created", "Updated")
values (14, 'Chips and Snacks', now(), now());

insert into sections ("Id", "Name", "Created", "Updated")
values (15, 'Beverages', now(), now());

insert into sections ("Id", "Name", "Created", "Updated")
values (16, 'Pasta', now(), now());

insert into sections ("Id", "Name", "Created", "Updated")
values (17, 'Condiments', now(), now());

select *
from sections;


-- CREATE SEED INGREDIENTS

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (0, 'Fettuccine', 16, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (1, 'Stewed Tomatoes', 4, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (2, 'Crushed Tomatoes', 4, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (3, 'Ground Beef', 2, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (4, 'Yellow Onion', 0, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (5, 'Garlic', 0, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (6, 'Sugar', 5, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (7, 'Dried Basil', 10, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (8, 'Dried Oregano', 10, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (9, 'Kidney Beans', 4, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (10, 'Tomato Sauce', 4, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (11, 'Chili Seasoning', 7, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (12, 'Great Northern Beans', 4, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (13, 'Canned Corn', 4, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (14, 'Chicken Broth', 4, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (15, 'Salsa Verde', 8, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (16, 'Chicken Thighs', 2, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (17, 'All-Purpose Flour', 5, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (18, 'Cumin', 7, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (19, 'Farfalle', 16, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (20, 'Parmesan', 3, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (21, 'Olive Oil', 5, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (22, 'Pine Nuts', 10, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (23, 'No-Salt Seasoning', 7, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (24, 'Butter', 1, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (25, 'Heavy Whipping Cream', 1, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (26, 'Eggs', 1, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (27, 'Russet Potatoes', 0, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (28, 'Frozen Vegetable Mix', 11, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (29, 'Stubs Chicken Rub', 7, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (30, 'Montreal Steak Seasoning', 7, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (31, 'Steak', 2, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (32, 'Yoshida Sauce', 9, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (33, 'Bell Peppers', 0, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (34, 'Corn Starch', 5, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (35, 'Lemon Juice', 0, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (36, 'Milk', 1, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (37, 'Salt', 5, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (38, 'Baking Soda', 5, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (39, 'Bacon', 2, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (40, 'Sliced Cheddar', 3, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (41, 'Hamburger Buns', 3, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (42, 'Iceberg Lettuce', 0, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (43, 'Heirloom Tomato', 0, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (44, 'Ketchup', 17, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (45, 'Hoisin Sauce', 9, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (46, 'Soy Sauce', 9, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (47, 'Oyster Sauce', 9, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (48, 'Sweet Chili Sauce', 9, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (49, 'Crushed Red Pepper', 7, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (50, 'Apple Cider Vinegar', 5, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (51, 'Green Cabbage', 0, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (52, 'Peanut Oil', 5, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (53, 'Chow Mein Noodles', 9, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (54, 'Carrot', 0, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (55, 'Bean Sprouts', 9, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (56, 'Green Onions', 0, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (57, 'Sesame Oil', 9, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (58, 'Croissant', 6, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (59, 'Sweet Smoked Ham', 3, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (60, 'Vanilla Extract', 5, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (61, 'Banana', 0, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (62, 'Lala Yogurt', 1, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (63, 'Cereal', 12, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (64, 'Hashbrowns', 11, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (65, 'Mexican Cheese Blend', 3, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (66, 'Tortillas', 8, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (67, 'Ground Cinnamon', 5, now(), now());

insert into ingredients ("Id", "Name", "SectionId", "Created", "Updated")
values (68, 'White Bread', 6, now(), now());


-- CREATE SEED RECIPE
select *
from sections;

select *
from ingredients;

select i."Id"
     , i."Name"
     , s."Id"
     , s."Name"
from ingredients i
         inner join sections s on i."SectionId" = s."Id";
