USE [StarSecurityServices]
GO
INSERT [dbo].[Branches] ([Id], [Address], [ContactPerson], [Email], [Name])
VALUES (
	N'5c26de79-b151-4197-8b12-d0d051f6bf10',
	N'Ha Noi',
	N'Dang Nhat Minh',
	N'star.hn.branch@starsecurityservices.vn',
	N'Star Security Services Ha Noi'
)
INSERT [dbo].[Branches] ([Id], [Address], [ContactPerson], [Email], [Name])
VALUES (
	N'bd4669f3-e060-498b-8f51-ab21ccd4f066',
	N'Ho Chi Minh',
	N'Dang Nhat Minh Anh',
	N'star.hcm.branch@starsecurityservices.vn',
	N'Star Security Services Ho Chi Minh'
)
GO
INSERT [dbo].[Departments] ([Id], [BranchId], [Description], [Name])
VALUES (
	N'300f191b-ad96-41e7-82a9-cc4913d03efe',
	N'bd4669f3-e060-498b-8f51-ab21ccd4f066',
	N'Description',
	N'Management'
)
INSERT [dbo].[Departments] ([Id], [BranchId], [Description], [Name])
VALUES (
	N'271d1d37-2fe2-4807-bd64-0acba396d11e',
	N'bd4669f3-e060-498b-8f51-ab21ccd4f066',
	N'Description',
	N'Manned guarding'
)
INSERT [dbo].[Departments] ([Id], [BranchId], [Description], [Name])
VALUES (
	N'd33af70f-4d38-412d-b3d9-e8d6307d9c61',
	N'bd4669f3-e060-498b-8f51-ab21ccd4f066',
	N'Description',
	N'Traning'
)
INSERT [dbo].[Departments] ([Id], [BranchId], [Description], [Name])
VALUES (
	N'1833c864-143c-4623-8368-46f34ebdd09c',
	N'bd4669f3-e060-498b-8f51-ab21ccd4f066',
	N'Description',
	N'Electronic security systems'
)
INSERT [dbo].[Departments] ([Id], [BranchId], [Description], [Name])
VALUES (
	N'26e2704d-4d12-4e24-9eaf-1b6c1d1b1fbe',
	N'bd4669f3-e060-498b-8f51-ab21ccd4f066',
	N'Description',
	N'Cash Services'
)
INSERT [dbo].[Departments] ([Id], [BranchId], [Description], [Name])
VALUES (
	N'fe0ccfc7-f718-47c1-8911-2eecbc7d2574',
	N'5c26de79-b151-4197-8b12-d0d051f6bf10',
	N'Description',
	N'Management'
)
INSERT [dbo].[Departments] ([Id], [BranchId], [Description], [Name])
VALUES (
	N'820d8f42-9dd2-4042-9e22-8adf9dc95d55',
	N'5c26de79-b151-4197-8b12-d0d051f6bf10',
	N'Description',
	N'Manned guarding'
)
INSERT [dbo].[Departments] ([Id], [BranchId], [Description], [Name])
VALUES (
	N'666f978f-fe87-4c46-bd2e-2177abf59452',
	N'5c26de79-b151-4197-8b12-d0d051f6bf10',
	N'Description',
	N'Traning'
)
INSERT [dbo].[Departments] ([Id], [BranchId], [Description], [Name])
VALUES (
	N'c498148a-8400-458f-8002-308f20b4588b',
	N'5c26de79-b151-4197-8b12-d0d051f6bf10',
	N'Description',
	N'Electronic security systems'
)
INSERT [dbo].[Departments] ([Id], [BranchId], [Description], [Name])
VALUES (
	N'084dc5ba-2935-4f2f-8316-752cbd3e9bad',
	N'5c26de79-b151-4197-8b12-d0d051f6bf10',
	N'Description',
	N'Cash Services'
)
GO
INSERT [dbo].[Clients] ([Id], [Email], [Name], [PhoneNumber])
VALUES (
	N'06f0115e-bd8b-4390-8ef9-31e0df7db77e',
	N'haanhtuan@gmail.com',
	N'Ha Anh Tuan',
	N'0326451623'
)
INSERT [dbo].[Clients] ([Id], [Email], [Name], [PhoneNumber])
VALUES (
	N'1ee50c1e-411d-4484-ba17-6447d4fb7812',
	N'linhmychi@gmail.com',
	N'Linh My Chi',
	N'0912873827'
)
INSERT [dbo].[Clients] ([Id], [Email], [Name], [PhoneNumber])
VALUES (
	N'324b53a7-8ede-43a1-96f8-98e113af44cc',
	N'unnamed.user@gmail.com',
	N'Ty Quay',
	N'0982894823'
)
INSERT [dbo].[Clients] ([Id], [Email], [Name], [PhoneNumber])
VALUES (
	N'488fa096-9865-4ae2-817b-aad1a1a618c1',
	N'anhchungthuyma@gmail.com',
	N'Hieu Thu Sau',
	N'0912874638'
)
INSERT [dbo].[Clients] ([Id], [Email], [Name], [PhoneNumber])
VALUES (
	N'707a1602-47af-4dfe-bfc9-854b2dff65b2',
	N'dobietday@gmail.com',
	N'Sau Thu Thau',
	N'0982654723'
)
INSERT [dbo].[Clients] ([Id], [Email], [Name], [PhoneNumber])
VALUES (
	N'70ee3dec-d460-4020-b6ec-9a692fb7842d',
	N'thangsida@gmail.com',
	N'Thang Vu',
	N'0935232123'
)
INSERT [dbo].[Clients] ([Id], [Email], [Name], [PhoneNumber])
VALUES (
	N'abea7802-25ad-4e1d-b1ff-3f80e2b636f8',
	N'aduthangcho@gamil.com',
	N'Dang Truong Thuong',
	N'0192874638')
