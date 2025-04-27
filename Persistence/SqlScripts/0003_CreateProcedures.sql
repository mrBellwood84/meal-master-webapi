# Only procedures expected to be consumed by application are createad
# Headline tags for tables may exist without any procedures as they are marked down in the same 
#  load order as table creation. Order kept for consistency! Many to many relationship tables not included.

USE MealMasterDb;
DELIMITER //

# -- MessureType Procedures --
CREATE PROCEDURE MessureTypeSelectAll ()
	BEGIN
		SELECT * FROM MessureType;
	END//

#  -- Messure Procedures --
CREATE PROCEDURE MessureSelectAll ()
	BEGIN
		SELECT * FROM Messure AS m 
			JOIN MessureType AS mt ON m.MessureTypeId = mt.Id;
	END //

# Ingredient Procedures


#  -- Ingredient Category Procedures --
CREATE PROCEDURE IngredientCategorySelectAll ()
	BEGIN
		SELECT * FROM IngredientCategory;
    END //


#  -- NutrientType Procedures --
CREATE PROCEDURE NutrientTypeSelectAll ()
	BEGIN
		SELECT * FROM NutrientType AS nt
			JOIN Messure AS m ON nt.MessureId = m.id
            JOIN MessureType as mt on m.MessureTypeId = mt.Id
		ORDER BY nt.DisplayIndex ASC;
	END //


# IngredientNutrient Procedures

# Recipe Procedures

# RecipeIngredient Procedures

# RecipeStep Procecures

# -- RecipeCategory Procedures -- 
CREATE PROCEDURE RecipeCategorySelectAll ()
	BEGIN
		SELECT * FROM RecipeCategory;
    END //
    

#  -- RecipeContinentOrgin Procedures --
CREATE PROCEDURE RecipeContinentOrginSelectAll ()
	BEGIN
		SELECT * FROM RecipeContinentOrgin;
    END //
    
    
# -- RecipeCountryOrgin Procedures --
CREATE PROCEDURE RecipeCountryOrgin ()
	BEGIN
		SELECT * FROM RecipeCountryOrgin;
    END //