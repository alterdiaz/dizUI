CREATE PROCEDURE [dbo].[spCompanyLogoCaptionSquare]
AS
BEGIN
  select images from sys_images where idimages = (select top 1 value from sys_appsetting where variable='CompanyLogoCaptionSquare')
END


