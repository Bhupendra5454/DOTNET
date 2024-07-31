drop database if exists warehouse;
create database warehouse;
use warehouse;
 
-- Create the Inventory table
CREATE TABLE Inventory (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100) NOT NULL,
    Quantity INT NOT NULL
);
 
-- Create the ChangeLog table
CREATE TABLE ChangeLog (
    LogID INT AUTO_INCREMENT PRIMARY KEY,
    ProductID INT,
    QuantityChange INT,
    UpdatedBy VARCHAR(50),
    ChangeDate DATETIME,
    FOREIGN KEY (ProductID) REFERENCES Inventory(ProductID)
);
 
-- Insert sample data into Inventory
INSERT INTO Inventory (ProductID, ProductName, Quantity)
VALUES  (1, 'iphone 13 pro', 100),
		(2, 'iphone 14 pro', 150),
		(3, 'iphone 15 pro', 200);
 
 
DELIMITER //
 
CREATE PROCEDURE UpdateInventory(
    IN p_ProductID INT,
    IN p_QuantityChange INT,
    IN p_UpdatedBy VARCHAR(50)
)
BEGIN
    DECLARE EXIT HANDLER FOR SQLEXCEPTION
    BEGIN
        -- Rollback the transaction on error
        ROLLBACK;
    END;
 
    -- Start a transaction
    START TRANSACTION;
 
    -- Update the inventory table
    UPDATE Inventory
    SET Quantity = Quantity + p_QuantityChange
    WHERE ProductID = p_ProductID;
 
    -- Check if the update was successful
    IF ROW_COUNT() = 0 THEN
        -- No rows affected, so the product ID might be invalid
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Invalid Product';
    END IF;
 
    -- Insert a record into the ChangeLog table
    INSERT INTO ChangeLog (ProductID, QuantityChange, UpdatedBy, ChangeDate)
    VALUES (p_ProductID, p_QuantityChange, p_UpdatedBy, NOW());
 
    -- Commit the transaction
    COMMIT;
END //
 
DELIMITER ;
 
-- Invoking Stored Procedure
 
CALL UpdateInventory(1, 20, 'admin');
CALL UpdateInventory(2, 20, 'manager');
 