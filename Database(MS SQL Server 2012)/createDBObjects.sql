/****** Object:  StoredProcedure [dbo].[deleteFormData]    Script Date: 2015-07-05 17:32:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[deleteFormData]
	@FormDataId INT
AS
BEGIN

	SET NOCOUNT ON;

UPDATE FormsData
SET Deleted = 1
	WHERE Id = @FormDataId;

	END

GO
/****** Object:  StoredProcedure [dbo].[deleteFormDefinition]    Script Date: 2015-07-05 17:32:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[deleteFormDefinition]
	@FormId INT
AS
BEGIN

	SET NOCOUNT ON;

UPDATE FormsDefinition
SET Deleted = 1
	WHERE Id = @FormId;

	END

GO
/****** Object:  StoredProcedure [dbo].[getAllFormData]    Script Date: 2015-07-05 17:32:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getAllFormData]
	-- Add the parameters for the stored procedure here
	@FormId int
AS
BEGIN

	SET NOCOUNT ON;

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
	CreatedAt
	Owner
	 FROM FormsData
	 WHERE FormId = @FormId
	 AND Deleted = 0;
END

GO
/****** Object:  StoredProcedure [dbo].[getAllFormsForUser]    Script Date: 2015-07-05 17:32:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getAllFormsForUser]
	@UserId INT

AS
BEGIN

	SET NOCOUNT ON;

    SELECT ID,
		OwnerId,
		FormCode,
		CreatedAt,
		UpdatedAt,
		VersionNumber
	FROM FormsDefinition
	WHERE OwnerId = @UserId
	and Deleted = 0; 

END

GO
/****** Object:  StoredProcedure [dbo].[getFormData]    Script Date: 2015-07-05 17:32:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[getFormData]
	@Id INT
AS
BEGIN

	SET NOCOUNT ON;

 SELECT  Id,
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
		CreatedAt
	FROM FormsData
	WHERE Id = @Id
	and Deleted = 0;

	END

GO
/****** Object:  StoredProcedure [dbo].[getFormDefinition]    Script Date: 2015-07-05 17:32:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getFormDefinition]
	@FormId INT
AS
BEGIN

	SET NOCOUNT ON;

 SELECT ID,
		OwnerId,
		FormCode,
		CreatedAt,
		UpdatedAt,
		VersionNumber
	FROM FormsDefinition
	WHERE Id = @FormId
	and Deleted = 0;

	END

GO
/****** Object:  StoredProcedure [dbo].[saveFormData]    Script Date: 2015-07-05 17:32:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[saveFormData]
	-- Add the parameters for the stored procedure here
	@Id int,
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
	@Field12 nvarchar(250),
	@Field13 nvarchar(250),
	@Field14 nvarchar(250),
	@Field15 nvarchar(250),
	@Field16 nvarchar(250),
	@Field17 nvarchar(250),
	@Field18 nvarchar(250),
	@Field19 nvarchar(250),
	@Field20 nvarchar(250),
	@Field21 nvarchar(250),
	@Field22 nvarchar(250),
	@Field23 nvarchar(250),
	@Field24 nvarchar(250),
	@Field25 nvarchar(250),
	@Field26 nvarchar(250),
	@Field27 nvarchar(250),
	@Field28 nvarchar(250),
	@Field29 nvarchar(250),
	@Field30 nvarchar(250),
	@Field31 nvarchar(250),
	@Field32 nvarchar(250)
AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF (@Id IS NOT NULL)
	BEGIN
		UPDATE FormsData SET Field1 = @Field1, Field2 = @Field2, Field3 = @Field3, Field4 = @Field4, Field5 = @Field5, 
		Field6 = @Field6, Field7= @Field7, Field8 = @Field8, Field9 = @Field9, Field10 = @Field10, Field11 = @Field11,
		Field12 = @Field12, Field13 = @Field13, Field14 = @Field14, Field15 = @Field15, Field16 = @Field16, 
		Field17 = @Field17,  Field18 = @Field18,  Field19 = @Field19, Field20 = @Field20,  Field21 = @Field21,
		Field22 = @Field22,  Field23 = @Field23, Field24 = @Field24,  Field25 = @Field25,  Field26 = @Field26,
		Field27 = @Field27,  Field28 = @Field28,  Field29 = @Field29,  Field30= @Field30,  Field31 = @Field31,
		Field32 = @Field32
		WHERE Id = @Id;
	END

	ELSE
	BEGIN

	INSERT INTO FormsData (FormId, Field1, Field2, Field3, Field4, Field5, Field6, Field7, Field8, Field9, Field10, 
		Field11, Field12, Field13, Field14, Field15, Field16, Field17,  Field18,  Field19, Field20,  Field21,  Field22,  Field23,
		 Field24,  Field25,  Field26,  Field27,  Field28,  Field29,  Field30,  Field31,  Field32, CreatedAt, Deleted)
	VALUES (@FormId, @Field1, @Field2, @Field3, @Field4, @Field5, @Field6, @Field7, @Field8, 
	@Field9, @Field10, @Field11, @Field12, @Field13, @Field14, @Field15,@Field16, @Field17,@Field18, @Field19, @Field20, 
	@Field21, @Field22, @Field23, @Field24, @Field25, @Field26, @Field27, @Field28, @Field29, @Field30, @Field31, @Field32,
	 GETDATE(), 0);

	 set @Id = SCOPE_IDENTITY();
	END
	select @Id;
END


GO
/****** Object:  StoredProcedure [dbo].[saveFormDefinition]    Script Date: 2015-07-05 17:32:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[saveFormDefinition]
	-- Add the parameters for the stored procedure here
	@Id int,
	@OwnerId int, 
	@FormCode text
AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF (@Id IS NOT NULL)
	BEGIN
		UPDATE FormsDefinition SET FormCode = @FormCode, UpdatedAt = GETDATE(), VersionNumber = VersionNumber + 1
		WHERE ID = @Id;
	END

	ELSE
	BEGIN
		INSERT INTO FormsDefinition (OwnerID, FormCode, CreatedAt, VersionNumber, Deleted)
		VALUES (@OwnerId, @FormCode, GETDATE(), 1, 0);

		SET @Id = SCOPE_IDENTITY();
	END

	select @Id;

END


GO
/****** Object:  Table [dbo].[FormsData]    Script Date: 2015-07-05 17:32:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormsData](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FormID] [int] NOT NULL,
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
	[CreatedAt] [datetime] NULL,
	[Deleted] [bit] NULL,
 CONSTRAINT [PK_FormsData] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FormsDefinition]    Script Date: 2015-07-05 17:32:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormsDefinition](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OwnerID] [int] NOT NULL,
	[FormCode] [text] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdatedAt] [datetime] NULL,
	[VersionNumber] [int] NULL,
	[Deleted] [bit] NULL,
 CONSTRAINT [PK_FormsDefinition] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 2015-07-05 17:32:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](250) NOT NULL,
	[FullName] [nvarchar](150) NULL,
	[CreatedAt] [datetime] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[FormsDefinition] ADD  CONSTRAINT [DF_FormsDefinition_UpdatedAt]  DEFAULT (((1900)-(1))-(1)) FOR [UpdatedAt]
GO
ALTER TABLE [dbo].[FormsData]  WITH CHECK ADD  CONSTRAINT [FK_FormDefinition_FormData] FOREIGN KEY([FormID])
REFERENCES [dbo].[FormsDefinition] ([ID])
GO
ALTER TABLE [dbo].[FormsData] CHECK CONSTRAINT [FK_FormDefinition_FormData]
GO
ALTER TABLE [dbo].[FormsDefinition]  WITH CHECK ADD  CONSTRAINT [FK_Foms_Users] FOREIGN KEY([OwnerID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[FormsDefinition] CHECK CONSTRAINT [FK_Foms_Users]
GO
