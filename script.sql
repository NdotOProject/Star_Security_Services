USE [master]
GO
CREATE DATABASE [StarSecurityServices]
GO
ALTER DATABASE [StarSecurityServices] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StarSecurityServices] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StarSecurityServices] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StarSecurityServices] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StarSecurityServices] SET ARITHABORT OFF 
GO
ALTER DATABASE [StarSecurityServices] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [StarSecurityServices] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StarSecurityServices] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StarSecurityServices] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StarSecurityServices] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StarSecurityServices] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StarSecurityServices] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StarSecurityServices] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StarSecurityServices] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StarSecurityServices] SET  ENABLE_BROKER 
GO
ALTER DATABASE [StarSecurityServices] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StarSecurityServices] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StarSecurityServices] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StarSecurityServices] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StarSecurityServices] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StarSecurityServices] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [StarSecurityServices] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StarSecurityServices] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StarSecurityServices] SET  MULTI_USER 
GO
ALTER DATABASE [StarSecurityServices] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StarSecurityServices] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StarSecurityServices] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StarSecurityServices] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StarSecurityServices] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StarSecurityServices] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [StarSecurityServices] SET QUERY_STORE = OFF
GO
USE [StarSecurityServices]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (
	PAD_INDEX = OFF,
	STATISTICS_NORECOMPUTE = OFF,
	IGNORE_DUP_KEY = OFF,
	ALLOW_ROW_LOCKS = ON,
	ALLOW_PAGE_LOCKS = ON,
	OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
	) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Achievements](
	[Id] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Name] [nvarchar](100) NOT NULL,
	[OwnerId] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Achievements] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (
	PAD_INDEX = OFF,
	STATISTICS_NORECOMPUTE = OFF,
	IGNORE_DUP_KEY = OFF,
	ALLOW_ROW_LOCKS = ON,
	ALLOW_PAGE_LOCKS = ON,
	OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
	) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branches](
	[Id] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](255) NOT NULL,
	[ContactPerson] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](255) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Branches] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (
	PAD_INDEX = OFF,
	STATISTICS_NORECOMPUTE = OFF,
	IGNORE_DUP_KEY = OFF,
	ALLOW_ROW_LOCKS = ON,
	ALLOW_PAGE_LOCKS = ON,
	OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
	) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](255) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[PhoneNumber] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (
	PAD_INDEX = OFF,
	STATISTICS_NORECOMPUTE = OFF,
	IGNORE_DUP_KEY = OFF,
	ALLOW_ROW_LOCKS = ON,
	ALLOW_PAGE_LOCKS = ON,
	OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
	) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contracts](
	[Id] [nvarchar](50) NOT NULL,
	[ClientId] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Contracts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (
	PAD_INDEX = OFF,
	STATISTICS_NORECOMPUTE = OFF,
	IGNORE_DUP_KEY = OFF,
	ALLOW_ROW_LOCKS = ON,
	ALLOW_PAGE_LOCKS = ON,
	OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
	) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContractServices](
	[ContractId] [nvarchar](50) NOT NULL,
	[ServiceId] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ContractServices] PRIMARY KEY CLUSTERED 
