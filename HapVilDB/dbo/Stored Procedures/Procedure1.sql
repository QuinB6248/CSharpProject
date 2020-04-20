CREATE PROCEDURE [dbo].[ImagesRetrieve]
	
AS
	SELECT	Images.Id,
			Images.Title
	FROM Images
RETURN 
GO
