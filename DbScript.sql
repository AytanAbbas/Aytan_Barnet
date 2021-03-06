USE [BarnetDB]
GO
SET IDENTITY_INSERT [dbo].[Articles] ON 

INSERT [dbo].[Articles] ([Id], [Title], [CreatedDate]) VALUES (3, N'Aspernatur aut odit fugit quia', CAST(N'2021-12-19T21:51:00.0000000' AS DateTime2))
INSERT [dbo].[Articles] ([Id], [Title], [CreatedDate]) VALUES (4, N'Aspernatur aut odit fugit quia', CAST(N'2021-12-16T21:51:00.0000000' AS DateTime2))
INSERT [dbo].[Articles] ([Id], [Title], [CreatedDate]) VALUES (5, N'Aspernatur aut odit fugit quia', CAST(N'2021-12-02T21:51:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Articles] OFF
GO
SET IDENTITY_INSERT [dbo].[Banners] ON 

INSERT [dbo].[Banners] ([Id], [Title], [Page], [Image]) VALUES (2, N'Service One', N'Service', N'360bb173-c0d9-47e0-a799-736bcc15111f-20211219215451-3.jpg')
SET IDENTITY_INSERT [dbo].[Banners] OFF
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([Id], [Image], [Fullname], [Article]) VALUES (2, N'dce08294-2d64-42b1-aa70-21a818193be4-20211219220214-team-5.jpg', N'Mark William', N'Lorem ipsum dolor sit amet consectetur adipisicing elit eiusm tempor idunt ut labore dolore magna aliqua.enim ad ven.quis nostrud exercitation ullamc o laboris.aliquip ex ea commodo consequat duis aute irure dolor in reprehen derit in voluptate aute cillum dolore eu fugiat')
INSERT [dbo].[Clients] ([Id], [Image], [Fullname], [Article]) VALUES (3, N'6c376908-b377-4239-beaa-0d1996cec7cd-20211219220201-team-6.jpg', N'Birte Janssen', N'Lorem ipsum dolor sit amet consectetur adipisicing elit eiusm tempor idunt ut labore dolore magna aliqua.enim ad ven.quis nostrud exercitation ullamc o laboris.aliquip ex ea commodo consequat duis aute irure dolor in reprehen derit in voluptate aute cillum dolore eu fugiat')
INSERT [dbo].[Clients] ([Id], [Image], [Fullname], [Article]) VALUES (4, N'5042b541-d230-4875-b677-94c35a64e8a1-20211219220145-team-4.jpg', N'John Smith', N'Lorem ipsum dolor sit amet consectetur adipisicing elit eiusm tempor idunt ut labore dolore magna aliqua.enim ad ven.quis nostrud exercitation ullamc o laboris.aliquip ex ea commodo consequat duis aute irure dolor in reprehen derit in voluptate aute cillum dolore eu fugiat')
SET IDENTITY_INSERT [dbo].[Clients] OFF
GO
SET IDENTITY_INSERT [dbo].[Services] ON 

INSERT [dbo].[Services] ([Id], [Image], [Icon], [Title], [Content], [CreatedDate]) VALUES (11, N'096a9cc6-9f24-4163-8b19-ce4ac72f38a9-20211219212549-service-1.jpg', N'far fa-lightbulb', N'Professional Aproach', N'Lorem ipsum dolor sit amet adipelit sed eiusmtempor encid dolore.', CAST(N'2021-12-19T21:25:49.3112171' AS DateTime2))
INSERT [dbo].[Services] ([Id], [Image], [Icon], [Title], [Content], [CreatedDate]) VALUES (12, N'42dcfeaf-f48d-4658-b135-9a8bd1d0df3e-20211219212709-service-2.jpg', N'fas fa-piggy-bank', N'Startup Investment', N'Lorem ipsum dolor sit amet adipelit sed eiusmtempor encid dolore.', CAST(N'2021-12-19T21:27:09.5840485' AS DateTime2))
INSERT [dbo].[Services] ([Id], [Image], [Icon], [Title], [Content], [CreatedDate]) VALUES (13, N'2b4ade1c-8757-4a31-91f9-435a91120c32-20211219212909-service-3.jpg', N'far fa-chart-bar', N'Market Analysis', N'Lorem ipsum dolor sit amet adipelit sed eiusmtempor encid dolore.', CAST(N'2021-12-19T21:29:09.8789844' AS DateTime2))
INSERT [dbo].[Services] ([Id], [Image], [Icon], [Title], [Content], [CreatedDate]) VALUES (14, N'06fbf02a-f6b2-4a49-8593-9b9291a7cdc2-20211219214647-service-6.jpg', N'far fa-chart-bar', N'Growth Tracking', N'Lorem ipsum dolor sit amet adipelit sed eiusmtempor encid dolore.', CAST(N'2021-12-19T21:46:47.7183733' AS DateTime2))
INSERT [dbo].[Services] ([Id], [Image], [Icon], [Title], [Content], [CreatedDate]) VALUES (15, N'9f92ccfe-a0ba-452b-971a-9aca0a1f4178-20211219214804-service-7.jpg', N'fas fa-bullhorn', N'Successful Marketing', N'Lorem ipsum dolor sit amet adipelit sed eiusmtempor encid dolore.', CAST(N'2021-12-19T21:48:04.4175089' AS DateTime2))
INSERT [dbo].[Services] ([Id], [Image], [Icon], [Title], [Content], [CreatedDate]) VALUES (16, N'33655bc2-61f1-418f-a070-272946984d77-20211219215028-service-8.jpg', N'far fa-chart-bar', N'Planning Strategies', N'Lorem ipsum dolor sit amet adipelit sed eiusmtempor encid dolore.', CAST(N'2021-12-19T21:50:28.2508804' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Services] OFF
GO
SET IDENTITY_INSERT [dbo].[Settings] ON 

INSERT [dbo].[Settings] ([Id], [HeaderLogo], [Phone1], [Phone2], [Address], [Email], [About]) VALUES (8, N'3317eb48-861c-4f8a-b8ad-112babc97fe0-20211220105644-logo.png', N'(251) 235-3256', N'+2(305) 587-3407', N'Flat 20, Reynolds Neck, North Hele naville, FV77 8WS', N'info@barnet.com', N'Lorem ipsum dolor amet consecte adipisicing elit sed eiusm tempor incididunt ut labore dolore magna aliqua enim ad minim veniam. quis nostrud exercitation ullam  Duis aute irure dolor in reprehend it in voluptate velit cillum.dolore eu fugiat nulla.')
INSERT [dbo].[Settings] ([Id], [HeaderLogo], [Phone1], [Phone2], [Address], [Email], [About]) VALUES (9, N'1be8bd99-1c35-420a-b498-3f9fd985f66f-20211219222530-footer-logo.png', N'(251) 235-3256', N'l,oi', N'mosgi', N'aytan@gmail.com', N'dmofsiefjidej9sd8fde')
INSERT [dbo].[Settings] ([Id], [HeaderLogo], [Phone1], [Phone2], [Address], [Email], [About]) VALUES (10, N'287b84c4-4a59-4dba-a1c5-3c52e8f7904d-20211219222636-favicon.png', N'(251) 235-3256', N'misegsiujrgvsiuerwfe', N'edfmkedufj8r7fv', N'mefviesrudj8se7', N'de vfirdyh7de ')
SET IDENTITY_INSERT [dbo].[Settings] OFF
GO
SET IDENTITY_INSERT [dbo].[Sliders] ON 

INSERT [dbo].[Sliders] ([Id], [Image], [Category], [Title], [Content]) VALUES (2, N'959c9473-b55d-41fd-a45a-b6fe9bc86f78-20211219222018-1.jpg', N'Corporate', N'Business Solution', N'Lorem ipsum dolor sit amet constur adipelit sed do eiusm tempor magna aliqu enim ad minim veniam quis nostrud.exercittion ullamco laboris nisi ut aliquip excepteur.sint occaecat cuidatat non proident sunt in culpa officia')
INSERT [dbo].[Sliders] ([Id], [Image], [Category], [Title], [Content]) VALUES (3, N'003eb4bc-5505-4302-b927-61e3aceb302f-20211219222103-2.jpg', N'Corporate', N'Business Solution', N'Lorem ipsum dolor sit amet constur adipelit sed do eiusm tempor magna aliqu enim ad minim veniam quis nostrud.exercittion ullamco laboris nisi ut aliquip excepteur.sint occaecat cuidatat non proident sunt in culpa officia')
INSERT [dbo].[Sliders] ([Id], [Image], [Category], [Title], [Content]) VALUES (4, N'5bd088cf-b422-4299-819d-d02e58396f3b-20211219222202-3.jpg', N'Corporate', N'Business Solution', N'Lorem ipsum dolor sit amet constur adipelit sed do eiusm tempor magna aliqu enim ad minim veniam quis nostrud.exercittion ullamco laboris nisi ut aliquip excepteur.sint occaecat cuidatat non proident sunt in culpa officia.')
INSERT [dbo].[Sliders] ([Id], [Image], [Category], [Title], [Content]) VALUES (5, N'25be562d-ea09-4cf2-aa69-41698e904153-20211219222237-4.jpg', N'Corporate', N'Business Solution', N'Lorem ipsum dolor sit amet constur adipelit sed do eiusm tempor magna aliqu enim ad minim veniam quis nostrud.exercittion ullamco laboris nisi ut aliquip excepteur.sint occaecat cuidatat non proident sunt in culpa officia')
SET IDENTITY_INSERT [dbo].[Sliders] OFF
GO
SET IDENTITY_INSERT [dbo].[Socials] ON 

INSERT [dbo].[Socials] ([Id], [Name], [Icon], [Link]) VALUES (2, N'Gmail', N'fab fa-google-plus-g', NULL)
INSERT [dbo].[Socials] ([Id], [Name], [Icon], [Link]) VALUES (3, N'Facebook', N'fab fa-facebook-f', NULL)
INSERT [dbo].[Socials] ([Id], [Name], [Icon], [Link]) VALUES (4, N'Dribbble', N'fab fa-dribbble', NULL)
INSERT [dbo].[Socials] ([Id], [Name], [Icon], [Link]) VALUES (5, N'Twitter', N'fab fa-twitter', NULL)
SET IDENTITY_INSERT [dbo].[Socials] OFF
GO