INSERT [dbo].[Clients] ([Id], [Email], [Name], [PhoneNumber])
VALUES (
	N'ebefa0b9-780c-4ece-bda3-1a1683ec9cb2',
	N'mayduataoa@gmail.com',
	N'Nhat Duong Chi',
	N'0976927123'
)
INSERT [dbo].[Clients] ([Id], [Email], [Name], [PhoneNumber])
VALUES (
	N'f0c9e08d-d8a8-4658-9d9c-cc53cf372cb7',
	N'muoidiemkhongconhung@gmail.com',
	N'Le Thanh Cong',
	N'0988371928'
)
GO
INSERT [dbo].[Contracts] ([Id], [ClientId])
VALUES (
	N'3990219d-445e-466f-9db6-fcf2676181f1',
	N'06f0115e-bd8b-4390-8ef9-31e0df7db77e'
)
INSERT [dbo].[Contracts] ([Id], [ClientId])
VALUES (
	N'8ba375fa-23b7-43bc-a4c2-11452b6ee021',
	N'06f0115e-bd8b-4390-8ef9-31e0df7db77e'
)
GO
INSERT [dbo].[Services] ([Id], [Description], [Name])
VALUES (
	N'1a223d4e-060a-4073-bf3d-c0b03315f600',
	N'Essentially the term manned guarding refers to the actual security guards
that you’ll likely be familiar with. It refers to the physical presence of
security personnel and is a licensed activity that is monitored by a
Government department. They could be placed to physically guard properties,
people, assets or more against the threat of entry, assault, theft or
criminal damage. A manned security guard will be put in place to protect
various assets, which of course will depend on the needs and requirements
of the client(s). Security guards will usually be uniformed and act to
protect a designated property. They will act as a highly visible presence
and deterrent, which will ensure any criminal or inappropriate activities
are avoided and prevented.',
	N'Manned guarding'
)
INSERT [dbo].[Services] ([Id], [Description], [Name])
VALUES (
	N'5fc64104-0998-4ecb-97f2-285e472b94e6',
	N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur rutrum
sapien a tempus consequat. Donec mattis imperdiet lorem ac aliquam. Fusce
vel neque non nisl condimentum interdum vitae nec magna. Phasellus
fermentum ullamcorper aliquet. Praesent molestie risus eu quam malesuada,
nec consectetur nunc rhoncus. Vestibulum elementum ut enim congue feugiat.
Duis turpis mauris, ullamcorper eget venenatis vitae, tincidunt nec nibh.
Maecenas mauris leo, ornare vel ullamcorper vitae, venenatis ut nisi.
Aenean scelerisque elit id sapien laoreet aliquam. Quisque tristique felis
sed accumsan posuere. Nullam eget libero elit. Vivamus tempor pharetra
auctor. Orci varius natoque penatibus et magnis dis parturient montes,
nascetur ridiculus mus. Phasellus iaculis augue id eros aliquam venenatis.',
	N'Training'
)
INSERT [dbo].[Services] ([Id], [Description], [Name])
VALUES (
	N'838d987a-c267-4b6d-87bd-5f658dcb9845',
	N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur rutrum
sapien a tempus consequat. Donec mattis imperdiet lorem ac aliquam. Fusce
vel neque non nisl condimentum interdum vitae nec magna. Phasellus fermentum
ullamcorper aliquet. Praesent molestie risus eu quam malesuada, nec
consectetur nunc rhoncus. Vestibulum elementum ut enim congue feugiat. Duis
turpis mauris, ullamcorper eget venenatis vitae, tincidunt nec nibh.
Maecenas mauris leo, ornare vel ullamcorper vitae, venenatis ut nisi.
Aenean scelerisque elit id sapien laoreet aliquam. Quisque tristique felis
sed accumsan posuere. Nullam eget libero elit. Vivamus tempor pharetra
auctor. Orci varius natoque penatibus et magnis dis parturient montes,
nascetur ridiculus mus. Phasellus iaculis augue id eros aliquam venenatis.',
	N'Electronic security systems'
)
INSERT [dbo].[Services] ([Id], [Description], [Name])
VALUES (
	N'95f4546f-85dc-4ed8-acc9-e830b766a180',
	N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur rutrum
sapien a tempus consequat. Donec mattis imperdiet lorem ac aliquam. Fusce
vel neque non nisl condimentum interdum vitae nec magna. Phasellus
fermentum ullamcorper aliquet. Praesent molestie risus eu quam malesuada,
nec consectetur nunc rhoncus. Vestibulum elementum ut enim congue feugiat.
Duis turpis mauris, ullamcorper eget venenatis vitae, tincidunt nec nibh.
Maecenas mauris leo, ornare vel ullamcorper vitae, venenatis ut nisi.
Aenean scelerisque elit id sapien laoreet aliquam. Quisque tristique felis
sed accumsan posuere. Nullam eget libero elit. Vivamus tempor pharetra
auctor. Orci varius natoque penatibus et magnis dis parturient montes,
nascetur ridiculus mus. Phasellus iaculis augue id eros aliquam venenatis.',
	N'Cash Services'
)
GO
INSERT [dbo].[ContractServices] ([ContractId], [ServiceId])
VALUES (
	N'3990219d-445e-466f-9db6-fcf2676181f1',
	N'1a223d4e-060a-4073-bf3d-c0b03315f600'
)
INSERT [dbo].[ContractServices] ([ContractId], [ServiceId])
VALUES (
	N'8ba375fa-23b7-43bc-a4c2-11452b6ee021',
	N'1a223d4e-060a-4073-bf3d-c0b03315f600'
)
GO
INSERT [dbo].[EducationalQualifications] ([Id], [Description], [Name])
VALUES (
	N'8d07e0ac-63b4-41d4-ac33-8906e2d28082',
	N'Description',
	N'High School'
)
INSERT [dbo].[EducationalQualifications] ([Id], [Description], [Name])
VALUES (
	N'd62e1a46-e318-49cd-9832-d7026920406b',
	N'Description',
	N'Junior High School'
)
INSERT [dbo].[EducationalQualifications] ([Id], [Description], [Name])
VALUES (
	N'fa82ac29-729d-4cf0-a8d8-d61766bd442a',
	N'Description',
	N'University'
)
GO
INSERT [dbo].[Grades] ([Id], [Description], [Name])
VALUES (
	N'4f5b1dad-1488-47fd-b232-d7411db7a241',
	N'Description',
	N'Level 1'
)
INSERT [dbo].[Grades] ([Id], [Description], [Name])
VALUES (
	N'a022aba6-bc66-4dca-adb4-650911fc78ac',
	N'Description',
	N'Level 2'
)
INSERT [dbo].[Grades] ([Id], [Description], [Name])
VALUES (
	N'29c7306f-e283-4385-8d66-f3502bf6fc63',
	N'Description',
	N'Level 3'
)
INSERT [dbo].[Grades] ([Id], [Description], [Name])
VALUES (
	N'36967f25-99a8-4d2a-ae0e-105233f8bf42',
	N'Description',
	N'Level 4'
)
INSERT [dbo].[Grades] ([Id], [Description], [Name])
VALUES (
	N'8abd3103-a228-467a-b927-200986857279',
	N'Description',
	N'Level 5'
)
GO
INSERT [dbo].[Roles] ([Id], [Description], [Name])
VALUES (
	N'24722a9d-ad40-4324-a044-50825421cc6c',
	N'Description',
	N'Manager'
)
INSERT [dbo].[Roles] ([Id], [Description], [Name])
VALUES (
	N'97ce9bf7-6745-42d8-b6d0-e5f52f91a802',
	N'Description',
	N'Basic Employee'
)
GO
INSERT [dbo].[Employees] (
	[Id],
	[Address],
	[Code],
	[ContactNumber],
	[DepartmentId],
	[EducationalQualificationId],
	[GradeId],
	[Name],
	[Password],
	[RoleId]
)
VALUES (
	N'3d4d0938-b24c-4826-931f-7428234f6f64',
	N'Ho Chi Minh, Viet Nam',
	N'EMPLOYEE04',
	N'0223456789',
	N'271d1d37-2fe2-4807-bd64-0acba396d11e',
	N'8d07e0ac-63b4-41d4-ac33-8906e2d28082',
	N'a022aba6-bc66-4dca-adb4-650911fc78ac',
	N'Chi Hung Anh Dung',
	N'@1234567',
	N'97ce9bf7-6745-42d8-b6d0-e5f52f91a802'
)
INSERT [dbo].[Employees] (
	[Id],
	[Address],
	[Code],
	[ContactNumber],
	[DepartmentId],
	[EducationalQualificationId],
	[GradeId],
	[Name],
	[Password],
	[RoleId]
)
VALUES (
	N'9469cfb3-d7ef-4c04-8fb4-890942450b96',
	N'Ha Noi, Viet Nam',
	N'EMPLOYEE02',
	N'0912345678',
	N'820d8f42-9dd2-4042-9e22-8adf9dc95d55',
	N'8d07e0ac-63b4-41d4-ac33-8906e2d28082',
	N'36967f25-99a8-4d2a-ae0e-105233f8bf42',
	N'Dang Nhat Tuan',
	N'@1234567',
	N'97ce9bf7-6745-42d8-b6d0-e5f52f91a802'
)
INSERT [dbo].[Employees] (
	[Id],
	[Address],
	[Code],
	[ContactNumber],
	[DepartmentId],
	[EducationalQualificationId],
	[GradeId],
	[Name],
	[Password],
	[RoleId]
)
VALUES (
	N'a30f1922-74b4-4ae9-a907-8c9660cf7945',
	N'Ho Chi Minh, Viet Nam',
	N'EMPLOYEE03',
	N'0312345678',
	N'300f191b-ad96-41e7-82a9-cc4913d03efe',
	N'fa82ac29-729d-4cf0-a8d8-d61766bd442a',
	N'8abd3103-a228-467a-b927-200986857279',
	N'Nguyen Thuy Thu Trang',
	N'@1234567',
	N'24722a9d-ad40-4324-a044-50825421cc6c'
)
INSERT [dbo].[Employees] (
	[Id],
	[Address],
	[Code],
	[ContactNumber],
	[DepartmentId],
	[EducationalQualificationId],
	[GradeId],
	[Name],
	[Password],
	[RoleId]
)
VALUES (
	N'f21004f9-4ae7-4a16-a3a8-e8759038c58a',
	N'Ha Noi, Viet Nam',
	N'EMPLOYEE01',
	N'0123456789',
	N'fe0ccfc7-f718-47c1-8911-2eecbc7d2574',
	N'fa82ac29-729d-4cf0-a8d8-d61766bd442a',
	N'8abd3103-a228-467a-b927-200986857279',
	N'Ngo Bat Hanh',
	N'@1234567',
	N'24722a9d-ad40-4324-a044-50825421cc6c'
)
GO
INSERT [dbo].[EmployeeContracts] ([EmployeeId], [ContractId])
VALUES (
	N'3d4d0938-b24c-4826-931f-7428234f6f64',
	N'3990219d-445e-466f-9db6-fcf2676181f1'
)
INSERT [dbo].[EmployeeContracts] ([EmployeeId], [ContractId])
VALUES (
	N'3d4d0938-b24c-4826-931f-7428234f6f64',
	N'8ba375fa-23b7-43bc-a4c2-11452b6ee021'
)
INSERT [dbo].[EmployeeContracts] ([EmployeeId], [ContractId])
VALUES (
	N'9469cfb3-d7ef-4c04-8fb4-890942450b96',
	N'8ba375fa-23b7-43bc-a4c2-11452b6ee021'
)
GO
INSERT [dbo].[Recruitments] (
	[Id],
	[Description],
	[ManagerId],
	[Title],
	[Vacancies]
)
VALUES (
	N'43b882b7-1e5a-4216-8c21-dec4284b43de',
	N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus
maximus quam et tempus bibendum. Cras quis lectus ut leo sagittis
posuere. Proin dapibus ligula sodales sem aliquam commodo. Ut facilisis
tortor nec ligula pharetra feugiat vitae rutrum leo. Mauris vulputate
facilisis urna vitae fringilla. Sed sodales nisi augue, id efficitur orci
rutrum et. Phasellus non diam vitae dolor pulvinar ultricies quis ut nisl.
Nullam eget posuere purus. Pellentesque habitant morbi tristique senectus
et netus et malesuada fames ac turpis egestas. Nam tristique enim vel elit
aliquam pretium. Vivamus sodales urna vitae magna auctor dictum.

	Maecenas vitae velit non nibh tincidunt posuere in quis sapien. Ut interdum,
lacus id mattis porttitor, purus nulla fermentum nisi, id scelerisque libero
urna sit amet nisi. Maecenas blandit pharetra justo, sit amet feugiat nulla
elementum vitae. Vestibulum venenatis dictum pellentesque. Sed mi leo,
suscipit viverra tristique nec, pellentesque efficitur magna. Duis hendrerit
iaculis eros ut laoreet. Nam auctor cursus velit nec tempor. Nam at ipsum a
sapien condimentum lobortis. In hac habitasse platea dictumst. Suspendisse
sed vulputate lorem, ut luctus nulla.

	Pellentesque euismod tortor sit amet maximus placerat. Pellentesque eget
laoreet mi, at accumsan orci. Sed non lorem leo. Maecenas eu mi ut tellus
interdum feugiat eu sit amet dui. Suspendisse nulla felis, porttitor quis
arcu ac, fermentum porttitor arcu. Phasellus iaculis elit id interdum
feugiat. Integer quis ornare nibh, in cursus justo.

	Quisque facilisis quam nec quam eleifend, molestie pellentesque diam
dignissim. Morbi a consectetur augue. Fusce feugiat, felis nec dignissim
efficitur, elit lorem accumsan tortor, ut laoreet nunc nibh sit amet quam.
Integer fermentum tempor enim eget condimentum. Phasellus ut cursus lorem, non
porta velit. Suspendisse potenti. Duis diam est, luctus vitae nisi sodales,
efficitur luctus odio. Phasellus faucibus dui et velit tristique tempus.

	Nulla lobortis arcu nisl, non pulvinar lacus lobortis quis. Integer nec
dolor in lectus maximus porttitor a id ligula. Sed accumsan blandit neque, in
dignissim metus. Donec quis condimentum nisl. Nunc suscipit quam in ligula
suscipit cursus. Duis ex mi, condimentum et scelerisque sed, auctor id est.
Vestibulum suscipit placerat interdum. Etiam nec mauris ac est aliquam
sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis id
enim a dui vehicula volutpat.',
	N'f21004f9-4ae7-4a16-a3a8-e8759038c58a',
	N'Tuyen nhan vien 02',
	N'Nhan vien'
)

