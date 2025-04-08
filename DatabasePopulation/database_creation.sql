CREATE TABLE product(
	product_id INT IDENTITY(1,1) PRIMARY KEY,
	name VARCHAR(255),
	description VARCHAR(1000),
	image VARBINARY(MAX),
	man_info VARCHAR(255),
	dimensions VARCHAR(255),
	weight FLOAT,
    rating FLOAT,
	SKU VARCHAR(255),
	category VARCHAR(255)
);

CREATE TABLE app_user(
	app_user_id INT IDENTITY(1,1) PRIMARY KEY,
	uid VARCHAR(255),
	username VARCHAR(255),
	password VARCHAR(255)
);

CREATE TABLE payment(
	payment_id INT IDENTITY(1,1) PRIMARY KEY,
	app_user_id INT,
	number VARCHAR(255),
	name VARCHAR(255),
	pin VARCHAR(255),
	expiration_date VARCHAR(255),
	FOREIGN KEY (app_user_id) REFERENCES app_user(app_user_id)
);

CREATE TABLE cart(
	cart_id INT IDENTITY(1,1) PRIMARY KEY,
	app_user_id INT,
	status VARCHAR(255),
	start_date VARCHAR(255),
	end_date VARCHAR(255),
	discount FLOAT,
	FOREIGN KEY (app_user_id) REFERENCES app_user(app_user_id)
);


CREATE TABLE address(
	address_id INT IDENTITY(1,1) PRIMARY KEY,
	app_user_id INT,
	street VARCHAR(255),
	city VARCHAR(255),
	state VARCHAR(255),
	zip VARCHAR(255),
	FOREIGN KEY (app_user_id) REFERENCES app_user(app_user_id)
);

CREATE TABLE checkout(
	checkout_id INT IDENTITY(1,1) PRIMARY KEY,
	app_user_id INT,
	oid VARCHAR(255),
	date VARCHAR(255),
	FOREIGN KEY (app_user_id) REFERENCES app_user(app_user_id)
);

CREATE TABLE cart_item(
	cart_item_id INT IDENTITY(1,1) PRIMARY KEY,
	cart_id INT,
	product_id INT,
	quantity INT,
	FOREIGN KEY (cart_id) REFERENCES cart(cart_id),
	FOREIGN KEY (product_id) REFERENCES product(product_id)
);
