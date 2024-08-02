-- Create the bookstore database
drop database bookstore;
CREATE DATABASE IF NOT EXISTS bookstore;
USE bookstore;

-- Create the books table
CREATE TABLE IF NOT EXISTS books (
    book_id INT AUTO_INCREMENT PRIMARY KEY,
    title VARCHAR(255) NOT NULL,
    author VARCHAR(255),
    price DECIMAL(10, 2) NOT NULL,
    stock INT DEFAULT 0
);

-- Create the sales table
CREATE TABLE IF NOT EXISTS sales (
    sale_id INT AUTO_INCREMENT PRIMARY KEY,
    book_id INT,
    quantity INT NOT NULL,
    sale_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (book_id) REFERENCES books(book_id)
);

INSERT INTO books (title, author, price, stock) VALUES
('The Great Gatsby', 'F. Scott Fitzgerald', 10.99, 50),
('1984', 'George Orwell', 8.99, 30),
('To Kill a Mockingbird', 'Harper Lee', 12.99, 20),
('Pride and Prejudice', 'Jane Austen', 9.99, 40),
('Moby-Dick', 'Herman Melville', 11.99, 15);

-- Insert sample data into the sales table
INSERT INTO sales (book_id, quantity) VALUES
(1, 5),
(2, 3),
(3, 2),
(4, 1),
(5, 4);



-- Create the stored procedure to add new books
DELIMITER //

CREATE PROCEDURE AddBook(IN p_title VARCHAR(255),IN p_author VARCHAR(255),IN p_price DECIMAL(10, 2),IN p_stock INT)
BEGIN
    INSERT INTO books (title, author, price, stock)
    VALUES (p_title, p_author, p_price, p_stock);
END //

DELIMITER ;

CALL AddBook('The Catcher in the Rye', 'J.D. Salinger', 10.99, 25);
CALL AddBook('Brave New World', 'Aldous Huxley', 7.99, 30);
CALL AddBook('Fahrenheit 451', 'Ray Bradbury', 6.99, 40);
CALL AddBook('The Hobbit', 'J.R.R. Tolkien', 14.99, 15);
CALL AddBook('Little Women', 'Louisa May Alcott', 11.99, 20);

-- Drop the existing after_insert_sale trigger if it exists
DROP TRIGGER IF EXISTS after_insert_sale;

-- Create the after_insert_sale trigger to update stock after a sale
DELIMITER //

CREATE TRIGGER after_insert_sale
AFTER INSERT ON sales
FOR EACH ROW
BEGIN
    -- Decrease the stock of the book sold
    UPDATE books
    SET stock = stock - NEW.quantity
    WHERE book_id = NEW.book_id;
END //

DELIMITER ;
INSERT INTO sales (book_id, quantity) VALUES(1, 5);
INSERT INTO sales (book_id, quantity) VALUES(2, 15);