INSERT [dbo].[Recruitments] (
	[Id],
	[Description],
	[ManagerId],
	[Title],
	[Vacancies]
)
VALUES (
	N'ad46ff58-be15-4aea-b0c7-976c73a08e1e',
	N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus maximus
quam et tempus bibendum. Cras quis lectus ut leo sagittis posuere. Proin dapibus
ligula sodales sem aliquam commodo. Ut facilisis tortor nec ligula pharetra
feugiat vitae rutrum leo. Mauris vulputate facilisis urna vitae fringilla. Sed
sodales nisi augue, id efficitur orci rutrum et. Phasellus non diam vitae dolor
pulvinar ultricies quis ut nisl. Nullam eget posuere purus. Pellentesque
habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.
Nam tristique enim vel elit aliquam pretium. Vivamus sodales urna vitae magna
auctor dictum.

	Maecenas vitae velit non nibh tincidunt posuere in quis sapien. Ut interdum,
lacus id mattis porttitor, purus nulla fermentum nisi, id scelerisque libero
urna sit amet nisi. Maecenas blandit pharetra justo, sit amet feugiat nulla
elementum vitae. Vestibulum venenatis dictum pellentesque. Sed mi leo,
suscipit viverra tristique nec, pellentesque efficitur magna. Duis hendrerit
iaculis eros ut laoreet. Nam auctor cursus velit nec tempor. Nam at ipsum a
sapien condimentum lobortis. In hac habitasse platea dictumst. Suspendisse
sed vulputate lorem, ut luctus nulla.

	Pellentesque euismod tortor sit amet maximus placerat. Pellentesque eget
laoreet mi, at accumsan orci. Sed non lorem leo. Maecenas eu mi ut tellus
interdum feugiat eu sit amet dui. Suspendisse nulla felis, porttitor quis arcu
ac, fermentum porttitor arcu. Phasellus iaculis elit id interdum feugiat.
Integer quis ornare nibh, in cursus justo.

	Quisque facilisis quam nec quam eleifend, molestie pellentesque diam
dignissim. Morbi a consectetur augue. Fusce feugiat, felis nec dignissim
efficitur, elit lorem accumsan tortor, ut laoreet nunc nibh sit amet quam.
Integer fermentum tempor enim eget condimentum. Phasellus ut cursus lorem, non
porta velit. Suspendisse potenti. Duis diam est, luctus vitae nisi sodales,
efficitur luctus odio. Phasellus faucibus dui et velit tristique tempus.

	Nulla lobortis arcu nisl, non pulvinar lacus lobortis quis. Integer nec
dolor in lectus maximus porttitor a id ligula. Sed accumsan blandit neque,
in dignissim metus. Donec quis condimentum nisl. Nunc suscipit quam in ligula
suscipit cursus. Duis ex mi, condimentum et scelerisque sed, auctor id est.
Vestibulum suscipit placerat interdum. Etiam nec mauris ac est aliquam
sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis
id enim a dui vehicula volutpat.',
	N'f21004f9-4ae7-4a16-a3a8-e8759038c58a',
	N'Tuyen nhan vien 01',
	N'Nhan vien'
)
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240627092309_DatabaseVer1', N'8.0.6')
GO
