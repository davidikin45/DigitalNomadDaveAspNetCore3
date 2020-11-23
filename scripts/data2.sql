DELETE FROM Project;
DELETE FROM Testimonial;
DELETE FROM BlogPostLocation;
DELETE FROM BlogPostTag;
DELETE FROM BlogPost;
DELETE FROM CarouselItem;
DELETE FROM Category;
DELETE FROM Author;
DELETE FROM Tag;
DELETE FROM [Location];
DELETE FROM ContentHtml;
DELETE FROM ContentText;
DELETE FROM Faq;
DELETE FROM MailingList;

SET IDENTITY_INSERT [dbo].[Location] ON 
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (1, CAST(N'2017-06-09T22:49:56.0000000' AS DateTime2), N'admin', CAST(N'2017-06-15T08:09:59.7766667' AS DateTime2), N'admin', N'Iceland', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJQ2Dro1Ir0kgRmkXB5TQEim8', 64.963051, -19.020835, N'files/gallery/iceland', N'iceland')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (2, CAST(N'2017-06-10T16:02:18.0000000' AS DateTime2), N'admin', CAST(N'2018-05-11T00:28:09.1133333' AS DateTime2), N'Anonymous', N'Australia', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJ38WHZwf9KysRUhNblaFnglM', -25.274398, 133.775136, N'files/gallery/australia', N'australia')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (3, CAST(N'2017-06-10T16:02:42.0900000' AS DateTime2), N'admin', CAST(N'2017-06-10T16:02:42.0900000' AS DateTime2), N'admin', N'New Zealand', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJh5Z3Fw4gLG0RM0dqdeIY1rE', -40.900557, 174.8859710000001, N'files/gallery/new-zealand', N'new-zealand')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (4, CAST(N'2017-06-10T16:03:03.0433333' AS DateTime2), N'admin', CAST(N'2017-06-10T16:03:03.0433333' AS DateTime2), N'admin', N'Vietnam', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJXx5qc016FTERvmL-4smwO7A', 14.058324, 108.277199, N'files/gallery/vietnam', N'vietnam')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (5, CAST(N'2017-06-10T16:03:28.7366667' AS DateTime2), N'admin', CAST(N'2017-06-10T16:03:28.7366667' AS DateTime2), N'admin', N'Indonesia', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJtwRkSdcHTCwRhfStG-dNe-M', -0.789275, 113.921327, N'files/gallery/indonesia', N'indonesia')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (6, CAST(N'2017-06-10T16:04:01.3533333' AS DateTime2), N'admin', CAST(N'2017-06-10T16:04:01.3533333' AS DateTime2), N'admin', N'Jordan', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJmd5kZkdvABURmU4mUQdbKI0', 30.585164, 36.238414, N'files/gallery/jordan', N'jordan')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (7, CAST(N'2017-06-10T16:04:18.9966667' AS DateTime2), N'admin', CAST(N'2017-06-10T16:04:18.9966667' AS DateTime2), N'admin', N'Egypt', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJ6TZcw3aJNhQRRMTEJQmgRSw', 26.820553, 30.802498, N'files/gallery/egypt', N'egypt')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (8, CAST(N'2017-06-10T16:05:06.2266667' AS DateTime2), N'admin', CAST(N'2017-06-10T16:05:06.2266667' AS DateTime2), N'admin', N'Israel', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJi8mnMiRJABURuiw1EyBCa2o', 31.046051, 34.8516119999999, N'files/gallery/israel', N'israel')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (9, CAST(N'2017-06-10T16:05:54.9200000' AS DateTime2), N'admin', CAST(N'2017-06-10T16:05:54.9200000' AS DateTime2), N'admin', N'Turkey', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJcSZPllwVsBQRKl9iKtTb2UA', 38.963745, 35.243322, N'files/gallery/turkey', N'turkey')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (10, CAST(N'2017-06-10T16:06:19.7233333' AS DateTime2), N'admin', CAST(N'2017-06-10T16:06:19.7233333' AS DateTime2), N'admin', N'Greece', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJY2xxEcdKWxMRHS2a3HUXOjY', 39.074208, 21.824312, N'files/gallery/greece', N'greece')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (11, CAST(N'2017-06-10T16:06:44.4366667' AS DateTime2), N'admin', CAST(N'2017-06-10T16:06:44.4366667' AS DateTime2), N'admin', N'Albania', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJLUwnvfM7RRMR7juY1onlfAc', 41.153332, 20.168331, N'files/gallery/albania', N'albania')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (12, CAST(N'2017-06-10T16:07:12.8733333' AS DateTime2), N'admin', CAST(N'2017-06-10T16:07:12.8733333' AS DateTime2), N'admin', N'Montenegro', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJyx8sJBcyTBMRRtP_boadTDg', 42.708678, 19.37439, N'files/gallery/montenegro', N'montenegro')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (13, CAST(N'2017-06-10T16:07:37.0000000' AS DateTime2), N'admin', CAST(N'2017-08-07T07:10:48.7600000' AS DateTime2), N'admin', N'Croatia', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJ7ZXdCghBNBMRfxtm4STA86A', 45.1, 15.2, N'files/gallery/croatia', N'croatia')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (14, CAST(N'2017-06-10T16:07:56.0000000' AS DateTime2), N'admin', CAST(N'2017-08-18T12:02:00.9966667' AS DateTime2), N'admin', N'Hungary', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJw-Q333uDQUcREBAeDCnEAAA', 47.162494, 19.5033040000001, N'files/gallery/hungary', N'hungary')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (15, CAST(N'2017-06-10T16:08:13.0000000' AS DateTime2), N'admin', CAST(N'2017-07-01T18:00:44.9333333' AS DateTime2), N'admin', N'Romania', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJw3aJlSb_sUARlLEEqJJP74Q', 45.943161, 24.96676, N'files/gallery/romania', N'romania')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (16, CAST(N'2017-06-10T16:08:37.0500000' AS DateTime2), N'admin', CAST(N'2017-06-10T16:08:37.0500000' AS DateTime2), N'admin', N'Bulgaria', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJifBbyMH-qEAREEy_aRKgAAA', 42.733883, 25.48583, N'files/gallery/bulgaria', N'bulgaria')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (17, CAST(N'2017-06-10T16:08:55.3400000' AS DateTime2), N'admin', CAST(N'2017-06-10T16:08:55.3400000' AS DateTime2), N'admin', N'Ukraine', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJjw5wVMHZ0UAREED2iIQGAQA', 48.379433, 31.16558, N'files/gallery/ukraine', N'ukraine')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (18, CAST(N'2017-06-10T16:09:15.0500000' AS DateTime2), N'admin', CAST(N'2017-06-10T16:09:15.0500000' AS DateTime2), N'admin', N'Poland', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJuwtkpGSZAEcR6lXMScpzdQk', 51.919438, 19.145136, N'files/gallery/poland', N'poland')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (19, CAST(N'2017-06-10T16:09:35.0000000' AS DateTime2), N'admin', CAST(N'2020-04-11T10:32:24.7992871' AS DateTime2), N'59f6b452-2a98-4aa0-aa03-475a1c9790ab', N'Lithuania', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 1, 0, N'ChIJE74zDxSU3UYRubpdpdNUCvM', 55.169438, 23.881275, NULL, N'lithuania')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (20, CAST(N'2017-06-10T16:09:54.5566667' AS DateTime2), N'admin', CAST(N'2017-06-10T16:09:54.5566667' AS DateTime2), N'admin', N'Latvia', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJ_ZqKe2cw6UYREPzyaM3PAAA', 56.879635, 24.6031889999999, N'files/gallery/latvia', N'latvia')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (21, CAST(N'2017-06-10T16:10:10.6100000' AS DateTime2), N'admin', CAST(N'2019-03-03T18:50:57.1623260' AS DateTime2), N'78340e0c-d14b-41b8-8cf8-f373c774ce21', N'Estonia', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJvxZW35mUkkYRcGL8GG2zAAQ', 59.4369608, 24.7535746999999, N'files/gallery/estonia', N'estonia')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (22, CAST(N'2017-06-10T16:10:26.5633333' AS DateTime2), N'admin', CAST(N'2017-06-10T16:10:26.5633333' AS DateTime2), N'admin', N'Finland', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJ3fYyS9_KgUYREKh1PNZGAQA', 61.92411, 25.748151, N'files/gallery/finland', N'finland')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (23, CAST(N'2017-06-10T16:10:46.3833333' AS DateTime2), N'admin', CAST(N'2017-06-10T16:10:46.3833333' AS DateTime2), N'admin', N'Norway', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJv-VNj0VoEkYRK9BkuJ07sKE', 60.472024, 8.468946, N'files/gallery/norway', N'norway')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (24, CAST(N'2017-06-10T16:11:07.4133333' AS DateTime2), N'admin', CAST(N'2017-06-10T16:11:07.4133333' AS DateTime2), N'admin', N'Sweden', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJ8fA1bTmyXEYRYm-tjaLruCI', 60.128161, 18.643501, N'files/gallery/sweden', N'sweden')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (25, CAST(N'2017-06-10T16:11:26.7100000' AS DateTime2), N'admin', CAST(N'2017-06-10T16:11:26.7100000' AS DateTime2), N'admin', N'Denmark', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJ-1-U7rYnS0YRzZLgw9BDh1I', 56.26392, 9.501785, N'files/gallery/denmark', N'denmark')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (26, CAST(N'2017-06-10T16:11:57.0833333' AS DateTime2), N'admin', CAST(N'2017-06-10T16:11:57.0833333' AS DateTime2), N'admin', N'Austria', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJfyqdJZsHbUcRr8Hk3XvUEhA', 47.516231, 14.550072, N'files/gallery/austria', N'austria')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (27, CAST(N'2017-06-10T16:12:14.5433333' AS DateTime2), N'admin', CAST(N'2017-06-10T16:12:14.5433333' AS DateTime2), N'admin', N'Switzerland', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJYW1Zb-9kjEcRFXvLDxG1Vlw', 46.818188, 8.2275119999999, N'files/gallery/switzerland', N'switzerland')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (28, CAST(N'2017-06-10T16:12:33.7500000' AS DateTime2), N'admin', CAST(N'2017-06-10T16:12:33.7500000' AS DateTime2), N'admin', N'Monaco', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJMYU_e2_CzRIR_JzEOkx493Q', 43.7384176, 7.4246158, N'files/gallery/monaco', N'monaco')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (29, CAST(N'2017-06-10T16:12:59.7400000' AS DateTime2), N'admin', CAST(N'2017-06-10T16:12:59.7400000' AS DateTime2), N'admin', N'Vatican City', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJPS3UVwqJJRMRsH46sppPCQA', 41.902916, 12.453389, N'files/gallery/vatican-city', N'vatican-city')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (30, CAST(N'2017-06-10T16:13:14.3500000' AS DateTime2), N'admin', CAST(N'2017-06-10T16:13:14.3500000' AS DateTime2), N'admin', N'Italy', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJA9KNRIL-1BIRb15jJFz1LOI', 41.87194, 12.56738, N'files/gallery/italy', N'italy')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (31, CAST(N'2017-06-10T16:13:32.7633333' AS DateTime2), N'admin', CAST(N'2017-06-10T16:13:32.7633333' AS DateTime2), N'admin', N'Spain', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJi7xhMnjjQgwR7KNoB5Qs7KY', 40.463667, -3.74922, N'files/gallery/spain', N'spain')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (32, CAST(N'2017-06-10T16:13:51.4533333' AS DateTime2), N'admin', CAST(N'2017-06-10T16:13:51.4533333' AS DateTime2), N'admin', N'Portugal', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJ1SZCvy0kMgsRQfBOHAlLuCo', 39.399872, -8.224454, N'files/gallery/portugal', N'portugal')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (33, CAST(N'2017-06-10T16:14:13.7700000' AS DateTime2), N'admin', CAST(N'2017-06-10T16:14:13.7700000' AS DateTime2), N'admin', N'Morocco', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJjcVRlmGICw0Rw_8sxIGT09k', 31.791702, -7.09262, N'files/gallery/morocco', N'morocco')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (34, CAST(N'2017-06-10T16:14:58.4400000' AS DateTime2), N'admin', CAST(N'2017-06-10T16:14:58.4400000' AS DateTime2), N'admin', N'France', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJMVd4MymgVA0R99lHx5Y__Ws', 46.227638, 2.213749, N'files/gallery/france', N'france')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (35, CAST(N'2017-06-10T16:15:18.5366667' AS DateTime2), N'admin', CAST(N'2017-06-10T16:15:18.5366667' AS DateTime2), N'admin', N'India', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJkbeSa_BfYzARphNChaFPjNc', 20.593684, 78.96288, N'files/gallery/india', N'india')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (36, CAST(N'2017-06-10T16:15:50.8233333' AS DateTime2), N'admin', CAST(N'2017-06-10T16:15:50.8233333' AS DateTime2), N'admin', N'Slovakia', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJf8Z8rrlgFEcRfTpysWdha80', 48.669026, 19.699024, N'files/gallery/slovakia', N'slovakia')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (37, CAST(N'2017-06-10T16:18:27.6733333' AS DateTime2), N'admin', CAST(N'2017-06-10T16:18:27.6733333' AS DateTime2), N'admin', N'Czechia', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJQ4Ld14-UC0cRb1jb03UcZvg', 49.817492, 15.4729620000001, N'files/gallery/czechia', N'czechia')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (38, CAST(N'2017-06-10T16:18:46.5633333' AS DateTime2), N'admin', CAST(N'2017-06-10T16:18:46.5633333' AS DateTime2), N'admin', N'Germany', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJa76xwh5ymkcRW-WRjmtd6HU', 51.165691, 10.4515260000001, N'files/gallery/germany', N'germany')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (39, CAST(N'2017-06-10T16:19:04.2800000' AS DateTime2), N'admin', CAST(N'2017-06-10T16:19:04.2800000' AS DateTime2), N'admin', N'Netherlands', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJu-SH28MJxkcRnwq9_851obM', 52.132633, 5.291266, N'files/gallery/netherlands', N'netherlands')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (40, CAST(N'2017-06-10T16:19:29.0000000' AS DateTime2), N'admin', CAST(N'2017-08-07T07:12:51.2733333' AS DateTime2), N'admin', N'England', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 1, N'ChIJ39UebIqp0EcRqI4tMyWV4fQ', 52.3555177, -1.1743197000001, N'files/gallery/england', N'england')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (41, CAST(N'2017-06-10T16:19:55.6833333' AS DateTime2), N'admin', CAST(N'2017-06-10T16:19:55.6833333' AS DateTime2), N'admin', N'Ireland', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJ-ydAXOS6WUgRCPTbzjQSfM8', 53.41291, -8.24389, N'files/gallery/ireland', N'ireland')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (42, CAST(N'2017-06-10T16:20:21.6366667' AS DateTime2), N'admin', CAST(N'2017-06-10T16:20:21.6366667' AS DateTime2), N'admin', N'Northern Ireland', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJdZmmmcoQXkgR2OO3bu8o5fc', 54.7877149, -6.4923145, N'files/gallery/northern-ireland', N'northern-ireland')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (43, CAST(N'2017-06-10T16:20:39.3233333' AS DateTime2), N'admin', CAST(N'2017-06-10T16:20:39.3233333' AS DateTime2), N'admin', N'Wales', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJ7Q8cbLY0ZEgRouilirxxux4', 52.1306607, -3.7837117, N'files/gallery/wales', N'wales')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (44, CAST(N'2017-06-10T16:21:01.1933333' AS DateTime2), N'admin', CAST(N'2017-06-10T16:21:01.1933333' AS DateTime2), N'admin', N'Scotland', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJn6HyA8TiYUgRFAfDCdj6wec', 56.4906712, -4.2026458, N'files/gallery/scotland', N'scotland')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (45, CAST(N'2017-06-10T16:21:51.0000000' AS DateTime2), N'admin', CAST(N'2017-09-17T13:34:34.5700000' AS DateTime2), N'admin', N'Slovenia', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJYYOWXuckZUcRZdTiJR5FQOc', 46.151241, 14.995463, N'files/gallery/slovenia', N'slovenia')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (46, CAST(N'2017-06-10T16:22:34.5933333' AS DateTime2), N'admin', CAST(N'2017-06-10T16:22:34.5933333' AS DateTime2), N'admin', N'United Arab Emirates', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJvRKrsd9IXj4RpwoIwFYv0zM', 23.424076, 53.847818, N'files/gallery/united-arab-emirates', N'united-arab-emirates')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (47, CAST(N'2017-06-10T16:25:55.3600000' AS DateTime2), N'admin', CAST(N'2017-06-10T16:25:55.3600000' AS DateTime2), N'admin', N'Palestine', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJ2b1miNLyHBURhvZm0QGgF-4', 31.952162, 35.233154, N'files/gallery/palestine', N'palestine')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (48, CAST(N'2017-06-16T15:30:01.0000000' AS DateTime2), N'admin', CAST(N'2017-06-27T18:25:56.6933333' AS DateTime2), N'admin', N'Sun Voyager', N'TouristAttraction', N'Sun Voyager is a dreamboat built to commemorate the 200th anniversary of Reykjavik. ', N'10 minutes', N'free', NULL, NULL, 0, 0, 0, N'ChIJz-YMCc501kgRqKacmXs6e9g', 64.14761, -21.9222878, N'files/gallery/iceland/sun-voyager', N'sun-voyager')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (49, CAST(N'2017-06-16T15:33:38.0000000' AS DateTime2), N'admin', CAST(N'2017-06-27T17:58:48.3766667' AS DateTime2), N'admin', N'Hallgrímskirkja Church', N'TouristAttraction', N'I didn''t get a chance to on my most recent trip but in January 2016 I climbed the tower for sunrise, definitely recommend for some nice shots.', N'30 minutes', N'7 GBP to climb tower', NULL, NULL, 0, 0, 0, N'ChIJtS1DoMx01kgR76qdSMQor_c', 64.1417149, -21.9266371, N'files/gallery/iceland/hallgrimskirkja', N'hallgrimskirkja-church')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (50, CAST(N'2017-06-16T15:36:47.0000000' AS DateTime2), N'admin', CAST(N'2017-06-22T23:19:58.9900000' AS DateTime2), N'admin', N'Thingvellir National Park', N'TouristAttraction', N'When you arrive at Thingvellir there is a viewing platform but I highly recommend walking down into the national park. Look out for divers diving between the North American and Eurasian tectonic plates in the rift named Silfra.', N'1 hour', N'free', NULL, NULL, 0, 0, 0, N'ChIJe2kT-x-B1kgR8mKSB4tsdWs', 64.255857, -21.1303622, N'files/gallery/iceland/thingvellir', N'thingvellir-national-park')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (51, CAST(N'2017-06-16T15:38:09.0000000' AS DateTime2), N'admin', CAST(N'2017-06-27T18:05:10.1800000' AS DateTime2), N'admin', N'Bruarfoss Waterfall', N'TouristAttraction', N'In my opinion this is one of the prettiest waterfalls in Iceland. I''m not sure what makes it so blue but it looks amazing! To get there after driving down a gravel road with lots of pot holes you then have to walk 10 - 15 minutes. Make sure you wear boots as it was quite muddy when we visited. Once you cross the small bridge with a sign that says 10km (don''t worry Bruarfoss is not a 10km walk) head to the right and follow the squashed grass where people have walked previously.', N'45 minutes', N'free', NULL, NULL, 0, 0, 0, N'ChIJ6cRQKbSZ1kgRgcrK-RjqESY', 64.2642562, -20.5157061, N'files/gallery/iceland/bruarfoss', N'bruarfoss-waterfall')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (52, CAST(N'2017-06-16T15:39:37.0000000' AS DateTime2), N'admin', CAST(N'2017-06-27T18:29:21.7433333' AS DateTime2), N'admin', N'Strokkur Geysir', N'TouristAttraction', N'The strokkur geyser explodes approximately every 5 minutes and is located right next to the main road.', N'30 minutes', N'free', NULL, NULL, 0, 0, 0, N'ChIJQx6ihstf1kgR4wuu2I9A_hM', 64.3103873, -20.3023158999999, N'files/gallery/iceland/strokkur-geysir', N'strokkur-geysir')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (53, CAST(N'2017-06-16T15:40:44.0000000' AS DateTime2), N'admin', CAST(N'2017-06-27T18:33:17.6266667' AS DateTime2), N'admin', N'Gulfoss Waterfall', N'TouristAttraction', N'This is the last stop on the ring road. We didn''t go down to the waterfall as we wanted to maximize our time at the Reykjadalur hot springs in the evening.', N'30 minutes', N'free', NULL, NULL, 0, 0, 0, N'ChIJAWT8snSl1kgRYhl-3u9_hIA', 64.3270716, -20.1199478, N'files/gallery/iceland/gulfoss', N'gulfoss-waterfall')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (54, CAST(N'2017-06-16T15:41:56.0000000' AS DateTime2), N'admin', CAST(N'2017-06-22T23:27:18.0000000' AS DateTime2), N'admin', N'Kerid Crater', N'TouristAttraction', N'This was pretty much the only attraction we paid for the entire road trip. It''s not too far off the main road and you can walk all around the crater edge and also to walk down to the water level if desired. Worth 3 GBP I reckon.', N'30 minutes', N'3 GBP', NULL, NULL, 0, 0, 0, N'ChIJV_L2VbeL1kgRB9kuweBEWlE', 64.0412785, -20.8851466, N'files/gallery/iceland/kerid-crater', N'kerid-crater')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (55, CAST(N'2017-06-16T15:45:00.0000000' AS DateTime2), N'admin', CAST(N'2017-06-27T18:45:22.5333333' AS DateTime2), N'admin', N'Reykjadalur Hot Springs', N'TouristAttraction', N'This is one of my favourite places in Iceland and is only about 45 minutes drive from Reykjavik! The name Reykjadalur means steam valley and if you visit you will understand why. The actual river that people bathe in is a flowing hot river about 30cm deep. A warning that in order to get to the hot springs it is a reasonably hilly 3.2km hike (mind the horse poo as there is a lot on the track) but trust me it''s worth it. It took us about an hour each way while stopping and taking photos. Make sure you bring some beers to enjoy after the hike!', N'2/3 hours', N'free', NULL, NULL, 0, 0, 0, N'ChIJf-ftCwJk1kgRrDOC5eVTA3s', 64.0228673, -21.2116442, N'files/gallery/iceland/reykjadalur', N'reykjadalur-hot-springs')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (56, CAST(N'2017-06-16T15:46:08.0000000' AS DateTime2), N'admin', CAST(N'2017-06-27T18:38:12.2966667' AS DateTime2), N'admin', N'Seljalandsfoss Waterfall', N'TouristAttraction', N'A waterfall you can walk behind. What more needs to be said!', N'20 minutes', N'free', NULL, NULL, 0, 0, 0, N'ChIJ7YHQxK0e10gRRS5ga9KJs0Y', 63.6156232, -19.9885687999999, N'files/gallery/iceland/seljalandsfoss', N'seljalandsfoss-waterfall')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (57, CAST(N'2017-06-16T15:47:18.0000000' AS DateTime2), N'admin', CAST(N'2017-06-23T00:08:33.4133333' AS DateTime2), N'admin', N'Gljufrabui Waterfall', N'TouristAttraction', N'This waterfall is located close to Seljalandsfoss (The waterfall you can walk behind) and in my opinion is better. In order to see it you have to go inside a canyon/cave and you get absolutely saturated! I wouldn''t recommend bringing a DSLR inside but perfect for a GoPro!', N'20 minutes', N'free', NULL, NULL, 0, 0, 0, N'ChIJF7NTFbAe10gRLl8U7LZVapY', 63.6208631, -19.9864486, N'files/gallery/iceland/gljufrabui', N'gljufrabui-waterfall')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (58, CAST(N'2017-06-16T15:51:26.0000000' AS DateTime2), N'admin', CAST(N'2017-06-27T18:40:09.4133333' AS DateTime2), N'admin', N'Seljavallalaug Thermal Pool', N'TouristAttraction', N'After visiting Seljalandsfoss and Gljufrabui we were saturated so decided we may as well go for a morning swim in an outdoor thermal pool! In my opinion it''s not quite as good as Reykjadalur but still amazing and it even has free change rooms (See photo below)! To get to the pool you have to drive 10 minutes up a gravel road with lots of pot holes and then walk 20 minutes through a valley. You cross one small river along the way. ', N'1.5 hours', N'free', NULL, NULL, 0, 0, 0, N'ChIJ88Mrkcs810gRyUoreu0vMd4', 63.5655971, -19.6075774, N'files/gallery/iceland/seljavallalaug', N'seljavallalaug-thermal-pool')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (59, CAST(N'2017-06-16T15:55:09.0000000' AS DateTime2), N'admin', CAST(N'2017-06-27T16:42:34.8600000' AS DateTime2), N'admin', N'Iceland Plane Wreck', N'TouristAttraction', N'On the 24th Novemeber 1973 a US Navy Douglas Super DC-3 crashed on Sólheimasandur black sand beach. Luckily everyone survived! If you''re a Justin Bieber fan he skate boards on top of this plane in his video clip "I''ll Show You". When I was in Iceland in January 2016 you could drive right up to the plane but now they have put fences up and you have to walk from the main road. It''s quite deceptive how far away it is and takes approximately 45 minutes each way. I think it''s about 4km. I wouldn''t be surprised if the land owners soon start charging for entry.', N'2 hours', N'free', NULL, NULL, 0, 0, 0, N'ChIJHcosKqw510gR91fMhtJmZd4', 63.4590918, -19.3647122, N'files/gallery/iceland/douglas-super-dc3-plane-crash', N'iceland-plane-wreck')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (60, CAST(N'2017-06-16T15:56:21.0000000' AS DateTime2), N'admin', CAST(N'2017-06-27T16:52:15.2500000' AS DateTime2), N'admin', N'Halsanefshellir Cave ', N'TouristAttraction', N'This place is easy to visit which is probably why my photo has lots of tourists in it. Regardless it''s pretty cool seeing the cave and hexagonal basalt columns. You have to pay for the toilets outside but if you walk inside the restaurant they are free :-)', N'20 minutes', N'free', NULL, NULL, 0, 0, 0, N'ChIJdYBsYypK10gRhaAfGQ9Bd0E', 63.4032141, -19.0421384, N'files/gallery/iceland/halsanefshellir-cave', N'halsanefshellir-cave')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (61, CAST(N'2017-06-16T15:58:08.0000000' AS DateTime2), N'admin', CAST(N'2017-06-27T17:55:12.5633333' AS DateTime2), N'admin', N'Vik', N'City', N'We only made a quick stop here to have a look at the stunning view from the Vík í Mýrdal church.', N'20 minutes', N'free', NULL, NULL, 0, 0, 0, N'ChIJgytzWEZK10gRDaIjlil70kY', 63.4205506, -19.0030002999999, N'files/gallery/iceland/vik', N'vik')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (62, CAST(N'2017-06-16T16:04:25.0000000' AS DateTime2), N'admin', CAST(N'2017-06-27T18:55:06.0966667' AS DateTime2), N'admin', N'Fjathrargljufur Canyon', N'TouristAttraction', N'This is probably my favourite place in Iceland possibly because I''d heard very little about it prior to visiting and had no expectations. It is situated between the city of Vik and Jokulsarlon Glacier Lagoon and as always you have to drive up a gravel path with lots of pot holes. You can walk into the canyon but the majority of tourists walk up the right hand side where you can get amazing photos looking down. It was a bit dull the day we went but still the greens and blues looked amazing! We stopped for dinner here as there are tables, chairs and free toilets right next to the car park.', N'1.5 hours', N'free', NULL, NULL, 0, 0, 0, N'ChIJ3ZFCWfDl0EgRvbVlccHsIKQ', 63.771279, -18.1718159, N'files/gallery/iceland/fjathrargljufur', N'fjathrargljufur-canyon')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (63, CAST(N'2017-06-16T16:05:28.0000000' AS DateTime2), N'admin', CAST(N'2017-06-27T18:59:20.8966667' AS DateTime2), N'admin', N'Jokulsarlon Glacier Lagoon', N'TouristAttraction', N'Whenever a friend visits Iceland I always recommend they try and at least make it around to see Jokulsarlon Glacier Lagoon. Its still, blue waters are dotted with icebergs from the surrounding Vatnajökull Glacier. The lagoon flows through a short waterway into the Atlantic Ocean, leaving chunks of ice on Diamond Beach. Keep an eye out for the seals and try and get a photo standing on an iceberg. The photos below were all taken around midnight.', N'45 minutes', N'free', NULL, NULL, 0, 0, 0, N'ChIJQ7AeMo3Wz0gRCf-T3qxJay8', 64.0739632, -16.2196827, N'files/gallery/iceland/jokulsarlon-glacier-lagoon', N'jokulsarlon-glacier-lagoon')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (64, CAST(N'2017-06-16T21:56:03.0000000' AS DateTime2), N'admin', CAST(N'2017-06-27T17:48:25.9666667' AS DateTime2), N'admin', N'Diamond Beach', N'TouristAttraction', N'You can see why this place is called ''Diamond Beach''. A great place if you are into photography especially if you get a killer sunset like we did. By the time we visited in May a lot of the ice had melted. I''ve posted a photo from January 2016 for comparison.', N'30 minutes', N'free', NULL, NULL, 0, 0, 0, N'ChIJ8wb7pBnXz0gRWoQH-WXoAkI', 64.044334, -16.1776622, N'files/gallery/iceland/diamond-beach', N'diamond-beach')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (65, CAST(N'2017-06-16T21:57:30.0000000' AS DateTime2), N'admin', CAST(N'2017-06-27T17:27:25.4900000' AS DateTime2), N'admin', N'Dettifoss Waterfall', N'TouristAttraction', N'Europe''s most powerful waterfall. 500 cubic metres of water per second plunges over the edge!', N'1 hour', N'free', NULL, NULL, 0, 0, 0, N'ChIJuU9fzooGzUgReiMomHV4QkA', 65.8146662, -16.384576, N'files/gallery/iceland/dettifoss', N'dettifoss-waterfall')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (66, CAST(N'2017-06-16T21:58:27.0000000' AS DateTime2), N'admin', CAST(N'2017-06-27T17:33:26.4666667' AS DateTime2), N'admin', N'Hverir Mud Pots', N'TouristAttraction', N'This place makes you feel like you''re on Mars! The landscape is very barren and is packed with bubbling mud pots and fumaroles releasing sulphuric gas.', N'30 minutes', N'free', NULL, NULL, 0, 0, 0, N'ChIJbeqt1QqfzUgR_PI0Y1ByDBA', 65.6409144, -16.8093111000001, N'files/gallery/iceland/hverir-mud-pots', N'hverir-mud-pots')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (67, CAST(N'2017-06-16T21:59:32.0000000' AS DateTime2), N'admin', CAST(N'2017-06-27T17:34:22.3900000' AS DateTime2), N'admin', N'Bjarnaflag Geothermal Station', N'TouristAttraction', N'The real Blue Lagoon! Unfortunately this is the waste water from a geothermal station and you can''t swim here.', N'10 minutes', N'free', NULL, NULL, 0, 0, 0, N'ChIJLcf00f6ezUgRIVSqv6AlviY', 65.6333333, -16.8666667, N'files/gallery/iceland/bjarnaflag-geothermal-station', N'bjarnaflag-geothermal-station')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (68, CAST(N'2017-06-16T22:00:25.0000000' AS DateTime2), N'admin', CAST(N'2017-06-27T17:47:55.2900000' AS DateTime2), N'admin', N'Grjotagja Cave', N'TouristAttraction', N'Previously people use to bathe in this cave but during volcanic eruptions from 1975 to 1984 the temperature of the water rose to more than 50 °C. It is apparently now slowly dropping and when I felt the water it was perfect bathing temperature! Unfortunately there is a a sign up outside saying the cave is only for photography. Look up a cave named Stóragjá as apparently it''s not far from here and you can swim inside!', N'20 minutes', N'free', NULL, NULL, 0, 0, 0, N'ChIJve4v3_CezUgREZX9xdn26Hk', 65.6271251, -16.8815664, N'files/gallery/iceland/grjotagja-cave', N'grjotagja-cave')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (69, CAST(N'2017-06-16T22:01:35.0000000' AS DateTime2), N'admin', CAST(N'2017-06-27T17:52:37.7700000' AS DateTime2), N'admin', N'Hverfjall Volcano', N'TouristAttraction', N'Don''t worry it erupted 2500 years ago! Once you reach the top you are able to walk right around the crater.', N'1 hour', N'free', NULL, NULL, 0, 0, 0, N'ChIJdVfoR7iezUgRIeMo4EHAZGs', 65.6086111, -16.8716667, N'files/gallery/iceland/hverfjall-volcano', N'hverfjall-volcano')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (70, CAST(N'2017-06-16T22:02:23.0000000' AS DateTime2), N'admin', CAST(N'2017-06-27T17:49:52.7133333' AS DateTime2), N'admin', N'Gothafoss Waterfall', N'TouristAttraction', N'I think you probably get better photos from the other side of the river but by the time I got here I was pretty wrecked and waterfalled out!', N'20 minutes', N'free', NULL, NULL, 0, 0, 0, N'ChIJnzYfSGp-zUgROx0NTqrNu34', 65.6827782, -17.5501919000001, N'files/gallery/iceland/gothafoss', N'gothafoss-waterfall')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (71, CAST(N'2017-06-16T15:52:52.0000000' AS DateTime2), N'admin', CAST(N'2017-06-27T18:49:59.1833333' AS DateTime2), N'admin', N'Skogafoss', N'TouristAttraction', N'This waterfall is right next to the ring road and is unique because you can climb stairs to look at it from above. We noticed there were toilets and showers here but you have to pay. I can''t remember the prices.
', N'30 minutes', N'free', NULL, NULL, 0, 0, 0, N'ChIJFYylOXY710gRSHn-zR_HYA8', 63.5320523, -19.5113706, N'files/gallery/iceland/skogafoss', N'skogafoss')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (72, CAST(N'2017-06-16T15:34:55.0000000' AS DateTime2), N'admin', CAST(N'2017-06-27T18:04:12.8533333' AS DateTime2), N'admin', N'Thorufoss Waterfall', N'TouristAttraction', N'This was our first stop on the ring road. If you are running short on time I would skip this one.', N'20 minutes', N'free', NULL, NULL, 0, 0, 0, N'ChIJv8nNFBd_1kgR3uih7uzjI00', 64.2606961, -21.3723883, N'files/gallery/iceland/porufoss', N'thorufoss-waterfall')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (73, CAST(N'2017-06-15T12:42:36.0000000' AS DateTime2), N'admin', CAST(N'2017-06-27T17:59:41.4500000' AS DateTime2), N'admin', N'Reykjavik', N'City', N'My favourite thing about Reykjavik is the graffiti art in the city centre. The photo from Jan 2016 was when I was lucky enough to see the Northern Lights dancing over Reykjavik (Yes that''s right, you don''t have to go on a tour to see them).', N'4 hours', N'free', NULL, NULL, 0, 0, 0, N'ChIJw-3c7rl01kgRcWDSMKIskew', 64.1265206, -21.8174392999999, N'files/gallery/iceland/reykjavik', N'reykjavik')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (74, CAST(N'2017-06-26T21:34:08.3533333' AS DateTime2), N'admin', CAST(N'2017-06-26T21:34:08.3533333' AS DateTime2), N'admin', N'Karvys Lake', N'Beach', NULL, N'2 days', N'180 Euro', NULL, NULL, 0, 0, 0, N'ChIJhZjqsy6E3UYRys7xbW2XCU0', 54.8754, 25.1320860000001, NULL, N'karvys-lake')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (75, CAST(N'2017-07-31T20:49:57.0000000' AS DateTime2), N'admin', CAST(N'2017-08-18T12:00:59.9166667' AS DateTime2), N'admin', N'Timisoara', N'City', NULL, N'1 Day', NULL, NULL, NULL, 0, 0, 0, N'ChIJp7UPy31nRUcRSWeTc2Svf1M', 45.7488716, 21.2086793, N'files/gallery/romania/timisoara', N'timisoara')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (76, CAST(N'2017-07-31T20:50:51.6333333' AS DateTime2), N'admin', CAST(N'2017-07-31T20:50:51.6333333' AS DateTime2), N'admin', N'Belgrade', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJvT-116N6WkcR5H4X8lxkuB0', 44.786568, 20.4489216, NULL, N'belgrade')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (77, CAST(N'2017-08-07T07:09:50.0000000' AS DateTime2), N'admin', CAST(N'2017-08-18T12:00:23.2166667' AS DateTime2), N'admin', N'Bosnia and Herzegovina', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJ16k3xxWiSxMRDOm3QwPi920', 43.915886, 17.679076, N'files/gallery/bosnia-and-herzegovina', N'bosnia-and-herzegovina')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (78, CAST(N'2017-08-07T07:11:50.5933333' AS DateTime2), N'admin', CAST(N'2017-08-07T07:11:50.5933333' AS DateTime2), N'admin', N'Serbia', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJlYCJ8t8dV0cRXYYjN-pQXgU', 44.016521, 21.005859, N'files/gallery/serbia', N'serbia')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (79, CAST(N'2017-08-18T11:59:49.7200000' AS DateTime2), N'admin', CAST(N'2017-08-18T11:59:49.7200000' AS DateTime2), N'admin', N'Cuba', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJtUx6DwdJzYgRGqQQkVL3jHk', 21.521757, -77.781167, N'files/gallery/cuba', N'cuba')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (80, CAST(N'2017-09-04T15:43:22.0000000' AS DateTime2), N'admin', CAST(N'2017-09-27T16:59:22.9366667' AS DateTime2), N'admin', N'Mexico', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJU1NoiDs6BIQREZgJa760ZO0', 23.634501, -102.552784, N'files/gallery/mexico', N'mexico')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (81, CAST(N'2017-09-04T15:44:09.0000000' AS DateTime2), N'admin', CAST(N'2017-11-01T02:57:04.9466667' AS DateTime2), N'admin', N'Belize', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJ-foSwT5bXI8RTuMeP02KSvY', 17.189877, -88.49765, N'files/gallery/belize', N'belize')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (82, CAST(N'2017-09-06T00:27:17.0000000' AS DateTime2), N'admin', CAST(N'2017-09-06T02:36:46.5966667' AS DateTime2), N'admin', N'Havana', N'City', NULL, N'3 days', NULL, NULL, NULL, 0, 0, 0, N'ChIJ4QD2vUx3zYgRYA13Gn5NKU4', 23.1135925, -82.3665956, N'files/gallery/cuba/havana', N'havana')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (83, CAST(N'2017-09-06T00:30:52.0000000' AS DateTime2), N'admin', CAST(N'2017-09-06T02:37:17.2033333' AS DateTime2), N'admin', N'Vinales', N'City', NULL, N'2 days', NULL, NULL, NULL, 0, 0, 0, N'ChIJIfwSLgtRy4gRZ-rAdvh9f0U', 22.6188131, -83.7066289, N'files/gallery/cuba/vinales', N'vinales')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (84, CAST(N'2017-09-06T00:32:00.0000000' AS DateTime2), N'admin', CAST(N'2017-09-06T02:37:57.0766667' AS DateTime2), N'admin', N'Playa Larga', N'City', NULL, N'2 days', NULL, NULL, NULL, 0, 0, 0, N'ChIJN8xSI4DJLI8RcwoyuP36rcE', 22.2886647, -81.2050614, N'files/gallery/cuba/playa-larga', N'playa-larga')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (85, CAST(N'2017-09-06T00:33:21.0000000' AS DateTime2), N'admin', CAST(N'2017-09-06T02:38:23.0333333' AS DateTime2), N'admin', N'Trinidad', N'City', NULL, N'3 days', NULL, NULL, NULL, 0, 0, 0, N'ChIJxeCp7ULkKo8RiVCxsgZ162c', 21.7960343, -79.9808143, N'files/gallery/cuba/trinidad', N'trinidad')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (86, CAST(N'2017-09-06T00:34:17.0000000' AS DateTime2), N'admin', CAST(N'2017-09-06T02:39:15.5633333' AS DateTime2), N'admin', N'Playa Ancon', N'Beach', NULL, N'1 day', NULL, NULL, NULL, 0, 0, 0, N'ChIJL6_TxVX7Ko8RVF1bdyLhb94', 21.7405008, -80.0129679, N'files/gallery/cuba/playa-ancon', N'playa-ancon')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (87, CAST(N'2017-09-27T16:56:45.0000000' AS DateTime2), N'admin', CAST(N'2017-11-05T14:20:11.3966667' AS DateTime2), N'admin', N'Guatemala', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJa1DnNlATiIURu9WEWzcrmDU', 15.783471, -90.230759, N'files/gallery/guatemala', N'guatemala')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (88, CAST(N'2017-11-01T02:55:32.0000000' AS DateTime2), N'admin', CAST(N'2017-12-08T16:36:22.7033333' AS DateTime2), N'admin', N'Nicaragua', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJzSL_zgDCEI8RtRWsP-Wn-sg', 12.865416, -85.207229, N'files/gallery/nicaragua', N'nicaragua')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (89, CAST(N'2017-11-03T16:11:59.0000000' AS DateTime2), N'admin', CAST(N'2017-11-04T03:48:59.4233333' AS DateTime2), N'admin', N'Mexico City', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJB3UJ2yYAzoURQeheJnYQBlQ', 19.4326077, -99.133208, N'files/gallery/mexico/Mexico City', N'mexico-city')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (90, CAST(N'2017-11-03T16:13:10.0000000' AS DateTime2), N'admin', CAST(N'2017-11-04T03:48:29.0700000' AS DateTime2), N'admin', N'Puerto Escondido', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJP7nTd-n3uIURpKCTb4nhhJE', 15.8719795, -97.0767365, N'files/gallery/mexico/Puerto Escondido', N'puerto-escondido')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (91, CAST(N'2017-11-03T16:14:29.0000000' AS DateTime2), N'admin', CAST(N'2017-11-04T03:49:17.2133333' AS DateTime2), N'admin', N'San Cristobal', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJz5uoHjtF7YUR3uJXSaNc1Ug', 16.7370359, -92.6376186, N'files/gallery/mexico/San Cristobal', N'san-cristobal')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (92, CAST(N'2017-11-03T16:15:27.0000000' AS DateTime2), N'admin', CAST(N'2017-11-04T03:47:53.6933333' AS DateTime2), N'admin', N'Palenque', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJKTvaAEZP8oUR8XOZc3PNatE', 17.5109792, -91.9930466, N'files/gallery/mexico/Palenque', N'palenque')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (93, CAST(N'2017-11-03T16:16:06.0000000' AS DateTime2), N'admin', CAST(N'2017-11-04T03:48:11.7133333' AS DateTime2), N'admin', N'Merida', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJFw1Fq1xxVo8RCeurFVcV_F0', 20.9673702, -89.5925857, N'files/gallery/mexico/Merida', N'merida')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (94, CAST(N'2017-11-03T16:17:17.0000000' AS DateTime2), N'admin', CAST(N'2017-11-04T03:47:35.6666667' AS DateTime2), N'admin', N'Valladolid', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJ9_O-e9oKUY8RMao55Y8feu0', 20.68964, -88.2022488, N'files/gallery/mexico/Valladolid', N'valladolid')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (95, CAST(N'2017-11-03T16:18:22.0000000' AS DateTime2), N'admin', CAST(N'2017-11-04T03:47:00.0466667' AS DateTime2), N'admin', N'Chichen Itza', N'TouristAttraction', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJM_iYoLk4UY8RRQ11MHWmcA8', 20.6783333, -88.5688888, N'files/gallery/mexico/Chichen Itza', N'chichen-itza')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (96, CAST(N'2017-11-03T16:19:34.0000000' AS DateTime2), N'admin', CAST(N'2017-11-04T03:46:24.8666667' AS DateTime2), N'admin', N'Ik Kil', N'TouristAttraction', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJl11soik_UY8RSO0deqb8H8w', 20.6610138, -88.550438, N'files/gallery/mexico/Ik Kil Cenote', N'ik-kil')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (97, CAST(N'2017-11-03T16:21:28.8866667' AS DateTime2), N'admin', CAST(N'2017-11-03T16:21:28.8866667' AS DateTime2), N'admin', N'Cenote Samula', N'TouristAttraction', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJ9RPbeH4LUY8RWGOHaAaU1kc', 20.6614944, -88.24404, NULL, N'cenote-samula')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (98, CAST(N'2017-11-03T16:22:52.2533333' AS DateTime2), N'admin', CAST(N'2017-11-03T16:22:52.2533333' AS DateTime2), N'admin', N'Cenote Xkeken', N'TouristAttraction', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJd52qnHwLUY8R4cV2Ady9ZY8', 20.6620132, -88.2439887, NULL, N'cenote-xkeken')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (99, CAST(N'2017-11-03T16:23:39.0000000' AS DateTime2), N'admin', CAST(N'2017-11-04T03:46:04.4600000' AS DateTime2), N'admin', N'Tulum', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJSyrkEAPUT48Rt5r_k9vA7Q4', 20.2114185, -87.4653502, N'files/gallery/mexico/Tulum', N'tulum')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (100, CAST(N'2017-11-03T16:24:25.0000000' AS DateTime2), N'admin', CAST(N'2017-11-04T03:46:05.2166667' AS DateTime2), N'admin', N'Playa del Carmen', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJYU4t0iNDTo8R3EqrO3gLweg', 20.6295586, -87.0738851, N'files/gallery/mexico/Playa Del Carmen', N'playa-del-carmen')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (101, CAST(N'2017-11-03T16:25:09.0000000' AS DateTime2), N'admin', CAST(N'2017-11-04T03:45:46.0433333' AS DateTime2), N'admin', N'Cancun', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJ21P2rgUrTI8Ris1fYjy3Ms4', 21.161908, -86.8515279, N'files/gallery/mexico/Cancun', N'cancun')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (102, CAST(N'2017-11-03T16:41:31.0000000' AS DateTime2), N'admin', CAST(N'2018-02-21T13:58:15.3533333' AS DateTime2), N'Anonymous', N'Costa Rica', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJJcmsIWLlko8RK5qBNSX3VGI', 9.748917, -83.753428, N'files/gallery/costa-rica', N'costa-rica')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (103, CAST(N'2017-11-09T15:26:50.8733333' AS DateTime2), N'admin', CAST(N'2017-11-09T15:26:50.8733333' AS DateTime2), N'admin', N'Antigua', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJFQslsHQOiYURPXIDKSu6hvc', 14.5585707, -90.729523, NULL, N'antigua')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (104, CAST(N'2017-11-09T16:05:09.0000000' AS DateTime2), N'admin', CAST(N'2017-11-10T02:39:10.8266667' AS DateTime2), N'admin', N'Chichicastenango', N'TouristAttraction', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJ_6z8h0pRiYUR1seJfh7-Bfs', 14.9431276, -91.1116546, N'files/gallery/guatemala/chichicastenango', N'chichicastenango')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (105, CAST(N'2017-11-09T16:51:57.0000000' AS DateTime2), N'admin', CAST(N'2017-11-10T02:39:10.0933333' AS DateTime2), N'admin', N'Livingston', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJ324vhgErZ48RUCKFaWdZ6No', 15.8269363, -88.7530076, N'files/gallery/guatemala/livingston', N'livingston')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (106, CAST(N'2017-11-09T16:55:24.0000000' AS DateTime2), N'admin', CAST(N'2017-11-10T02:38:53.1800000' AS DateTime2), N'admin', N'Volcano Acatenango', N'TouristAttraction', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJSfxsBKUXiYURg4NzmbkaWy0', 14.500461, -90.8756662, N'files/gallery/guatemala/acatenango', N'volcano-acatenango')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (107, CAST(N'2017-11-14T01:20:12.9900000' AS DateTime2), N'admin', CAST(N'2017-11-14T01:20:12.9900000' AS DateTime2), N'admin', N'Granada', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJeSryR-0MdI8RUZZYplJVAgY', 11.9049845, -85.8895551, NULL, N'granada')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (108, CAST(N'2017-12-08T16:13:41.5200000' AS DateTime2), N'admin', CAST(N'2017-12-08T16:13:41.5200000' AS DateTime2), N'admin', N'Leon', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJd3qPu5IfcY8RPDHqZG_AtTo', 12.4315534, -86.8722146, NULL, N'leon')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (109, CAST(N'2017-12-08T16:14:56.2366667' AS DateTime2), N'admin', CAST(N'2017-12-08T16:14:56.2366667' AS DateTime2), N'admin', N'Ometepe', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJ8yjPRvH3dI8Rjz7WkAWzyBA', 11.5141431, -85.5817911, NULL, N'ometepe')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (110, CAST(N'2017-12-08T16:31:57.0000000' AS DateTime2), N'admin', CAST(N'2018-02-02T22:08:05.8300000' AS DateTime2), N'admin', N'Panama', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJ4yu-yIMVpo8Rz5ulH03g7nk', 8.537981, -80.782127, N'files/gallery/panama', N'panama')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (111, CAST(N'2017-12-08T16:34:36.0000000' AS DateTime2), N'admin', CAST(N'2018-05-11T00:28:52.6600000' AS DateTime2), N'Anonymous', N'Colombia', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJo5QVrjqkFY4RQKPy7wSaDZo', 4.570868, -74.297333, N'files/gallery/colombia', N'colombia')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (112, CAST(N'2017-12-12T23:49:34.2000000' AS DateTime2), N'admin', CAST(N'2017-12-12T23:49:34.2166667' AS DateTime2), N'admin', N'Bastimentos', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJg5D1o2emqI8RFoJ_2CXq_9A', 9.3084415, -82.1441643, NULL, N'bastimentos')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (113, CAST(N'2017-12-22T14:07:11.7066667' AS DateTime2), N'admin', CAST(N'2017-12-22T14:07:11.7066667' AS DateTime2), N'admin', N'Tenorio National Park', N'TouristAttraction', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJP2ao8_dTdY8RNUf9QV4emn4', 10.6713889, -85.0125, NULL, N'tenorio-national-park')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (114, CAST(N'2017-12-22T14:08:51.0000000' AS DateTime2), N'admin', CAST(N'2017-12-22T14:21:38.0466667' AS DateTime2), N'admin', N'Free Hot Springs', N'TouristAttraction', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJHRPMAC0JoI8RHTMcr_OZOPs', 10.488671, -84.723409, NULL, N'free-hot-springs')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (115, CAST(N'2017-12-22T14:09:29.6033333' AS DateTime2), N'admin', CAST(N'2017-12-22T14:09:29.6033333' AS DateTime2), N'admin', N'La Fortuna Waterfall', N'TouristAttraction', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJbVyq80oMoI8Re6MOA-GxyT8', 10.442043, -84.667454, NULL, N'la-fortuna-waterfall')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (116, CAST(N'2017-12-22T14:10:20.9366667' AS DateTime2), N'admin', CAST(N'2017-12-22T14:10:20.9366667' AS DateTime2), N'admin', N'Monteverde', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJSXz39XgZoI8R1CQ_F8jsDZk', 10.306982, -84.809731, NULL, N'monteverde')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (117, CAST(N'2017-12-22T14:11:51.5933333' AS DateTime2), N'admin', CAST(N'2017-12-22T14:11:51.5933333' AS DateTime2), N'admin', N'Sámara', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJI1IHqgOqn48RxK8xGSlmLkQ', 9.8820222, -85.5290361, NULL, N'samara')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (118, CAST(N'2017-12-22T14:12:22.2733333' AS DateTime2), N'admin', CAST(N'2017-12-22T14:12:22.2733333' AS DateTime2), N'admin', N'Manzanillo', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJWwAvyeJFpo8Rt1GdbWwwG0g', 9.629838, -82.6577963, NULL, N'manzanillo')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (119, CAST(N'2017-12-22T14:12:50.1166667' AS DateTime2), N'admin', CAST(N'2017-12-22T14:12:50.1166667' AS DateTime2), N'admin', N'Montezuma', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJ3-4mKyJln48RL_dIMz18gdI', 9.6713187, -85.0701001, NULL, N'montezuma')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (120, CAST(N'2017-12-22T14:14:10.2566667' AS DateTime2), N'admin', CAST(N'2017-12-22T14:14:10.2566667' AS DateTime2), N'admin', N'Tambor Beach', N'Beach', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJO-iCZIF8n48R2htHAklsQwY', 9.7262692, -85.0285428, NULL, N'tambor-beach')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (121, CAST(N'2017-12-22T14:14:51.7466667' AS DateTime2), N'admin', CAST(N'2017-12-22T14:14:51.7466667' AS DateTime2), N'admin', N'Jaco', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJgwxhuWrHoY8R9t2Ppf9-8xs', 9.6202396, -84.6217487, NULL, N'jaco')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (122, CAST(N'2017-12-22T14:15:42.3300000' AS DateTime2), N'admin', CAST(N'2017-12-22T14:15:42.3300000' AS DateTime2), N'admin', N'Manuel Antonio National Park', N'TouristAttraction', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJS_Wpm5xxoY8Rhkpczjlh5pU', 9.392308, -84.1369879, NULL, N'manuel-antonio-national-park')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (123, CAST(N'2017-12-22T14:16:09.3000000' AS DateTime2), N'admin', CAST(N'2017-12-22T14:16:09.3000000' AS DateTime2), N'admin', N'Puerto Viejo ', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJFd-e6wxQpo8RRbmWoq2O61M', 9.6540146, -82.7549412, NULL, N'puerto-viejo')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (124, CAST(N'2017-12-22T14:16:53.2533333' AS DateTime2), N'admin', CAST(N'2017-12-22T14:16:53.2533333' AS DateTime2), N'admin', N'San Jose', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJxRUNxULjoI8RgrgRn2pqdOY', 9.9280694, -84.0907246, NULL, N'san-jose')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (125, CAST(N'2018-02-02T21:56:13.7466667' AS DateTime2), N'admin', CAST(N'2018-02-02T21:56:13.7466667' AS DateTime2), N'admin', N'San Blas Islands', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, NULL, 9.6185502576144, -78.9127612207085, NULL, N'san-blas-islands')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (126, CAST(N'2018-03-01T13:40:35.9866667' AS DateTime2), N'Anonymous', CAST(N'2018-03-01T13:40:35.9866667' AS DateTime2), N'Anonymous', N'Guatape', N'City', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJu_HtcikdRI4R3HpvCZzE6cg', 6.231137, -75.153467, NULL, N'guatape')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (127, CAST(N'2018-04-25T11:14:26.4400000' AS DateTime2), N'Anonymous', CAST(N'2018-04-25T11:14:26.4400000' AS DateTime2), N'Anonymous', N'Tasmania', N'Region', NULL, NULL, NULL, NULL, NULL, 0, 0, 0, N'ChIJz_o0fifteqoRZEBAKd2ljyo', -41.4545196, 145.9706647000001, N'files/gallery/australia/tasmania', N'tasmania')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (128, CAST(N'2019-03-03T11:46:46.3810389' AS DateTime2), N'78340e0c-d14b-41b8-8cf8-f373c774ce21', CAST(N'2019-03-03T18:31:43.5954797' AS DateTime2), N'78340e0c-d14b-41b8-8cf8-f373c774ce21', N'Georgia', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJa2JP5tcMREARwkotEmR5kE8', 42.315407, 43.356892, N'files/gallery/georgia', N'georgia')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (129, CAST(N'2020-04-14T10:27:25.7532054' AS DateTime2), N'59f6b452-2a98-4aa0-aa03-475a1c9790ab', CAST(N'2020-04-14T11:48:29.6955698' AS DateTime2), N'59f6b452-2a98-4aa0-aa03-475a1c9790ab', N'Thailand', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJsU1CR_eNTTARAuhXB4gs154', 15.870032, 100.992541, N'files/gallery/thailand', N'thailand')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (130, CAST(N'2020-04-14T10:29:05.4550152' AS DateTime2), N'59f6b452-2a98-4aa0-aa03-475a1c9790ab', CAST(N'2020-04-14T11:48:10.5933964' AS DateTime2), N'59f6b452-2a98-4aa0-aa03-475a1c9790ab', N'Ecuador', N'Country', NULL, NULL, NULL, NULL, NULL, 1, 0, 0, N'ChIJpftUlDxfqpoRf2eVV-5_DZA', -0.6393592, -90.3371889, N'files/gallery/ecuador', N'ecuador')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (131, CAST(N'2020-04-15T07:24:26.6006471' AS DateTime2), N'59f6b452-2a98-4aa0-aa03-475a1c9790ab', CAST(N'2020-04-15T07:29:23.6379643' AS DateTime2), N'59f6b452-2a98-4aa0-aa03-475a1c9790ab', N'Santa Cruz', N'City', NULL, N'3 days', NULL, NULL, NULL, 0, 0, 0, N'ChIJpftUlDxfqpoRf2eVV-5_DZA', -0.6393592, -90.3371889, N'files/gallery/ecuador/galapagos/Santa Cruz', N'santa-cruz')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (132, CAST(N'2020-04-15T07:26:54.1297248' AS DateTime2), N'59f6b452-2a98-4aa0-aa03-475a1c9790ab', CAST(N'2020-04-15T09:44:10.0368736' AS DateTime2), N'59f6b452-2a98-4aa0-aa03-475a1c9790ab', N'Floreana', N'City', NULL, N'2 days', N'$60 return', NULL, NULL, 0, 0, 0, N'ChIJzwI_o0qPqZoRPMZLKse9oWA', -1.3083314, -90.4313729, N'files/gallery/ecuador/galapagos/Floreana', N'floreana')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (133, CAST(N'2020-04-15T07:33:48.7395128' AS DateTime2), N'59f6b452-2a98-4aa0-aa03-475a1c9790ab', CAST(N'2020-04-15T07:33:48.7395166' AS DateTime2), N'59f6b452-2a98-4aa0-aa03-475a1c9790ab', N'Isabela', N'City', NULL, N'3 days', N'$60 return', NULL, NULL, 0, 0, 0, N'ChIJEYkA7sViq5oR5SOBpk1Xi2A', -0.8292374, -91.135302, N'files/gallery/ecuador/galapagos/Isabela', N'isabela')
GO
INSERT [dbo].[Location] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [LocationType], [DescriptionBody], [TimeRequired], [Cost], [LinkText], [Link], [ShowOnTravelMap], [CurrentLocation], [NextLocation], [PlaceId], [Latitude], [Longitude], [Album], [UrlSlug]) VALUES (134, CAST(N'2020-04-15T07:37:39.9349730' AS DateTime2), N'59f6b452-2a98-4aa0-aa03-475a1c9790ab', CAST(N'2020-04-15T07:38:39.3116191' AS DateTime2), N'59f6b452-2a98-4aa0-aa03-475a1c9790ab', N'San Cristobal', N'City', NULL, N'3 days', N'$60 return', NULL, NULL, 0, 0, 0, N'ChIJOejSsNLjAJARQOjtsiqyKR0', -0.8674715, -89.436391, N'files/gallery/ecuador/galapagos/San Cristobal', N'san-cristobal')
GO
SET IDENTITY_INSERT [dbo].[Location] OFF
GO
SET IDENTITY_INSERT [dbo].[Author] ON 
GO
INSERT [dbo].[Author] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [UrlSlug]) VALUES (1, CAST(N'2017-06-09T22:12:55.2933333' AS DateTime2), N'admin', CAST(N'2017-06-09T22:12:55.2933333' AS DateTime2), N'admin', N'Dave', N'dave')
GO
SET IDENTITY_INSERT [dbo].[Author] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 
GO
INSERT [dbo].[Category] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [UrlSlug], [Description], [Published]) VALUES (1, CAST(N'2017-06-09T22:13:56.0000000' AS DateTime2), N'admin', CAST(N'2018-05-10T02:05:25.6566667' AS DateTime2), N'Anonymous', N'Travel', N'travel', N'Travel', 1)
GO
INSERT [dbo].[Category] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [UrlSlug], [Description], [Published]) VALUES (2, CAST(N'2017-06-09T22:14:26.0000000' AS DateTime2), N'admin', CAST(N'2018-05-10T02:05:18.8700000' AS DateTime2), N'Anonymous', N'Photography', N'photography', N'Photography', 1)
GO
INSERT [dbo].[Category] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [UrlSlug], [Description], [Published]) VALUES (3, CAST(N'2017-06-09T22:14:50.0000000' AS DateTime2), N'admin', CAST(N'2017-06-10T16:00:33.8633333' AS DateTime2), N'admin', N'Digital Nomad', N'digital-nomad', N'Digital Nomad', 0)
GO
INSERT [dbo].[Category] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [UrlSlug], [Description], [Published]) VALUES (4, CAST(N'2020-04-11T10:28:48.9527894' AS DateTime2), N'59f6b452-2a98-4aa0-aa03-475a1c9790ab', CAST(N'2020-04-11T10:28:48.9527920' AS DateTime2), N'59f6b452-2a98-4aa0-aa03-475a1c9790ab', N'Programming', N'programming', N'programming', 1)
GO
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[BlogPost] ON 
GO
INSERT [dbo].[BlogPost] ([Id], [CreatedBy], [UpdatedOn], [UpdatedBy], [Title], [ShortDescription], [Description], [UrlSlug], [CarouselImage], [CarouselText], [ShowInCarousel], [Published], [CreatedOn], [AuthorId], [CategoryId], [ShowLocationDetail], [ShowLocationMap], [MapHeight], [MapZoom], [Album], [ShowPhotosInAlbum]) VALUES (1, N'admin', CAST(N'2017-06-21T08:21:34.6500000' AS DateTime2), N'admin', N'Iceland Ring Road on a Budget in 3 Days', N'Iceland is expensive but we managed to do it on a budget and still see over 25+ sites in 3 days!', N'<p>Lets start with the bad news by saying Iceland is expensive...even when you are earning a strong currency such as the sterling! I''m not sure if it''s possible to do Iceland completely dirt cheap (unless you hitch hike/walk) but it is possible to maximize the sights you see. This post is about saving money on some things and spending on others in order to see as many free sights as possible in 3 days.<br /><br />I previously visited Iceland in the winter of January 2016 and as most people do, based myself in the capital of Reykjavik and did day trips. I stayed at a really cool hostel named <a href="http://www.hostelworld.com/hosteldetails.php/KEX-Hostel/Reykjavik/48573" target="_blank" title="Kex" rel="noopener noreferrer">Kex</a> which is located <a href="https://www.google.co.uk/maps/place/Kex+Hostel+Reykjavik/@64.145424,-21.9216727,17z/data=!3m1!4b1!4m5!3m4!1s0x48d674ce84f58251:0x58b25b89d1a390f7!8m2!3d64.145424!4d-21.919484" target="_blank" title="Kex Hostel" rel="noopener noreferrer">very central</a> in an old biscuit factory. The hostel is located on the 3rd floor above a bar which on a saturday night is packed with locals. I definitely wouldn''t classify it as a&nbsp;''party hostel'' but it has a great vibe about it.</p>
<p>In 2016 the day tours I paid for were <a href="https://intotheglacier.is/" target="_blank" title="Into the Glacier" rel="noopener noreferrer">Into the Glacier</a> (&pound;150.00) and <a href="http://www.bluelagoon.com/" target="_blank" title="The Blue Lagoon" rel="noopener noreferrer">The Blue Lagoon</a> (min&nbsp;&pound;50.00). Don''t get me wrong they were both excellent but they were quite expensive and meant I missed out on seeing other natural sights which in my opinion are much better.<br /><br />My girlfriend Dovile was keen to visit Iceland and I was keen to see it in the summer so we decided to visit at the end of May to make use of the long hours of daylight. The rough plan was to do the Ring Road as cheap as possible by keeping the visit short and visiting as many free sights as possible. Notably giving the Blue Lagoon a miss.<br /><br />One thing I didn''t like about my last trip was having to return to Reykjavik each night so after doing some research we decided hiring a camper van worked out to be pretty much the same price as booking accomodation and hiring a car. We hired our van through a company named <a href="http://www.gocampers.is" target="_blank" title="Go Camper" rel="noopener noreferrer">Go Camper</a> which I highly recommend. They even pick you up from the <a href="https://www.google.co.uk/maps/place/BSI+Reykjavik/@64.1376143,-21.9370066,17z/data=!3m1!4b1!4m5!3m4!1s0x48d60b344a43b93f:0xbfe1bcd8cd9796e6!8m2!3d64.137612!4d-21.9348126" target="_blank" title="BSI Reykjavik bus terminal" rel="noopener noreferrer">BSI Reykjavik bus terminal</a>&nbsp;and drop you off anywhere in Reykjavik for free!</p>
<p>To save money we also brought a small thermos from London and each evening made up a fresh brew for the next day.<br /><br />We flew WOW Air from Gatwick Airport on Friday 26th of May @ 21:00 and arrived at Kevlavik airport at approximately 23:30. The first thing I noticed was how light it was outside! In the summer you pretty much get 24 hours day light! Perfect for a road trip!<br /><br />We caught the <a href="https://www.re.is/flybus/" target="_blank" title="FlyBus" rel="noopener noreferrer">FlyBus</a> which costs approximately &pound;35.00 return from <a href="https://www.google.co.uk/maps/place/Keflav%C3%ADk+International+Airport/@63.986809,-22.6301608,17z/data=!3m1!4b1!4m5!3m4!1s0x4929fdfce2ab799f:0x27f88d0a15c328cd!8m2!3d63.9868067!4d-22.6279668" target="_blank" title="Kevlavik Airport" rel="noopener noreferrer">Kevlavik Airport</a> to the <a href="https://www.google.co.uk/maps/place/BSI+Reykjavik/@64.1376143,-21.9370066,17z/data=!3m1!4b1!4m5!3m4!1s0x48d60b344a43b93f:0xbfe1bcd8cd9796e6!8m2!3d64.137612!4d-21.9348126" target="_blank" title="BSI Reykjavik bus terminal" rel="noopener noreferrer">BSI Reykjavik bus terminal</a> and then walked to our first nights AirBnB accomodation 15 minutes away. Iceland is safe so walking around after midnight is not a problem. The AirBnB accomodation was the strangest I''d ever experienced as it was located in a tiny attic only accessible by a ladder. To be honest I was extremely tired so I didn''t care too much but&nbsp;it was an experience. The nights accomodation cost&nbsp;&pound;50.00 which is considerably more expensive than other european cities but it was still cheaper than 2 x dorm beds at <a href="http://www.hostelworld.com/hosteldetails.php/KEX-Hostel/Reykjavik/48573" target="_blank" title="Kex" rel="noopener noreferrer">Kex</a>.</p>
<p><strong>Day 1 - Saturday 27th May</strong></p>
<p>We woke up at approximately 7am (probably because the attic we were staying in didn''t have a curtain) and ventured into the city centre. Reykjavik is not massive so you are able to see most things by walking within a few hours. It has lots of art so for the first hour we just wandered around looking at graffitti art. My favourite was a mural at <a href="https://www.google.co.uk/maps/place/Laugavegur+66,+101+Reykjav%C3%ADk,+Iceland/@64.1434137,-21.9279072,15.46z/data=!4m5!3m4!1s0x48d674cc19a399f7:0xacd8cc2c9a98fa23!8m2!3d64.1441187!4d-21.9211949" target="_blank" title="66 Laugavegur St" rel="noopener noreferrer">66 Laugavegur St</a>.&nbsp;</p>
<p>We then continued to see the Sun Voyager monument and the Hallgr&iacute;mskirkja church. Both iconic Reykjavik sights.</p>
<p>If your short on time my tip is to spend as little time as possible in Reykjavik to maximize the time at the natural sights which in my opinion is the best part about Iceland. Flights out of Iceland are generally early afternoon which means the last day is pretty much a right off for doing anything adventurous. Instead use this time to see anything you missed in Reykjavik on your first day.</p>
<p>At 10:00 we got our free shuttle from the BSI bus terminal and arrived at the Go Camper office after a short drive. The office was busy but the process of picking up our van was relatively simple and the staff were helpful with tips about Iceland. The van we hired was a <a href="http://www.gocampers.is/our-campers/go-smart-camper-2-pax-/478" target="_blank" title="2 pax Go SMART camper" rel="noopener noreferrer">2 pax Go SMART camper</a> which included the following essentials:</p>
<ul>
<li>Mattress</li>
<li>Curtains</li>
<li>Plates/Bowls</li>
<li>Cutlery&nbsp;</li>
<li>Frying pan with gas canister adapter</li>
<li>Pot</li>
<li>Dishwashing liquid</li>
<li>Fire Lighter</li>
<li>Free coffee and fuel discount card @ Ol&iacute;s!</li>
</ul>
<p>We also hired the following <a href="http://www.gocampers.is/extras/" target="_blank" title="extras" rel="noopener noreferrer">extras</a>:</p>
<ul>
<li>2 x sleeping bags (2 x &pound;20.00)&nbsp;</li>
<li>Power inverter to charge camera batteries (&pound;15.00)</li>
</ul>
<p>They will probably try and sell you a gas canister (&euro;10.00 small, &euro;15.00 large) but see if you can get them to throw in a half full one for free like they did for us. To give an indication of how much gas you will use, we still had gas left at the end of our 3 day trip.</p>
<p>You will probably also get the spiel about staying in caravan parks. It''s up to you whether you want to take this advice but we had minimal issues finding places to sleep each night without paying. I give exact locations where we stayed later on.</p>
<p>Before you leave raid the free food shelf they have, trust me you will be thankful you did once you go to the supermarket and see the prices!</p>
<p>After picking up the van we went to the <a href="https://www.google.co.uk/maps/place/Kr%C3%B3nan/@64.0732594,-21.9643122,14z/data=!4m8!1m2!2m1!1zS3LDs25hbiwgSGFmbmFyZmrDtnLDsHVyLCBJY2VsYW5k!3m4!1s0x0:0x7b41bfaae8ae4219!8m2!3d64.076454!4d-21.9421113" target="_blank" title="Kr&oacute;nan" rel="noopener noreferrer">Kr&oacute;nan</a> supermarket just around the corner and stocked up on the following&nbsp;essentials:</p>
<ul>
<li>Water</li>
<li>Bananas</li>
<li>Apples</li>
<li>Tomatoes</li>
<li>Cucumber</li>
<li>Cheese</li>
<li>Hamburgers</li>
<li>Doritios and Dip</li>
<li>Baked Beans</li>
<li>Eggs</li>
<li>Ham</li>
<li>Bread</li>
<li>Red Bull</li>
<li>Beer</li>
</ul>
<p>We spent a total of&nbsp;&pound;70.00. The supermarket beers in iceland are all 2.25% so you won''t be getting drunk off them but definitely get a few for the Reykjadalur hot springs.</p>
<p>We managed to leave Reykjavik at 12:00 and&nbsp;got to the end of the&nbsp;Golden Circle (Gulfoss Waterfall)&nbsp;by approximately 18:00 after which we headed to Kerid Crater and then hiked into the Reykjadalur hot springs. Reykjadalur was the highlight of my day and highly recommend visiting with a few beers. After a busy day sightseeing it is the the perfect way to unwind!</p>
<p>Highlight: Reykjadalur hot springs</p>
<p>Dinner: In a <a href="https://www.google.co.uk/maps/place/Sk%C3%B3lam%C3%B6rk,+Hverager%C3%B0i,+Iceland/@64.0013469,-21.1827687,16z/data=!4m18!1m12!4m11!1m6!1m2!1s0x48d66408f311ada5:0x2c0af65ac78b7511!2sReykjadalur,+Iceland!2m2!1d-21.216023!2d64.0330888!1m3!2m2!1d-21.1830461!2d64.0012835!3m4!1s0x48d666ca66273c5b:0xea8e6ab877d1fe25!8m2!3d64.0008262!4d-21.1826449" target="_blank" title="park" rel="noopener noreferrer">park</a> nearby to Reykjadalur.</p>
<p>Sleep: Hella in the car park of <a href="https://www.google.co.uk/maps/place/Restaurant+%C3%81rh%C3%BAs/@63.8339486,-20.4078823,17z/data=!4m8!1m2!2m1!1srestauarant+arhus+hella!3m4!1s0x0:0x9dd2e2f49ac423dc!8m2!3d63.8337899!4d-20.4066318" target="_blank" title="Restaurant &Aacute;rh&uacute;s" rel="noopener noreferrer">Restaurant &Aacute;rh&uacute;s</a>.</p>
<p>Sights visited:</p>
<ul>
<li><a href="https://www.google.co.uk/maps/place/Reykjav%C3%ADk,+Iceland/@64.1323387,-21.9224813,12z/data=!3m1!4b1!4m5!3m4!1s0x48d674b9eedcedc3:0xec912ca230d26071!8m2!3d64.1265206!4d-21.8174393" target="_blank" title="Reykjavik" rel="noopener noreferrer">Reykjavik</a></li>
<li><a href="https://www.google.co.uk/maps/place/S%C3%B3lfari%C3%B0+-+Sun+Voyager/@64.1476123,-21.9244765,17z/data=!3m1!4b1!4m5!3m4!1s0x48d674ce090ce6cf:0xd87b3a7b999ca6a8!8m2!3d64.14761!4d-21.9222878" target="_blank" title="Sun Voyager monument" rel="noopener noreferrer">Sun Voyager monument</a></li>
<li><a href="https://www.google.co.uk/maps/place/Hallgrimskirkja/@64.1417172,-21.9288258,17z/data=!3m1!4b1!4m5!3m4!1s0x48d674cca0432db5:0xf7af28c4489daaef!8m2!3d64.1417149!4d-21.9266371" target="_blank" title="https://www.google.co.uk/maps/place/Hallgrimskirkja/@64.1417172,-21.9288258,17z/data=!3m1!4b1!4m5!3m4!1s0x48d674cca0432db5:0xf7af28c4489daaef!8m2!3d64.1417149!4d-21.9266371" rel="noopener noreferrer">Hallgrimskirkja church</a></li>
<li><a href="https://www.google.co.uk/maps/place/%C3%BE%C3%B3rufoss/@64.2606984,-21.374577,17z/data=!3m1!4b1!4m5!3m4!1s0x48d67f1714cdc9bf:0x4d23e3eceea1e8de!8m2!3d64.2606961!4d-21.3723883" target="_blank" title="&thorn;&oacute;rufoss waterfall" rel="noopener noreferrer">&thorn;&oacute;rufoss waterfall (Golden Circle)</a></li>
<li><a href="https://www.google.co.uk/maps/place/%C3%9Eingvellir+national+park/@64.2558593,-21.1325509,17z/data=!3m1!4b1!4m5!3m4!1s0x48d6811ffb13697b:0x6b756c8b079262f2!8m2!3d64.255857!4d-21.1303622" target="_blank" title="&THORN;ingvellir National Park " rel="noopener noreferrer">&THORN;ingvellir National Park (Golden Circle)</a></li>
<li><a href="https://www.google.co.uk/maps/place/Bruarfoss+Waterfall/@64.2642585,-20.5178948,17z/data=!3m1!4b1!4m5!3m4!1s0x48d699b42950c4e9:0x2611ea18f9caca81!8m2!3d64.2642562!4d-20.5157061" target="_blank" title="Bruarfoss waterfall" rel="noopener noreferrer">*Bruarfoss waterfall (Golden Circle)</a></li>
<li><a href="https://www.google.co.uk/maps/place/Strokkur+Geysir/@64.3103306,-20.3044875,17z/data=!4m8!1m2!2m1!1sStrokkur+Geysir+!3m4!1s0x0:0x13fe408fd8ae0be3!8m2!3d64.3103869!4d-20.302316" target="_blank" title="Strokkur Geysir " rel="noopener noreferrer">Strokkur Geysir (Golden Circle)</a></li>
<li><a href="https://www.google.co.uk/maps/place/Gullfoss+Falls/@64.3266961,-20.1226018,17z/data=!3m1!4b1!4m5!3m4!1s0x48d6a574af45b6c9:0x2c6347db0b411601!8m2!3d64.3270716!4d-20.1199478" target="_blank" title="Gulfoss waterfall" rel="noopener noreferrer">Gulfoss waterfall (Golden Circle)</a></li>
<li><a href="https://www.google.co.uk/maps/place/Keri%C3%B0/@64.0412808,-20.8873353,17z/data=!3m1!4b1!4m5!3m4!1s0x48d68bb755f6f257:0x515a44e0c12ed907!8m2!3d64.0412785!4d-20.8851466" target="_blank" title="Kerid crater" rel="noopener noreferrer">Kerid crater</a></li>
<li><a href="https://www.google.co.uk/maps/place/Reykjadalur+Hot+Spring+Thermal/@64.0248527,-21.2153319,14z/data=!4m5!3m4!1s0x48d664020bede77f:0x7b0353e5e58233ac!8m2!3d64.0228673!4d-21.2116442" target="_blank" title="Reykjadalur hot springs" rel="noopener noreferrer">*Reykjadalur hot springs</a></li>
</ul>
<p><strong>Day 2 - Sunday 28th May</strong></p>
<p>We started off the day by getting absolutely saturated seeing Seljalandsfoss and Glj&uacute;frab&uacute;i waterfalls and then continued onto the Seljavallalaug thermal pool for a morning bath.&nbsp;</p>
<p>After the bath on the way to Fja&eth;r&aacute;rglj&uacute;fur Canyon we made stops at the US Navy Douglas Super DC-3 plane wreck, H&aacute;lsanefshellir Cave and the Vik church. All are worth checking out.</p>
<p>The next stop was Fja&eth;r&aacute;rglj&uacute;fur Canyon. It is absolutely amazing and surprisingly not many tourists go there! Do yourself a favour and make sure you check this out!</p>
<p>We continued onto Jukulsarlon Glacier Lagoon/Diamond that evening and arrived at approximately 23:00. It was perfect timing as at about 23.30 the sun started to go down and we got to witness a killer sunset with some amazing colours. See photos below.</p>
<p>Highlight:&nbsp;Fja&eth;r&aacute;rglj&uacute;fur Canyon</p>
<p>Dinner: At <a href="https://www.google.co.uk/maps/place/Fja%C3%B0r%C3%A1rglj%C3%BAfur/@64.8358438,-20.1805506,7z/data=!4m8!1m2!2m1!1siceland+canyon!3m4!1s0x0:0xa420ecc17165b5bd!8m2!3d63.77126!4d-18.1720734" target="_blank" title="Fja&eth;r&aacute;rglj&uacute;fur" rel="noopener noreferrer">Fja&eth;r&aacute;rglj&uacute;fur</a>. There are tables and chairs as well as free toilets.</p>
<p>Sleep: <a href="https://www.google.co.uk/maps/place/H%C3%B6fn,+Iceland/@64.2538322,-15.2222919,14z/data=!3m1!4b1!4m5!3m4!1s0x48cfac585a9c079f:0xb0ee81c829dbe0ed!8m2!3d64.2497026!4d-15.2020076?biw=1920&amp;bih=963&amp;q=hofn&amp;bav=on.2,or.r_cp.&amp;um=1&amp;ie=UTF-8&amp;sa=X&amp;ved=0ahUKEwjM0eOY_8fUAhXhLsAKHe_eA_QQ_AUIBigB" target="_blank" title="H&ouml;fn" rel="noopener noreferrer">H&ouml;fn</a>. We unknowingly slept in a school car park and in the morning did get a knock on the window from the headmaster.</p>
<p>Sights visited:</p>
<ul>
<li><a href="https://www.google.co.uk/maps/place/Seljalandsfoss/@63.6155983,-19.9906909,17z/data=!3m1!4b1!4m5!3m4!1s0x48d71eade8ef2415:0xae01e6205209178d!8m2!3d63.6156232!4d-19.9885688" target="_blank" title="Seljalandsfoss Waterfall" rel="noopener noreferrer">Seljalandsfoss Waterfall</a></li>
<li><a href="https://www.google.co.uk/maps/place/Glj%C3%BAfrab%C3%BAi/@63.6180094,-19.9924375,16z/data=!4m8!1m2!2m1!1sGlj%C3%BAfrab%C3%BAi+Waterfall!3m4!1s0x0:0x966a55b6ec145f2e!8m2!3d63.6208629!4d-19.9864496" target="_blank" title="Glj&uacute;frab&uacute;i Waterfall" rel="noopener noreferrer">*Glj&uacute;frab&uacute;i Waterfall</a></li>
<li><a href="https://www.google.co.uk/maps/place/Seljavallalaug/@63.5655995,-19.6097661,17z/data=!3m1!4b1!4m5!3m4!1s0x48d73ccb912bc3f3:0xde312fed7a2b4ac9!8m2!3d63.5655971!4d-19.6075774" target="_blank" title="Seljavallalaug Thermal Pool" rel="noopener noreferrer">*Seljavallalaug Thermal Pool</a></li>
<li><a href="https://www.google.co.uk/maps/place/Sk%C3%B3gafoss/@63.5320147,-19.513565,17z/data=!3m1!4b1!4m5!3m4!1s0x48d73b7639a58c15:0xf60c71fcdfe7948!8m2!3d63.5320523!4d-19.5113706" target="_blank" title="Skogafoss waterfall" rel="noopener noreferrer">Skogafoss waterfall</a></li>
<li><a href="https://www.google.co.uk/maps/place/Solheimasandur+Plane+Wreck/@63.4590942,-19.3669009,17z/data=!3m1!4b1!4m5!3m4!1s0x48d739ac2a2cca1d:0xde6566d286cc57f7!8m2!3d63.4590918!4d-19.3647122" target="_blank" title="Douglas Super DC-3 Plane Crash" rel="noopener noreferrer">Douglas Super DC-3 Plane Crash</a></li>
<li><a href="https://www.google.co.uk/maps/place/H%C3%A1lsanefshellir+Cave/@63.4032165,-19.0443271,17z/data=!3m1!4b1!4m5!3m4!1s0x48d74a2a636c8075:0x4177410f191fa085!8m2!3d63.4032141!4d-19.0421384" target="_blank" title="H&aacute;lsanefshellir Cave" rel="noopener noreferrer">H&aacute;lsanefshellir Cave</a></li>
<li><a href="https://www.google.co.uk/maps/place/Vik+i+Myrdal+Church/@63.419417,-19.010618,15z/data=!4m13!1m7!3m6!1s0x48d74a424936b0d1:0xbe83531b006d778d!2sVik,+Iceland!3b1!8m2!3d63.4186315!4d-19.0060479!3m4!1s0x0:0x46d27b299623a20d!8m2!3d63.4205506!4d-19.0030003" target="_blank" title="Vik" rel="noopener noreferrer">Vik</a></li>
<li><a href="https://www.google.co.uk/maps/place/Fja%C3%B0r%C3%A1rglj%C3%BAfur/@63.7712814,-18.1740046,17z/data=!3m1!4b1!4m5!3m4!1s0x48d0e5f0594291dd:0xa420ecc17165b5bd!8m2!3d63.771279!4d-18.1718159" target="_blank" title="Fja&eth;r&aacute;rglj&uacute;fur Canyon" rel="noopener noreferrer">*Fja&eth;r&aacute;rglj&uacute;fur Canyon</a></li>
<li><a href="https://www.google.co.uk/maps/place/J%C3%B6kuls%C3%A1rl%C3%B3n/@64.0762208,-16.2443017,13z/data=!3m1!4b1!4m5!3m4!1s0x48cfd6ecd73a3819:0xcd05c959e10146a9!8m2!3d64.0784458!4d-16.2305536" target="_blank" title="Jokulsarlon Glacier Lagoon" rel="noopener noreferrer">*Jokulsarlon Glacier Lagoon</a></li>
<li><a href="https://www.google.co.uk/maps/place/Diamond+Beach+(Ice+Beach)/@64.0436089,-16.1810711,18z/data=!4m8!1m2!2m1!1sDiamond+Beach!3m4!1s0x0:0x4202e865f907845a!8m2!3d64.044334!4d-16.1776619" target="_blank" title="Diamond Beach" rel="noopener noreferrer">Diamond Beach</a></li>
</ul>
<p><strong>Day 3 - Monday 29th May</strong></p>
<p>Day 3 involved quite alot of driving in order to make it back to Reykjavik in the evening.</p>
<p>After waking early and driving 4 hours we made it to Europes most powerful waterfall Dettifoss and then continued onto the Myvatn geothermal area where we got to see some cool things such as boiling mud pots, an underground thermal pool and a volcano!</p>
<p>On the way back to Reykjavik we stopped off at&nbsp;Go&eth;afoss waterfall and passed through Icelands second city Akureyi. When visiting or passing through Akureyi keep an eye out for the love heart traffic lights which were introduced after the 2008 financial crisis as a way to promote positive thinking.</p>
<p>Highlight: Grj&oacute;tagj&aacute; Cave</p>
<p>Dinner: Subway</p>
<p>Sleep:&nbsp;We arrived back at Reykjavik at approximately 1am and slept in the <a href="https://www.google.co.uk/maps/place/Kr%C3%B3nan/@64.0732594,-21.9643122,14z/data=!4m8!1m2!2m1!1zS3LDs25hbiwgSGFmbmFyZmrDtnLDsHVyLCBJY2VsYW5k!3m4!1s0x0:0x7b41bfaae8ae4219!8m2!3d64.076454!4d-21.9421113" target="_blank" title="Kr&oacute;nan" rel="noopener noreferrer">Kr&oacute;nan</a> supermarket car park near the Go Camper office.</p>
<p>Sights visted:</p>
<ul>
<li><a href="https://www.google.co.uk/maps/place/Dettifoss/@65.8146684,-16.3867647,17z/data=!4m13!1m7!3m6!1s0x48cd068ace5f4fb9:0x404278759828237a!2sDettifoss!3b1!8m2!3d65.8146662!4d-16.384576!3m4!1s0x0:0xaa3291c886436c90!8m2!3d65.8151401!4d-16.385635" target="_blank" title="Dettifoss Waterfall" rel="noopener noreferrer">Dettifoss Waterfall</a></li>
<li><a href="https://www.google.co.uk/maps/place/Hverir/@65.6409166,-16.8114998,17z/data=!3m1!4b1!4m5!3m4!1s0x48cd9f0ad5adea6d:0x100c72506334f2fc!8m2!3d65.6409144!4d-16.8093111" target="_blank" title="Hverir Mud Pots" rel="noopener noreferrer">Hverir Mud Pots</a></li>
<li><a href="https://www.google.co.uk/maps/place/Bjarnarflag/@65.6333355,-16.8688554,17z/data=!3m1!4b1!4m5!3m4!1s0x48cd9efed1f4c72d:0x26be25a0bfaa5421!8m2!3d65.6333333!4d-16.8666667" target="_blank" title="Bjarnarflag Geothermal Station" rel="noopener noreferrer">Bjarnarflag Geothermal Station</a></li>
<li><a href="https://www.google.co.uk/maps/place/Grj%C3%B3tagj%C3%A1+cave/@65.6271273,-16.8837551,17z/data=!3m1!4b1!4m5!3m4!1s0x48cd9ef0df2feebd:0x79e8f6d9c5fd9511!8m2!3d65.6271251!4d-16.8815664" target="_blank" title="Grj&oacute;tagj&aacute; Cave" rel="noopener noreferrer">*Grj&oacute;tagj&aacute; Cave</a></li>
<li><a href="https://www.google.co.uk/maps/place/Hverfjall/@65.6086133,-16.8738554,17z/data=!3m1!4b1!4m5!3m4!1s0x48cd9eb847e85775:0x6b64c041e028e321!8m2!3d65.6086111!4d-16.8716667" target="_blank" title="Hverfjall Volcano" rel="noopener noreferrer">Hverfjall Volcano</a></li>
<li><a href="https://www.google.co.uk/maps/place/Go%C3%B0afoss+Waterfall/@65.6828211,-17.5514223,18z/data=!3m1!4b1!4m5!3m4!1s0x48cd7e6a481f369f:0x7ebbcdaa4e0d1d3b!8m2!3d65.6827782!4d-17.5501919" target="_blank" title="Go&eth;afoss Waterfall" rel="noopener noreferrer">Go&eth;afoss Waterfall</a></li>
<li><a href="https://www.google.co.uk/maps/place/Akureyri,+Iceland/@65.6693289,-18.2054356,12z/data=!3m1!4b1!4m5!3m4!1s0x48d28f071cb0bfa7:0xbdb632798c71fdd1!8m2!3d65.6884921!4d-18.1261693" target="_blank" title="Akureyi" rel="noopener noreferrer">Akureyi</a></li>
</ul>
<p><strong>Day 4 - Tuesday 30th May</strong></p>
<p>We woke up at 8am which was probably the latest we had slept in the entire trip. After a quick tidy up we returned the camper camper at 9:30 with 1941.7km on the odometer and left our remaining food on the free food shelf. The staff at Go Camper definitely didn''t expect the camper to be ultra clean and were mainly concerned that all dishes had been washed.</p>
<p>Go Camper then gave us a ride back into Reykjavik where we spent the rest of our time at a coffee shop named <a href="https://www.google.co.uk/maps/place/Kaffit%C3%A1r/@64.1466407,-21.9362158,17z/data=!3m1!4b1!4m5!3m4!1s0x48d674cd55d20d25:0xe0541521ddc30c67!8m2!3d64.1466407!4d-21.9340271" target="_blank" title="Kaffit&aacute;r" rel="noopener noreferrer">Kaffit&aacute;r</a> reflecting on an amazing few days. It was also nice to have a proper coffee after drinking thermos and service station coffee for a few days :-)</p>
<p>At approximately 12:00 we made our way back to the BSI bus terminal and caught the FlyBus back to Keflavik for our return flight to London at 15:50. The food at the airport is quite expensive so recommend eating before you go there.</p>
<p><strong>Road Trip</strong><strong> breakdown</strong></p>
<p>km driven: 1941.7km</p>
<p>AirBnB Accomodation:&nbsp;&pound;50.00</p>
<p>Cash withdrawn:&nbsp;&pound;30.00&nbsp;</p>
<p>FlyBus Airport Transfer cost: 2 x &pound;35.00 =&nbsp;&pound;70.00</p>
<p>Food cost:&nbsp;&pound;70.00</p>
<p>Van cost including full insurance:&nbsp;&pound;320.00</p>
<p>Van extras cost:&nbsp;&pound;55.00</p>
<p>Fuel cost:&nbsp;&pound;155.00</p>
<p>Airport Food:&nbsp;&pound;10.00</p>
<p>Total trip cost for 2 people (excluding flights):&nbsp;&pound;760.00</p>
<p><strong>Roundup</strong></p>
<p>1941.7km driven, 25+ sights visited, spent&nbsp;&pound;760.00, completed an unforgettable road trip and obtained priceless memories.</p>
<p>Iceland is amazing and if you have the time/money I definitely recommend staying for longer than 3 days (In my opinion 4/5 days would be ideal in the summer) but if you''re short on either do your home work, get on the caffeine for a&nbsp;few days and check out this amazing place!&nbsp;</p>
<p>Sights we missed:</p>
<ul>
<li>Svartifoss waterfall</li>
</ul>
<p>To finish these are my tips:</p>
<ul>
<li>Hire a camper van. Expensive but worth it in the summer. Other camper van companies that I saw were <a href="http://www.goiceland.com" target="_blank" title="Go Iceland" rel="noopener noreferrer">Go Iceland</a>, <a href="https://happycampers.is" target="_blank" title="Happy Campers" rel="noopener noreferrer">Happy Campers</a> and <a href="http://www.kukucampers.is/" target="_blank" title="KuKu Campers" rel="noopener noreferrer">KuKu Campers</a>. I can''t say how these compare for price, quality or service.</li>
<li>If you hire with Go Camper make use of the free coffees at&nbsp;Ol&iacute;s.</li>
<li>Put the van heater on full blast before going to sleep.</li>
<li>Don''t stop in the middle of the road to take a photo. You will be surprised how many people you see doing this.</li>
<li>Avoid paying for toilets. Lots of sights charge approx&nbsp;&pound;2.00 but there are a few which are free. I mention them below.</li>
<li>Avoid paying for caravan parks.</li>
<li>Say hi to the horses.</li>
<li>Give the Blue Lagoon a miss and check out the <strong>free</strong> natural baths instead.</li>
<li>Do research before you go to make the best use of your time.</li>
<li>The food at the airport is quite expensive so recommend you eat before you go there.</li>
<li>Try an Iceland Hotdog.</li>
<li>Try the drink Malt Appelsin.</li>
<li>If you are interested in trying exotic foods such as H&aacute;karl (fermented shark) or puffin a centrally located Reykjaik restauarant which I visited on my previous trip is <a href="https://www.google.co.uk/maps/place/%C3%8Dslenski+barinn/@64.1469146,-21.935277,17z/data=!3m1!4b1!4m5!3m4!1s0x43812fcd8fbbeea9:0xb747b528932f1372!8m2!3d64.1469123!4d-21.933083" target="_blank" title="&Iacute;slenski barinn" rel="noopener noreferrer">&Iacute;slenski barinn</a>. This is a link to the <a href="http://islenskibarinn.is/net/en/menu-3/" target="_blank" title="menu" rel="noopener noreferrer">menu</a>.</li>
<li>The speed limit in iceland is 90km/h which in the summer does seem a little slow. I''m not suggesting intentionally going faster than 90km/h but from Jukulsarlson Lagoon around to Akureryi I didn''t spot one speed camera. A local did mention they are generally in the tunnels.</li>
</ul>', N'iceland-ring-road-on-a-budget-in-3-days', N'files/gallery/iceland/road-trip/Midnight sunset at Jokulsarlon Glacier Lagoon.JPG', NULL, 1, 1, CAST(N'2017-06-09T22:55:02.0833333' AS DateTime2), 1, 1, 1, 1, 400, 6, N'files/gallery/iceland/road-trip', 1)
GO
INSERT [dbo].[BlogPost] ([Id], [CreatedBy], [UpdatedOn], [UpdatedBy], [Title], [ShortDescription], [Description], [UrlSlug], [CarouselImage], [CarouselText], [ShowInCarousel], [Published], [CreatedOn], [AuthorId], [CategoryId], [ShowLocationDetail], [ShowLocationMap], [MapHeight], [MapZoom], [Album], [ShowPhotosInAlbum]) VALUES (2, N'admin', CAST(N'2017-09-04T15:41:32.5466667' AS DateTime2), N'admin', N'Saint Johns Day 2017', N'We always find an excuse to escape the hustle bustle of London and this time it was to celebrate Saint Johns Day in Lithuania!', N'<p>It''s no secret that Dovile and I find London a hectic place to live which is possibly why we always find excuses to escape! This time it was to celebrate&nbsp;Saint Johns Day in Lithuania, Dovile''s home country!</p>
<p>This was my third trip to Lithuania and each time I visit I grow fonder of the simple, relaxed and affordable life style they have. Lithuania is a former soviet country before becoming independant in 1991. In 2004 Lithuania joined the European Union and in 2015 gave up there national currency the Litas in favour of the Euro. For a relatively poor country (compared to other european countries) this has no doubt opened up lots of opportunities for the younger generation but Dovile tells me that supermarket prices have increased alot more than the wages. For instance a loaf that previously cost 2 litas now cost 2 euros (approx 7 litas), an increase of 250% yet wages have not increased at the same rate. Over time wages will increase but for the time being it has unfortunately meant low income earners are struggling. To put the struggle in context the average wage in Lithuania is approximately 600 euro.&nbsp;</p>
<p>The good news is that Lithuania is still a cheap place to visit which is one of the reasons I keep going back. I like to compare a countries affordability by it''s uber and beer price. In Lithuania you pay approximately 3.50 euro for an uber from the airport to the city centre and 1 euro for a beer in the supermarket. Bargain!&nbsp;</p>
<p>Being off the European tourist track not everyone speaks English fluently but alot of the younger generation do. All of the Lithuanians I have met are friendly and the country is safe.</p>
<p>Saint Johns Day falls on the 23rd of June each year and the locals tell me these day it''s pretty much an excuse to catch up with friends/family and throw a party. This year a group of 12 of us (a mix of Londoners and Locals) hired a lakeside villa for 180 euro and chipped in 15 euro each for accomodation and 10 euro each for food. The villa which slept 12 people had it''s own private jetty, wood fired BBQ, outdoor sound system, volleyball court, basketball hoop, full size football goals, sauna and a wood fired hob tub! I am told saunas are very common in Lithuania.</p>
<p>Check out the video we put together of the amazing time we had! If you would like to know details of the villa we rented get in contact with me and I will pass them on.</p>
<p>I would love to one day spend some time living in Lithuania to enjoy the hustle bustle free lifestyle and explore more countries in the region such as Latvia, Estonia, Belarus and Russia. Hopefully it won''t be too long before this becomes a reality. Now just need to find a remote job!</p>', N'saint-johns-day-2017', N'files/gallery/lithuania/Saint Johns Day 2017/Private jetty and lake.JPG', NULL, 0, 1, CAST(N'2017-06-26T07:33:24.6533333' AS DateTime2), 1, 1, 0, 1, 400, 9, N'files/gallery/lithuania/Saint Johns Day 2017', 1)
GO
INSERT [dbo].[BlogPost] ([Id], [CreatedBy], [UpdatedOn], [UpdatedBy], [Title], [ShortDescription], [Description], [UrlSlug], [CarouselImage], [CarouselText], [ShowInCarousel], [Published], [CreatedOn], [AuthorId], [CategoryId], [ShowLocationDetail], [ShowLocationMap], [MapHeight], [MapZoom], [Album], [ShowPhotosInAlbum]) VALUES (3, N'admin', CAST(N'2017-09-17T15:00:42.5166667' AS DateTime2), N'admin', N'12 days in Cuba', N'Cuba you were absolutely amazing and so unique!', N'<p>Like many other keen travellers Cuba has always been high on our bucket lists. Although high, it was one of those exotic locations that we thought we may never get a chance to visit.</p>
<p>In late 2016 we started planning a trip to backpack down through Central America including&nbsp;Mexico<em>.</em> After doing research we discovered a flight from Europe to Mexico City with a stopover in Cuba was of similar cost to a direct flight so decided it was a perfect opportunity to check it out.</p>
<p>As with most new countries we visit our research began with googling the country and reading blog posts. It didn''t take long to realise that the information within these posts would become super important as Internet is hard to come by in Cuba.</p>
<p>Some blog posts we found useful were:</p>
<p><a href="http://mylifesamovie.com/25-awesome-things-to-do-in-havana-cuba/">25 Awesome things to do in Havana, Cuba </a><br /><a href="http://www.culturalxplorer.com/what-to-do-havana-cuba/">11 Things To Do During Your Trip to Havana, Cuba</a><br /><a href="http://diytravelhq.com/diving-in-the-bay-of-pigs/">Budget Diving in the Bay of Pigs: Things to Know</a><br /><a href="https://www.twoscotsabroad.com/before-you-die-diving-in-the-bay-of-pigs/">Cheapest Scuba Diving in Cuba Review</a><br /><a href="http://diytravelhq.com/playa-larga-on-a-budget/">Playa Larga on a Budget: Planning Your Visit</a><br /> <br />In addition to saving the above websites for offline viewing we found having a copy of Cuba Lonely Planet really useful.</p>
<p>The sections below give an overview of our 12 day trip with a focus on budget travel and documenting useful information that we think could help others.</p>
<p><strong>Mobile Apps</strong></p>
<p>Two apps that we recommend downloading before heading to Cuba are: <br /><a href="https://play.google.com/store/apps/details?id=com.google.android.apps.translate&amp;hl=en">Google Translate<br /></a><a href="https://play.google.com/store/apps/details?id=org.mapapps.mapyourtown.cuba&amp;hl=en">Map of Cuba offline</a></p>
<p>Locals speak very little English so if your Spanish is rusty like ours it will save you. The app is great as it works without an internet connection and also pronounces translated words which we found useful for learning useful phrases such as "dos de cerveza por favor".</p>
<p>Before we visited Cuba we marked everything on Google Maps knowing that even without internet we could still find our way around with GPS. For some reason once we arrived in Cuba both of our markings disappeared. Luckily we had downloaded Map of Cuba offline. It was useful for finding Lonely Planet street addresses, tourist attractions and other places of interest such as currency exchanges (Cadeca) and banks.</p>
<p><strong>Itinerary</strong></p>
<p>Havana Airport to City &ndash; 30 minutes &ndash; 30 CUC total <br />Havana - Casa Mariela - 3 full days - 17 CUC per night x 4 (Airbnb)<br />Havana to Vinales Collectivo - 5 hours - 30 CUC per person<br />Vinales - Casa Lliana y Albe - 1.5 days - 12.50 CUC per night x 2 (Airbnb)<br />Vinales to Playa Larga Collectivo - 7 hours - 35 CUC per person<br />Playa Larga - Casa El Ruso - 1.5 days - 16.50 CUC (Airbnb) + 20 CUC extra night<br />Playa Larga to Trinidad - 3 hours - 15 CUC per person<br />Trinidad - Casa ??? - 2.5 days - 20 CUC per night x 3<br />Trinidad to Havana - 5 hours - 25 CUC per person<br />Havana - 1.5 days - 15 CUC per night x 1<br />City to Havana Airport &ndash; 30 minutes &ndash; 20 CUC total</p>
<p><strong>Budget for 2 people</strong></p>
<p>Visa = 2 x &pound;23 = &pound;46 =&nbsp;&euro;53<br />Flights = 2 x &euro;285 =&nbsp;&euro;570</p>
<p>Collectivo Transport = 260 CUC<br />Accomodation = 204.50 CUC (99.50 CUC pre booked through Airbnb, 105 CUC spent while in Cuba)<br />Spending Money for 12 days = 605 CUC</p>
<p>Total spent in Cuba for 12 days = 1069.50 CUC =&nbsp;&euro;900</p>
<p>Total spent in Cuba for 12 days + flights + visas =&nbsp;&euro;53 + &euro;570 + &euro;900 = &euro;1523</p>
<p><strong>Visa</strong><br />We both (Lithuanian and Australian) required a 30 day visa to visit Cuba. We paid &pound;23 each through the website <a href="http://www.cubavisas.com" rel="noopener noreferrer" title="http://www.cubavisas.com " target="_blank">http://www.cubavisas.com </a>and they were posted to our home address in the UK. The visa took about 5 days to arrive in the UK but you can pay extra to get it delivered express.</p>
<p><strong>Arriving in Cuba</strong><br />We took a 16 hour bus from Ljubjana, Slovenia to Cologne, Germany and then flew with Eurowings direct to Havana, Cuba. The flight took approximately 11 hours.</p>
<p>Once arriving in Havana we paid 30 CUC for a taxi into the city.</p>
<p><strong>Money</strong></p>
<p>1 Convertible Peso CUC = 1 USD<br />1 Convertible Peso CUC = 25 Local Cuban Peso CUP<br />0.05 Convertible Peso CUC ~= 1 Local Cuban Peso CUP</p>
<p>Do not bring American dollars as they charge a 20% fee at the exchanges!</p>
<p>At the airport we exchanged 600 euros into 670 convertible pesos. A Passport was required. The airport didn''t have any local Cuban pesos so instead we had to wait till the next day to find a currency exchange (Cadeca).</p>
<p>For an idea of how much to convert into local pesos, we converted 40 CUC which lasted us for 12 days. No passport was required when converting CUC into CUP.</p>
<p>While in Cuba we withdrew an extra 300 CUC using our UK debit cards at a cash machine near the Sevilla Hotel in Havana. My Australian bank card didn''t work.</p>
<p>There are banks in Cuba but the waiting times we witnessed were very long so wouldn''t recommend relying on a Travel or Debit card. Bring cash.</p>
<p>Before we visited Cuba we were expecting it to be really confusing which currency an item was being advertised in but it didn''t take long to work it out. The street stalls generally advertised in local pesos but also accepted convertibles and fractions of convertibles. Cafes/bars/restaurants/casas/collectivos always advertised in convertibles.</p>
<p>We found that things were slightly more expensive than blog posts suggested which maybe an indication that Cuba is getting more expensive or we need to work on our haggling skills!</p>
<p><strong>Street Food</strong></p>
<p>Cuban streets pretty much consists of pizzas and toasted sandwiches and the going rate seemed to be 15/20 local pesos.</p>
<p>Sometimes a stall would advertise a pizza/toasted sandwich for 1 CUC but most often if we offered 15/20 local pesos they would accept.</p>
<p>Also often no prices were displayed on street food and when enquiring we would get the standard response of 1 CUC. We often observed how much a local was handing over to get an idea of the real price.</p>
<p><strong>Crime/Safety</strong></p>
<p>Crime is pretty much non existent in Cuba. We felt extremely safe the entire time. Even walking around at night with mobile phones and DSLR camera out.</p>
<p>The scariest part of Cuba for us was the rainy 130 + km/h collectivo ride from Vinales to Playa Larga with 15 of us in the back. The roads have lots of pot holes and it doesn''t help that the cars aren''t in great condition either. Also all our backpacks were tied on the roof and there was no cover so our backpacks and everything inside got soaking wet.</p>
<p>I didn''t see any car crashes but did see alot of broken down cars on the side of the road and witnessed it first hand. On the way back from snorkelling at Bay of Pigs our bus broke down. We flagged down another bus which let us on for free. Cubans are friendly people and even if your collectivo were to break down on a longer haul I''m confident it wouldn''t be too hard to flag down another and continue the journey.</p>
<p><strong>Water</strong></p>
<p>We always drank bottled water but apparently the tap water in Cuba isn''t as bad as other Central/South American countries.</p>
<p>One thing that we noticed was that hardly any peso stores had the price of water. When enquiring the standard response was 1.50 or 2 CUC which was the same price being charged in restaurants. We tried haggling the price down but couldn''t get anyone to budge.</p>
<p>At the Havana local bus station we managed to get it for 0.80 CUC which I think is closer to the local price.</p>
<p><strong>Beers/Alcohol</strong></p>
<p>The going rate seemed to be 1/1.5 CUC for a local beer, 2/3 CUC for a Mojito and 4/5 CUC for a bottle of rum.</p>
<p>The best Mojitos we had were at Hotel Sevilla and Maximo Bar in Havana. They both cost 5 CUC but were large and quality. Hotel Sevilla had really nice views over the city.</p>
<p>Our favourite local bar in Havana was Bar Lucero.</p>
<p>You see alot of locals drinking straight Silver Dry rum from cardboard boxes especially along the Malecon in Havana. It costs about 1 CUC for 200mL. I initially thought it was a cheap pre-mix but turned out to be 200mL of 36% local rum. Try if you dare!</p>
<p><strong>Local Restaurants</strong></p>
<p>We often found restaurants offering meat with salad, rice and black beans for 4/5 CUC.</p>
<p><strong>Accomodation</strong></p>
<p>Home stays in Casa Particulars are the most common accomodation in Cuba. No matter where you stay generally it will include the following:<br />A private room<br />A private bathroom<br />2 single or double beds<br />Air conditioning<br />Fan<br />Breakfast offered for 4/5 CUC</p>
<p>We prebooked 7 of our 13 nights through Airbnb before we arrived. It''s super easy to find accomodation once you arrive in each city but we found on average we were paying around 15/20 CUC through Airbnb but in person they were wanting 25 + CUC. For our last two nights in Havana we did manage to haggle a room down to 15 CUC.</p>
<p>We tried booking Airbnb accomodation while in Cuba but received an error message saying you aren''t allowed to.</p>
<p><strong>Transport</strong></p>
<p>We used collectivos taxis the entire time as they offered door to door service and were the same price as buses.</p>
<p>For arranging collectivos we always found if we booked ourselves we would get 5 CUC cheaper than what a Casa owner quoted as they got a commission.</p>
<p>In Havana we arranged transport through Hotel Lido and in the other cities we found locals offering cheap deals. Sometimes we had to pay a deposit to secure a seat.</p>
<p>The Locals always fulfilled there promise of picking us up from our accomodation at a certain time and then dropped us at the door of our next city accomodation.</p>
<p><strong>Departing Cuba</strong></p>
<p>We managed to get a taxi to the airport for 20 CUC and flew direct to Mexico City, Mexico with Interjet. The airport didn''t have many food/drink options but thankfully the prices weren''t overly inflated like many other airports. We paid 2 CUC for a sandwich and 1 CUC for a coffee.</p>', N'12-days-in-cuba', N'files/gallery/cuba/vinales/Mojitos in Vinales_main.JPG', NULL, 1, 1, CAST(N'2017-09-06T00:49:44.6266667' AS DateTime2), 1, 1, 1, 1, 300, 6, N'files/gallery/cuba/blog-post', 0)
GO
INSERT [dbo].[BlogPost] ([Id], [CreatedBy], [UpdatedOn], [UpdatedBy], [Title], [ShortDescription], [Description], [UrlSlug], [CarouselImage], [CarouselText], [ShowInCarousel], [Published], [CreatedOn], [AuthorId], [CategoryId], [ShowLocationDetail], [ShowLocationMap], [MapHeight], [MapZoom], [Album], [ShowPhotosInAlbum]) VALUES (4, N'admin', CAST(N'2017-11-03T16:03:54.5833333' AS DateTime2), N'admin', N'12 days in Cuba Part 2', N'Part 2 of our time in Cuba', N'<p>Part 2 of our time in Cuba</p>', N'12-days-in-cuba-part-2', NULL, NULL, 0, 1, CAST(N'2017-11-03T15:55:35.1533333' AS DateTime2), 1, 1, 0, 1, 300, 6, N'files/gallery/cuba/blog-post-2', 0)
GO
INSERT [dbo].[BlogPost] ([Id], [CreatedBy], [UpdatedOn], [UpdatedBy], [Title], [ShortDescription], [Description], [UrlSlug], [CarouselImage], [CarouselText], [ShowInCarousel], [Published], [CreatedOn], [AuthorId], [CategoryId], [ShowLocationDetail], [ShowLocationMap], [MapHeight], [MapZoom], [Album], [ShowPhotosInAlbum]) VALUES (5, N'admin', CAST(N'2017-11-04T03:51:04.5133333' AS DateTime2), N'admin', N'Mexico 2017', N'Backpacking from Mexico City to Tulum', N'<p>Backpacking from Mexico City to Tulum</p>', N'mexico-2017', NULL, NULL, 0, 1, CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), 1, 1, 1, 1, 300, 5, N'files/gallery/mexico/blog-post', 0)
GO
INSERT [dbo].[BlogPost] ([Id], [CreatedBy], [UpdatedOn], [UpdatedBy], [Title], [ShortDescription], [Description], [UrlSlug], [CarouselImage], [CarouselText], [ShowInCarousel], [Published], [CreatedOn], [AuthorId], [CategoryId], [ShowLocationDetail], [ShowLocationMap], [MapHeight], [MapZoom], [Album], [ShowPhotosInAlbum]) VALUES (6, N'admin', CAST(N'2017-11-10T02:41:13.0266667' AS DateTime2), N'admin', N'Guatemala', N'The people are poor but life is rich', N'<p>The people are poor but life is rich</p>', N'guatemala', NULL, NULL, 0, 1, CAST(N'2017-11-08T03:45:16.4833333' AS DateTime2), 1, 1, 1, 1, 300, 7, N'files/gallery/guatemala/blog-post', 0)
GO
INSERT [dbo].[BlogPost] ([Id], [CreatedBy], [UpdatedOn], [UpdatedBy], [Title], [ShortDescription], [Description], [UrlSlug], [CarouselImage], [CarouselText], [ShowInCarousel], [Published], [CreatedOn], [AuthorId], [CategoryId], [ShowLocationDetail], [ShowLocationMap], [MapHeight], [MapZoom], [Album], [ShowPhotosInAlbum]) VALUES (7, N'admin', CAST(N'2017-11-10T03:21:36.1900000' AS DateTime2), N'admin', N'Europe 2017', N'Europe 2017 featuring Romania, Serbia, Bosnia, Croatia, Sziget and Slovenia', N'<p>Europe 2017 featuring Romania, Serbia, Bosnia, Croatia, Sziget and Slovenia</p>', N'europe-2017', NULL, NULL, 0, 1, CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), 1, 1, 0, 1, 300, 4, N'files/gallery/hungary/budapest/sziget', 0)
GO
INSERT [dbo].[BlogPost] ([Id], [CreatedBy], [UpdatedOn], [UpdatedBy], [Title], [ShortDescription], [Description], [UrlSlug], [CarouselImage], [CarouselText], [ShowInCarousel], [Published], [CreatedOn], [AuthorId], [CategoryId], [ShowLocationDetail], [ShowLocationMap], [MapHeight], [MapZoom], [Album], [ShowPhotosInAlbum]) VALUES (8, N'admin', CAST(N'2017-12-13T01:13:36.8800000' AS DateTime2), N'admin', N'Promotional photo shoot', N'Promotional photo shoot in Granada, Nicaragua in return for accommodation and food', N'<p>Promotional photo shoot in Granada, Nicaragua in return for accommodation and food</p>', N'promotional-photo-shoot', NULL, NULL, 0, 1, CAST(N'2017-11-14T01:31:30.5800000' AS DateTime2), 1, 2, 0, 1, 300, 7, N'files/gallery/el-arca-de-noe', 1)
GO
INSERT [dbo].[BlogPost] ([Id], [CreatedBy], [UpdatedOn], [UpdatedBy], [Title], [ShortDescription], [Description], [UrlSlug], [CarouselImage], [CarouselText], [ShowInCarousel], [Published], [CreatedOn], [AuthorId], [CategoryId], [ShowLocationDetail], [ShowLocationMap], [MapHeight], [MapZoom], [Album], [ShowPhotosInAlbum]) VALUES (9, N'admin', CAST(N'2017-12-08T21:11:08.9333333' AS DateTime2), N'admin', N'Nicaragua', N'From Volcano boarding in Leon to riding a scooter on the island of Ometepe!', N'<p>From Volcano boarding in Leon to riding a scooter on the island of Ometepe!</p>', N'nicaragua', NULL, NULL, 0, 1, CAST(N'2017-12-08T16:17:21.0700000' AS DateTime2), 1, 1, 0, 1, 300, 7, N'files/gallery/nicaragua/post', 0)
GO
INSERT [dbo].[BlogPost] ([Id], [CreatedBy], [UpdatedOn], [UpdatedBy], [Title], [ShortDescription], [Description], [UrlSlug], [CarouselImage], [CarouselText], [ShowInCarousel], [Published], [CreatedOn], [AuthorId], [CategoryId], [ShowLocationDetail], [ShowLocationMap], [MapHeight], [MapZoom], [Album], [ShowPhotosInAlbum]) VALUES (10, N'admin', CAST(N'2017-12-13T00:27:56.0333333' AS DateTime2), N'admin', N'Bastimentos, Panama', N'Our first two weeks on the Caribbean island of Bastimentos!', N'<p>Our first two weeks on the Caribbean island of Bastimentos!</p>', N'bastimentos-panama', NULL, NULL, 0, 1, CAST(N'2017-12-13T00:27:56.0333333' AS DateTime2), 1, 1, 0, 1, 300, 7, N'files/gallery/panama/bastimentos/post', 0)
GO
INSERT [dbo].[BlogPost] ([Id], [CreatedBy], [UpdatedOn], [UpdatedBy], [Title], [ShortDescription], [Description], [UrlSlug], [CarouselImage], [CarouselText], [ShowInCarousel], [Published], [CreatedOn], [AuthorId], [CategoryId], [ShowLocationDetail], [ShowLocationMap], [MapHeight], [MapZoom], [Album], [ShowPhotosInAlbum]) VALUES (11, N'admin', CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', N'Costa Rica', N'Costa Rica Roadtrip', N'<p>Costa Rica Roadtrip</p>', N'costa-rica', NULL, NULL, 0, 1, CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), 1, 1, 0, 1, 300, 7, N'files/gallery/costa-rica/post', 0)
GO
INSERT [dbo].[BlogPost] ([Id], [CreatedBy], [UpdatedOn], [UpdatedBy], [Title], [ShortDescription], [Description], [UrlSlug], [CarouselImage], [CarouselText], [ShowInCarousel], [Published], [CreatedOn], [AuthorId], [CategoryId], [ShowLocationDetail], [ShowLocationMap], [MapHeight], [MapZoom], [Album], [ShowPhotosInAlbum]) VALUES (12, N'admin', CAST(N'2018-02-07T12:57:26.3133333' AS DateTime2), N'Anonymous', N'Eclypse de Mar', N'Eclypse de Mar promotional video', N'<p>Eclypse de Mar promotional video</p>', N'eclypse-de-mar', NULL, NULL, 0, 1, CAST(N'2018-02-02T22:02:57.7033333' AS DateTime2), 1, 1, 1, 0, 300, 7, N'files/gallery/panama/bastimentos/eclypse-de-mar', 0)
GO
INSERT [dbo].[BlogPost] ([Id], [CreatedBy], [UpdatedOn], [UpdatedBy], [Title], [ShortDescription], [Description], [UrlSlug], [CarouselImage], [CarouselText], [ShowInCarousel], [Published], [CreatedOn], [AuthorId], [CategoryId], [ShowLocationDetail], [ShowLocationMap], [MapHeight], [MapZoom], [Album], [ShowPhotosInAlbum]) VALUES (13, N'admin', CAST(N'2018-02-07T12:57:18.5400000' AS DateTime2), N'Anonymous', N'San Blas Adventures', N'San Blas Adventures promotional video', N'<p>San Blas Adventures promotional video</p>', N'san-blas-adventures', NULL, NULL, 0, 1, CAST(N'2018-02-02T22:03:36.4566667' AS DateTime2), 1, 1, 0, 1, 300, 7, N'files/gallery/panama/san-blas', 0)
GO
INSERT [dbo].[BlogPost] ([Id], [CreatedBy], [UpdatedOn], [UpdatedBy], [Title], [ShortDescription], [Description], [UrlSlug], [CarouselImage], [CarouselText], [ShowInCarousel], [Published], [CreatedOn], [AuthorId], [CategoryId], [ShowLocationDetail], [ShowLocationMap], [MapHeight], [MapZoom], [Album], [ShowPhotosInAlbum]) VALUES (14, N'Anonymous', CAST(N'2018-03-01T13:46:23.4533333' AS DateTime2), N'Anonymous', N'Happy Buddha Guatape', N'Happy Buddha Guatape promotional video', N'<p>Happy Buddha Guatape promotional video</p>', N'happy-buddha-guatape', NULL, NULL, 0, 1, CAST(N'2018-03-01T13:46:23.4533333' AS DateTime2), 1, 1, 0, 1, 300, 7, N'files/gallery/colombia/happy-buddha-guatape', 0)
GO
INSERT [dbo].[BlogPost] ([Id], [CreatedBy], [UpdatedOn], [UpdatedBy], [Title], [ShortDescription], [Description], [UrlSlug], [CarouselImage], [CarouselText], [ShowInCarousel], [Published], [CreatedOn], [AuthorId], [CategoryId], [ShowLocationDetail], [ShowLocationMap], [MapHeight], [MapZoom], [Album], [ShowPhotosInAlbum]) VALUES (15, N'Anonymous', CAST(N'2018-04-25T11:17:45.0833333' AS DateTime2), N'Anonymous', N'Tasmania', N'One minute video from our amazing time in Tasmania!', N'<p>One minute video from our amazing time in Tasmania!</p>', N'tasmania', NULL, NULL, 0, 1, CAST(N'2018-04-25T11:17:45.0833333' AS DateTime2), 1, 1, 0, 1, 300, 7, N'files/gallery/australia/tasmania', 0)
GO
INSERT [dbo].[BlogPost] ([Id], [CreatedBy], [UpdatedOn], [UpdatedBy], [Title], [ShortDescription], [Description], [UrlSlug], [CarouselImage], [CarouselText], [ShowInCarousel], [Published], [CreatedOn], [AuthorId], [CategoryId], [ShowLocationDetail], [ShowLocationMap], [MapHeight], [MapZoom], [Album], [ShowPhotosInAlbum]) VALUES (16, N'admin', CAST(N'2018-10-03T20:35:59.0209086' AS DateTime2), N'admin', N'Colombia 2017', N'Our first time in South America!', N'<p>Our first time in South America!</p>', N'colombia-2017', NULL, NULL, 0, 1, CAST(N'2018-10-03T20:35:08.5328481' AS DateTime2), 1, 1, 1, 1, 300, 7, N'files/gallery/colombia/post', 0)
GO
INSERT [dbo].[BlogPost] ([Id], [CreatedBy], [UpdatedOn], [UpdatedBy], [Title], [ShortDescription], [Description], [UrlSlug], [CarouselImage], [CarouselText], [ShowInCarousel], [Published], [CreatedOn], [AuthorId], [CategoryId], [ShowLocationDetail], [ShowLocationMap], [MapHeight], [MapZoom], [Album], [ShowPhotosInAlbum]) VALUES (17, N'59f6b452-2a98-4aa0-aa03-475a1c9790ab', CAST(N'2020-04-15T10:12:10.4211188' AS DateTime2), N'59f6b452-2a98-4aa0-aa03-475a1c9790ab', N'Galapagos Islands on a Budget', N'2 weeks on the Galapagos Islands!', N'<p>Coming soon...</p>', N'galapagos-islands-on-a-budget', N'files/gallery/ecuador/galapagos/Santa Cruz/Santa Cruz 9.jpg', N'2 weeks on the Galapagos Islands!', 1, 1, CAST(N'2020-04-15T07:21:35.7960265' AS DateTime2), 1, 1, 1, 1, 300, 7, N'files/gallery/ecuador', 0)
GO
SET IDENTITY_INSERT [dbo].[BlogPost] OFF
GO
SET IDENTITY_INSERT [dbo].[BlogPostLocation] ON 
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (2, 1, CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', 70)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (3, 1, CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', 69)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (4, 1, CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', 68)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (5, 1, CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', 67)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (6, 1, CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', 66)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (7, 1, CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', 65)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (8, 1, CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', 64)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (9, 1, CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', 63)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (10, 1, CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', 62)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (11, 1, CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', 61)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (12, 1, CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', 60)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (13, 1, CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', 59)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (14, 1, CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', 58)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (15, 1, CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', 57)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (16, 1, CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', 56)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (17, 1, CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', 55)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (18, 1, CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', 54)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (19, 1, CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', 53)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (20, 1, CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', 52)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (21, 1, CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', 51)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (22, 1, CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', 50)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (23, 1, CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', 49)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (24, 1, CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', CAST(N'2017-06-16T22:03:48.1900000' AS DateTime2), N'admin', 48)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (25, 1, CAST(N'2017-06-16T23:36:25.6466667' AS DateTime2), N'admin', CAST(N'2017-06-16T23:36:25.6466667' AS DateTime2), N'admin', 72)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (26, 1, CAST(N'2017-06-16T23:36:25.6466667' AS DateTime2), N'admin', CAST(N'2017-06-16T23:36:25.6466667' AS DateTime2), N'admin', 71)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (27, 1, CAST(N'2017-06-18T19:01:15.0600000' AS DateTime2), N'admin', CAST(N'2017-06-18T19:01:15.0600000' AS DateTime2), N'admin', 73)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (29, 2, CAST(N'2017-06-26T21:34:52.1466667' AS DateTime2), N'admin', CAST(N'2017-06-26T21:34:52.1466667' AS DateTime2), N'admin', 74)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (30, 3, CAST(N'2017-09-06T00:49:44.6266667' AS DateTime2), N'admin', CAST(N'2017-09-06T00:49:44.6266667' AS DateTime2), N'admin', 86)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (31, 3, CAST(N'2017-09-06T00:49:44.6266667' AS DateTime2), N'admin', CAST(N'2017-09-06T00:49:44.6266667' AS DateTime2), N'admin', 85)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (32, 3, CAST(N'2017-09-06T00:49:44.6266667' AS DateTime2), N'admin', CAST(N'2017-09-06T00:49:44.6266667' AS DateTime2), N'admin', 84)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (33, 3, CAST(N'2017-09-06T00:49:44.6266667' AS DateTime2), N'admin', CAST(N'2017-09-06T00:49:44.6266667' AS DateTime2), N'admin', 83)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (34, 3, CAST(N'2017-09-06T00:49:44.6266667' AS DateTime2), N'admin', CAST(N'2017-09-06T00:49:44.6266667' AS DateTime2), N'admin', 82)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (35, 4, CAST(N'2017-11-03T15:55:35.1533333' AS DateTime2), N'admin', CAST(N'2017-11-03T15:55:35.1533333' AS DateTime2), N'admin', 86)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (36, 4, CAST(N'2017-11-03T15:55:35.1533333' AS DateTime2), N'admin', CAST(N'2017-11-03T15:55:35.1533333' AS DateTime2), N'admin', 85)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (37, 4, CAST(N'2017-11-03T15:55:35.1533333' AS DateTime2), N'admin', CAST(N'2017-11-03T15:55:35.1533333' AS DateTime2), N'admin', 84)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (38, 4, CAST(N'2017-11-03T15:55:35.1533333' AS DateTime2), N'admin', CAST(N'2017-11-03T15:55:35.1533333' AS DateTime2), N'admin', 83)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (39, 4, CAST(N'2017-11-03T15:55:35.1533333' AS DateTime2), N'admin', CAST(N'2017-11-03T15:55:35.1533333' AS DateTime2), N'admin', 82)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (40, 5, CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), N'admin', CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), N'admin', 101)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (41, 5, CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), N'admin', CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), N'admin', 100)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (42, 5, CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), N'admin', CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), N'admin', 99)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (45, 5, CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), N'admin', CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), N'admin', 96)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (46, 5, CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), N'admin', CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), N'admin', 95)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (47, 5, CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), N'admin', CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), N'admin', 94)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (48, 5, CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), N'admin', CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), N'admin', 93)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (49, 5, CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), N'admin', CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), N'admin', 92)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (50, 5, CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), N'admin', CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), N'admin', 91)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (51, 5, CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), N'admin', CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), N'admin', 90)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (52, 5, CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), N'admin', CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), N'admin', 89)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (54, 6, CAST(N'2017-11-09T17:02:17.5533333' AS DateTime2), N'admin', CAST(N'2017-11-09T17:02:17.5533333' AS DateTime2), N'admin', 106)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (55, 6, CAST(N'2017-11-09T17:02:17.5533333' AS DateTime2), N'admin', CAST(N'2017-11-09T17:02:17.5533333' AS DateTime2), N'admin', 105)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (56, 6, CAST(N'2017-11-09T17:02:17.5533333' AS DateTime2), N'admin', CAST(N'2017-11-09T17:02:17.5533333' AS DateTime2), N'admin', 104)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (57, 6, CAST(N'2017-11-09T17:02:17.5533333' AS DateTime2), N'admin', CAST(N'2017-11-09T17:02:17.5533333' AS DateTime2), N'admin', 103)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (58, 7, CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), N'admin', CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), N'admin', 78)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (59, 7, CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), N'admin', CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), N'admin', 77)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (60, 7, CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), N'admin', CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), N'admin', 45)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (61, 7, CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), N'admin', CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), N'admin', 15)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (62, 7, CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), N'admin', CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), N'admin', 14)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (63, 7, CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), N'admin', CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), N'admin', 13)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (64, 8, CAST(N'2017-11-14T01:31:30.5800000' AS DateTime2), N'admin', CAST(N'2017-11-14T01:31:30.5800000' AS DateTime2), N'admin', 107)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (65, 9, CAST(N'2017-12-08T16:17:21.0700000' AS DateTime2), N'admin', CAST(N'2017-12-08T16:17:21.0700000' AS DateTime2), N'admin', 109)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (66, 9, CAST(N'2017-12-08T16:17:21.0700000' AS DateTime2), N'admin', CAST(N'2017-12-08T16:17:21.0700000' AS DateTime2), N'admin', 108)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (67, 9, CAST(N'2017-12-08T16:17:21.0700000' AS DateTime2), N'admin', CAST(N'2017-12-08T16:17:21.0700000' AS DateTime2), N'admin', 107)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (68, 10, CAST(N'2017-12-13T00:27:56.0333333' AS DateTime2), N'admin', CAST(N'2017-12-13T00:27:56.0333333' AS DateTime2), N'admin', 112)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (69, 11, CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', 124)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (70, 11, CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', 123)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (71, 11, CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', 122)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (72, 11, CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', 121)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (73, 11, CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', 120)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (74, 11, CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', 119)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (75, 11, CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', 118)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (76, 11, CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', 117)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (77, 11, CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', 116)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (78, 11, CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', 115)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (79, 11, CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', 114)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (80, 11, CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', 113)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (81, 12, CAST(N'2018-02-02T22:02:57.7033333' AS DateTime2), N'admin', CAST(N'2018-02-02T22:02:57.7033333' AS DateTime2), N'admin', 112)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (82, 13, CAST(N'2018-02-02T22:03:36.4566667' AS DateTime2), N'admin', CAST(N'2018-02-02T22:03:36.4566667' AS DateTime2), N'admin', 125)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (83, 14, CAST(N'2018-03-01T13:46:23.4533333' AS DateTime2), N'Anonymous', CAST(N'2018-03-01T13:46:23.4533333' AS DateTime2), N'Anonymous', 126)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (84, 15, CAST(N'2018-04-25T11:17:45.0833333' AS DateTime2), N'Anonymous', CAST(N'2018-04-25T11:17:45.0833333' AS DateTime2), N'Anonymous', 127)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (86, 17, CAST(N'2020-04-15T07:39:48.7532555' AS DateTime2), NULL, CAST(N'2020-04-15T07:42:53.1589217' AS DateTime2), NULL, 131)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (87, 17, CAST(N'2020-04-15T07:39:48.7532604' AS DateTime2), NULL, CAST(N'2020-04-15T07:42:53.1589329' AS DateTime2), NULL, 132)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (88, 17, CAST(N'2020-04-15T07:39:48.7532644' AS DateTime2), NULL, CAST(N'2020-04-15T07:42:53.1589374' AS DateTime2), NULL, 133)
GO
INSERT [dbo].[BlogPostLocation] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LocationId]) VALUES (89, 17, CAST(N'2020-04-15T07:39:48.7532685' AS DateTime2), NULL, CAST(N'2020-04-15T07:42:53.1589417' AS DateTime2), NULL, 134)
GO
SET IDENTITY_INSERT [dbo].[BlogPostLocation] OFF
GO
SET IDENTITY_INSERT [dbo].[Tag] ON 
GO
INSERT [dbo].[Tag] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [UrlSlug], [Description]) VALUES (1, CAST(N'2017-06-09T22:15:13.1933333' AS DateTime2), N'admin', CAST(N'2017-06-09T22:15:13.1933333' AS DateTime2), N'admin', N'Iceland', N'iceland', N'Iceland')
GO
INSERT [dbo].[Tag] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [UrlSlug], [Description]) VALUES (2, CAST(N'2017-06-26T13:57:27.2233333' AS DateTime2), N'admin', CAST(N'2017-06-26T13:57:27.2233333' AS DateTime2), N'admin', N'Saint Johns Day', N'saint-johns-day', N'Saint Johns Day')
GO
INSERT [dbo].[Tag] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [UrlSlug], [Description]) VALUES (3, CAST(N'2017-09-06T00:46:36.8366667' AS DateTime2), N'admin', CAST(N'2017-09-06T00:46:36.8366667' AS DateTime2), N'admin', N'Cuba', N'cuba', N'Cuba')
GO
INSERT [dbo].[Tag] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [UrlSlug], [Description]) VALUES (4, CAST(N'2017-09-06T01:26:31.0900000' AS DateTime2), N'admin', CAST(N'2017-09-06T01:26:31.0900000' AS DateTime2), N'admin', N'Romania', N'romania', N'Romania')
GO
INSERT [dbo].[Tag] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [UrlSlug], [Description]) VALUES (5, CAST(N'2017-09-06T01:26:41.9200000' AS DateTime2), N'admin', CAST(N'2017-09-06T01:26:41.9200000' AS DateTime2), N'admin', N'Serbia', N'serbia', N'Serbia')
GO
INSERT [dbo].[Tag] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [UrlSlug], [Description]) VALUES (6, CAST(N'2017-09-06T01:27:20.6500000' AS DateTime2), N'admin', CAST(N'2017-09-06T01:27:20.6500000' AS DateTime2), N'admin', N'Bosnia and Herzegovina', N'bosnia-and-herzegovina', N'Bosnia and Herzegovina')
GO
INSERT [dbo].[Tag] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [UrlSlug], [Description]) VALUES (7, CAST(N'2017-09-06T01:27:59.0366667' AS DateTime2), N'admin', CAST(N'2017-09-06T01:27:59.0366667' AS DateTime2), N'admin', N'Croatia', N'croatia', N'Croatia')
GO
INSERT [dbo].[Tag] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [UrlSlug], [Description]) VALUES (8, CAST(N'2017-09-06T01:28:33.6466667' AS DateTime2), N'admin', CAST(N'2017-09-06T01:28:33.6466667' AS DateTime2), N'admin', N'Hungary', N'hungary', N'Hungary')
GO
INSERT [dbo].[Tag] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [UrlSlug], [Description]) VALUES (9, CAST(N'2017-09-06T01:29:21.0566667' AS DateTime2), N'admin', CAST(N'2017-09-06T01:29:21.0566667' AS DateTime2), N'admin', N'Slovenia', N'slovenia', N'Slovenia')
GO
INSERT [dbo].[Tag] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [UrlSlug], [Description]) VALUES (10, CAST(N'2017-11-03T16:26:37.3933333' AS DateTime2), N'admin', CAST(N'2017-11-03T16:26:37.3933333' AS DateTime2), N'admin', N'Mexico', N'mexico', N'Mexico')
GO
INSERT [dbo].[Tag] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [UrlSlug], [Description]) VALUES (11, CAST(N'2017-11-08T03:44:20.2033333' AS DateTime2), N'admin', CAST(N'2017-11-08T03:44:20.2033333' AS DateTime2), N'admin', N'Guatemala', N'guatemala', N'Guatemala')
GO
INSERT [dbo].[Tag] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [UrlSlug], [Description]) VALUES (12, CAST(N'2017-11-14T01:14:38.7700000' AS DateTime2), N'admin', CAST(N'2017-11-14T01:14:38.7700000' AS DateTime2), N'admin', N'Nicaragua', N'nicaragua', N'Nicaragua')
GO
INSERT [dbo].[Tag] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [UrlSlug], [Description]) VALUES (13, CAST(N'2017-12-12T23:51:19.3333333' AS DateTime2), N'admin', CAST(N'2017-12-12T23:51:19.3333333' AS DateTime2), N'admin', N'Panama', N'panama', N'Panama')
GO
INSERT [dbo].[Tag] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [UrlSlug], [Description]) VALUES (14, CAST(N'2017-12-22T14:03:26.7733333' AS DateTime2), N'admin', CAST(N'2017-12-22T14:03:26.7866667' AS DateTime2), N'admin', N'Costa Rica', N'costa-rica', N'Costa Rica')
GO
INSERT [dbo].[Tag] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [UrlSlug], [Description]) VALUES (15, CAST(N'2018-03-01T13:38:58.7800000' AS DateTime2), N'Anonymous', CAST(N'2018-03-01T13:38:58.7800000' AS DateTime2), N'Anonymous', N'Colombia', N'Colombia', N'Colombia')
GO
INSERT [dbo].[Tag] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [UrlSlug], [Description]) VALUES (16, CAST(N'2018-04-25T11:13:18.5566667' AS DateTime2), N'Anonymous', CAST(N'2018-04-25T11:13:18.5566667' AS DateTime2), N'Anonymous', N'Australia', N'Australia', N'Australia')
GO
INSERT [dbo].[Tag] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [UrlSlug], [Description]) VALUES (17, CAST(N'2020-04-15T07:04:53.7274811' AS DateTime2), N'59f6b452-2a98-4aa0-aa03-475a1c9790ab', CAST(N'2020-04-15T07:04:53.7274836' AS DateTime2), N'59f6b452-2a98-4aa0-aa03-475a1c9790ab', N'Ecuador', N'ecuador', N'Ecuador')
GO
SET IDENTITY_INSERT [dbo].[Tag] OFF
GO
SET IDENTITY_INSERT [dbo].[BlogPostTag] ON 
GO
INSERT [dbo].[BlogPostTag] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [TagId]) VALUES (1, 1, CAST(N'2017-06-09T22:55:02.0833333' AS DateTime2), N'admin', CAST(N'2017-06-09T22:55:02.0833333' AS DateTime2), N'admin', 1)
GO
INSERT [dbo].[BlogPostTag] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [TagId]) VALUES (2, 2, CAST(N'2017-06-26T14:00:21.2833333' AS DateTime2), N'admin', CAST(N'2017-06-26T14:00:21.2833333' AS DateTime2), N'admin', 2)
GO
INSERT [dbo].[BlogPostTag] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [TagId]) VALUES (3, 3, CAST(N'2017-09-06T00:50:32.5900000' AS DateTime2), N'admin', CAST(N'2017-09-06T00:50:32.5900000' AS DateTime2), N'admin', 3)
GO
INSERT [dbo].[BlogPostTag] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [TagId]) VALUES (4, 4, CAST(N'2017-11-03T15:55:35.1533333' AS DateTime2), N'admin', CAST(N'2017-11-03T15:55:35.1533333' AS DateTime2), N'admin', 3)
GO
INSERT [dbo].[BlogPostTag] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [TagId]) VALUES (5, 5, CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), N'admin', CAST(N'2017-11-03T16:30:22.0033333' AS DateTime2), N'admin', 10)
GO
INSERT [dbo].[BlogPostTag] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [TagId]) VALUES (6, 6, CAST(N'2017-11-08T03:45:16.4833333' AS DateTime2), N'admin', CAST(N'2017-11-08T03:45:16.4833333' AS DateTime2), N'admin', 11)
GO
INSERT [dbo].[BlogPostTag] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [TagId]) VALUES (7, 7, CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), N'admin', CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), N'admin', 9)
GO
INSERT [dbo].[BlogPostTag] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [TagId]) VALUES (8, 7, CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), N'admin', CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), N'admin', 8)
GO
INSERT [dbo].[BlogPostTag] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [TagId]) VALUES (9, 7, CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), N'admin', CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), N'admin', 7)
GO
INSERT [dbo].[BlogPostTag] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [TagId]) VALUES (10, 7, CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), N'admin', CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), N'admin', 6)
GO
INSERT [dbo].[BlogPostTag] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [TagId]) VALUES (11, 7, CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), N'admin', CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), N'admin', 5)
GO
INSERT [dbo].[BlogPostTag] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [TagId]) VALUES (12, 7, CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), N'admin', CAST(N'2017-11-10T03:17:52.9200000' AS DateTime2), N'admin', 4)
GO
INSERT [dbo].[BlogPostTag] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [TagId]) VALUES (13, 8, CAST(N'2017-11-14T01:31:30.5800000' AS DateTime2), N'admin', CAST(N'2017-11-14T01:31:30.5800000' AS DateTime2), N'admin', 12)
GO
INSERT [dbo].[BlogPostTag] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [TagId]) VALUES (14, 9, CAST(N'2017-12-08T16:17:21.0700000' AS DateTime2), N'admin', CAST(N'2017-12-08T16:17:21.0700000' AS DateTime2), N'admin', 12)
GO
INSERT [dbo].[BlogPostTag] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [TagId]) VALUES (15, 10, CAST(N'2017-12-13T00:27:56.0333333' AS DateTime2), N'admin', CAST(N'2017-12-13T00:27:56.0333333' AS DateTime2), N'admin', 13)
GO
INSERT [dbo].[BlogPostTag] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [TagId]) VALUES (16, 11, CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', CAST(N'2017-12-22T14:18:26.6400000' AS DateTime2), N'admin', 14)
GO
INSERT [dbo].[BlogPostTag] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [TagId]) VALUES (17, 12, CAST(N'2018-02-02T22:02:57.7033333' AS DateTime2), N'admin', CAST(N'2018-02-02T22:02:57.7033333' AS DateTime2), N'admin', 13)
GO
INSERT [dbo].[BlogPostTag] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [TagId]) VALUES (18, 13, CAST(N'2018-02-02T22:03:36.4566667' AS DateTime2), N'admin', CAST(N'2018-02-02T22:03:36.4566667' AS DateTime2), N'admin', 13)
GO
INSERT [dbo].[BlogPostTag] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [TagId]) VALUES (19, 14, CAST(N'2018-03-01T13:46:23.4533333' AS DateTime2), N'Anonymous', CAST(N'2018-03-01T13:46:23.4533333' AS DateTime2), N'Anonymous', 15)
GO
INSERT [dbo].[BlogPostTag] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [TagId]) VALUES (20, 15, CAST(N'2018-04-25T11:17:45.0833333' AS DateTime2), N'Anonymous', CAST(N'2018-04-25T11:17:45.0833333' AS DateTime2), N'Anonymous', 16)
GO
INSERT [dbo].[BlogPostTag] ([Id], [BlogPostId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [TagId]) VALUES (21, 17, CAST(N'2020-04-15T07:21:35.7960586' AS DateTime2), NULL, CAST(N'2020-04-15T07:42:53.1589458' AS DateTime2), NULL, 17)
GO
SET IDENTITY_INSERT [dbo].[BlogPostTag] OFF
GO
SET IDENTITY_INSERT [dbo].[CarouselItem] ON 
GO
INSERT [dbo].[CarouselItem] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Title], [CarouselText], [Album], [ButtonText], [Link], [Image], [OpenInNewWindow], [Published]) VALUES (1, CAST(N'2017-07-31T20:26:10.0000000' AS DateTime2), N'admin', CAST(N'2017-10-08T02:20:36.8533333' AS DateTime2), N'admin', N'Timisoara', N'One day in Romania''s third largest city', N'files/gallery/romania', NULL, N'http://www.digitalnomaddave.com/gallery/romania', NULL, 0, 0)
GO
INSERT [dbo].[CarouselItem] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Title], [CarouselText], [Album], [ButtonText], [Link], [Image], [OpenInNewWindow], [Published]) VALUES (2, CAST(N'2017-08-07T07:00:17.0000000' AS DateTime2), N'admin', CAST(N'2017-08-07T07:19:19.2766667' AS DateTime2), N'admin', N'Belgrade', N'Three days in Belgrade, Serbia', N'files/gallery/serbia', NULL, NULL, NULL, 0, 1)
GO
INSERT [dbo].[CarouselItem] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Title], [CarouselText], [Album], [ButtonText], [Link], [Image], [OpenInNewWindow], [Published]) VALUES (3, CAST(N'2017-08-18T11:42:07.3633333' AS DateTime2), N'admin', CAST(N'2017-08-18T11:42:07.3633333' AS DateTime2), N'admin', N'Slovenia', N'The natural beauty of Slovenia', N'files/gallery/slovenia', NULL, NULL, NULL, 0, 1)
GO
SET IDENTITY_INSERT [dbo].[CarouselItem] OFF
GO
INSERT [dbo].[ContentHtml] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [HTML], [PreventDelete]) VALUES (N'About', CAST(N'2017-06-10T21:45:42.0500000' AS DateTime2), N'Anonymous', CAST(N'2020-04-11T10:27:19.3632641' AS DateTime2), N'59f6b452-2a98-4aa0-aa03-475a1c9790ab', N'<pre class="language-csharp"><code>public class Program
{
	public static async Task Main(string[] args)
	{
		await AboutMe();
		
		Console.WriteLine("Press any key to close this window . . .");
        Console.ReadKey(true);
	}

	public Task AboutMe()
	{
		Console.WriteLine(@"
		Hi I''m David and this is my website. Welcome!

		I developed the site initially as a way to showcase and enhance 
		my web design skills but hope it becomes more than just that.

		Since around the year 2000 advances in technology have given rise 
		to a new kind of IT nerd, aka the ''Digital Nomad''. You might be 
		wondering what exactly is a ''Digital Nomad'', like me a couple of 
		years ago? Essentially it is someone (generally in IT) who is able 
		to move around the world and make a living while doing so. 
		I''m a computer programmer and love travelling so I''ll be honest seeing 
		others live this life while being stuck in a London office drinking 
		overpriced coffee made me slightly jealous!

		With my Tier 5 UK visa (I''m an Aussie btw) coming to and end in August
		2017 I decided to leave my job and travel through Central/South America
		while doing some part-time remote work. I had a great time and realised
		while doing so that I was alot more productive working remotely than in
		an office.

		Since 2012, when I went on my first overseas trip to Europe I''ve had a
		severe case of the Travel Bug. Fast forward five years and I''ve now 
		visited 59+ countries, worked in 10+ countries and still haven''t been 
		able to find a cure. Check out my never ending bucket list. 

		I''m skeptical the Digital Nomad life is as good as social-media 
		accounts make it out to be but I like the idea of not being stuck in 
		the one location and being able to get a good balance between life 
		and work. My aim is to now get full time remote employment and make 
		this happen.

		I would also like to share useful information about my passions:

		1. Travel
		2. Photography
		3. Programming/Web Design

		I like taking photos and videos of the places I visit. If you would
		like to see some of my work, check out my gallery and videos.

		Thanks for visting the site and I look forward to sharing my journey,
		helping others and connecting with other like-minded people.

		Cheers,
		Dave
		");
		
		//You only live once but if you do it right once is enough.
		
		return Task.CompletedTask;
	}
}</code></pre>', 1)
GO
INSERT [dbo].[ContentHtml] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [HTML], [PreventDelete]) VALUES (N'Affiliates', CAST(N'2017-06-10T21:45:42.0500000' AS DateTime2), N'Anonymous', CAST(N'2018-05-04T11:57:29.1833333' AS DateTime2), N'Anonymous', N'<div class="sidebar-module">
<div data-target="_blank" data-enable-placeholders="true" data-affiliate="network:CJ;publisher:8365028;market:GB" data-origin-geo-lookup="true" data-market="UK" data-locale="en-GB" data-skyscanner-widget="SearchWidget">&nbsp;</div>
<script src="https://widgets.skyscanner.net/widget-server/js/loader.js"></script>
</div>
<div class="sidebar-module text-center"><a href="https://www.airbnb.com/c/davei4" rel="noopener noreferrer" target="_blank"><img border="0" src="../../../images/airbnb (Mobile).png" /></a></div>
<!--<div class="sidebar-module text-center"><a href="http://www.tkqlhce.com/click-8365028-11087588" target="_top"> <img alt="" border="0" height="400" src="http://www.awltovhc.com/image-8365028-11087588" width="230" /> </a></div>
<div class="sidebar-module text-center"><a href="http://www.kqzyfj.com/click-8365028-11839038" rel="noopener noreferrer" target="_blank"> <img alt="" border="0" height="250" src="http://www.awltovhc.com/image-8365028-11839038" width="300" /></a></div>-->', 1)
GO
INSERT [dbo].[ContentHtml] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [HTML], [PreventDelete]) VALUES (N'Contact', CAST(N'2017-06-10T21:45:42.0500000' AS DateTime2), N'Anonymous', CAST(N'2017-06-10T21:48:34.2500000' AS DateTime2), N'admin', N'<p>If you have a question check out my <a href="../../../help-faq">Help/FAQ</a> page to see if I have already answered your question.</p>', 1)
GO
INSERT [dbo].[ContentHtml] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [HTML], [PreventDelete]) VALUES (N'Head', CAST(N'2017-06-13T20:58:40.8600000' AS DateTime2), N'Anonymous', CAST(N'2017-06-19T09:08:43.3100000' AS DateTime2), N'admin', NULL, 1)
GO
INSERT [dbo].[ContentHtml] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [HTML], [PreventDelete]) VALUES (N'Main', CAST(N'2017-06-21T01:46:03.1333333' AS DateTime2), N'Anonymous', CAST(N'2017-12-01T01:36:44.2266667' AS DateTime2), N'admin', N'<div class="section-white margin-bottom-10">
<div class="container">
<div class="row">
<div class="col-12">
<div data-target="_blank" data-skyscanner-widget="SearchWidget" data-locale="en-GB" data-market="UK" data-origin-geo-lookup="true" data-affiliate="network:CJ;publisher:8365028;market:GB" data-enable-placeholders="true">&nbsp;</div>
<script async="async" src="https://widgets.skyscanner.net/widget-server/js/loader.js"></script>
</div>
</div>
</div>
</div>', 1)
GO
INSERT [dbo].[ContentHtml] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [HTML], [PreventDelete]) VALUES (N'MyWebsite', CAST(N'2018-03-08T21:51:12.9000000' AS DateTime2), N'Anonymous', CAST(N'2018-04-29T07:45:18.8700000' AS DateTime2), N'Anonymous', N'<div class="row">
<div class="col-12">I built this website from the ground up initially to showcase and enhance my web design skills. Along the way I also took the time to develop a reusable framework which implements the following techniques, interfaces, classes and third party libraries:</div>
<ul>
<li class="col-12">Independant Service Layer</li>
<li class="col-12">Decoupled UI and service layer datastructures</li>
<li class="col-12">Data exposed via RESTful Web API. See <a href="../../../swagger/" title="Swagger">http://www.digitalnomaddave.com/swagger/</a></li>
<li class="col-12">Dependency Injection using <a href="https://autofac.org/" title="Autofac">Autofac</a></li>
<li class="col-12">Unit Tests using <a href="https://github.com/moq/moq4">Moq</a></li>
<li class="col-12">Integration Tests</li>
<li class="col-12">Base object class implementing&nbsp;IValidatableObject</li>
<li class="col-12">Repository Pattern</li>
<li class="col-12"><a href="http://mehdi.me/ambient-dbcontext-in-ef6/" rel="noopener noreferrer" title="Unit of Work Pattern" target="_blank">Unit of Work Pattern</a></li>
<li class="col-12">Base CRUD controller class and MVC views</li>
<li class="col-12">Re-usable MVC Editor/Display templates</li>
<li class="col-12">Custom Image Handler</li>
<li class="col-12">Bootstrap alerts&nbsp;</li>
<li class="col-12">Entity Framework</li>
<li class="col-12"><a href="https://www.hangfire.io/" rel="noopener noreferrer" title="Hangfire" target="_blank">Hangfire</a></li>
<li class="col-12"><a href="http://swagger.io/" rel="noopener noreferrer" title="Swagger" target="_blank">Swagger</a></li>
<li class="col-12"><a href="http://www.roxyfileman.com/" rel="noopener noreferrer" title="Roxy File Manager" target="_blank">Roxy File Manager</a></li>
<li class="col-12"><a href="http://automapper.org/" rel="noopener noreferrer" title="Automapper" target="_blank">Automapper</a></li>
<li class="col-12"><a href="http://nlog-project.org/" rel="noopener noreferrer" title="NLog" target="_blank">NLog</a></li>
<li class="col-12"><a href="https://serilog.net/" rel="noopener" title="Serilog" target="_blank">Serilog</a></li>
<li class="col-12"><a href="https://github.com/KevinDockx/HttpCacheHeaders" rel="noopener" title="Http Cache Headers (Etags)" target="_blank">Http Cache Headers (Etags)</a></li>
<li class="col-12"><a href="http://www.ncrunch.net/" rel="noopener" title="NCrunch" target="_blank">NCrunch</a></li>
<li class="col-12"><a href="http://specflow.org/" rel="noopener" title="SpecFlow" target="_blank">SpecFlow</a></li>
<li class="col-12"><a href="http://websurge.west-wind.com/download.aspx" rel="noopener" title="WebSurge" target="_blank">WebSurge</a></li>
</ul>
<div class="col-12">The website is hosted on the <a href="https://azure.microsoft.com/en-us/" rel="noopener noreferrer" title="Azure cloud" target="_blank">Azure cloud</a>&nbsp;and all the content is maintained using a custom content management system. The back-end is written in C# .NET utilizing response caching and async programming for scalability. The front-end is a combination of CSS3, Angular, JQuery, Javascript, HTML5, Bootstrap 4 and third party scripts. Data analysis is taken care of by <a href="https://www.google.co.uk/analytics" rel="noopener noreferrer" title="Google Analytics" target="_blank">Google Analytics</a>.</div>
</div>', 1)
GO
INSERT [dbo].[ContentHtml] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [HTML], [PreventDelete]) VALUES (N'PrivacyPolicy', CAST(N'2018-10-04T13:28:02.5038753' AS DateTime2), N'SYSTEM', NULL, NULL, N'', 1)
GO
INSERT [dbo].[ContentHtml] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [HTML], [PreventDelete]) VALUES (N'Resume', CAST(N'2017-06-10T21:45:42.0500000' AS DateTime2), N'Anonymous', CAST(N'2018-03-08T21:23:29.4566667' AS DateTime2), N'Anonymous', N'<div><iframe frameborder="1" height="1225" src="https://docs.google.com/document/d/e/2PACX-1vQIVB_sfMlGMpD1Xy8h3Wht5KAwUEXHuPthea5Lwzgw_bvT553HXCMVoLbruPeNZYU-27ENwTFzfnfB/pub?embedded=true" width="700"></iframe></div>', 1)
GO
INSERT [dbo].[ContentHtml] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [HTML], [PreventDelete]) VALUES (N'SideBarAbout', CAST(N'2017-06-10T21:45:42.0500000' AS DateTime2), N'Anonymous', CAST(N'2017-06-10T22:06:03.6400000' AS DateTime2), N'admin', NULL, 1)
GO
INSERT [dbo].[ContentHtml] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [HTML], [PreventDelete]) VALUES (N'WorkWithMe', CAST(N'2017-06-10T21:45:42.0500000' AS DateTime2), N'Anonymous', CAST(N'2019-03-03T21:43:45.6264668' AS DateTime2), N'78340e0c-d14b-41b8-8cf8-f373c774ce21', N'<div class="row mb-3">
<div class="col-12 card-deck">
<div class="card text-white text-center m-1" style="background-color: #372f45; border-color: #372f45;">
<div class="card-body">
<p class="card-text">Do you require a Web Developer?</p>
</div>
</div>
<div class="card text-white text-center m-1" style="background-color: #372f45; border-color: #372f45;">
<div class="card-body">
<p class="card-text">Would you like someone to look after your social media accounts?</p>
</div>
</div>
<div class="card text-white text-center m-1" style="background-color: #372f45; border-color: #372f45;">
<div class="card-body">
<p class="card-text">Are you after a photographer or in need of a promotional video?</p>
</div>
</div>
</div>
</div>
<div class="row">
<div class="col-12">Some of the services I offer include:</div>
<ul>
<li class="col-12">Wordpress Websites</li>
<li class="col-12">Responsive Web Design (CSS/HTML5/Bootstrap 4)</li>
<li class="col-12">Web Development (C#/MVC 5/MVC Core/Web Api/Entity Framework/<span style="display: inline !important; float: none; background-color: transparent; color: #212529; cursor: text; font-family: Sans-Serif; font-size: 16px; font-style: normal; font-variant: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-decoration: none; text-indent: 0px; text-transform: none; -webkit-text-stroke-width: 0px; white-space: normal; word-spacing: 0px;">Entity Framework</span> Core/Angular/React/Javascript/JQuery)</li>
<li class="col-12">Multi-Tenant SaaS</li>
<li class="col-12">Multi-Language</li>
<li class="col-12">Azure Cloud Hosting</li>
<li class="col-12">Domain Name Registration</li>
<li class="col-12">SEO/Structured Data</li>
<li class="col-12">Google Analytics Integration</li>
<li class="col-12">Google Maps Integration</li>
<li class="col-12">Social Media Integration</li>
<li class="col-12">Photography (A7R II)</li>
<li class="col-12">Drone Photography/Videography (DJI Mavic)</li>
<li class="col-12">Videography (GoPro 6)</li>
<li class="col-12">Social Media</li>
</ul>
<div class="col-12">I have over 7 years experience as a .NET developer in the Finance and Education industries and as mentioned in my <a href="../../../about" title="About">About</a> page I built this website from the ground up initially to showcase and enhance my web design skills. If you would like to read about the technology stack I used click <a href="../../../my-website" title="My Website">here</a>.</div>
<div class="col-12">&nbsp;</div>
<div class="col-12">If you would like to see a full list of my technical skills or examples of my coding have a look at my online <a href="../../../resume" title="Resume">Resume</a>&nbsp;and <a href="https://github.com/davidikin45/DigitalNomadDave" rel="noopener noreferrer" title="GitHub" target="_blank">GitHub</a> repository.&nbsp;</div>
</div>
<div class="row">
<div class="col-12">&nbsp;</div>
<div class="col-12">In addition to the above services I offer, I am also open to any other ways (technical or non-technical) we can work together.</div>
<div class="col-12">&nbsp;</div>
<div class="col-12">Check out my <a href="../../../gallery" rel="noreferrer" title="Gallery">Gallery</a>&nbsp;for examples of photography, <a href="../../../videos" title="Videos">Videos</a> for examples of videography,&nbsp;<a href="../../../travel-map" title="Travel Map">Travel Map</a> for places I have visited and below for commercial projects I have worked on.</div>
<div class="col-12">&nbsp;</div>
<div class="col-12">If you would like to get in touch to discuss working together, please visit my <a href="../../../contact" title="Contact">Contact</a> page and I''ll get back to you as soon as possible.</div>
</div>', 1)
GO
SET IDENTITY_INSERT [dbo].[Project] ON 
GO
INSERT [dbo].[Project] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [Link], [File], [Album], [DescriptionText]) VALUES (1, CAST(N'2017-07-01T13:33:16.3833333' AS DateTime2), N'admin', CAST(N'2017-07-01T13:33:16.3833333' AS DateTime2), N'admin', N'Neo 200 CMS', N'http://neo200.com/', N'files/projects/neo200.jpg', NULL, N'Developed a Custom Content Management System using .NET, Caching, JQuery and an XML database.')
GO
INSERT [dbo].[Project] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [Link], [File], [Album], [DescriptionText]) VALUES (2, CAST(N'2017-07-01T17:43:22.1100000' AS DateTime2), N'admin', CAST(N'2017-07-01T17:43:22.1100000' AS DateTime2), N'admin', N'Digital Nomad Dave', N'http://www.digitalnomaddave.com', N'files/projects/digital-nomad-dave.jpg', NULL, N'Personal Website built using C# MVC 5, Web API 2, Angular and Bootstrap.')
GO
INSERT [dbo].[Project] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [Link], [File], [Album], [DescriptionText]) VALUES (3, CAST(N'2017-11-14T00:24:50.0000000' AS DateTime2), N'admin', CAST(N'2018-03-08T20:21:54.7100000' AS DateTime2), N'Anonymous', N'Eclypse de Mar', N'http://www.eclypsedemar.com', N'files/projects/Eclypse de Mar Promotional Video.txt', NULL, N'While working in Bastimentos, Panama we made this promotional video')
GO
INSERT [dbo].[Project] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [Link], [File], [Album], [DescriptionText]) VALUES (4, CAST(N'2017-11-14T01:03:00.2600000' AS DateTime2), N'admin', CAST(N'2017-11-14T01:03:00.2600000' AS DateTime2), N'admin', N'El Arca de Noe', N'http://www.digitalnomaddave.com/gallery/el-arca-de-noe', NULL, N'files/gallery/el-arca-de-noe', N'Photo shoot at Hotel El Arca de Noe in Granada, Nicaragua')
GO
INSERT [dbo].[Project] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [Link], [File], [Album], [DescriptionText]) VALUES (5, CAST(N'2018-03-08T20:25:27.7066667' AS DateTime2), N'Anonymous', CAST(N'2018-03-08T20:25:27.7066667' AS DateTime2), N'Anonymous', N'San Blas Adventures', N'https://sanblasadventures.com', N'files/projects/San Blas Adventures Promotional Video.txt', NULL, N'Promotional video for San Blas Adventures tour company')
GO
INSERT [dbo].[Project] ([Id], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [Name], [Link], [File], [Album], [DescriptionText]) VALUES (6, CAST(N'2018-03-08T20:27:31.1266667' AS DateTime2), N'Anonymous', CAST(N'2018-03-08T20:27:31.1266667' AS DateTime2), N'Anonymous', N'Happy Buddha Hostel Guatape', N'http://www.happybuddhaguatape.com', N'files/projects/Happy Buddha Guatape Promotional Video.txt', NULL, N'Promotional video for Happy Buddha Hostel in Guatape, Colombia')
GO
SET IDENTITY_INSERT [dbo].[Project] OFF

