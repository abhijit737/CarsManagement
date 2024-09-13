 
SELECT * FROM CarModels ORDER BY SortOrder ASC;

SELECT * FROM CarModels WHERE Id = @Id;

INSERT INTO CarModels 
(Brand, Class, ModelName, ModelCode, Description, Features, Price, DateOfManufacturing, Active, SortOrder, Images)
VALUES (@Brand, @Class, @ModelName, @ModelCode, @Description, @Features, @Price, @DateOfManufacturing, @Active, @SortOrder, @Images);

UPDATE CarModels SET 
Brand = @Brand, Class = @Class, ModelName = @ModelName, ModelCode = @ModelCode, 
Description = @Description, Features = @Features, Price = @Price, 
DateOfManufacturing = @DateOfManufacturing, Active = @Active, SortOrder = @SortOrder, Images = @Images
WHERE Id = @Id;

DELETE FROM CarModels WHERE Id = @Id;


SELECT * FROM SalesReports;
 