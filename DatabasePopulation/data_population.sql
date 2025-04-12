INSERT INTO product(name, description, image, man_info, dimensions, weight, rating, SKU, category)
VALUES 
	('Modern Sofa', 'A comfortable 3-seater modern fabric sofa.', NULL, 'SofaWorks', '80x35x30 in', 120.5, 4.6, 'SF-001', 'Living Room'),
	('Wooden Dining Table', '6-person oak dining table with a polished finish.', NULL, 'Oak & Co.', '72x38x30 in', 140.0, 4.8, 'DT-002', 'Dining'),
	('Office Chair', 'Ergonomic swivel chair with lumbar support.', NULL, 'ErgoFlex', '24x24x45 in', 33.0, 4.4, 'OC-003', 'Office');

INSERT INTO app_user(uid, username, password)
VALUES
	('U001', 'furniFan', 'securepass123'),
	('U002', 'homestyler', 'designlover'),
	('U003', 'woodlover', 'crafty123');

INSERT INTO contact_info(app_user_id, email, phone)
VALUES
	(1, 'furnifan@example.com', '+15555550101'),
	(2, 'homestyler@example.com', '+15555550102'),
	(3, 'woodlover@example.com', '+15555550103');

INSERT INTO payment(app_user_id, number, name, pin, expiration_date)
VALUES
	(1, '4111111111111111', 'John Doe', '123', '12/26'),
	(2, '5555444433331111', 'Jane Smith', '456', '08/25'),
	(3, '378282246310005', 'Mike Wood', '789', '03/27');
INSERT INTO cart(app_user_id, status, start_date, end_date, discount)
VALUES
	(1, 'active', '2025-04-10', NULL, 0),
	(2, 'expired', '2025-03-15', '2025-03-16', 10),
	(3, 'active', '2025-04-01', '2025-04-03', 5);

INSERT INTO address(app_user_id, street, city, state, zip)
VALUES
	(1, '123 Maple St', 'Brooklyn', 'NY', '11201'),
	(2, '456 Oak Ave', 'Los Angeles', 'CA', '90001'),
	(3, '789 Pine Rd', 'Austin', 'TX', '73301');

INSERT INTO checkout(app_user_id, payment_id, date, total)
VALUES
	(2, 2, '2025-03-16', 899.99),
	(3, 3, '2025-04-03', 249.99);

INSERT INTO cart_item(cart_id, product_id, quantity)
VALUES
	(2, 1, 1),
	(2, 3, 2), 
	(3, 2, 1); 

INSERT INTO orders(app_user_id, cart_id, address_id, checkout_id, status, date, total)
VALUES
	(2, 2, 2, 1, 'Shipped', '2025-03-16', 899.99),
	(3, 3, 3, 2, 'Processing', '2025-04-03', 249.99);