(
	[ContractId] ASC,
	[ServiceId] ASC
)WITH (
	PAD_INDEX = OFF,
	STATISTICS_NORECOMPUTE = OFF,
	IGNORE_DUP_KEY = OFF,
	ALLOW_ROW_LOCKS = ON,
	ALLOW_PAGE_LOCKS = ON,
	OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
	) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[Id] [nvarchar](50) NOT NULL,
	[BranchId] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (
	PAD_INDEX = OFF,
	STATISTICS_NORECOMPUTE = OFF,
	IGNORE_DUP_KEY = OFF,
	ALLOW_ROW_LOCKS = ON,
	ALLOW_PAGE_LOCKS = ON,
	OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
	) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EducationalQualifications](
	[Id] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_EducationalQualifications] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (
	PAD_INDEX = OFF,
	STATISTICS_NORECOMPUTE = OFF,
	IGNORE_DUP_KEY = OFF,
	ALLOW_ROW_LOCKS = ON,
	ALLOW_PAGE_LOCKS = ON,
	OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
	) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeContracts](
	[EmployeeId] [nvarchar](50) NOT NULL,
	[ContractId] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_EmployeeContracts] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC,
	[ContractId] ASC
)WITH (
	PAD_INDEX = OFF,
	STATISTICS_NORECOMPUTE = OFF,
	IGNORE_DUP_KEY = OFF,
	ALLOW_ROW_LOCKS = ON,
	ALLOW_PAGE_LOCKS = ON,
	OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
	) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](255) NOT NULL,
	[Code] [nvarchar](30) NOT NULL,
	[ContactNumber] [nvarchar](15) NOT NULL,
	[DepartmentId] [nvarchar](50) NOT NULL,
	[EducationalQualificationId] [nvarchar](50) NOT NULL,
	[GradeId] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[RoleId] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (
	PAD_INDEX = OFF,
	STATISTICS_NORECOMPUTE = OFF,
	IGNORE_DUP_KEY = OFF,
	ALLOW_ROW_LOCKS = ON,
	ALLOW_PAGE_LOCKS = ON,
	OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
	) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grades](
	[Id] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Grades] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (
	PAD_INDEX = OFF,
	STATISTICS_NORECOMPUTE = OFF,
	IGNORE_DUP_KEY = OFF,
	ALLOW_ROW_LOCKS = ON,
	ALLOW_PAGE_LOCKS = ON,
	OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
	) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recruitments](
	[Id] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[ManagerId] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[Vacancies] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Recruitments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (
	PAD_INDEX = OFF,
	STATISTICS_NORECOMPUTE = OFF,
	IGNORE_DUP_KEY = OFF,
	ALLOW_ROW_LOCKS = ON,
	ALLOW_PAGE_LOCKS = ON,
	OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
	) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (
	PAD_INDEX = OFF,
	STATISTICS_NORECOMPUTE = OFF,
	IGNORE_DUP_KEY = OFF,
	ALLOW_ROW_LOCKS = ON,
	ALLOW_PAGE_LOCKS = ON,
	OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
	) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[Id] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (
	PAD_INDEX = OFF,
	STATISTICS_NORECOMPUTE = OFF,
	IGNORE_DUP_KEY = OFF,
	ALLOW_ROW_LOCKS = ON,
	ALLOW_PAGE_LOCKS = ON,
	OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
	) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240627092309_DatabaseVer1', N'8.0.6')
GO
INSERT [dbo].[Branches] ([Id], [Address], [ContactPerson], [Email], [Name]) VALUES (N'5c26de79-b151-4197-8b12-d0d051f6bf10', N'Ha Noi', N'Minh', N'branch.01@starsecurityservices.vn', N'Star Security Services Ha Noi')
INSERT [dbo].[Branches] ([Id], [Address], [ContactPerson], [Email], [Name]) VALUES (N'bd4669f3-e060-498b-8f51-ab21ccd4f066', N'Ho Chi Minh', N'Anh', N'branch.02@starsecurityservices.vn', N'Star Security Services Ho Chi Minh')
GO
INSERT [dbo].[Departments] ([Id], [BranchId], [Description], [Name]) VALUES (N'271d1d37-2fe2-4807-bd64-0acba396d11e', N'bd4669f3-e060-498b-8f51-ab21ccd4f066', N'Description', N'Manned guarding')
INSERT [dbo].[Departments] ([Id], [BranchId], [Description], [Name]) VALUES (N'300f191b-ad96-41e7-82a9-cc4913d03efe', N'bd4669f3-e060-498b-8f51-ab21ccd4f066', N'Description', N'Management')
INSERT [dbo].[Departments] ([Id], [BranchId], [Description], [Name]) VALUES (N'820d8f42-9dd2-4042-9e22-8adf9dc95d55', N'5c26de79-b151-4197-8b12-d0d051f6bf10', N'Description', N'Manned guarding')
INSERT [dbo].[Departments] ([Id], [BranchId], [Description], [Name]) VALUES (N'fe0ccfc7-f718-47c1-8911-2eecbc7d2574', N'5c26de79-b151-4197-8b12-d0d051f6bf10', N'Description', N'Management')
GO
INSERT [dbo].[EducationalQualifications] ([Id], [Description], [Name]) VALUES (N'8d07e0ac-63b4-41d4-ac33-8906e2d28082', N'Description', N'High School')
INSERT [dbo].[EducationalQualifications] ([Id], [Description], [Name]) VALUES (N'd62e1a46-e318-49cd-9832-d7026920406b', N'Description', N'Junior High School')
INSERT [dbo].[EducationalQualifications] ([Id], [Description], [Name]) VALUES (N'fa82ac29-729d-4cf0-a8d8-d61766bd442a', N'Description', N'University')
GO
INSERT [dbo].[Employees] ([Id], [Address], [Code], [ContactNumber], [DepartmentId], [EducationalQualificationId], [GradeId], [Name], [Password], [RoleId]) VALUES (N'3d4d0938-b24c-4826-931f-7428234f6f64', N'Ho Chi Minh, Viet Nam', N'EMPLOYEE04', N'0223456789', N'271d1d37-2fe2-4807-bd64-0acba396d11e', N'8d07e0ac-63b4-41d4-ac33-8906e2d28082', N'a022aba6-bc66-4dca-adb4-650911fc78ac', N'Hung', N'@1234567', N'97ce9bf7-6745-42d8-b6d0-e5f52f91a802')
INSERT [dbo].[Employees] ([Id], [Address], [Code], [ContactNumber], [DepartmentId], [EducationalQualificationId], [GradeId], [Name], [Password], [RoleId]) VALUES (N'9469cfb3-d7ef-4c04-8fb4-890942450b96', N'Ha Noi, Viet Nam', N'EMPLOYEE02', N'0912345678', N'820d8f42-9dd2-4042-9e22-8adf9dc95d55', N'8d07e0ac-63b4-41d4-ac33-8906e2d28082', N'36967f25-99a8-4d2a-ae0e-105233f8bf42', N'Tuan', N'@1234567', N'97ce9bf7-6745-42d8-b6d0-e5f52f91a802')
INSERT [dbo].[Employees] ([Id], [Address], [Code], [ContactNumber], [DepartmentId], [EducationalQualificationId], [GradeId], [Name], [Password], [RoleId]) VALUES (N'a30f1922-74b4-4ae9-a907-8c9660cf7945', N'Ho Chi Minh, Viet Nam', N'EMPLOYEE03', N'0312345678', N'300f191b-ad96-41e7-82a9-cc4913d03efe', N'fa82ac29-729d-4cf0-a8d8-d61766bd442a', N'8abd3103-a228-467a-b927-200986857279', N'Trang', N'@1234567', N'24722a9d-ad40-4324-a044-50825421cc6c')
INSERT [dbo].[Employees] ([Id], [Address], [Code], [ContactNumber], [DepartmentId], [EducationalQualificationId], [GradeId], [Name], [Password], [RoleId]) VALUES (N'f21004f9-4ae7-4a16-a3a8-e8759038c58a', N'Ha Noi, Viet Nam', N'EMPLOYEE01', N'0123456789', N'fe0ccfc7-f718-47c1-8911-2eecbc7d2574', N'fa82ac29-729d-4cf0-a8d8-d61766bd442a', N'8abd3103-a228-467a-b927-200986857279', N'Hanh', N'@1234567', N'24722a9d-ad40-4324-a044-50825421cc6c')
GO
INSERT [dbo].[Grades] ([Id], [Description], [Name]) VALUES (N'29c7306f-e283-4385-8d66-f3502bf6fc63', N'Description', N'Level 3')
INSERT [dbo].[Grades] ([Id], [Description], [Name]) VALUES (N'36967f25-99a8-4d2a-ae0e-105233f8bf42', N'Description', N'Level 4')
INSERT [dbo].[Grades] ([Id], [Description], [Name]) VALUES (N'4f5b1dad-1488-47fd-b232-d7411db7a241', N'Description', N'Level 1')
INSERT [dbo].[Grades] ([Id], [Description], [Name]) VALUES (N'8abd3103-a228-467a-b927-200986857279', N'Description', N'Level 5')
INSERT [dbo].[Grades] ([Id], [Description], [Name]) VALUES (N'a022aba6-bc66-4dca-adb4-650911fc78ac', N'Description', N'Level 2')
GO
INSERT [dbo].[Roles] ([Id], [Description], [Name]) VALUES (N'24722a9d-ad40-4324-a044-50825421cc6c', N'Description', N'Manager')
INSERT [dbo].[Roles] ([Id], [Description], [Name]) VALUES (N'97ce9bf7-6745-42d8-b6d0-e5f52f91a802', N'Description', N'Basic Employee')
GO
INSERT [dbo].[Services] ([Id], [Description], [Name]) VALUES (N'1a223d4e-060a-4073-bf3d-c0b03315f600', N'Description', N'Manned guarding')
INSERT [dbo].[Services] ([Id], [Description], [Name]) VALUES (N'5fc64104-0998-4ecb-97f2-285e472b94e6', N'Description', N'Recruitment and training')
INSERT [dbo].[Services] ([Id], [Description], [Name]) VALUES (N'838d987a-c267-4b6d-87bd-5f658dcb9845', N'Description', N'Electronic security systems')
INSERT [dbo].[Services] ([Id], [Description], [Name]) VALUES (N'95f4546f-85dc-4ed8-acc9-e830b766a180', N'Description', N'Cash Services')
GO
SET ANSI_PADDING ON
GO
CREATE NONCLUSTERED INDEX [IX_Achievements_OwnerId] ON [dbo].[Achievements]
(
	[OwnerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
CREATE NONCLUSTERED INDEX [IX_Contracts_ClientId] ON [dbo].[Contracts]
(
	[ClientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
CREATE NONCLUSTERED INDEX [IX_ContractServices_ServiceId] ON [dbo].[ContractServices]
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
CREATE NONCLUSTERED INDEX [IX_Departments_BranchId] ON [dbo].[Departments]
(
	[BranchId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
CREATE NONCLUSTERED INDEX [IX_EmployeeContracts_ContractId] ON [dbo].[EmployeeContracts]
(
	[ContractId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Employees_Code] ON [dbo].[Employees]
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
CREATE NONCLUSTERED INDEX [IX_Employees_DepartmentId] ON [dbo].[Employees]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
CREATE NONCLUSTERED INDEX [IX_Employees_EducationalQualificationId] ON [dbo].[Employees]
(
	[EducationalQualificationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
CREATE NONCLUSTERED INDEX [IX_Employees_GradeId] ON [dbo].[Employees]
(
	[GradeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
CREATE NONCLUSTERED INDEX [IX_Employees_RoleId] ON [dbo].[Employees]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
CREATE NONCLUSTERED INDEX [IX_Recruitments_ManagerId] ON [dbo].[Recruitments]
(
	[ManagerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Achievements]  WITH CHECK ADD  CONSTRAINT [FK_Achievements_Employees_OwnerId] FOREIGN KEY([OwnerId])
REFERENCES [dbo].[Employees] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Achievements] CHECK CONSTRAINT [FK_Achievements_Employees_OwnerId]
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD  CONSTRAINT [FK_Contracts_Clients_ClientId] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Clients] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Contracts] CHECK CONSTRAINT [FK_Contracts_Clients_ClientId]
GO
ALTER TABLE [dbo].[ContractServices]  WITH CHECK ADD  CONSTRAINT [FK_ContractServices_Contracts_ContractId] FOREIGN KEY([ContractId])
REFERENCES [dbo].[Contracts] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ContractServices] CHECK CONSTRAINT [FK_ContractServices_Contracts_ContractId]
GO
ALTER TABLE [dbo].[ContractServices]  WITH CHECK ADD  CONSTRAINT [FK_ContractServices_Services_ServiceId] FOREIGN KEY([ServiceId])
REFERENCES [dbo].[Services] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ContractServices] CHECK CONSTRAINT [FK_ContractServices_Services_ServiceId]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_Branches_BranchId] FOREIGN KEY([BranchId])
REFERENCES [dbo].[Branches] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_Branches_BranchId]
GO
ALTER TABLE [dbo].[EmployeeContracts]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeContracts_Contracts_ContractId] FOREIGN KEY([ContractId])
REFERENCES [dbo].[Contracts] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EmployeeContracts] CHECK CONSTRAINT [FK_EmployeeContracts_Contracts_ContractId]
GO
ALTER TABLE [dbo].[EmployeeContracts]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeContracts_Employees_EmployeeId] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EmployeeContracts] CHECK CONSTRAINT [FK_EmployeeContracts_Employees_EmployeeId]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Departments_DepartmentId] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Departments_DepartmentId]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_EducationalQualifications_EducationalQualificationId] FOREIGN KEY([EducationalQualificationId])
REFERENCES [dbo].[EducationalQualifications] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_EducationalQualifications_EducationalQualificationId]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Grades_GradeId] FOREIGN KEY([GradeId])
REFERENCES [dbo].[Grades] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Grades_GradeId]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Roles_RoleId]
GO
ALTER TABLE [dbo].[Recruitments]  WITH CHECK ADD  CONSTRAINT [FK_Recruitments_Employees_ManagerId] FOREIGN KEY([ManagerId])
REFERENCES [dbo].[Employees] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Recruitments] CHECK CONSTRAINT [FK_Recruitments_Employees_ManagerId]
GO
USE [master]
GO
ALTER DATABASE [StarSecurityServices] SET  READ_WRITE 
GO
