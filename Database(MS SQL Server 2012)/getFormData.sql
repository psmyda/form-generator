USE [smdSoft_db]
GO
/****** Object:  StoredProcedure [formGenerator].[getFormData]    Script Date: 2015-06-30 05:59:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [formGenerator].[getFormData]
	-- Add the parameters for the stored procedure here
	@FormId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Id,
	FormId,
	Field1,
	Field2,
	Field3,
	Field4,
	Field5,
	Field6,
	Field7,
	Field8,
	Field9,
	Field10,
	Field11,
	Field12,
	Field13,
	Field14,
	Field15,
	Field16,
	Field17,
	Field18,
	Field19,
	Field20,
	Field21,
	Field22,
	Field23,
	Field24,
	Field25,
	Field26,
	Field27,
	Field28,
	Field29,
	Field30,
	Field31,
	Field32,
	InsertDate,
	Owner
	 FROM FormsData
	 WHERE FormId = @FormId;
END
