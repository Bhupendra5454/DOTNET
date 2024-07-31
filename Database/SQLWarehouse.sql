IF EXISTS (SELECT * FROM sys.databases WHERE name = 'warehouse')
BEGIN
    DROP DATABASE warehouse;
END

CREATE DATABASE warehouse;
USE warehouse;


CREATE TABLE Inventory (
    ProductID INT PRIMARY KEY,
    ProductName NVARCHAR(100) NOT NULL,
    Quantity INT NOT NULL
);


CREATE TABLE ChangeLog (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    ProductID INT,
    QuantityChange INT,
    UpdatedBy NVARCHAR(50),
    ChangeDate DATETIME,
    FOREIGN KEY (ProductID) REFERENCES Inventory(ProductID)
);


INSERT INTO Inventory (ProductID, ProductName, Quantity)
VALUES (1, 'iphone 13 pro', 100),
       (2, 'iphone 14 pro', 150),
       (3, 'iphone 15 pro', 200);
-- GO STATEMENT IS UDES TO SEPRATE TWO BATCHES OF CODE
GO


CREATE PROCEDURE UpdateInventory
       @ProductID INT,
	   @QuantityChange INT,
	   @UpdatedBy NVARCHAR(50)

	   AS
	   BEGIN
	        BEGIN TRANSACTION
			      BEGIN TRY
				        UPDATE Inventory
						SET QUANTITY = QUANTITY + @QuantityChange
						WHERE ProductID = @ProductID;
                 IF @@ROWCOUNT = 0
                 BEGIN
            -- No rows were affected, meaning no PRODUCT with that ID exists
                 RAISERROR('No Product found with the given ID.', 16, 1);
                END

				-- Insert a record into the ChangeLog table
               INSERT INTO ChangeLog (ProductID, QuantityChange, UpdatedBy, ChangeDate)
               VALUES (@ProductID,@QuantityChange, @UpdatedBy, GETDATE());

			-- Commit the transaction
                COMMIT TRANSACTION;
                END TRY

				BEGIN CATCH
				      ROLLBACK TRANSACTION;
					  -- Capture error information
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT 
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        -- Raise the error to the calling application
        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END

EXEC UpdateInventory @ProductID = 1, @QuantityChange = 50, @UpdatedBy = 'Admin';
EXEC UpdateInventory @ProductID = 4, @QuantityChange = 50, @UpdatedBy = 'Admin';

-- Severity Level
-- 0–10: Informational messages or warnings.
-- 11–16: Errors that can be corrected by the user.
-- 17–19: Software or hardware errors, typically requiring intervention.
-- 20–25: Serious errors, often indicating problems with the SQL Server instance itself.




