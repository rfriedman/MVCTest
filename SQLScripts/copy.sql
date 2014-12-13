USE [DevelopmentTest]
GO

INSERT INTO [dbo].[Customer]
           ([id]
           ,[first_name]
           ,[last_name]
           ,[email]
           ,[phone]
           ,[street]
           ,[city]
           ,[region]
           ,[postal_code]
           ,[country]
           ,[dob])
  SELECT * FROM dbo.Dataset$
GO


