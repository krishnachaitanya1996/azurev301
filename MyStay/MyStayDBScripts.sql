/****** Object:  Table [dbo].[Booking]    Script Date: 2/5/2019 3:26:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ParentHotelID] [int] NULL,
	[ParentRoomID] [int] NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2/5/2019 3:26:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](10) NULL,
	[Email] [varchar](20) NULL,
	[Address] [varchar](20) NULL,
	[MobileNumber] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HotelInfo]    Script Date: 2/5/2019 3:26:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HotelInfo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Address] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 2/5/2019 3:26:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](100) NULL,
	[Password] [varchar](50) NULL,
	[IsAdmin] [bit] NULL,
 CONSTRAINT [PK__Login__3214EC274E8E919B] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 2/5/2019 3:26:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ParentBookingID] [int] NULL,
	[PaymentStatus] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RegisteredUsers]    Script Date: 2/5/2019 3:26:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegisteredUsers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
	[MobileNumber] [varchar](15) NULL,
	[Password] [varchar](50) NULL,
	[IsAdmin] [bit] NULL,
 CONSTRAINT [PK__Register__3214EC2772D43DCB] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 2/5/2019 3:26:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ParentHotelID] [int] NULL,
	[RoomNumber] [varchar](10) NULL,
	[NumberOfBeds] [int] NULL,
	[Price] [decimal](18, 0) NULL,
	[RoomType] [varchar](20) NULL,
	[RoomStatus] [varchar](20) NULL,
	[Service] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Booking] ON 
GO
INSERT [dbo].[Booking] ([ID], [ParentHotelID], [ParentRoomID], [StartDate], [EndDate]) VALUES (1, 1, 1, CAST(N'2019-02-01T00:00:00.000' AS DateTime), CAST(N'2019-02-06T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Booking] ([ID], [ParentHotelID], [ParentRoomID], [StartDate], [EndDate]) VALUES (2, 2, 2, CAST(N'2019-02-06T00:00:00.000' AS DateTime), CAST(N'2019-02-13T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Booking] ([ID], [ParentHotelID], [ParentRoomID], [StartDate], [EndDate]) VALUES (3, 3, 3, CAST(N'2019-02-13T00:00:00.000' AS DateTime), CAST(N'2019-02-15T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Booking] OFF
GO
SET IDENTITY_INSERT [dbo].[HotelInfo] ON 
GO
INSERT [dbo].[HotelInfo] ([ID], [Name], [Address]) VALUES (1, N'Suraj Palace', N'Infocity, Odisha')
GO
INSERT [dbo].[HotelInfo] ([ID], [Name], [Address]) VALUES (2, N'The Pride Hotel', N'Bangalore')
GO
INSERT [dbo].[HotelInfo] ([ID], [Name], [Address]) VALUES (3, N'Radisson Blu Plaza', N'Hyderabad')
GO
SET IDENTITY_INSERT [dbo].[HotelInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[Payment] ON 
GO
INSERT [dbo].[Payment] ([ID], [ParentBookingID], [PaymentStatus]) VALUES (1, 1, N'Paid')
GO
SET IDENTITY_INSERT [dbo].[Payment] OFF
GO
SET IDENTITY_INSERT [dbo].[Room] ON 
GO
INSERT [dbo].[Room] ([ID], [ParentHotelID], [RoomNumber], [NumberOfBeds], [Price], [RoomType], [RoomStatus], [Service]) VALUES (1, 3, N'201', 1, CAST(7000 AS Decimal(18, 0)), N'Luxury', NULL, N'All-Day Breakfast')
GO
INSERT [dbo].[Room] ([ID], [ParentHotelID], [RoomNumber], [NumberOfBeds], [Price], [RoomType], [RoomStatus], [Service]) VALUES (2, 3, N'202', 2, CAST(5000 AS Decimal(18, 0)), N'Non-Luxury', NULL, N'Luggage Forwarding')
GO
INSERT [dbo].[Room] ([ID], [ParentHotelID], [RoomNumber], [NumberOfBeds], [Price], [RoomType], [RoomStatus], [Service]) VALUES (3, 3, N'203', 3, CAST(4000 AS Decimal(18, 0)), N'Non-Luxury', NULL, N'Pick-up/Drop-off')
GO
SET IDENTITY_INSERT [dbo].[Room] OFF
GO
