INSERT INTO product(name, description, image, man_info, dimensions, weight, rating, SKU, category)
VALUES 
	('Wireless Mouse', 'Ergonomic wireless mouse with adjustable DPI.', NULL, 'Logitech', '4x2x1 inches', 0.2, 4.5, 'SKU12345', 'Electronics'),
	('Bluetooth Headphones', 'Over-ear noise-cancelling headphones.', NULL, 'Sony', '7x6x3 inches', 0.5, 4.8, 'SKU67890', 'Audio'),
	('USB-C Charger', 'Fast charging USB-C wall charger.', NULL, 'Anker', '2x2x1 inches', 0.1, 4.2, 'SKU11121', 'Accessories'),
	('Mechanical Keyboard', 'RGB mechanical keyboard with blue switches.', NULL, 'Corsair', '17x5x1.5 inches', 1.2, 4.6, 'SKU22222', 'Computers'),
	('Webcam', '1080p HD webcam with built-in mic.', NULL, 'Logitech', '3x1x1 inches', 0.3, 4.4, 'SKU33333', 'Cameras');

INSERT INTO app_user(uid, username, password)
VALUES
	('UID001', 'john_doe', 'hashed_pw1'),
	('UID002', 'jane_smith', 'hashed_pw2'),
	('UID003', 'bob_ross', 'hashed_pw3'),
	('UID004', 'susan_lee', 'hashed_pw4'),
	('UID005', 'mike_chen', 'hashed_pw5');

INSERT INTO payment(app_user_id, number, name, pin, expiration_date)
VALUES
	(1, '4111111111111111', 'John Doe', 'hashed_pin1', '2026-12'),
	(2, '5500000000000004', 'Jane Smith', 'hashed_pin2', '2025-10'),
	(3, '340000000000009', 'Bob Ross', 'hashed_pin3', '2027-03'),
	(4, '6011000000000004', 'Susan Lee', 'hashed_pin4', '2026-08'),
	(5, '3530111333300000', 'Mike Chen', 'hashed_pin5', '2024-11');

INSERT INTO cart(app_user_id, status, start_date, end_date, discount)
VALUES
	(1, 'active', '2025-04-01', NULL, 0.00),
	(2, 'completed', '2025-03-15', '2025-03-16', 10.00),
	(3, 'active', '2025-04-05', NULL, 5.00),
	(4, 'completed', '2025-04-01', '2025-04-02', 0.00),
	(5, 'cancelled', '2025-03-20', '2025-03-21', 0.00);

INSERT INTO address(app_user_id, street, city, state, zip)
VALUES
	(1, '123 Maple Street', 'New York', 'NY', '10001'),
	(2, '456 Oak Avenue', 'Los Angeles', 'CA', '90001'),
	(3, '789 Pine Lane', 'Austin', 'TX', '73301'),
	(4, '321 Cedar Rd', 'Seattle', 'WA', '98101'),
	(5, '654 Birch Blvd', 'Chicago', 'IL', '60601');

INSERT INTO checkout(app_user_id, oid, date)
VALUES
	(2, 'ORD001', '2025-03-16'),
	(3, 'ORD002', '2025-04-06'),
	(4, 'ORD003', '2025-04-02'),
	(5, 'ORD004', '2025-03-21'),
	(1, 'ORD005', '2025-04-08');

INSERT INTO cart_item(cart_id, product_id, quantity)
VALUES
	(1, 1, 2),
	(2, 2, 1),
	(3, 1, 1),
	(3, 3, 2),
	(4, 4, 1);