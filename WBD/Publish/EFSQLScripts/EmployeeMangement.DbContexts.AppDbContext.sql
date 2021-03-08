IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210224084516_InitDb')
BEGIN
    CREATE TABLE [Employees] (
        [EmployeeId] int NOT NULL IDENTITY,
        [Firstname] nvarchar(10) NOT NULL,
        [Lastname] nvarchar(50) NOT NULL,
        CONSTRAINT [PK_Employees] PRIMARY KEY ([EmployeeId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210224084516_InitDb')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210224084516_InitDb', N'3.1.12');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210224090037_AlterEmployeeTable')
BEGIN
    ALTER TABLE [Employees] ADD [Age] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210224090037_AlterEmployeeTable')
BEGIN
    ALTER TABLE [Employees] ADD [AvatarPath] nvarchar(500) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210224090037_AlterEmployeeTable')
BEGIN
    ALTER TABLE [Employees] ADD [Code] nvarchar(8) NOT NULL DEFAULT N'';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210224090037_AlterEmployeeTable')
BEGIN
    ALTER TABLE [Employees] ADD [Email] nvarchar(100) NOT NULL DEFAULT N'';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210224090037_AlterEmployeeTable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210224090037_AlterEmployeeTable', N'3.1.12');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210226072405_CreateDepartmentTable')
BEGIN
    CREATE TABLE [Departments] (
        [DepartmentId] int NOT NULL IDENTITY,
        [DepartmentName] nvarchar(200) NOT NULL,
        [Email] nvarchar(50) NOT NULL,
        [PhoneNumber] nvarchar(20) NOT NULL,
        CONSTRAINT [PK_Departments] PRIMARY KEY ([DepartmentId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210226072405_CreateDepartmentTable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210226072405_CreateDepartmentTable', N'3.1.12');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210226080300_Create_Relationship_Employee_Department')
BEGIN
    ALTER TABLE [Employees] ADD [DepartmentId] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210226080300_Create_Relationship_Employee_Department')
BEGIN
    CREATE INDEX [IX_Employees_DepartmentId] ON [Employees] ([DepartmentId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210226080300_Create_Relationship_Employee_Department')
BEGIN
    ALTER TABLE [Employees] ADD CONSTRAINT [FK_Employees_Departments_DepartmentId] FOREIGN KEY ([DepartmentId]) REFERENCES [Departments] ([DepartmentId]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210226080300_Create_Relationship_Employee_Department')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210226080300_Create_Relationship_Employee_Department', N'3.1.12');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210226080802_Seeding_Department_Employee')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'DepartmentId', N'DepartmentName', N'Email', N'PhoneNumber') AND [object_id] = OBJECT_ID(N'[Departments]'))
        SET IDENTITY_INSERT [Departments] ON;
    INSERT INTO [Departments] ([DepartmentId], [DepartmentName], [Email], [PhoneNumber])
    VALUES (1, N'IT', N'it@codegym.vn', N'0935216417');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'DepartmentId', N'DepartmentName', N'Email', N'PhoneNumber') AND [object_id] = OBJECT_ID(N'[Departments]'))
        SET IDENTITY_INSERT [Departments] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210226080802_Seeding_Department_Employee')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'DepartmentId', N'DepartmentName', N'Email', N'PhoneNumber') AND [object_id] = OBJECT_ID(N'[Departments]'))
        SET IDENTITY_INSERT [Departments] ON;
    INSERT INTO [Departments] ([DepartmentId], [DepartmentName], [Email], [PhoneNumber])
    VALUES (2, N'HR', N'hr@codegym.vn', N'0935216417');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'DepartmentId', N'DepartmentName', N'Email', N'PhoneNumber') AND [object_id] = OBJECT_ID(N'[Departments]'))
        SET IDENTITY_INSERT [Departments] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210226080802_Seeding_Department_Employee')
BEGIN
    UPDATE [Employees] SET [DepartmentId] = 1
    WHERE [EmployeeId] = 1;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210226080802_Seeding_Department_Employee')
BEGIN
    UPDATE [Employees] SET [DepartmentId] = 1
    WHERE [EmployeeId] = 2;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210226080802_Seeding_Department_Employee')
BEGIN
    UPDATE [Employees] SET [DepartmentId] = 2
    WHERE [EmployeeId] = 3;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210226080802_Seeding_Department_Employee')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210226080802_Seeding_Department_Employee', N'3.1.12');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210226081648_Seeding_Employee')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'Age', N'AvatarPath', N'Code', N'DepartmentId', N'Email', N'Firstname', N'Lastname') AND [object_id] = OBJECT_ID(N'[Employees]'))
        SET IDENTITY_INSERT [Employees] ON;
    INSERT INTO [Employees] ([EmployeeId], [Age], [AvatarPath], [Code], [DepartmentId], [Email], [Firstname], [Lastname])
    VALUES (1, 18, N'avatar11.jpg', N'CGH00001', 1, N'khoa.nguyen@codegym.vn', N'Khoa', N'Nguyen');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'Age', N'AvatarPath', N'Code', N'DepartmentId', N'Email', N'Firstname', N'Lastname') AND [object_id] = OBJECT_ID(N'[Employees]'))
        SET IDENTITY_INSERT [Employees] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210226081648_Seeding_Employee')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'Age', N'AvatarPath', N'Code', N'DepartmentId', N'Email', N'Firstname', N'Lastname') AND [object_id] = OBJECT_ID(N'[Employees]'))
        SET IDENTITY_INSERT [Employees] ON;
    INSERT INTO [Employees] ([EmployeeId], [Age], [AvatarPath], [Code], [DepartmentId], [Email], [Firstname], [Lastname])
    VALUES (2, 18, N'avatar10.jpg', N'CGH00002', 1, N'hung.tran@codegym.vn', N'Hung', N'Tran');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'Age', N'AvatarPath', N'Code', N'DepartmentId', N'Email', N'Firstname', N'Lastname') AND [object_id] = OBJECT_ID(N'[Employees]'))
        SET IDENTITY_INSERT [Employees] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210226081648_Seeding_Employee')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'Age', N'AvatarPath', N'Code', N'DepartmentId', N'Email', N'Firstname', N'Lastname') AND [object_id] = OBJECT_ID(N'[Employees]'))
        SET IDENTITY_INSERT [Employees] ON;
    INSERT INTO [Employees] ([EmployeeId], [Age], [AvatarPath], [Code], [DepartmentId], [Email], [Firstname], [Lastname])
    VALUES (3, 18, N'avatar14.jpg', N'CGH00003', 2, N'huy.phan@codegym.vn', N'Huy', N'Phan');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'Age', N'AvatarPath', N'Code', N'DepartmentId', N'Email', N'Firstname', N'Lastname') AND [object_id] = OBJECT_ID(N'[Employees]'))
        SET IDENTITY_INSERT [Employees] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210226081648_Seeding_Employee')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210226081648_Seeding_Employee', N'3.1.12');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210226084252_Create_Member_Food_MemberFood_Tables')
