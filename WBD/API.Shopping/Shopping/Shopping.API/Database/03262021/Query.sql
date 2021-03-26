USE [Shopping]
GO

/****** Object:  StoredProcedure [dbo].[sp_GetCategories]    Script Date: 3/26/2021 10:57:46 AM ******/
DROP PROCEDURE [dbo].[sp_GetCategories]
GO

/****** Object:  StoredProcedure [dbo].[sp_GetCategoryById]    Script Date: 3/26/2021 10:57:46 AM ******/
DROP PROCEDURE [dbo].[sp_GetCategoryById]
GO

/****** Object:  StoredProcedure [dbo].[sp_CreateCategory]    Script Date: 3/26/2021 10:57:46 AM ******/
DROP PROCEDURE [dbo].[sp_CreateCategory]
GO

/****** Object:  StoredProcedure [dbo].[sp_CreateCategory]    Script Date: 3/26/2021 10:57:46 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Khoa Nguyen
-- Create date: 24/03/2021
-- Description:	Create Category
-- =============================================
CREATE PROCEDURE [dbo].[sp_CreateCategory] 
	@CategoryName		NVARCHAR(200)
AS
BEGIN
	DECLARE @CategoryId INT = 0
	BEGIN TRAN
	BEGIN TRY
		INSERT INTO [dbo].[Category]
			   ([CategoryName]
			   ,[IsDeleted])
		 VALUES
			   (@CategoryName
			   ,0)
		SET @CategoryId = SCOPE_IDENTITY();
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH

	SELECT @CategoryId AS CategoryId
END
GO

/****** Object:  StoredProcedure [dbo].[sp_GetCategoryById]    Script Date: 3/26/2021 10:57:46 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Khoa Nguyen
-- Create date: 24/03/2021
-- Description:	Get category by Id
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetCategoryById] 
	@CategoryId		INT
AS
BEGIN
	SELECT CategoryId,
			CategoryName
	FROM Category
	WHERE IsDeleted = 0 AND CategoryId = @CategoryId
END
GO

/****** Object:  StoredProcedure [dbo].[sp_GetCategories]    Script Date: 3/26/2021 10:57:46 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Khoa Nguyen
-- Create date: 24/03/2021
-- Description:	Get categories which not deleted yet
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetCategories] 
AS
BEGIN
	SELECT CategoryId,
			CategoryName
	FROM Category
	WHERE IsDeleted = 0
END
GO

