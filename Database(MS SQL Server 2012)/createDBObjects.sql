USE [smdSoft_db]
GO
/****** Object:  User [formGenerator]    Script Date: 2015-06-29 23:36:01 ******/
CREATE USER [formGenerator] FOR LOGIN [formGenerator] WITH DEFAULT_SCHEMA=[formGenerator]
GO
ALTER ROLE [db_owner] ADD MEMBER [formGenerator]
GO
/****** Object:  Schema [formGenerator]    Script Date: 2015-06-29 23:36:02 ******/
CREATE SCHEMA [formGenerator]
GO
/****** Object:  StoredProcedure [formGenerator].[SaveFormData]    Script Date: 2015-06-29 23:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [formGenerator].[SaveFormData]
	-- Add the parameters for the stored procedure here
	@FormId int, 
	@Field1 nvarchar(250),
	@Field2 nvarchar(250),
	@Field3 nvarchar(250),
	@Field4 nvarchar(250),
	@Field5 nvarchar(250),
	@Field6 nvarchar(250),
	@Field7 nvarchar(250),
	@Field8 nvarchar(250),
	@Field9 nvarchar(250),
	@Field10 nvarchar(250),
	@Field11 nvarchar(250),
	@Field12 nvarchar(250)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [formGenerator].[FormsData] (FormId, Field1, Field2, Field3, Field4, Field5, Field6, Field7, Field8, Field9, Field10, Field11, Field12, InsertDate, Owner)
	VALUES (@FormId, @Field1, @Field2, @Field3, @Field4, @Field5, @Field6, @Field7, @Field8, @Field9, @Field10, @Field11, @Field12, GETDATE(), SUSER_SNAME());

END

GO
/****** Object:  Table [formGenerator].[Forms]    Script Date: 2015-06-29 23:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [formGenerator].[Forms](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FormHtml] [text] NOT NULL,
	[Owner] [nvarchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[VersionNumber] [int] NULL,
 CONSTRAINT [PK_formGenerator_Forms] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [formGenerator].[FormsData]    Script Date: 2015-06-29 23:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [formGenerator].[FormsData](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FormId] [int] NOT NULL,
	[Field1] [nvarchar](max) NULL,
	[Field2] [nvarchar](max) NULL,
	[Field3] [nvarchar](max) NULL,
	[Field4] [nvarchar](max) NULL,
	[Field5] [nvarchar](max) NULL,
	[Field6] [nvarchar](max) NULL,
	[Field7] [nvarchar](max) NULL,
	[Field8] [nvarchar](max) NULL,
	[Field9] [nvarchar](max) NULL,
	[Field10] [nvarchar](max) NULL,
	[Field11] [nvarchar](max) NULL,
	[Field12] [nvarchar](max) NULL,
	[Field13] [nvarchar](max) NULL,
	[Field14] [nvarchar](max) NULL,
	[Field15] [nvarchar](max) NULL,
	[Field16] [nvarchar](max) NULL,
	[Field17] [nvarchar](max) NULL,
	[Field18] [nvarchar](max) NULL,
	[Field19] [nvarchar](max) NULL,
	[Field20] [nvarchar](max) NULL,
	[Field21] [nvarchar](max) NULL,
	[Field22] [nvarchar](max) NULL,
	[Field23] [nvarchar](max) NULL,
	[Field24] [nvarchar](max) NULL,
	[Field25] [nvarchar](max) NULL,
	[Field26] [nvarchar](max) NULL,
	[Field27] [nvarchar](max) NULL,
	[Field28] [nvarchar](max) NULL,
	[Field29] [nvarchar](max) NULL,
	[Field30] [nvarchar](max) NULL,
	[Field31] [nvarchar](max) NULL,
	[Field32] [nvarchar](max) NULL,
	[InsertDate] [nvarchar](max) NULL,
	[Owner] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_FormsData] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [formGenerator].[FormsData]  WITH CHECK ADD  CONSTRAINT [FK_FormData_Form] FOREIGN KEY([FormId])
REFERENCES [formGenerator].[Forms] ([Id])
GO
ALTER TABLE [formGenerator].[FormsData] CHECK CONSTRAINT [FK_FormData_Form]
GO