BEGIN
    CREATE TABLE [Foods] (
        [FoodId] int NOT NULL IDENTITY,
        [Name] nvarchar(50) NOT NULL,
        [Image] nvarchar(500) NOT NULL,
        [Price] decimal(18,2) NOT NULL,
        CONSTRAINT [PK_Foods] PRIMARY KEY ([FoodId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210226084252_Create_Member_Food_MemberFood_Tables')
BEGIN
    CREATE TABLE [Members] (
        [MemberId] int NOT NULL IDENTITY,
        [Fullname] nvarchar(50) NOT NULL,
        [Email] nvarchar(50) NOT NULL,
        [Status] int NOT NULL,
        CONSTRAINT [PK_Members] PRIMARY KEY ([MemberId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210226084252_Create_Member_Food_MemberFood_Tables')
BEGIN
    CREATE TABLE [MemberFoods] (
        [MemberFoodId] int NOT NULL IDENTITY,
        [MemberId] int NOT NULL,
        [FoodId] int NOT NULL,
        [OrderDate] datetime2 NOT NULL,
        CONSTRAINT [PK_MemberFoods] PRIMARY KEY ([MemberFoodId]),
        CONSTRAINT [FK_MemberFoods_Foods_FoodId] FOREIGN KEY ([FoodId]) REFERENCES [Foods] ([FoodId]) ON DELETE CASCADE,
        CONSTRAINT [FK_MemberFoods_Members_MemberId] FOREIGN KEY ([MemberId]) REFERENCES [Members] ([MemberId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210226084252_Create_Member_Food_MemberFood_Tables')
BEGIN
    CREATE INDEX [IX_MemberFoods_FoodId] ON [MemberFoods] ([FoodId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210226084252_Create_Member_Food_MemberFood_Tables')
BEGIN
    CREATE INDEX [IX_MemberFoods_MemberId] ON [MemberFoods] ([MemberId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210226084252_Create_Member_Food_MemberFood_Tables')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210226084252_Create_Member_Food_MemberFood_Tables', N'3.1.12');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210301073001_Create_Identity_Tables')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210301073001_Create_Identity_Tables')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210301073001_Create_Identity_Tables')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210301073001_Create_Identity_Tables')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210301073001_Create_Identity_Tables')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(450) NOT NULL,
        [ProviderKey] nvarchar(450) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210301073001_Create_Identity_Tables')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210301073001_Create_Identity_Tables')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(450) NOT NULL,
        [Name] nvarchar(450) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210301073001_Create_Identity_Tables')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210301073001_Create_Identity_Tables')
BEGIN
    CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210301073001_Create_Identity_Tables')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210301073001_Create_Identity_Tables')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210301073001_Create_Identity_Tables')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210301073001_Create_Identity_Tables')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210301073001_Create_Identity_Tables')
BEGIN
    CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210301073001_Create_Identity_Tables')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210301073001_Create_Identity_Tables', N'3.1.12');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210301074212_Extend_IdentityUser_IdentityRole')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [Address] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210301074212_Extend_IdentityUser_IdentityRole')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [Gender] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210301074212_Extend_IdentityUser_IdentityRole')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210301074212_Extend_IdentityUser_IdentityRole', N'3.1.12');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210301074515_Extend_IdentityRole')
BEGIN
    ALTER TABLE [AspNetRoles] ADD [IsActive] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210301074515_Extend_IdentityRole')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210301074515_Extend_IdentityRole', N'3.1.12');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210301075302_Alter_IdentityUser_Table')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUsers]') AND [c].[name] = N'Address');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUsers] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [AspNetUsers] ALTER COLUMN [Address] nvarchar(300) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210301075302_Alter_IdentityUser_Table')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210301075302_Alter_IdentityUser_Table', N'3.1.12');
END;

GO

