USE [NileCapitalCruisesWSDB]
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_CruiseCategory] ON 
GO
INSERT [dbo].[tbl_CruiseBooking_CruiseCategory] ([Id], [CruiseCategoryNameSys], [classIcon]) VALUES (12, N'5 Star', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_CruiseCategory] ([Id], [CruiseCategoryNameSys], [classIcon]) VALUES (13, N'4 Stars', NULL)
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_CruiseCategory] OFF
GO

SET IDENTITY_INSERT [dbo].[tbl_Master_Languages] ON 
GO
INSERT [dbo].[tbl_Master_Languages] ([Id], [LanguageName], [LanguageFlag], [LanguageAbbreviation], [LangStatus], [LanguageClass]) VALUES (1, N'Englsih', N'en.jpg', N'en', 1, N'flag-us')
GO
INSERT [dbo].[tbl_Master_Languages] ([Id], [LanguageName], [LanguageFlag], [LanguageAbbreviation], [LangStatus], [LanguageClass]) VALUES (2, N'Arabic', N'eg.jpg', N'ar', 0, N'flag-eg')
GO
SET IDENTITY_INSERT [dbo].[tbl_Master_Languages] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Cruises] ON 
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises] ([Id], [CruiseLocationID], [CruiseUsername], [CruisePassword], [CruiseNameSys], [CruiseStatus], [CabinNumbers], [DeckNumbers], [BrandID], [CruiseURL], [CruisePhoto], [CruiseLogo], [CruiseBanner], [CruiseCategoryID], [CruisePhoto_Width], [CruisePhoto_Height], [CruiseLogo_Width], [CruiseLogo_Height], [CruiseBanner_Width], [CruiseBanner_Height], [CruiseDeckPlan], [CruiseDeckPlan_Width], [CruiseDeckPlan_Height], [CruisePosition], [CruiseLength], [CruiseWidth], [CruiseHeight], [CruiseOopeningYear], [CruiseRenovationYear], [CruiseReservationEmail], [CruiseGeneralEmail], [CruiseCheckIn], [CruiseCheckout], [WS_Booking], [WS_Expedia], [WS_Agouda], [WS_Facebook], [WS_Instgram], [WS_X], [WS_SnapChat], [WS_TikTok], [WSLinkdIN], [WS_TripAdvisor], [WS_Youtube], [WS_Google], [WS_BrandURL], [Contact_GM_Name], [Contact_GM_Mobile], [Contact_GM_Email], [Contact_Sales_Name], [Contact_Sales_Mobile], [Contact_Sales_Email], [Contact_Reservation_Name], [Contact_Reservation_Mobile], [Contact_Reservation_Email], [Contact_Finance_Name], [Contact_Fininace_Mobile], [Contact_Fininace_Email], [Contact_Marketing_Name], [Contact_Marketing_Mobile], [Contact_Marketing_Email]) VALUES (2, 1, NULL, NULL, N'Jaz Crown Prince', 0, 84, 9, 29, N'jaz-crown-prince', N'Overview_10102__16408_1.jpg', N'Logo_19835_none.jpg', N'_8652_banner-wedding.jpg', 12, 690, 450, 1200, 1200, 1920, 527, N'DeckPlan_12024_1.jpg', 1315, 1231, 1, N'sds', N'dsd', N'sdsd', N'2323', N'23', NULL, NULL, N'', N'', N'Booking.com', N'Expedia.com', N'Agoda.com', N'Facebook', N'InstgramInstgram', N'X', N'SnapChat', N'TikTok', N'LinkedIn', N'Advisor', N'Youtube', N'Google ', N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises] ([Id], [CruiseLocationID], [CruiseUsername], [CruisePassword], [CruiseNameSys], [CruiseStatus], [CabinNumbers], [DeckNumbers], [BrandID], [CruiseURL], [CruisePhoto], [CruiseLogo], [CruiseBanner], [CruiseCategoryID], [CruisePhoto_Width], [CruisePhoto_Height], [CruiseLogo_Width], [CruiseLogo_Height], [CruiseBanner_Width], [CruiseBanner_Height], [CruiseDeckPlan], [CruiseDeckPlan_Width], [CruiseDeckPlan_Height], [CruisePosition], [CruiseLength], [CruiseWidth], [CruiseHeight], [CruiseOopeningYear], [CruiseRenovationYear], [CruiseReservationEmail], [CruiseGeneralEmail], [CruiseCheckIn], [CruiseCheckout], [WS_Booking], [WS_Expedia], [WS_Agouda], [WS_Facebook], [WS_Instgram], [WS_X], [WS_SnapChat], [WS_TikTok], [WSLinkdIN], [WS_TripAdvisor], [WS_Youtube], [WS_Google], [WS_BrandURL], [Contact_GM_Name], [Contact_GM_Mobile], [Contact_GM_Email], [Contact_Sales_Name], [Contact_Sales_Mobile], [Contact_Sales_Email], [Contact_Reservation_Name], [Contact_Reservation_Mobile], [Contact_Reservation_Email], [Contact_Finance_Name], [Contact_Fininace_Mobile], [Contact_Fininace_Email], [Contact_Marketing_Name], [Contact_Marketing_Mobile], [Contact_Marketing_Email]) VALUES (3, 1, NULL, NULL, N'Jaz Crown Jewel', 1, 80, 5, 29, N'jaz-crown-jewel', N'_11838__3610_brand-dahabeyat.jpg', NULL, N'_17817_bannernonw.jpg', 12, 690, 450, NULL, NULL, 1920, 530, N'_12771_jaz-crown-JEWEL.jpg', 1315, 1231, 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises] ([Id], [CruiseLocationID], [CruiseUsername], [CruisePassword], [CruiseNameSys], [CruiseStatus], [CabinNumbers], [DeckNumbers], [BrandID], [CruiseURL], [CruisePhoto], [CruiseLogo], [CruiseBanner], [CruiseCategoryID], [CruisePhoto_Width], [CruisePhoto_Height], [CruiseLogo_Width], [CruiseLogo_Height], [CruiseBanner_Width], [CruiseBanner_Height], [CruiseDeckPlan], [CruiseDeckPlan_Width], [CruiseDeckPlan_Height], [CruisePosition], [CruiseLength], [CruiseWidth], [CruiseHeight], [CruiseOopeningYear], [CruiseRenovationYear], [CruiseReservationEmail], [CruiseGeneralEmail], [CruiseCheckIn], [CruiseCheckout], [WS_Booking], [WS_Expedia], [WS_Agouda], [WS_Facebook], [WS_Instgram], [WS_X], [WS_SnapChat], [WS_TikTok], [WSLinkdIN], [WS_TripAdvisor], [WS_Youtube], [WS_Google], [WS_BrandURL], [Contact_GM_Name], [Contact_GM_Mobile], [Contact_GM_Email], [Contact_Sales_Name], [Contact_Sales_Mobile], [Contact_Sales_Email], [Contact_Reservation_Name], [Contact_Reservation_Mobile], [Contact_Reservation_Email], [Contact_Finance_Name], [Contact_Fininace_Mobile], [Contact_Fininace_Email], [Contact_Marketing_Name], [Contact_Marketing_Mobile], [Contact_Marketing_Email]) VALUES (4, 1, NULL, NULL, N'Jaz Crown Jubilee', 0, 76, 5, 29, N'jaz-crown-jubilee', N'_8330_Exterior-1.jpg', NULL, NULL, 12, 1000, 667, NULL, NULL, NULL, NULL, N'_12405_jaz-crown-JUBILEE.jpg', 1315, 1231, 3, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises] ([Id], [CruiseLocationID], [CruiseUsername], [CruisePassword], [CruiseNameSys], [CruiseStatus], [CabinNumbers], [DeckNumbers], [BrandID], [CruiseURL], [CruisePhoto], [CruiseLogo], [CruiseBanner], [CruiseCategoryID], [CruisePhoto_Width], [CruisePhoto_Height], [CruiseLogo_Width], [CruiseLogo_Height], [CruiseBanner_Width], [CruiseBanner_Height], [CruiseDeckPlan], [CruiseDeckPlan_Width], [CruiseDeckPlan_Height], [CruisePosition], [CruiseLength], [CruiseWidth], [CruiseHeight], [CruiseOopeningYear], [CruiseRenovationYear], [CruiseReservationEmail], [CruiseGeneralEmail], [CruiseCheckIn], [CruiseCheckout], [WS_Booking], [WS_Expedia], [WS_Agouda], [WS_Facebook], [WS_Instgram], [WS_X], [WS_SnapChat], [WS_TikTok], [WSLinkdIN], [WS_TripAdvisor], [WS_Youtube], [WS_Google], [WS_BrandURL], [Contact_GM_Name], [Contact_GM_Mobile], [Contact_GM_Email], [Contact_Sales_Name], [Contact_Sales_Mobile], [Contact_Sales_Email], [Contact_Reservation_Name], [Contact_Reservation_Mobile], [Contact_Reservation_Email], [Contact_Finance_Name], [Contact_Fininace_Mobile], [Contact_Fininace_Email], [Contact_Marketing_Name], [Contact_Marketing_Mobile], [Contact_Marketing_Email]) VALUES (5, 1, NULL, NULL, N'Jaz Imperial', 0, 48, 3, 29, N'jaz-imperial', N'_1065_Exterior-1.jpg', NULL, NULL, 12, 1000, 667, NULL, NULL, NULL, NULL, N'_2339_jaz_IMPERIL.jpg', 1315, 1231, 4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises] ([Id], [CruiseLocationID], [CruiseUsername], [CruisePassword], [CruiseNameSys], [CruiseStatus], [CabinNumbers], [DeckNumbers], [BrandID], [CruiseURL], [CruisePhoto], [CruiseLogo], [CruiseBanner], [CruiseCategoryID], [CruisePhoto_Width], [CruisePhoto_Height], [CruiseLogo_Width], [CruiseLogo_Height], [CruiseBanner_Width], [CruiseBanner_Height], [CruiseDeckPlan], [CruiseDeckPlan_Width], [CruiseDeckPlan_Height], [CruisePosition], [CruiseLength], [CruiseWidth], [CruiseHeight], [CruiseOopeningYear], [CruiseRenovationYear], [CruiseReservationEmail], [CruiseGeneralEmail], [CruiseCheckIn], [CruiseCheckout], [WS_Booking], [WS_Expedia], [WS_Agouda], [WS_Facebook], [WS_Instgram], [WS_X], [WS_SnapChat], [WS_TikTok], [WSLinkdIN], [WS_TripAdvisor], [WS_Youtube], [WS_Google], [WS_BrandURL], [Contact_GM_Name], [Contact_GM_Mobile], [Contact_GM_Email], [Contact_Sales_Name], [Contact_Sales_Mobile], [Contact_Sales_Email], [Contact_Reservation_Name], [Contact_Reservation_Mobile], [Contact_Reservation_Email], [Contact_Finance_Name], [Contact_Fininace_Mobile], [Contact_Fininace_Email], [Contact_Marketing_Name], [Contact_Marketing_Mobile], [Contact_Marketing_Email]) VALUES (6, 1, NULL, NULL, N'Jaz Viceroy', 1, 37, 5, 29, N'jaz-viceroy', N'_9816_Viceroy-Exterior-2-202252410.jpg', NULL, N'_8736_bannernonw.jpg', 12, 1000, 667, NULL, NULL, 1920, 530, N'_7182_jaz_VICEROY.jpg', 1315, 1231, 5, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises] ([Id], [CruiseLocationID], [CruiseUsername], [CruisePassword], [CruiseNameSys], [CruiseStatus], [CabinNumbers], [DeckNumbers], [BrandID], [CruiseURL], [CruisePhoto], [CruiseLogo], [CruiseBanner], [CruiseCategoryID], [CruisePhoto_Width], [CruisePhoto_Height], [CruiseLogo_Width], [CruiseLogo_Height], [CruiseBanner_Width], [CruiseBanner_Height], [CruiseDeckPlan], [CruiseDeckPlan_Width], [CruiseDeckPlan_Height], [CruisePosition], [CruiseLength], [CruiseWidth], [CruiseHeight], [CruiseOopeningYear], [CruiseRenovationYear], [CruiseReservationEmail], [CruiseGeneralEmail], [CruiseCheckIn], [CruiseCheckout], [WS_Booking], [WS_Expedia], [WS_Agouda], [WS_Facebook], [WS_Instgram], [WS_X], [WS_SnapChat], [WS_TikTok], [WSLinkdIN], [WS_TripAdvisor], [WS_Youtube], [WS_Google], [WS_BrandURL], [Contact_GM_Name], [Contact_GM_Mobile], [Contact_GM_Email], [Contact_Sales_Name], [Contact_Sales_Mobile], [Contact_Sales_Email], [Contact_Reservation_Name], [Contact_Reservation_Mobile], [Contact_Reservation_Email], [Contact_Finance_Name], [Contact_Fininace_Mobile], [Contact_Fininace_Email], [Contact_Marketing_Name], [Contact_Marketing_Mobile], [Contact_Marketing_Email]) VALUES (7, 1, NULL, NULL, N'Jaz Regent', 1, 56, 5, 29, N'jaz-regent', N'_13922_Regent-Exterior-20225249.jpg', NULL, N'_14859_bannernonw.jpg', 12, 1000, 667, NULL, NULL, 1920, 530, N'_8683_jaz_REGENT.jpg', 1315, 1231, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises] ([Id], [CruiseLocationID], [CruiseUsername], [CruisePassword], [CruiseNameSys], [CruiseStatus], [CabinNumbers], [DeckNumbers], [BrandID], [CruiseURL], [CruisePhoto], [CruiseLogo], [CruiseBanner], [CruiseCategoryID], [CruisePhoto_Width], [CruisePhoto_Height], [CruiseLogo_Width], [CruiseLogo_Height], [CruiseBanner_Width], [CruiseBanner_Height], [CruiseDeckPlan], [CruiseDeckPlan_Width], [CruiseDeckPlan_Height], [CruisePosition], [CruiseLength], [CruiseWidth], [CruiseHeight], [CruiseOopeningYear], [CruiseRenovationYear], [CruiseReservationEmail], [CruiseGeneralEmail], [CruiseCheckIn], [CruiseCheckout], [WS_Booking], [WS_Expedia], [WS_Agouda], [WS_Facebook], [WS_Instgram], [WS_X], [WS_SnapChat], [WS_TikTok], [WSLinkdIN], [WS_TripAdvisor], [WS_Youtube], [WS_Google], [WS_BrandURL], [Contact_GM_Name], [Contact_GM_Mobile], [Contact_GM_Email], [Contact_Sales_Name], [Contact_Sales_Mobile], [Contact_Sales_Email], [Contact_Reservation_Name], [Contact_Reservation_Mobile], [Contact_Reservation_Email], [Contact_Finance_Name], [Contact_Fininace_Mobile], [Contact_Fininace_Email], [Contact_Marketing_Name], [Contact_Marketing_Mobile], [Contact_Marketing_Email]) VALUES (8, 1, NULL, NULL, N'Jaz Nile Monarch', 0, 45, 5, 29, N'jaz-nile-monarch', N'_12807__3610_brand-dahabeyat.jpg', NULL, NULL, 12, 690, 450, NULL, NULL, NULL, NULL, N'_17193_jaz-MONARCH.jpg', 1315, 1231, 7, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises] ([Id], [CruiseLocationID], [CruiseUsername], [CruisePassword], [CruiseNameSys], [CruiseStatus], [CabinNumbers], [DeckNumbers], [BrandID], [CruiseURL], [CruisePhoto], [CruiseLogo], [CruiseBanner], [CruiseCategoryID], [CruisePhoto_Width], [CruisePhoto_Height], [CruiseLogo_Width], [CruiseLogo_Height], [CruiseBanner_Width], [CruiseBanner_Height], [CruiseDeckPlan], [CruiseDeckPlan_Width], [CruiseDeckPlan_Height], [CruisePosition], [CruiseLength], [CruiseWidth], [CruiseHeight], [CruiseOopeningYear], [CruiseRenovationYear], [CruiseReservationEmail], [CruiseGeneralEmail], [CruiseCheckIn], [CruiseCheckout], [WS_Booking], [WS_Expedia], [WS_Agouda], [WS_Facebook], [WS_Instgram], [WS_X], [WS_SnapChat], [WS_TikTok], [WSLinkdIN], [WS_TripAdvisor], [WS_Youtube], [WS_Google], [WS_BrandURL], [Contact_GM_Name], [Contact_GM_Mobile], [Contact_GM_Email], [Contact_Sales_Name], [Contact_Sales_Mobile], [Contact_Sales_Email], [Contact_Reservation_Name], [Contact_Reservation_Mobile], [Contact_Reservation_Email], [Contact_Finance_Name], [Contact_Fininace_Mobile], [Contact_Fininace_Email], [Contact_Marketing_Name], [Contact_Marketing_Mobile], [Contact_Marketing_Email]) VALUES (9, 1, NULL, NULL, N'Jaz Celebrity', 0, 0, 5, 29, N'jaz-celebrity', N'_18133__3610_brand-dahabeyat.jpg', NULL, NULL, 12, 690, 450, NULL, NULL, NULL, NULL, N'_182_JAZ_CELEBRITY.jpg', 1315, 1231, 8, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises] ([Id], [CruiseLocationID], [CruiseUsername], [CruisePassword], [CruiseNameSys], [CruiseStatus], [CabinNumbers], [DeckNumbers], [BrandID], [CruiseURL], [CruisePhoto], [CruiseLogo], [CruiseBanner], [CruiseCategoryID], [CruisePhoto_Width], [CruisePhoto_Height], [CruiseLogo_Width], [CruiseLogo_Height], [CruiseBanner_Width], [CruiseBanner_Height], [CruiseDeckPlan], [CruiseDeckPlan_Width], [CruiseDeckPlan_Height], [CruisePosition], [CruiseLength], [CruiseWidth], [CruiseHeight], [CruiseOopeningYear], [CruiseRenovationYear], [CruiseReservationEmail], [CruiseGeneralEmail], [CruiseCheckIn], [CruiseCheckout], [WS_Booking], [WS_Expedia], [WS_Agouda], [WS_Facebook], [WS_Instgram], [WS_X], [WS_SnapChat], [WS_TikTok], [WSLinkdIN], [WS_TripAdvisor], [WS_Youtube], [WS_Google], [WS_BrandURL], [Contact_GM_Name], [Contact_GM_Mobile], [Contact_GM_Email], [Contact_Sales_Name], [Contact_Sales_Mobile], [Contact_Sales_Email], [Contact_Reservation_Name], [Contact_Reservation_Mobile], [Contact_Reservation_Email], [Contact_Finance_Name], [Contact_Fininace_Mobile], [Contact_Fininace_Email], [Contact_Marketing_Name], [Contact_Marketing_Mobile], [Contact_Marketing_Email]) VALUES (10, 1, NULL, NULL, N'Iberotel Crown Emperor', 1, 117, 5, 30, N'iberotel-crown-emperor', N'_13502__3610_brand-dahabeyat.jpg', NULL, N'_6385_bannernonw.jpg', 12, 690, 450, NULL, NULL, 1920, 530, N'_10827_landing-parallax.jpg', NULL, NULL, 9, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises] ([Id], [CruiseLocationID], [CruiseUsername], [CruisePassword], [CruiseNameSys], [CruiseStatus], [CabinNumbers], [DeckNumbers], [BrandID], [CruiseURL], [CruisePhoto], [CruiseLogo], [CruiseBanner], [CruiseCategoryID], [CruisePhoto_Width], [CruisePhoto_Height], [CruiseLogo_Width], [CruiseLogo_Height], [CruiseBanner_Width], [CruiseBanner_Height], [CruiseDeckPlan], [CruiseDeckPlan_Width], [CruiseDeckPlan_Height], [CruisePosition], [CruiseLength], [CruiseWidth], [CruiseHeight], [CruiseOopeningYear], [CruiseRenovationYear], [CruiseReservationEmail], [CruiseGeneralEmail], [CruiseCheckIn], [CruiseCheckout], [WS_Booking], [WS_Expedia], [WS_Agouda], [WS_Facebook], [WS_Instgram], [WS_X], [WS_SnapChat], [WS_TikTok], [WSLinkdIN], [WS_TripAdvisor], [WS_Youtube], [WS_Google], [WS_BrandURL], [Contact_GM_Name], [Contact_GM_Mobile], [Contact_GM_Email], [Contact_Sales_Name], [Contact_Sales_Mobile], [Contact_Sales_Email], [Contact_Reservation_Name], [Contact_Reservation_Mobile], [Contact_Reservation_Email], [Contact_Finance_Name], [Contact_Fininace_Mobile], [Contact_Fininace_Email], [Contact_Marketing_Name], [Contact_Marketing_Mobile], [Contact_Marketing_Email]) VALUES (11, 1, NULL, NULL, N'Iberotel Crown Empress', 1, 128, 5, 30, N'iberotel-crown-empress', N'_18744__3610_brand-dahabeyat.jpg', NULL, N'_12516_bannernonw.jpg', 12, 690, 450, NULL, NULL, 1920, 530, N'_10827_landing-parallax.jpg', NULL, NULL, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises] ([Id], [CruiseLocationID], [CruiseUsername], [CruisePassword], [CruiseNameSys], [CruiseStatus], [CabinNumbers], [DeckNumbers], [BrandID], [CruiseURL], [CruisePhoto], [CruiseLogo], [CruiseBanner], [CruiseCategoryID], [CruisePhoto_Width], [CruisePhoto_Height], [CruiseLogo_Width], [CruiseLogo_Height], [CruiseBanner_Width], [CruiseBanner_Height], [CruiseDeckPlan], [CruiseDeckPlan_Width], [CruiseDeckPlan_Height], [CruisePosition], [CruiseLength], [CruiseWidth], [CruiseHeight], [CruiseOopeningYear], [CruiseRenovationYear], [CruiseReservationEmail], [CruiseGeneralEmail], [CruiseCheckIn], [CruiseCheckout], [WS_Booking], [WS_Expedia], [WS_Agouda], [WS_Facebook], [WS_Instgram], [WS_X], [WS_SnapChat], [WS_TikTok], [WSLinkdIN], [WS_TripAdvisor], [WS_Youtube], [WS_Google], [WS_BrandURL], [Contact_GM_Name], [Contact_GM_Mobile], [Contact_GM_Email], [Contact_Sales_Name], [Contact_Sales_Mobile], [Contact_Sales_Email], [Contact_Reservation_Name], [Contact_Reservation_Mobile], [Contact_Reservation_Email], [Contact_Finance_Name], [Contact_Fininace_Mobile], [Contact_Fininace_Email], [Contact_Marketing_Name], [Contact_Marketing_Mobile], [Contact_Marketing_Email]) VALUES (12, 1, NULL, NULL, N'Steigenberger Legacy', 1, 76, 5, 31, N'steigenberger-legacy', N'_15216__3610_brand-dahabeyat.jpg', NULL, N'_16071_bannernonw.jpg', 12, 690, 450, NULL, NULL, 1920, 530, N'_10827_landing-parallax.jpg', NULL, NULL, 11, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises] ([Id], [CruiseLocationID], [CruiseUsername], [CruisePassword], [CruiseNameSys], [CruiseStatus], [CabinNumbers], [DeckNumbers], [BrandID], [CruiseURL], [CruisePhoto], [CruiseLogo], [CruiseBanner], [CruiseCategoryID], [CruisePhoto_Width], [CruisePhoto_Height], [CruiseLogo_Width], [CruiseLogo_Height], [CruiseBanner_Width], [CruiseBanner_Height], [CruiseDeckPlan], [CruiseDeckPlan_Width], [CruiseDeckPlan_Height], [CruisePosition], [CruiseLength], [CruiseWidth], [CruiseHeight], [CruiseOopeningYear], [CruiseRenovationYear], [CruiseReservationEmail], [CruiseGeneralEmail], [CruiseCheckIn], [CruiseCheckout], [WS_Booking], [WS_Expedia], [WS_Agouda], [WS_Facebook], [WS_Instgram], [WS_X], [WS_SnapChat], [WS_TikTok], [WSLinkdIN], [WS_TripAdvisor], [WS_Youtube], [WS_Google], [WS_BrandURL], [Contact_GM_Name], [Contact_GM_Mobile], [Contact_GM_Email], [Contact_Sales_Name], [Contact_Sales_Mobile], [Contact_Sales_Email], [Contact_Reservation_Name], [Contact_Reservation_Mobile], [Contact_Reservation_Email], [Contact_Finance_Name], [Contact_Fininace_Mobile], [Contact_Fininace_Email], [Contact_Marketing_Name], [Contact_Marketing_Mobile], [Contact_Marketing_Email]) VALUES (13, 1, NULL, NULL, N'Steigenberger Minerva', 1, 77, 5, 31, N'steigenberger-minerva', N'_4459__3610_brand-dahabeyat.jpg', N'_18082_bannernonw.jpg', NULL, 12, 690, 450, 1920, 530, NULL, NULL, N'_10827_landing-parallax.jpg', NULL, NULL, 12, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises] ([Id], [CruiseLocationID], [CruiseUsername], [CruisePassword], [CruiseNameSys], [CruiseStatus], [CabinNumbers], [DeckNumbers], [BrandID], [CruiseURL], [CruisePhoto], [CruiseLogo], [CruiseBanner], [CruiseCategoryID], [CruisePhoto_Width], [CruisePhoto_Height], [CruiseLogo_Width], [CruiseLogo_Height], [CruiseBanner_Width], [CruiseBanner_Height], [CruiseDeckPlan], [CruiseDeckPlan_Width], [CruiseDeckPlan_Height], [CruisePosition], [CruiseLength], [CruiseWidth], [CruiseHeight], [CruiseOopeningYear], [CruiseRenovationYear], [CruiseReservationEmail], [CruiseGeneralEmail], [CruiseCheckIn], [CruiseCheckout], [WS_Booking], [WS_Expedia], [WS_Agouda], [WS_Facebook], [WS_Instgram], [WS_X], [WS_SnapChat], [WS_TikTok], [WSLinkdIN], [WS_TripAdvisor], [WS_Youtube], [WS_Google], [WS_BrandURL], [Contact_GM_Name], [Contact_GM_Mobile], [Contact_GM_Email], [Contact_Sales_Name], [Contact_Sales_Mobile], [Contact_Sales_Email], [Contact_Reservation_Name], [Contact_Reservation_Mobile], [Contact_Reservation_Email], [Contact_Finance_Name], [Contact_Fininace_Mobile], [Contact_Fininace_Email], [Contact_Marketing_Name], [Contact_Marketing_Mobile], [Contact_Marketing_Email]) VALUES (14, 1, NULL, NULL, N'Steigenberger Royale', 0, 52, 5, 31, N'steigenberger-royale', N'_14387__3610_brand-dahabeyat.jpg', NULL, NULL, 12, 690, 450, NULL, NULL, NULL, NULL, N'_10827_landing-parallax.jpg', NULL, NULL, 13, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises] ([Id], [CruiseLocationID], [CruiseUsername], [CruisePassword], [CruiseNameSys], [CruiseStatus], [CabinNumbers], [DeckNumbers], [BrandID], [CruiseURL], [CruisePhoto], [CruiseLogo], [CruiseBanner], [CruiseCategoryID], [CruisePhoto_Width], [CruisePhoto_Height], [CruiseLogo_Width], [CruiseLogo_Height], [CruiseBanner_Width], [CruiseBanner_Height], [CruiseDeckPlan], [CruiseDeckPlan_Width], [CruiseDeckPlan_Height], [CruisePosition], [CruiseLength], [CruiseWidth], [CruiseHeight], [CruiseOopeningYear], [CruiseRenovationYear], [CruiseReservationEmail], [CruiseGeneralEmail], [CruiseCheckIn], [CruiseCheckout], [WS_Booking], [WS_Expedia], [WS_Agouda], [WS_Facebook], [WS_Instgram], [WS_X], [WS_SnapChat], [WS_TikTok], [WSLinkdIN], [WS_TripAdvisor], [WS_Youtube], [WS_Google], [WS_BrandURL], [Contact_GM_Name], [Contact_GM_Mobile], [Contact_GM_Email], [Contact_Sales_Name], [Contact_Sales_Mobile], [Contact_Sales_Email], [Contact_Reservation_Name], [Contact_Reservation_Mobile], [Contact_Reservation_Email], [Contact_Finance_Name], [Contact_Fininace_Mobile], [Contact_Fininace_Email], [Contact_Marketing_Name], [Contact_Marketing_Mobile], [Contact_Marketing_Email]) VALUES (15, 1, NULL, NULL, N'Steigenberger Senator', 0, 17, 4, 31, N'steigenberger-senator', N'_11466__3610_brand-dahabeyat.jpg', NULL, NULL, 12, 690, 450, NULL, NULL, NULL, NULL, N'_10827_landing-parallax.jpg', NULL, NULL, 14, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises] ([Id], [CruiseLocationID], [CruiseUsername], [CruisePassword], [CruiseNameSys], [CruiseStatus], [CabinNumbers], [DeckNumbers], [BrandID], [CruiseURL], [CruisePhoto], [CruiseLogo], [CruiseBanner], [CruiseCategoryID], [CruisePhoto_Width], [CruisePhoto_Height], [CruiseLogo_Width], [CruiseLogo_Height], [CruiseBanner_Width], [CruiseBanner_Height], [CruiseDeckPlan], [CruiseDeckPlan_Width], [CruiseDeckPlan_Height], [CruisePosition], [CruiseLength], [CruiseWidth], [CruiseHeight], [CruiseOopeningYear], [CruiseRenovationYear], [CruiseReservationEmail], [CruiseGeneralEmail], [CruiseCheckIn], [CruiseCheckout], [WS_Booking], [WS_Expedia], [WS_Agouda], [WS_Facebook], [WS_Instgram], [WS_X], [WS_SnapChat], [WS_TikTok], [WSLinkdIN], [WS_TripAdvisor], [WS_Youtube], [WS_Google], [WS_BrandURL], [Contact_GM_Name], [Contact_GM_Mobile], [Contact_GM_Email], [Contact_Sales_Name], [Contact_Sales_Mobile], [Contact_Sales_Email], [Contact_Reservation_Name], [Contact_Reservation_Mobile], [Contact_Reservation_Email], [Contact_Finance_Name], [Contact_Fininace_Mobile], [Contact_Fininace_Email], [Contact_Marketing_Name], [Contact_Marketing_Mobile], [Contact_Marketing_Email]) VALUES (16, 2, NULL, NULL, N'Steigenberger Omar El Khayam', 0, 80, 6, 31, N'steigenberger-omar-el-khayam', N'_1515__3610_brand-dahabeyat.jpg', NULL, N'_2834_bannernonw.jpg', 12, 690, 450, NULL, NULL, 1920, 530, N'_10827_landing-parallax.jpg', NULL, NULL, 15, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises] ([Id], [CruiseLocationID], [CruiseUsername], [CruisePassword], [CruiseNameSys], [CruiseStatus], [CabinNumbers], [DeckNumbers], [BrandID], [CruiseURL], [CruisePhoto], [CruiseLogo], [CruiseBanner], [CruiseCategoryID], [CruisePhoto_Width], [CruisePhoto_Height], [CruiseLogo_Width], [CruiseLogo_Height], [CruiseBanner_Width], [CruiseBanner_Height], [CruiseDeckPlan], [CruiseDeckPlan_Width], [CruiseDeckPlan_Height], [CruisePosition], [CruiseLength], [CruiseWidth], [CruiseHeight], [CruiseOopeningYear], [CruiseRenovationYear], [CruiseReservationEmail], [CruiseGeneralEmail], [CruiseCheckIn], [CruiseCheckout], [WS_Booking], [WS_Expedia], [WS_Agouda], [WS_Facebook], [WS_Instgram], [WS_X], [WS_SnapChat], [WS_TikTok], [WSLinkdIN], [WS_TripAdvisor], [WS_Youtube], [WS_Google], [WS_BrandURL], [Contact_GM_Name], [Contact_GM_Mobile], [Contact_GM_Email], [Contact_Sales_Name], [Contact_Sales_Mobile], [Contact_Sales_Email], [Contact_Reservation_Name], [Contact_Reservation_Mobile], [Contact_Reservation_Email], [Contact_Finance_Name], [Contact_Fininace_Mobile], [Contact_Fininace_Email], [Contact_Marketing_Name], [Contact_Marketing_Mobile], [Contact_Marketing_Email]) VALUES (17, 1, NULL, NULL, N'Steigenberger Regency', 1, 52, 5, 31, N'steigenberger-regency', N'_4804__3610_brand-dahabeyat.jpg', NULL, NULL, 12, 690, 450, NULL, NULL, NULL, NULL, N'_10827_landing-parallax.jpg', NULL, NULL, 16, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Cruises] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Cabins] ON 
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (3, 10, 1, N'Standard Cabin', N'none.jpg', NULL, N'standard-cabin', 1, 1, N'4', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (4, 10, 1, N'Standard Cabin Upper Deck', N'none.jpg', NULL, N'standard-cabin-upper-deck', 1, 2, N'4', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (5, 10, 2, N'Suite', N'none.jpg', NULL, N'suite', 1, 3, N'4', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (6, 11, 1, N'Standard Cabin', N'none.jpg', NULL, N'standard-cabin', 1, 100, N'4', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (7, 11, 1, N'Standard Cabin Upper Deck', N'none.jpg', NULL, N'standard-cabin-upper-deck', 1, 100, N'4', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (8, 11, 2, N'Suite', N'none.jpg', NULL, N'suite', 1, 100, N'4', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (9, 16, 2, N'Grand Suite', N'none.jpg', NULL, N'grand-suite', 1, 100, N'4', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (10, 16, 2, N'Royal Suite', N'none.jpg', NULL, N'royal-suite', 1, 100, N'4', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (11, 16, 1, N'Standard Cabin', N'none.jpg', NULL, N'standard-cabin', 1, 100, N'4', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (12, 12, 1, N'Standard Cabin', N'none.jpg', NULL, N'standard-cabin', 1, 100, N'4', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (13, 12, 1, N'Standard Cabin Upper Deck', N'none.jpg', NULL, N'standard-cabin-upper-deck', 1, 100, N'4', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (14, 12, 2, N'Suite', N'none.jpg', NULL, N'suite', 1, 100, N'4', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (15, 13, 2, N'Suite', N'none.jpg', NULL, N'suite', 1, 100, N'39', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (16, 13, 1, N'Standard Cabin', N'none.jpg', NULL, N'standard-cabin', 1, 100, N'19', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (17, 13, 1, N'Standard Cabin Upper Deck', N'none.jpg', NULL, N'standard-cabin-upper-deck', 1, 100, N'19', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (18, 14, 2, N'Suite', N'none.jpg', NULL, N'suite', 1, 100, N'4', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (19, 15, 2, N'Suite', N'none.jpg', NULL, N'suite', 1, 100, N'4', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (20, 17, 1, N'Standard Cabin', N'none.jpg', NULL, N'standard-cabin', 1, 100, N'4', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (21, 17, 2, N'Suite', N'none.jpg', NULL, N'suite', 1, 100, N'4', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (22, 2, 2, N'Standard Single Cabin', N'jaz-crown-prince_standard-single-cabin_17118_3.jpg', NULL, N'standard-single-cabin', 1, 100, N'4', 690, 450, NULL, NULL, N'', N'', 0)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (24, 4, 1, N'Standard Single Cabin', N'none.jpg', NULL, N'standard-single-cabin', 1, 100, N'4', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (25, 4, 1, N'Standard Twin Cabin', N'none.jpg', NULL, N'standard-twin-cabin', 1, 100, N'4', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (26, 6, 1, N'Standard Cabin', N'none.jpg', NULL, N'standard-cabin', 1, 1, N'19', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (27, 6, 2, N'Suite', N'none.jpg', NULL, N'suite', 1, 100, N'38', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (28, 7, 1, N'Standard Cabin', N'none.jpg', NULL, N'standard-cabin', 1, 100, N'4', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (29, 7, 1, N'Standard Cabin Upper Deck', N'none.jpg', NULL, N'standard-cabin-upper-deck', 1, 100, N'4', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (30, 7, 2, N'Suite', N'none.jpg', NULL, N'suite', 1, 100, N'4', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (31, 8, 1, N'Standard Single Cabin', N'none.jpg', NULL, N'standard-single-cabin', 1, 100, N'4', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (32, 8, 1, N'Standard Twin Cabin', N'none.jpg', NULL, N'standard-twin-cabin', 1, 100, N'4', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (33, 8, 2, N'Suite', N'none.jpg', NULL, N'suite', 1, 100, N'4', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (34, 9, 1, N'Standard Twin Cabin', N'none.jpg', NULL, N'standard-twin-cabin', 1, 100, N'4', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (35, 9, 2, N'Suite', N'none.jpg', NULL, N'suite', 1, 100, N'4', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (40, 3, 1, N'Standard Cabin', N'none.jpg', N'none.jpg', N'standard-cabin', 1, 100, NULL, 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (41, 3, 1, N'Standard Cabin Upper Deck', N'none.jpg', N'none.jpg', N'standard-cabin-upper-deck', 1, 100, NULL, 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (42, 5, 2, N'Suite', N'none.jpg', N'none.jpg', N'suite', 1, 100, NULL, 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (43, 5, 1, N'Standard Twin Cabin', N'none.jpg', N'none.jpg', N'standard-twin-cabin', 1, 100, NULL, 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (44, 5, 1, N'Standard Single Cabin', N'none.jpg', N'none.jpg', N'standard-single-cabin', 1, 100, NULL, 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (45, 14, 1, N'Standard Twin Cabin', N'none.jpg', N'none.jpg', N'standard-twin-cabin', 1, 100, NULL, 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (46, 9, 1, N'Standard Single Cabin', N'none.jpg', N'none.jpg', N'standard-single-cabin', 1, 100, NULL, 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (47, 3, 2, N'Suite', N'none.jpg', N'none.jpg', N'suite', 0, 100, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (48, 6, 1, N'Standard Cabin Upper Deck', N'none.jpg', N'none.jpg', N'standard-cabin-upper-deck', 1, 2, N'19', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (49, 6, 1, N'Suite Upper Deck', N'none.jpg', N'none.jpg', N'suite-upper-deck', 1, 100, N'38', 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (50, 17, 1, N'Standard Cabin Upper Deck', N'none.jpg', N'none.jpg', N'standard-cabin-upper-deck', 1, 100, NULL, 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (51, 7, 1, N'Suite Upper Deck', N'none.jpg', N'none.jpg', N'suite-upper-deck', 1, 100, NULL, 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (52, 16, 2, N'Grand Suite Upper Deck', N'none.jpg', N'none.jpg', N'grand-suite-upper-deck', 1, 100, NULL, 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (53, 16, 2, N'Royal Suite Upper Deck', N'none.jpg', N'none.jpg', N'royal-suite-upper-deck', 1, 100, NULL, 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins] ([Id], [CruiseID], [CabinCategoryTypeID], [CabinNameSys], [CabinPhoto], [CabinBanner], [CabinURL], [CabinStatus], [CabinPosition], [CabinSize], [CabinPhoto_Width], [CabinPhoto_Height], [CabinBanner_Width], [CabinBanner_Height], [CabinMinPax], [CabinMaxPax], [IsUpperDeckCabin]) VALUES (54, 16, 1, N'Standard Cabin Upper Deck', N'none.jpg', N'none.jpg', N'standard-cabin-upper-deck', 0, 100, NULL, 690, 450, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Cabins] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ON 
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (3, 2, 1, 1, N'Jaz Crown Prince', N'  ', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been', N'<p>sdfghjkl;''</p>', N'<p>Dining</p>', N'<p>Rooms</p>', N'<h3 class="card-title" style="color: rgb(73, 80, 87); margin-bottom: var(--bs-card-title-spacer-y);">Activities</h3>', NULL, N'<p>TechnicalSpecifications1<br></p>')
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (4, 2, 2, 0, N'Crown Prince', N'', N'', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (5, 3, 1, 0, N'Jaz Crown Jewel', N' ', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (6, 3, 2, 0, N'Jaz Crown Jewel', N'', N'', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (7, 4, 1, 0, N'Jaz Crown Jubilee', N'', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (8, 4, 2, 0, N'Jaz Crown Jubilee', N'', N'', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (9, 5, 1, 0, N'Jaz Imperial', N'', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (10, 5, 2, 0, N'Jaz Imperial', N'', N'', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (11, 6, 1, 0, N'Jaz Viceroy', N'', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (12, 6, 2, 0, N'Jaz Viceroy', N'', N'', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (13, 7, 1, 0, N'Jaz Regent', N'', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (14, 7, 2, 0, N'Jaz Regent', N'', N'', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (15, 8, 1, 0, N'Jaz Nile Monarch', N'', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (16, 8, 2, 0, N'Jaz Nile Monarch', N'', N'', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (17, 9, 1, 0, N'Jaz Celebrity', N'', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (18, 9, 2, 0, N'Jaz Celebrity', N'', N'', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (19, 10, 1, 1, N'Iberotel Crown Emperor', N'With a spacious sundeck boasting a luxurious swimming pool, 117 beautifully decorated rooms, a stunning reception, and an incredible restaurant serving an eclectic variety of exotic, delectable bites, every corner of Iberotel Crown Emperor is designed for your peace of mind. ', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (20, 10, 2, 0, N'Iberotel Crown Emperor', N'', N'', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (21, 11, 1, 0, N'Iberotel Crown Empress', N'', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (22, 11, 2, 0, N'Iberotel Crown Empress', N'', N'', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (23, 12, 1, 0, N'Steigenberger Legacy', N'', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (24, 12, 2, 0, N'Steigenberger Legacy', N'', N'', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (25, 13, 1, 0, N'Steigenberger Minerva', N'', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (26, 13, 2, 0, N'Steigenberger Minerva', N'', N'', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (27, 14, 1, 0, N'Steigenberger Royale', N'', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (28, 14, 2, 0, N'Steigenberger Royale', N'', N'', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (29, 15, 1, 0, N'Steigenberger Senator', N'', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (30, 15, 2, 0, N'Steigenberger Senator', N'', N'', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (31, 16, 1, 0, N'Steigenberger Omar El Khayam', N'', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (32, 16, 2, 0, N'Steigenberger Omar El Khayam', N'', N'', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (33, 17, 1, 0, N'Steigenberger Regency', N'', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been', N'', N'', N'', N'', N'', NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] ([Id], [CruiseID], [LangID], [ContentLangStatus], [CruiseName], [CruiseDetails], [CruiseIntro], [CruiseOverview], [CruiseDining], [CruiseAccommodation], [CruiseActivities], [CruiseNote], [CruiseTechnicalSpecifications]) VALUES (34, 17, 2, 0, N'Steigenberger Regency', N'', N'', N'', N'', N'', N'', N'', NULL)
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Cruises_Content] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ON 
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (6, 6, N'travco-travel_14369_Viceroy-Exterior-2-202252410.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (7, 6, N'travco-travel_1610_Viceroy-Exterior-202252410.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (8, 6, N'travco-travel_2002_Cabin-202252410.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (9, 6, N'travco-travel_9142_Gym-202252410.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (10, 6, N'travco-travel_9142_Suite-202252410.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (11, 6, N'travco-travel_16282_Suite-Seating-Area-202252410.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (12, 6, N'travco-travel_16282_Upper-Deck-Lounge-2-Viceroy-202252410.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (13, 6, N'travco-travel_16282_Upper-Deck-Lounge-Viceroy-202252410.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (14, 6, N'travco-travel_13026_Viceroy-Bar-Lounge-202252410.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (15, 6, N'travco-travel_13026_Viceroy-Lobby-202252410.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (16, 6, N'travco-travel_13026_Viceroy-Lounge-202252410.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (17, 6, N'travco-travel_266_Viceroy-Lounge-Close-202252410.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (18, 6, N'travco-travel_266_Viceroy-Main-Restaurant-202252410.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (19, 6, N'travco-travel_266_Viceroy-Sundeck-2-202252410.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (20, 6, N'travco-travel_7407_Viceroy-Sundeck-202252410.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (21, 3, N'travco-travel_3879_Exterior.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (22, 3, N'travco-travel_6291_Bar-1.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (23, 3, N'travco-travel_6291_Cabin-1.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (24, 3, N'travco-travel_13431_Cabin-2.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (25, 3, N'travco-travel_13431_Lobby.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (26, 3, N'travco-travel_13431_Sun-Deck-1.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (27, 3, N'travco-travel_10175_Sun-Deck-2.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (28, 7, N'travco-travel_7996_Regent-Exterior-2-20225249.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (29, 7, N'travco-travel_4740_Regent-Exterior-20225249.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (30, 7, N'travco-travel_18501_Cabin-20225249.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (31, 7, N'travco-travel_18501_Gym-20225249.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (32, 7, N'travco-travel_5741_Regent-Bar-Lounge-20225249.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (33, 7, N'travco-travel_2485_Regent-Lobby-20225249.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (34, 7, N'travco-travel_2485_Regent-Lobby-Close-20225249.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (35, 7, N'travco-travel_2485_Regent-Lounge-20225249.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (36, 7, N'travco-travel_9625_Regent-Lounge-Close-20225249.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (37, 7, N'travco-travel_9625_Regent-Main-Restaurant-20225249.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (38, 7, N'travco-travel_6369_Regent-Sundeck-20225249.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (39, 7, N'travco-travel_6369_Regent-Sundeck--20225249.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (40, 7, N'travco-travel_13509_Regent-Upper-Deck-Lounge-2-20225249.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (41, 7, N'travco-travel_13509_Suite-20225249.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (42, 10, N'travco-travel_19121_Cabin-1.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (43, 10, N'travco-travel_19121_Cabin-3.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (44, 10, N'travco-travel_6361_ezgif.com-webp-to-jpg.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (45, 10, N'travco-travel_6361_Lobby.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (46, 10, N'travco-travel_3105_Pool-202191312.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (47, 10, N'travco-travel_3105_Untitled-1.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (48, 10, N'travco-travel_3105_Untitled-2.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (49, 10, N'travco-travel_10245_Untitled-3.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (50, 11, N'travco-travel_19279_Exterior.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (51, 11, N'travco-travel_13098_Bar-1.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (52, 11, N'travco-travel_13098_Bar-202191311.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (53, 11, N'travco-travel_9842_Cabin-1.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (54, 11, N'travco-travel_9842_Cabin-2.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (55, 11, N'travco-travel_9842_Cabin-3.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (56, 11, N'travco-travel_16982_Pool-Luxor-202191311.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (57, 11, N'travco-travel_16982_Pool-side-202191311.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (58, 11, N'travco-travel_16982_Restaurant-202191311.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (59, 11, N'travco-travel_4222_Resturant-1.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (60, 11, N'travco-travel_4222_Resturant-2.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (61, 11, N'travco-travel_966_Sauna-202191311.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (62, 11, N'travco-travel_966_SPA.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (63, 11, N'travco-travel_966_Sun-Deck-1.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (64, 12, N'travco-travel_14607_steigenberger_legacy003.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (65, 12, N'travco-travel_9944_Cabin-queen-bedroom.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (66, 12, N'travco-travel_17084_Cabin-twin-beds.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (67, 12, N'travco-travel_4324_Restaurant.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (68, 12, N'travco-travel_4324_Restaurant-1.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (69, 12, N'travco-travel_4324_Restaurant-2.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (70, 12, N'travco-travel_1068_steigenberger_legacy000.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (71, 12, N'travco-travel_1068_steigenberger_legacy001.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (72, 12, N'travco-travel_8208_steigenberger_legacy005.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (73, 12, N'travco-travel_8208_steigenberger_legacy006.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (74, 12, N'travco-travel_4952_steigenberger_legacy009.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (75, 12, N'travco-travel_4952_steigenberger_legacy010.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (76, 12, N'travco-travel_4952_steigenberger_legacy013.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (77, 12, N'travco-travel_12093_steigenberger_legacy015.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (78, 12, N'travco-travel_12093_steigenberger_legacy016.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (79, 12, N'travco-travel_19233_Suite-Living-Area.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (80, 13, N'travco-travel_6652_steigenberger_minerva002.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (81, 13, N'travco-travel_8217_ezgif.com-webp-to-jpg.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (82, 13, N'travco-travel_15357_steigenberger_minerva003.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (83, 13, N'travco-travel_15357_steigenberger_minerva007.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (84, 13, N'travco-travel_2597_steigenberger_minerva013.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (85, 13, N'travco-travel_2597_steigenberger_minerva017.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (86, 13, N'travco-travel_2597_Suite-Bedroom-Minerva.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (87, 16, N'travco-travel_5708_DSC00362.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (88, 16, N'travco-travel_12848_DSC02008.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (89, 16, N'travco-travel_14696_DSC00111.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (90, 16, N'travco-travel_11440_DSC00138.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (91, 16, N'travco-travel_11440_DSC00155.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (92, 16, N'travco-travel_11440_DSC00875.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (93, 16, N'travco-travel_18580_DSC01098.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (94, 16, N'travco-travel_18580_DSC01117.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (95, 16, N'travco-travel_18580_DSC01167.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (96, 16, N'travco-travel_5820_DSC01247.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (97, 16, N'travco-travel_5820_DSC02090.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (98, 16, N'travco-travel_5820_DSC02235.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (99, 16, N'travco-travel_2564_DSC02404.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (100, 16, N'travco-travel_2564_DSC02502.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (101, 16, N'travco-travel_2564_ezgif.com-webp-to-jpg.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (102, 16, N'travco-travel_9704_ezgif.com-webp-tos-jpg.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (103, 16, N'travco-travel_9704_OmarElkhayam1.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (104, 17, N'travco-travel_5129_SHR-CRUISES-REGENCY-EXTERIOR-CRUISE-EXTERIOR-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (105, 17, N'travco-travel_11621_Regency-Sundeck-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (106, 17, N'travco-travel_11621_SHR-CRUISES-REGENCY-BAR-CHIMMNEY-BAR-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (107, 17, N'travco-travel_8365_SHR-CRUISES-REGENCY-BARS-PANORAMA-BAR-2-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (108, 17, N'travco-travel_8365_SHR-CRUISES-REGENCY-BARS-PANORAMA-BAR-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (109, 17, N'travco-travel_15505_SHR-CRUISES-REGENCY-INTERIOR-FIREPLACE-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (110, 17, N'travco-travel_15505_SHR-CRUISES-REGENCY-INTERIOR-LIBRARY-_2_-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (111, 17, N'travco-travel_15505_SHR-CRUISES-REGENCY-INTERIOR-LIBRARY-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (112, 17, N'travco-travel_2746_SHR-Cruises-Regency-Restaurant-MAIN-RESTAURANT-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (113, 17, N'travco-travel_2746_SHR-CRUISES-REGENCY-ROOMS-BATHROOM-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (114, 17, N'travco-travel_19390_SHR-CRUISES-REGENCY-ROOMS-KING-BEDROOM-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (115, 17, N'travco-travel_19390_SHR-CRUISES-REGENCY-ROOMS-SUITE-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (116, 17, N'travco-travel_19390_SHR-CRUISES-REGENCY-ROOMS-SUITE-BED-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (117, 17, N'travco-travel_6630_SHR-Cruises-Regency-Rooms-Twin-Room-2-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (118, 17, N'travco-travel_6630_SHR-Cruises-Regency-Rooms-Twin-Room-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (119, 17, N'travco-travel_6630_SHR-CRUISES-REGENECY-BAR-CHIMMNEY-BAR-2-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (126, 4, N'travco-travel_1097_Exterior-1.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (127, 4, N'travco-travel_12232_Bar-1.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (128, 4, N'travco-travel_12232_Cabin-1.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (129, 4, N'travco-travel_19372_Lobby.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (130, 4, N'travco-travel_19372_Restaurant-1.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (131, 4, N'travco-travel_16116_Restaurant-2.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (132, 4, N'travco-travel_16116_Sun-Deck-1.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (133, 5, N'travco-travel_11912_Exterior-1.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (134, 5, N'travco-travel_9333_Cabin-1.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (135, 5, N'travco-travel_16474_ezgif.com-webp-to-jpg_7_.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (136, 5, N'travco-travel_16474_lobby-1.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (137, 5, N'travco-travel_13218_lobby-2.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (138, 5, N'travco-travel_13218_Lounge-bar-1.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (139, 5, N'travco-travel_13218_Lounge-bar-2.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (140, 5, N'travco-travel_458_pool.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (141, 5, N'travco-travel_458_resturant.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (142, 8, N'travco-travel_5194_ezgif.com-webp-to-jpg_4_.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (143, 8, N'travco-travel_12334_ezgif.com-webp-to-jpg_5_.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (144, 8, N'travco-travel_3569_ezgif.com-webp-to-jpg_1_.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (145, 8, N'travco-travel_10709_ezgif.com-webp-to-jpg_2_.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (146, 8, N'travco-travel_17849_ezgif.com-webp-to-jpg_3_.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (147, 8, N'travco-travel_17849_ezgif.com-webp-to-jpg_6_.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (148, 8, N'travco-travel_14593_ezgif.com-webp-to-jpg_7_.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (149, 8, N'travco-travel_1833_ezgif.com-webp-to-jpg_8_.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (150, 8, N'travco-travel_1833_ezgif.com-webp-to-jpg_9_.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (151, 8, N'travco-travel_8973_ezgif.com-webp-to-jpg_10_.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (152, 8, N'travco-travel_8973_ezgif.com-webp-to-jpg_11_.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (153, 8, N'travco-travel_5717_ezgif.com-webp-to-jpg.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (154, 9, N'travco-travel_3556_ezgif.com-webp-to-jpg.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (155, 9, N'travco-travel_8028_ezgif.com-webp-to-jpg_1_.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (156, 9, N'travco-travel_15168_ezgif.com-webp-to-jpg_2_.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (157, 9, N'travco-travel_11912_ezgif.com-webp-to-jpg_3_.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (158, 9, N'travco-travel_11912_ezgif.com-webp-to-jpg_4_.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (159, 9, N'travco-travel_19053_ezgif.com-webp-to-jpg_5_.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (160, 9, N'travco-travel_15797_ezgif.com-webp-to-jpg_6_.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (161, 14, N'travco-travel_17742_Untitled-1.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (162, 14, N'travco-travel_11409_Royale-Sundeck-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (163, 14, N'travco-travel_8153_SHR-CRUISES-Royale-BAR-CHIMMNEY-BAR-2-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (164, 14, N'travco-travel_8153_SHR-CRUISES-Royale-BAR-CHIMMNEY-BAR-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (165, 14, N'travco-travel_15293_SHR-CRUISES-Royale-BARS-PANORAMA-BAR-2-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (166, 14, N'travco-travel_15293_SHR-CRUISES-Royale-BARS-PANORAMA-BAR-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (167, 14, N'travco-travel_15293_SHR-CRUISES-Royale-INTERIOR-FIREPLACE-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (168, 14, N'travco-travel_2533_SHR-CRUISES-Royale-INTERIOR-LIBRARY-_2_-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (169, 14, N'travco-travel_2533_SHR-CRUISES-Royale-INTERIOR-LIBRARY-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (170, 14, N'travco-travel_19177_SHR-Cruises-Royale-Restaurant-MAIN-RESTAURANT-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (171, 14, N'travco-travel_19177_SHR-CRUISES-Royale-ROOMS-BATHROOM-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (172, 14, N'travco-travel_6417_SHR-CRUISES-Royale-ROOMS-KING-BEDROOM-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (173, 14, N'travco-travel_6417_SHR-CRUISES-Royale-ROOMS-SUITE-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (174, 14, N'travco-travel_6417_SHR-CRUISES-Royale-ROOMS-SUITE-BED-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (175, 14, N'travco-travel_3161_SHR-Cruises-Royale-Rooms-Twin-Room-2-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (176, 14, N'travco-travel_3161_SHR-Cruises-Royale-Rooms-Twin-Room-202181712.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (177, 15, N'travco-travel_14497_1.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (178, 15, N'travco-travel_11241_2.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (179, 15, N'travco-travel_11241_3.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (180, 15, N'travco-travel_18381_4.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (181, 15, N'travco-travel_18381_5.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (182, 15, N'travco-travel_15125_6.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (183, 15, N'travco-travel_15125_7.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (184, 15, N'travco-travel_15125_8.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (185, 15, N'travco-travel_2366_9.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (186, 15, N'travco-travel_2366_10.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (187, 15, N'travco-travel_9506_11.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (188, 15, N'travco-travel_9506_12.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (189, 15, N'travco-travel_9506_13.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (190, 15, N'travco-travel_6250_14-Gym.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (191, 15, N'travco-travel_6250_15.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (192, 15, N'travco-travel_13390_16.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (193, 15, N'travco-travel_13390_Bathroom.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (194, 15, N'travco-travel_13390_Pool-10.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (195, 15, N'travco-travel_630_Sun-deck-11.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (196, 15, N'travco-travel_630_Sun-deck-12.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (197, 15, N'travco-travel_17274_Views-042-c.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (198, 15, N'travco-travel_17274_Views-052.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (199, 15, N'travco-travel_17274_Views-053.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (200, 15, N'travco-travel_4514_Views-055.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (201, 15, N'travco-travel_4514_Views-058.jpg', 100, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (211, 2, N'jaz-crown-prince_4317_Church-of-St.-Sergius-1200x900.jpg', 100, 1, 900, 1200)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (212, 2, N'jaz-crown-prince_14234_Colossi-of-Memnon.jpg', 100, 1, 460, 600)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] ([Id], [CruiseID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (213, 2, N'jaz-crown-prince_1474_edfu1.jpg', 100, 1, 460, 600)
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Cruises_Photos] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Dining] ON 
GO
INSERT [dbo].[tbl_CruiseBooking_Dining] ([Id], [CruiselID], [DiningName], [DiningHours], [DiningDescription], [IsDeleted], [DressCode], [DiningCuisine], [DiningOpenFor], [DiningMenu], [DiningFolderName], [DiningPhoto], [DiningCategoryTypeID], [DiningURL]) VALUES (1, 2, N'Test Name1', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, N'jaz-crown-prince_test-name1_15170_edfu3.jpg', 1, N'test-name1')
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Dining] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Master_Facilities_Categories] ON 
GO
INSERT [dbo].[tbl_Master_Facilities_Categories] ([Id], [FacilityCategory]) VALUES (12, N'General')
GO
INSERT [dbo].[tbl_Master_Facilities_Categories] ([Id], [FacilityCategory]) VALUES (13, N'Reception Services')
GO
INSERT [dbo].[tbl_Master_Facilities_Categories] ([Id], [FacilityCategory]) VALUES (14, N'Safety & security')
GO
INSERT [dbo].[tbl_Master_Facilities_Categories] ([Id], [FacilityCategory]) VALUES (15, N'Languages spoken')
GO
INSERT [dbo].[tbl_Master_Facilities_Categories] ([Id], [FacilityCategory]) VALUES (16, N'Cleaning services')
GO
INSERT [dbo].[tbl_Master_Facilities_Categories] ([Id], [FacilityCategory]) VALUES (17, N'Food & Drink')
GO
INSERT [dbo].[tbl_Master_Facilities_Categories] ([Id], [FacilityCategory]) VALUES (18, N'Outdoor swimming pool')
GO
INSERT [dbo].[tbl_Master_Facilities_Categories] ([Id], [FacilityCategory]) VALUES (19, N'Wellness')
GO
INSERT [dbo].[tbl_Master_Facilities_Categories] ([Id], [FacilityCategory]) VALUES (20, N'Methods of payment')
GO
INSERT [dbo].[tbl_Master_Facilities_Categories] ([Id], [FacilityCategory]) VALUES (21, N'Business facilities')
GO
SET IDENTITY_INSERT [dbo].[tbl_Master_Facilities_Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Master_Facilties] ON 
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (1, 12, N'Shuttle service', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (2, 12, N'Carbon monoxide detector', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (3, 12, N'Shared lounge/TV area', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (4, 12, N'Electric blankets', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (5, 12, N'Hypoallergenic', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (6, 12, N'Air conditioning', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (7, 12, N'Non-smoking throughout', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (8, 12, N'Allergy-free room', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (9, 12, N'Wake-up service', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (10, 12, N'Hardwood or parquet floors', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (11, 12, N'Heating', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (12, 12, N'Soundproofing', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (13, 12, N'Private entrance', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (14, 12, N'Carpeted', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (15, 12, N'Soundproof rooms', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (16, 12, N'Fan', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (17, 12, N'Family rooms', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (18, 12, N'Airport shuttle', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (19, 12, N'Additional charge', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (20, 12, N'Non-smoking rooms', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (21, 12, N'Wake up service/Alarm clock', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (22, 12, N'Room service', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (23, 13, N'Lockers', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (24, 13, N'Private check-in/check-out', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (25, 13, N'Concierge service', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (26, 13, N'Luggage storage', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (27, 13, N'Tour desk', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (28, 13, N'Express check-in/check-out', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (29, 13, N'24-hour front desk', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (30, 14, N'Fire extinguishers', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (31, 14, N'CCTV outside property', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (32, 14, N'CCTV in common areas', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (33, 14, N'Smoke alarms', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (34, 14, N'Security alarm', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (35, 14, N'Key card access', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (36, 14, N'Key access', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (37, 14, N'24-hour security', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (38, 14, N'Safety deposit box', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (39, 15, N'Arabic', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (40, 15, N'German', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (41, 15, N'English', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (42, 15, N'Spanish', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (43, 15, N'French', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (44, 15, N'Russian', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (45, 15, N'Italian', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (46, 16, N'Daily housekeeping', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (47, 16, N'Ironing service', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (48, 16, N'Dry cleaning', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (49, 17, N'Coffee house on site', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (50, 17, N'Fruits', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (51, 17, N'Wine/champagne', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (52, 17, N'Snack bar', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (53, 17, N'Bar', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (54, 17, N'Minibar', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (55, 17, N'Restaurant', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (56, 18, N'Open all year', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (57, 18, N'Adult only', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (58, 18, N'Pool is on rooftop', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (59, 18, N'Pool/beach towels', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (60, 18, N'Sun loungers or beach chairs', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (61, 19, N'Kids'' pool', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (62, 19, N'Spa/wellness packages', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (63, 19, N'Spa lounge/relaxation area', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (64, 19, N'Spa facilities', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (65, 19, N'Sun umbrellas', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (66, 19, N'Sun loungers or beach chairs', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (67, 19, N'Public Bath', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (68, 19, N'Open-air bath', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (69, 19, N'Hammam', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (70, 19, N'Spa and wellness centre', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (71, 19, N'Sauna', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (72, 20, N'Eurocard', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (73, 20, N'Cash', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (74, 20, N'Visa', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (75, 20, N'MasterCard', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (76, 20, N'American Express', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (77, 20, N'Diners club', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (78, 21, N'Fax/photocopying', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (79, 21, N'Business centre', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (81, 21, N'Meeting/banquet facilities', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (82, 15, N'Brazilian portuguese', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (83, 15, N'Bulgarian', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (84, 15, N'Catalan', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (85, 15, N'Chinese', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (86, 15, N'Croatian', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (87, 15, N'Czech', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (88, 15, N'Danish', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (89, 15, N'Dutch', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (90, 15, N'Estonian', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (91, 15, N'Finnish', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (92, 15, N'Greek', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (93, 15, N'Hebrew', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (94, 15, N'Hungarian', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (95, 15, N'Icelandic', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (96, 15, N'Indonesian', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (97, 15, N'Japanese', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (98, 15, N'Korean', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (99, 15, N'Latvian', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (100, 15, N'Lithuanian', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (101, 15, N'Norwegian nynorsk', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (102, 15, N'Persian', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (103, 15, N'Polish', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (104, 15, N'Portuguese', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (105, 15, N'Romanian', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (106, 15, N'Serbian', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (107, 15, N'Slovak', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (108, 15, N'Slovenian', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (109, 15, N'Swedish', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (110, 15, N'Thai', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (111, 15, N'Turkish', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (112, 15, N'Vietnamese', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (116, 20, N'JCB', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (117, 20, N'Discover', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (118, 20, N'Cirrus / Maestro', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (119, 20, N'Blanche', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (120, 20, N'Diners', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (121, 20, N'Union pay', NULL)
GO
INSERT [dbo].[tbl_Master_Facilties] ([Id], [FacilityCategoryID], [FacilityName], [FacilityNote]) VALUES (122, 20, N'JPN', NULL)
GO
SET IDENTITY_INSERT [dbo].[tbl_Master_Facilties] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Cruises_Facilities] ON 
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Facilities] ([Id], [FacilitiyID], [CruiseID], [ExtraCostTypeID], [FacilityCategoryID]) VALUES (3, 39, 2, 1, 15)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruises_Facilities] ([Id], [FacilitiyID], [CruiseID], [ExtraCostTypeID], [FacilityCategoryID]) VALUES (4, 82, 2, 1, 15)
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Cruises_Facilities] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ON 
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (5, 3, 1, 1, N'Standard Cabin', N'Our large panoramic windows bring in sunlight streaming into your cabin space of 19m2. These air-conditioned abodes are fitted with HD TV for entertainment that will keep you hooked to your cabin. With calm blue water on the outside and refreshing bath in our exquisite bathtubs - our single cabins have been made to be an oasis of rejuvenation. ', N'Our large panoramic windows bring in sunlight streaming into your cabin space of 19m2. These air-conditioned abodes are fitted with HD TV for entertainment that will keep you hooked to your cabin. With calm blue water on the outside and refreshing bath in our exquisite bathtubs - our single cabins have been made to be an oasis of rejuvenation.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (6, 3, 2, 0, N'Standard Cabin', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (7, 4, 1, 1, N'Standard Cabin Upper Deck', N'Fully sophisticated, 19sqm twin cabin comes with the most refined furnishings bringing you blissful sunrise views. Ease into the comfort of our air-conditioned cabins, with TV and other superior amenities. Immerse in our bathtubs to have the most revitalizing bath to refresh your mood for the day. ', N'Fully sophisticated, 19sqm twin cabin comes with the most refined furnishings bringing you blissful sunrise views. Ease into the comfort of our air-conditioned cabins, with TV and other superior amenities. Immerse in our bathtubs to have the most revitalizing bath to refresh your mood for the day.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (8, 4, 2, 0, N'Standard Cabin Upper Deck', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (9, 5, 1, 1, N'Suite', N'Our suites are designed with bespoke furnishings that spell luxury like no other. Separate seating area with a private balcony brings you the picturesque view of the Nile. Sip on your coffee as you absorb this view while being nestled in your bed. Our Air conditioned palatial suites come with a sleek TV for entertainment and grand bathtubs that will help you indulge in an unwinding sauna. ', N'Our suites are designed with bespoke furnishings that spell luxury like no other. Separate seating area with a private balcony brings you the picturesque view of the Nile. Sip on your coffee as you absorb this view while being nestled in your bed. Our Air conditioned palatial suites come with a sleek TV for entertainment and grand bathtubs that will help you indulge in an unwinding sauna.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (10, 5, 2, 0, N'Suite', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (11, 6, 1, 1, N'Standard Twin Cabin', N'Our cabins are a personal retreat that brings you shades of warmth as you traverse through the day. Dreamy mornings in our air conditioned cabins of 19m2 with TV and Wifi, is a unique experience of its own. Fall asleep under the starry night and unwind in the choicest bathtubs as you journey on a self-pamper mode. ', N'Our cabins are a personal retreat that brings you shades of warmth as you traverse through the day. Dreamy mornings in our air conditioned cabins of 19m2 with TV and Wifi, is a unique experience of its own. Fall asleep under the starry night and unwind in the choicest bathtubs as you journey on a self-pamper mode.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (12, 6, 2, 0, N'Standard Twin Cabin', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (13, 7, 1, 1, N'Standard Cabin Upper Deck', N'Our single cabins are generously designed spaces of 19m2, your very own personal retreat with indulgent facilities. Spend days in tranquility in our air conditioned cabins with TV and wifi to keep you entertained. Drift to sleep after long rejuvenating showers in our spacious bathtubs with the best of amenities. Enjoy the serene blues of the Nile as our Crown Empress wades through the waters - redefining luxury cruising experience.  ', N'Our single cabins are generously designed spaces of 19m2, your very own personal retreat with indulgent facilities. Spend days in tranquility in our air conditioned cabins with TV and wifi to keep you entertained. Drift to sleep after long rejuvenating showers in our spacious bathtubs with the best of amenities. Enjoy the serene blues of the Nile as our Crown Empress wades through the waters - redefining luxury cruising experience.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (14, 7, 2, 0, N'Standard Single Cabin', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (15, 8, 1, 1, N'Suite', N'Nothing states luxury better than our suites. A sanctuary to view the waves of serenity from our panoramic windows in air conditioned suites of 38m2. Wifi and TV ensure you are entertained throughout the day nestled in the warmth of these spaces. A relaxing bath in our bathtub will be an absolute haven of peace. Escape into a world of your own while cruising with us on Crown Empress. ', N'Nothing states luxury better than our suites. A sanctuary to view the waves of serenity from our panoramic windows in air conditioned suites of 38m2. Wifi and TV ensure you are entertained throughout the day nestled in the warmth of these spaces. A relaxing bath in our bathtub will be an absolute haven of peace. Escape into a world of your own while cruising with us on Crown Empress.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (16, 8, 2, 0, N'Suite', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (17, 9, 1, 1, N'Grand Suite', N'Our Grand suites stand true to their name. Lavishly designed in spaces of 35m2 and adorned in plush fabrics and furnishings, these suites make for a cozy haven. Enjoy the tranquility of the Nile and the expansive skies through our palatial private balcony. Uninterrupted entertainment is made available through the TV and Wifi service available in Aswan &amp; Abu Simbel. Sojourn in our magnificent suites for a royal cruising experience. ', N'Our Grand suites stand true to their name. Lavishly designed in spaces of 35m2 and adorned in plush fabrics and furnishings, these suites make for a cozy haven. Enjoy the tranquility of the Nile and the expansive skies through our palatial private balcony. Uninterrupted entertainment is made available through the TV and Wifi service available in Aswan & Abu Simbel. Sojourn in our magnificent suites for a royal cruising experience.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (18, 9, 2, 0, N'Grand Suite', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (19, 10, 1, 1, N'Royal Suite', N'Our royal suites will give you the perfect luxurious experience, Dipped in Excellency. Tasteful furnishings, rich interiors and separate seating and dining areas echo grandeur through every detail. Our oversized suites of 70m2 are air-conditioned and equipped with TV and Wifi service available in Aswan &amp; Abu Simbel. The Jacuzzi in the private bathtubs highlights cruising in these suites. They make you want to never step out of your haven of relaxation. Perch on the Nile-view balcony to enjoy the most captivating sights of the Nile and the cities along the banks of it. Enjoy tailor-made cruising like a royal in a world of your own. ', N'Our royal suites will give you the perfect luxurious experience, Dipped in Excellency. Tasteful furnishings, rich interiors and separate seating and dining areas echo grandeur through every detail. Our oversized suites of 70m2 are air-conditioned and equipped with TV and Wifi service available in Aswan & Abu Simbel. The Jacuzzi in the private bathtubs highlights cruising in these suites. They make you want to never step out of your haven of relaxation. Perch on the Nile-view balcony to enjoy the most captivating sights of the Nile and the cities along the banks of it. Enjoy tailor-made cruising like a royal in a world of your own.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (20, 10, 2, 0, N'Royal Suite', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (21, 11, 1, 1, N'Standard Cabin', N'Our double cabins are luxury at its best. Spaciously designed in 24m2, our air conditioned cabins are furnished in tasteful interiors that will leave you enchanted. High-definition TV, Wifi service available in Aswan &amp; Abu Simbel are accessible from the comfort of your bed that will keep you entertained. A long, unwinding shower in the bathtub will ensure you are ever-ready. A personal balcony space brings you the view of the Nile - a beauty to behold. At Omar El Khayam, experience a unique cruising that has been designed to suit every traveler needs.  ', N'Our double cabins are luxury at its best. Spaciously designed in 24m2, our air conditioned cabins are furnished in tasteful interiors that will leave you enchanted. High-definition TV, Wifi service available in Aswan & Abu Simbel are accessible from the comfort of your bed that will keep you entertained. A long, unwinding shower in the bathtub will ensure you are ever-ready. A personal balcony space brings you the view of the Nile - a beauty to behold. At Omar El Khayam, experience a unique cruising that has been designed to suit every traveler needs.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (22, 11, 2, 0, N'Standard Twin Cabin', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (23, 12, 1, 1, N'Standard Cabin', N'Our Single cabins reflect the Egyptian colors, patterns and prints across the furnishings. Spaciously proportioned cabins of 19m2, air conditioned and decked with high-end amenities mirror sophistication. Large sliding windows bring you the gorgeous view of the Nile to enjoy from the comfort of your mattress. Experience the best bathing experience with our private bathrooms that come with modern amenities. Our cabins are a setting that will immerse you into the local culture right from the moment you step aboard.  ', N'Our Single cabins reflect the Egyptian colors, patterns and prints across the furnishings. Spaciously proportioned cabins of 19m2, air conditioned and decked with high-end amenities mirror sophistication. Large sliding windows bring you the gorgeous view of the Nile to enjoy from the comfort of your mattress. Experience the best bathing experience with our private bathrooms that come with modern amenities. Our cabins are a setting that will immerse you into the local culture right from the moment you step aboard.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (24, 12, 2, 0, N'Standard Single Cabin', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (25, 13, 1, 1, N'Standard Cabin Upper Deck', N'Draped of luxury with the most superior features, our double cabins are a work of art. They come with the finest of features in generously spaced out air-conditioned cabins of 19m2 with private shower spaces. Perch over our large panoramic windows and soak in the views of the Nile while pampering yourself in the comfort of our cabins. Our cabins are crafted to make your journey truly memorable.  ', N'Draped of luxury with the most superior features, our double cabins are a work of art. They come with the finest of features in generously spaced out air-conditioned cabins of 19m2 with private shower spaces. Perch over our large panoramic windows and soak in the views of the Nile while pampering yourself in the comfort of our cabins. Our cabins are crafted to make your journey truly memorable.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (26, 13, 2, 0, N'Standard Twin Cabin', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (27, 14, 1, 1, N'Suite', N'Dipped in luxury, our suites are over 39m2, air-conditioned with private balconies, bringing you the breathtaking view of the Nile. A seating area comes with a sleek TV for in-suite entertainment. Treat yourself with the most relaxing experience that comes with our spacious bathtub and Jacuzzi. We redefine luxury cruising for you. ', N'Dipped in luxury, our suites are over 39m2, air-conditioned with private balconies, bringing you the breathtaking view of the Nile. A seating area comes with a sleek TV for in-suite entertainment. Treat yourself with the most relaxing experience that comes with our spacious bathtub and Jacuzzi. We redefine luxury cruising for you.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (28, 14, 2, 0, N'Suite', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (29, 15, 1, 1, N'Suite', N'Red-carpet-like welcome to our palatial suites in deep red is what awaits you at Steigenberger Minerva. Escape into your personal world, in generous air conditioned suites of 39m2. Designed furnishings with mood lighting evolve to match the different moods of the day. Our suites come with sleek TV, Wifi and a Jacuzzi in the private bathrooms that elevates your entire cruising experience. ', N'Red-carpet-like welcome to our palatial suites in deep red is what awaits you at Steigenberger Minerva. Escape into your personal world, in generous air conditioned suites of 39m2. Designed furnishings with mood lighting evolve to match the different moods of the day. Our suites come with sleek TV, Wifi and a Jacuzzi in the private bathrooms that elevates your entire cruising experience.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (30, 15, 2, 0, N'Suite', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (31, 16, 1, 1, N'Standard Cabin', N'An abode of relaxation, our single cabins are 19m2 air conditioned spaces welcoming you with warmth. Indulge in the comfort of the cabins as you enjoy the spell-binding view of the Nile and the other amenities like TV and Wifi. A chic palette blending warm tones with neutral, earthy shades color the cabin and the luxurious private bathrooms. Experience sophistication at cruising along the Nile, like no other, with us at Steigenberger Minerva.  ', N'An abode of relaxation, our single cabins are 19m2 air conditioned spaces welcoming you with warmth. Indulge in the comfort of the cabins as you enjoy the spell-binding view of the Nile and the other amenities like TV and Wifi. A chic palette blending warm tones with neutral, earthy shades color the cabin and the luxurious private bathrooms. Experience sophistication at cruising along the Nile, like no other, with us at Steigenberger Minerva.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (32, 16, 2, 0, N'Standard Single Cabin', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (33, 17, 1, 1, N'Standard Cabin Upper Deck', N'Imbued in sophistication with custom-made furnishings, chic lighting, private bathrooms. Nothing reflects luxury better than our Double cabins. Our Spacious cabins of 19m2, come air conditioned and equipped with features like TV and Wifi. Indulge in plush amenities of the cabin and unwind in our shower. Be mesmerized by the Nile with every passing day, as we captivate you with our unparalleled cruising experience.  ', N'Imbued in sophistication with custom-made furnishings, chic lighting, private bathrooms. Nothing reflects luxury better than our Double cabins. Our Spacious cabins of 19m2, come air conditioned and equipped with features like TV and Wifi. Indulge in plush amenities of the cabin and unwind in our shower. Be mesmerized by the Nile with every passing day, as we captivate you with our unparalleled cruising experience.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (34, 17, 2, 0, N'Standard Twin Cabin', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (35, 18, 1, 1, N'Suite', N'Our suites set new standards of luxury bringing the best of both worlds. Soak in the beauty of the Nile and the picturesque landscape along the course from our large windows. Laze the day browsing through TV or Wifi while being nestled in the comforts of the suites. Retire for the day with a rejuvenating bath that comes with the most refined features. Our suites are your personal retreat in the serene blue waters of the Nile. ', N'Our suites set new standards of luxury bringing the best of both worlds. Soak in the beauty of the Nile and the picturesque landscape along the course from our large windows. Laze the day browsing through TV or Wifi while being nestled in the comforts of the suites. Retire for the day with a rejuvenating bath that comes with the most refined features. Our suites are your personal retreat in the serene blue waters of the Nile.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (36, 18, 2, 0, N'Suite', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (37, 19, 1, 1, N'Suite', N'Our suites are a haven of sheer luxury, boasting rich and elegant furnishing. Generously designed air-conditioned suites of 32m2 come with a sleek TV and Wifi. Our suites are private seclusion with superior amenities ensuring you never have a reason to step out. Wake up to mesmerizing views of the Nile that you can relish over a cup of tea from your private balcony. Step in our private bathtubs for a long, unwinding shower that soothes you to sleep. Discover the quiet side of life cruising with us at Steigenberger Senator ', N'Our suites are a haven of sheer luxury, boasting rich and elegant furnishing. Generously designed air-conditioned suites of 32m2 come with a sleek TV and Wifi. Our suites are private seclusion with superior amenities ensuring you never have a reason to step out. Wake up to mesmerizing views of the Nile that you can relish over a cup of tea from your private balcony. Step in our private bathtubs for a long, unwinding shower that soothes you to sleep. Discover the quiet side of life cruising with us at Steigenberger Senator')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (38, 19, 2, 0, N'Suite', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (39, 20, 1, 1, N'Standard Cabin', N'Inspired from the luxury theme, our Double cabins are your home-away-from-home. Neutral shades of drapes, choicest furnishing and mood lights are bound to accentuate your spirit. Perch on our large window rails and soak in the view of the beautiful Nile. Our cabins are air conditioned and come in sizes of 19.5m2 featuring a TV and wifi. Retire for the day after a relaxing bath in our private bathrooms.  ', N'Inspired from the luxury theme, our Double cabins are your home-away-from-home. Neutral shades of drapes, choicest furnishing and mood lights are bound to accentuate your spirit. Perch on our large window rails and soak in the view of the beautiful Nile. Our cabins are air conditioned and come in sizes of 19.5m2 featuring a TV and wifi. Retire for the day after a relaxing bath in our private bathrooms.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (40, 20, 2, 0, N'Standard Twin Cabin', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (41, 21, 1, 1, N'Suite', N'Our suites are the perfect union of modernity and luxury coming in space of 35m2. Decked in warm earthy tones, they soothe you to sleep. Our suites come with top-of-the-art features like a sleek TV, Wifi and air conditioner. Have a rejuvenating shower in our private bathrooms and fall asleep under the night sky. Embark with us at Steigenberger Regency for a dreamy stay-cation of luxury. ', N'Our suites are the perfect union of modernity and luxury coming in space of 35m2. Decked in warm earthy tones, they soothe you to sleep. Our suites come with top-of-the-art features like a sleek TV, Wifi and air conditioner. Have a rejuvenating shower in our private bathrooms and fall asleep under the night sky. Embark with us at Steigenberger Regency for a dreamy stay-cation of luxury.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (42, 21, 2, 0, N'Suite', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (43, 22, 1, 1, N'Standard Single Cabin', N'A pop of colour accompanied by superior interiors - our single cabins make for the perfect setting for any time of the day. Air conditioned cabins of 19m2, decked with ultra-slim TV, wifi, minibar and private bathroom ensure you find your home when cruising the Nile. With our large windows in the cabin, wake-up to the beautiful view of the river Nile every morning - a sight to behold. Our Jaz Crown Prince is your personal sanctuary at Nile. ', N'A pop of colour accompanied by superior interiors - our single cabins make for the perfect setting for any time of the day. ')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (44, 22, 2, 0, N'Standard Single Cabin', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (47, 24, 1, 0, N'Standard Single Cabin', N'Revel in contemporary interiors of an air conditioned space of 19m2 decked with high-definition TV and Wifi for in-cabin entertainment along with a minibar. Sink into the comforts of the bedspace and the private bathroom settings promising you an elegant stay. Our Single cabins elevate your cruising experience with a panoramic view of the Nile all day long. ', N'Revel in contemporary interiors of an air conditioned space of 19m2 decked with high-definition TV and Wifi for in-cabin entertainment along with a minibar. Sink into the comforts of the bedspace and the private bathroom settings promising you an elegant stay. Our Single cabins elevate your cruising experience with a panoramic view of the Nile all day long.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (48, 24, 2, 0, N'Standard Single Cabin', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (49, 25, 1, 0, N'Standard Twin Cabin', N'Rejuvenate and rediscover the beauty of life in our double cabins of 19m2. They are air conditioned and tucked-in with private bathrooms for a sophisticated stay. Bask in the glory of the Nile from our panoramic windows. The cabins are also furnished with a modern TV and Wifi, and a minibar, making it irresistible to leave the cabin. We aim to bring a new kind of being in paradise with our cruising experience. ', N'Rejuvenate and rediscover the beauty of life in our double cabins of 19m2. They are air conditioned and tucked-in with private bathrooms for a sophisticated stay. Bask in the glory of the Nile from our panoramic windows. The cabins are also furnished with a modern TV and Wifi, and a minibar, making it irresistible to leave the cabin. We aim to bring a new kind of being in paradise with our cruising experience.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (50, 25, 2, 0, N'Standard Twin Cabin', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (51, 26, 1, 1, N'Standard Cabin', N'Our cabins are wrapped in luxury with the superior features. They are a piece of fine skill mirrored in the interiors and furnishings. Air conditioned cabins of 19m2 are equipped with minibar, TV and wifi fitted for entertainment. Perch over the panoramic windows as the gorgeous Nile sweeps you off your feet. Step-in our private bathrooms for the most revitalizing showers. Cruise with us and take back with you some of the most cherished family moments.  ', N'Our cabins are wrapped in luxury with the superior features. They are a piece of fine skill mirrored in the interiors and furnishings. Air conditioned cabins of 19m2 are equipped with minibar, TV and wifi fitted for entertainment. Perch over the panoramic windows as the gorgeous Nile sweeps you off your feet. Step-in our private bathrooms for the most revitalizing showers. Cruise with us and take back with you some of the most cherished family moments.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (52, 26, 2, 0, N'Standard Twin Cabin', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (53, 27, 1, 1, N'Suite', N'Soaked in luxury, our air conditioned suites are over 38m2. They are designed with private balconies that bring you the most dazzling view of the Nile. The seating area comes with a minibar, sleek TV using Marine satellite and Wifi for in-suite entertainment. Treat yourself to the most refreshing showers from our private bathrooms that help with unwinding. We bring the world to you, making it accessible from the comfort of your suites. ', N'Soaked in luxury, our air conditioned suites are over 38m2. They are designed with private balconies that bring you the most dazzling view of the Nile. The seating area comes with a minibar, sleek TV using Marine satellite and Wifi for in-suite entertainment. Treat yourself to the most refreshing showers from our private bathrooms that help with unwinding. We bring the world to you, making it accessible from the comfort of your suites.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (54, 27, 2, 0, N'Suite', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (55, 28, 1, 1, N'Standard Cabin', N'Enjoy tranquility and peace with us, away from the chaos of the city. Join us on-board Jaz Regent with air conditioned cabins designed in elaborate spaces of 19m2. These cabins come with the superior features like TV, wifi and minibar that will keep you entertained throughout the cruise. Indulge in a soothing, long bath in our private bathrooms. Let your day start and end with the most calming views of the Nile from our panoramic windows. Bringing you the beauty of living in the moment, we bring you the finest experience in cruising.  ', N'Enjoy tranquility and peace with us, away from the chaos of the city. Join us on-board Jaz Regent with air conditioned cabins designed in elaborate spaces of 19m2. These cabins come with the superior features like TV, wifi and minibar that will keep you entertained throughout the cruise. Indulge in a soothing, long bath in our private bathrooms. Let your day start and end with the most calming views of the Nile from our panoramic windows. Bringing you the beauty of living in the moment, we bring you the finest experience in cruising.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (56, 28, 2, 0, N'Standard Single Cabin', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (57, 29, 1, 1, N'Standard Cabin Upper Deck', N'Opulently furnished air conditioned cabins of the size of 19m2 are decked with TV, wifi and minibar. Our spaces are reimagined to ensure you have a stay of ultimate comfort. Enjoy a sweeping view of the Nile throughout your cruise while being cuddled in your cabin. Our cabins ensure you have the ultimate luxury cruising experience. Our Private bathrooms ensure you always stay refreshed and rejuvenated. Drift through the Nile in a world of your own with us at Jaz Regent.  ', N'Opulently furnished air conditioned cabins of the size of 19m2 are decked with TV, wifi and minibar. Our spaces are reimagined to ensure you have a stay of ultimate comfort. Enjoy a sweeping view of the Nile throughout your cruise while being cuddled in your cabin. Our cabins ensure you have the ultimate luxury cruising experience. Our Private bathrooms ensure you always stay refreshed and rejuvenated. Drift through the Nile in a world of your own with us at Jaz Regent.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (58, 29, 2, 0, N'Standard Twin Cabin', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (59, 30, 1, 1, N'Suite', N'Elaborate air conditioned suites of over 38 m2 feature sophisticated amenities like TV, wifi and a minibar. Private seating areas are separated from the bedspace and bring you the most gorgeous views of the river Nile. Nestle in the comfort of your beds and unwind with a relaxing shower in the private bathtub. Escape reality with our suites at Jaz Regent. ', N'Elaborate air conditioned suites of over 38 m2 feature sophisticated amenities like TV, wifi and a minibar. Private seating areas are separated from the bedspace and bring you the most gorgeous views of the river Nile. Nestle in the comfort of your beds and unwind with a relaxing shower in the private bathtub. Escape reality with our suites at Jaz Regent.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (60, 30, 2, 0, N'Suite', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (61, 31, 1, 1, N'Standard Single Cabin', N'Perfectly pleasant and offering a minimalistic luxury inspired interior, our cabins are 17m2 and air conditioned. Extra-large windows in the cabins offer charming views of the serene waters of the Nile. Equipped with deluxe amenities like TV and wifi, our cabins ensure you barely need to step out. Pamper yourself to long, comforting showers in the conjoining private bathrooms. On-board with us to experience cruising in a luxurious style across the river Nile. ', N'Perfectly pleasant and offering a minimalistic luxury inspired interior, our cabins are 17m2 and air conditioned. Extra-large windows in the cabins offer charming views of the serene waters of the Nile. Equipped with deluxe amenities like TV and wifi, our cabins ensure you barely need to step out. Pamper yourself to long, comforting showers in the conjoining private bathrooms. On-board with us to experience cruising in a luxurious style across the river Nile.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (62, 31, 2, 0, N'Standard Single Cabin', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (63, 32, 1, 1, N'Standard Twin Cabin', N'Designed in neutral shades, our double cabins will make you swoon over the 17m2, air conditioned spaces. Soak in the beautiful view of the Nile along with other picturesque scenery from the comfort of your cabin. Experience a rejuvenating shower within these home-like, private bathrooms. Our cabins are also well equipped with other features like TV and Wifi that ensure you remain entertained throughout the cruise.  ', N'Designed in neutral shades, our double cabins will make you swoon over the 17m2, air conditioned spaces. Soak in the beautiful view of the Nile along with other picturesque scenery from the comfort of your cabin. Experience a rejuvenating shower within these home-like, private bathrooms. Our cabins are also well equipped with other features like TV and Wifi that ensure you remain entertained throughout the cruise.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (64, 32, 2, 0, N'Standard Twin Cabin', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (65, 33, 1, 1, N'Suite', N'Our spaciously designed 32m2 air conditioned suites are best suited for families, seeking indulgence but with personalized care. The suite features a separate seating area with a sleek TV and Wifi for entertainment. The suites come with large windows that provide the most fascinating view of the Nile and the cities along the cruise. Our private bathrooms have bathtubs tucked-in to serve as your haven of relaxation. Experience a cruise of exquisite personalization and care with us at Nile Monarch. ', N'Our spaciously designed 32m2 air conditioned suites are best suited for families, seeking indulgence but with personalized care. The suite features a separate seating area with a sleek TV and Wifi for entertainment. The suites come with large windows that provide the most fascinating view of the Nile and the cities along the cruise. Our private bathrooms have bathtubs tucked-in to serve as your haven of relaxation. Experience a cruise of exquisite personalization and care with us at Nile Monarch.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (66, 33, 2, 0, N'Suite', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (67, 34, 1, 1, N'Standard Twin Cabin', N'Our Double Cabin elevates your cruising experience with air conditioned spacious cabins of 19m2. Designed in vibrant colours that reflect luxury, our cabins come with wifi and sleek TV for entertainment. The panoramic windows bring you the stunning view of the Nile as you unwind in your personal space. Adjoining private bathrooms are equipped with the finest of amenities that will help you de-stress. ', N'Our Double Cabin elevates your cruising experience with air conditioned spacious cabins of 19m2. Designed in vibrant colours that reflect luxury, our cabins come with wifi and sleek TV for entertainment. The panoramic windows bring you the stunning view of the Nile as you unwind in your personal space. Adjoining private bathrooms are equipped with the finest of amenities that will help you de-stress.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (68, 34, 2, 0, N'Standard Twin Cabin', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (69, 35, 1, 1, N'Suite', N'The 25m2 suites offer a larger than life experience with a private bathroom fitted with bathtubs. Our English styled suites are furnished in rich shades, gorgeously covering every inch of the suite. Our High-definition TV and Wifi ensure you always remain entertained throughout the cruise. The flamboyant windows ensure you never need to step away from your suites. Get on-board with us to experience the perfect cruising getaway you have always wanted. ', N'The 25m2 suites offer a larger than life experience with a private bathroom fitted with bathtubs. Our English styled suites are furnished in rich shades, gorgeously covering every inch of the suite. Our High-definition TV and Wifi ensure you always remain entertained throughout the cruise. The flamboyant windows ensure you never need to step away from your suites. Get on-board with us to experience the perfect cruising getaway you have always wanted.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (70, 35, 2, 0, N'Suite', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (79, 40, 1, 1, N'Standard Cabin', N'Drift to the rhythm of the river Nile in the comforting space of our Double cabins. At Jaz Crown Jewel, our cabins cover a space of 19m2 in handpicked furnishing that comes in soothing tones. Wake up to the panoramic view of the Nile brought to you in the comforts of your cabin equipped with a minibar, sleek TV and wifi for entertainment. Take a refreshing dip over the course of the day in the private bathtubs before you step out of your cocoon. Our Double Cabins guarantee you a blissful experience of cruising through the Nile.   ', N'Drift to the rhythm of the river Nile in the comforting space of our Double cabins. At Jaz Crown Jewel, our cabins cover a space of 19m2 in handpicked furnishing that comes in soothing tones. Wake up to the panoramic view of the Nile brought to you in the comforts of your cabin equipped with a minibar, sleek TV and wifi for entertainment. Take a refreshing dip over the course of the day in the private bathtubs before you step out of your cocoon. Our Double Cabins guarantee you a blissful experience of cruising through the Nile.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (80, 40, 2, 0, N'Standard Twin Cabin', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (81, 41, 1, 1, N'Standard Cabin Upper Deck', N'Enjoy your personal/me-time with our single cabins. Join us on-board the Crown Jewel, where our air-conditioned cabins of 19m2 is spaciously designed with a range of amenities like minibar, TV and wifi to entertain you throughout the cruise. Unwind yourself with a long shower in the bathtub that comes in the private bathroom. Allow the tranquility of the river Nile wash over you through the breathtaking windows. A cruise that promises you relaxation like no other.  ', N'Enjoy your personal/me-time with our single cabins. Join us on-board the Crown Jewel, where our air-conditioned cabins of 19m2 is spaciously designed with a range of amenities like minibar, TV and wifi to entertain you throughout the cruise. Unwind yourself with a long shower in the bathtub that comes in the private bathroom. Allow the tranquility of the river Nile wash over you through the breathtaking windows. A cruise that promises you relaxation like no other.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (82, 41, 2, 0, N'Standard Single Cabin', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (83, 42, 1, 0, N'Suite', N'Immense air conditioned suites of over 41.5m2 are equipped with the most stunning features. Private seating area offers an exquisite view of the Nile that will engulf you throughout the day. Laze in the comforts of your bed as our TV and Wifi with a minibar, keep you entertained over the day. Escape into a world of your own with a soothing dip in the bathtubs in our private bathrooms. An Experience unparalleled - crafted specially for you. ', N'Immense air conditioned suites of over 41.5m2 are equipped with the most stunning features. Private seating area offers an exquisite view of the Nile that will engulf you throughout the day. Laze in the comforts of your bed as our TV and Wifi with a minibar, keep you entertained over the day. Escape into a world of your own with a soothing dip in the bathtubs in our private bathrooms. An Experience unparalleled - crafted specially for you.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (84, 42, 2, 0, N'Suite', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (85, 43, 1, 1, N'Standard Twin Cabin', N'Lose yourself to the calm serene waters of the Nile through our panoramic windows. Our Double cabins are designed to blend modern elegance with home-like comfort. Air conditioned spaces of 19m2 are furnished in colours of opulence and accompanied with TV, wifi and a minibar. Revitalize yourself in our bathrooms with soothing showers. Our cabins elevate your standard of luxury, making cruising almost a way of life. ', N'Lose yourself to the calm serene waters of the Nile through our panoramic windows. Our Double cabins are designed to blend modern elegance with home-like comfort. Air conditioned spaces of 19m2 are furnished in colours of opulence and accompanied with TV, wifi and a minibar. Revitalize yourself in our bathrooms with soothing showers. Our cabins elevate your standard of luxury, making cruising almost a way of life.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (86, 43, 2, 0, N'Standard Twin Cabin', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (87, 44, 1, 1, N'Standard Single Cabin', N'Spacious cabins of 19m2 each come with tasteful furnishings making it your luxury abode. Our large windows elevate your cruising experience with never-ending views of the Nile. Accentuated by soft lighting, warm tones and deep shades welcomes you to the cabin. Single cabins come with a sleek TV and Wifi with a fitted minibar, that will keep you entertained throughout the cruise. Private bathrooms, well equipped with superior settings, promise you a refreshing bathing experience. ', N'Spacious cabins of 19m2 each come with tasteful furnishings making it your luxury abode. Our large windows elevate your cruising experience with never-ending views of the Nile. Accentuated by soft lighting, warm tones and deep shades welcomes you to the cabin. Single cabins come with a sleek TV and Wifi with a fitted minibar, that will keep you entertained throughout the cruise. Private bathrooms, well equipped with superior settings, promise you a refreshing bathing experience.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (88, 44, 2, 0, N'Standard Single Cabin', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (89, 45, 1, 1, N'Standard Twin Cabin', N'Our Double cabins are an alluring getaway from the mundane life with superior amenities like TV and Wifi. Air conditioned cabins of 19.5m2 come with balconies and sliding windows on the charming Nile River - a beauty to behold in addition to other special amenities such as safe box and private bathroom. ', N'Our Double cabins are an alluring getaway from the mundane life with superior amenities like TV and Wifi. Air conditioned cabins of 19.5m2 come with balconies and sliding windows on the charming Nile River - a beauty to behold in addition to other special amenities such as safe box and private bathroom.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (90, 45, 2, 0, N'Standard Twin Cabin', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (91, 46, 1, 1, N'Standard Single Cabin', N'Our air conditioned cabins feature deluxe amenities like high-definition TV, wifi and are tastefully designed in spaces of 19m2. Our enormous windows ensure you never miss any of the beautiful landscapes along the course of the river Nile. Savour the warmth of our luxurious cabins as you unwind in the private shower spaces after a long day. Our cruise is an enchanting escape from the chaos of city life. ', N'Our air conditioned cabins feature deluxe amenities like high-definition TV, wifi and are tastefully designed in spaces of 19m2. Our enormous windows ensure you never miss any of the beautiful landscapes along the course of the river Nile. Savour the warmth of our luxurious cabins as you unwind in the private shower spaces after a long day. Our cruise is an enchanting escape from the chaos of city life.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (92, 46, 2, 0, N'Standard Single Cabin', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (93, 47, 1, 0, N'Suite', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (94, 47, 2, 0, N'Suite', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (95, 48, 1, 1, N'Standard Cabin Upper Deck', N'Our cabins are wrapped in luxury with the superior features. They are a piece of fine skill mirrored in the interiors and furnishings. Air conditioned cabins of 19m2 are equipped with minibar, TV and wifi fitted for entertainment. Perch over the panoramic windows as the gorgeous Nile sweeps you off your feet. Step-in our private bathrooms for the most revitalizing showers. Cruise with us and take back with you some of the most cherished family moments. ', N'Our cabins are wrapped in luxury with the superior features. They are a piece of fine skill mirrored in the interiors and furnishings. Air conditioned cabins of 19m2 are equipped with minibar, TV and wifi fitted for entertainment. Perch over the panoramic windows as the gorgeous Nile sweeps you off your feet. Step-in our private bathrooms for the most revitalizing showers. Cruise with us and take back with you some of the most cherished family moments.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (96, 48, 2, 0, N'Standard Cabin Upper Deck', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (97, 49, 1, 1, N'Suite Upper Deck', N'Soaked in luxury, our air conditioned suites are over 38m2. They are designed with private balconies that bring you the most dazzling view of the Nile. The seating area comes with a minibar, sleek TV using Marine satellite and Wifi for in-suite entertainment. Treat yourself to the most refreshing showers from our private bathrooms that help with unwinding. We bring the world to you, making it accessible from the comfort of your suites. ', N'Soaked in luxury, our air conditioned suites are over 38m2. They are designed with private balconies that bring you the most dazzling view of the Nile. The seating area comes with a minibar, sleek TV using Marine satellite and Wifi for in-suite entertainment. Treat yourself to the most refreshing showers from our private bathrooms that help with unwinding. We bring the world to you, making it accessible from the comfort of your suites.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (98, 49, 2, 0, N'Suite Upper Deck', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (99, 50, 1, 1, N'Standard Cabin Upper Deck', N'Inspired from the luxury theme, our Double cabins are your home-away-from-home. Neutral shades of drapes, choicest furnishing and mood lights are bound to accentuate your spirit. Perch on our large window rails and soak in the view of the beautiful Nile. Our cabins are air conditioned and come in sizes of 19.5m2 featuring a TV and wifi. Retire for the day after a relaxing bath in our private bathrooms. ', N'Inspired from the luxury theme, our Double cabins are your home-away-from-home. Neutral shades of drapes, choicest furnishing and mood lights are bound to accentuate your spirit. Perch on our large window rails and soak in the view of the beautiful Nile. Our cabins are air conditioned and come in sizes of 19.5m2 featuring a TV and wifi. Retire for the day after a relaxing bath in our private bathrooms.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (100, 50, 2, 0, N'Standard Cabin Upper Deck', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (101, 51, 1, 1, N'Suite Upper Deck', N'Elaborate air conditioned suites of over 38 m2 feature sophisticated amenities like TV, wifi and a minibar. Private seating areas are separated from the bedspace and bring you the most gorgeous views of the river Nile. Nestle in the comfort of your beds and unwind with a relaxing shower in the private bathtub. Escape reality with our suites at Jaz Regent. ', N'Elaborate air conditioned suites of over 38 m2 feature sophisticated amenities like TV, wifi and a minibar. Private seating areas are separated from the bedspace and bring you the most gorgeous views of the river Nile. Nestle in the comfort of your beds and unwind with a relaxing shower in the private bathtub. Escape reality with our suites at Jaz Regent.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (102, 51, 2, 0, N'Suite Upper Deck', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (103, 52, 1, 1, N'Grand Suite Upper Deck', N'Our Grand suites stand true to their name. Lavishly designed in spaces of 35m2 and adorned in plush fabrics and furnishings, these suites make for a cozy haven. Enjoy the tranquility of the Nile and the expansive skies through our palatial private balcony. Uninterrupted entertainment is made available through the TV and Wifi service available in Aswan &amp; Abu Simbel. Sojourn in our magnificent suites for a royal cruising experience. ', N'Our Grand suites stand true to their name. Lavishly designed in spaces of 35m2 and adorned in plush fabrics and furnishings, these suites make for a cozy haven. Enjoy the tranquility of the Nile and the expansive skies through our palatial private balcony. Uninterrupted entertainment is made available through the TV and Wifi service available in Aswan & Abu Simbel. Sojourn in our magnificent suites for a royal cruising experience.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (104, 52, 2, 0, N'Grand Suite Upper Deck', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (105, 53, 1, 1, N'Royal Suite Upper Deck', N'Our royal suites will give you the perfect luxurious experience, Dipped in Excellency. Tasteful furnishings, rich interiors and separate seating and dining areas echo grandeur through every detail. Our oversized suites of 70m2 are air-conditioned and equipped with TV and Wifi service available in Aswan &amp; Abu Simbel. The Jacuzzi in the private bathtubs highlights cruising in these suites. They make you want to never step out of your haven of relaxation. Perch on the Nile-view balcony to enjoy the most captivating sights of the Nile and the cities along the banks of it. Enjoy tailor-made cruising like a royal in a world of your own. ', N'Our royal suites will give you the perfect luxurious experience, Dipped in Excellency. Tasteful furnishings, rich interiors and separate seating and dining areas echo grandeur through every detail. Our oversized suites of 70m2 are air-conditioned and equipped with TV and Wifi service available in Aswan & Abu Simbel. The Jacuzzi in the private bathtubs highlights cruising in these suites. They make you want to never step out of your haven of relaxation. Perch on the Nile-view balcony to enjoy the most captivating sights of the Nile and the cities along the banks of it. Enjoy tailor-made cruising like a royal in a world of your own.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (106, 53, 2, 0, N'Royal Suite Upper Deck', N'', N'')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (107, 54, 1, 1, N'Standard Cabin Upper Deck', N'Our double cabins are luxury at its best. Spaciously designed in 24m2, our air conditioned cabins are furnished in tasteful interiors that will leave you enchanted. High-definition TV, Wifi service available in Aswan &amp; Abu Simbel are accessible from the comfort of your bed that will keep you entertained. A long, unwinding shower in the bathtub will ensure you are ever-ready. A personal balcony space brings you the view of the Nile - a beauty to behold. At Omar El Khayam, experience a unique cruising that has been designed to suit every traveler needs. ', N'Our double cabins are luxury at its best. Spaciously designed in 24m2, our air conditioned cabins are furnished in tasteful interiors that will leave you enchanted. High-definition TV, Wifi service available in Aswan & Abu Simbel are accessible from the comfort of your bed that will keep you entertained. A long, unwinding shower in the bathtub will ensure you are ever-ready. A personal balcony space brings you the view of the Nile - a beauty to behold. At Omar El Khayam, experience a unique cruising that has been designed to suit every traveler needs.')
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] ([Id], [CabinID], [LangID], [ContentLangStatus], [CabinName], [CabinDetails], [CabinIntro]) VALUES (108, 54, 2, 0, N'Standard Cabin Upper Deck', N'', N'')
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Cabins_Content] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Cabins_Photos] ON 
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Photos] ([Id], [CabinID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (3, 22, N'jaz-crown-prince_standard-single-cabin_12071_2.jpg', 100, 1, 460, 600)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Photos] ([Id], [CabinID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (6, 22, N'jaz-crown-prince_standard-single-cabin_9387_karnak1.jpg', 100, 1, 460, 600)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Photos] ([Id], [CabinID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (7, 22, N'jaz-crown-prince_standard-single-cabin_16527_Kom-Ombo-Temple1.jpg', 100, 1, 460, 600)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Photos] ([Id], [CabinID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (8, 22, N'jaz-crown-prince_standard-single-cabin_16527_Kom-Ombo-Temple2.jpg', 100, 1, 460, 600)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Photos] ([Id], [CabinID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (9, 22, N'jaz-crown-prince_standard-single-cabin_13271_Kom-Ombo-Temple3.jpg', 100, 1, 460, 600)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Photos] ([Id], [CabinID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (10, 22, N'jaz-crown-prince_standard-single-cabin_511_Philae-temple2.jpg', 100, 1, 460, 600)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Photos] ([Id], [CabinID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (11, 22, N'jaz-crown-prince_standard-single-cabin_9007_edfu1.jpg', 100, 1, 460, 600)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Photos] ([Id], [CabinID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (12, 22, N'jaz-crown-prince_standard-single-cabin_3322_edfu2.jpg', 100, 1, 460, 600)
GO
INSERT [dbo].[tbl_CruiseBooking_Cabins_Photos] ([Id], [CabinID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (13, 22, N'jaz-crown-prince_standard-single-cabin_3322_edfu3.jpg', 100, 1, 460, 600)
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Cabins_Photos] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ON 
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (9, 22, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (10, 22, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (11, 22, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (12, 22, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (13, 24, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (14, 24, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (15, 24, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (16, 24, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (17, 24, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (18, 25, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (19, 25, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (20, 25, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (21, 25, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (22, 25, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (23, 42, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (24, 42, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (25, 42, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (26, 42, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (27, 42, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (28, 43, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (29, 43, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (30, 43, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (31, 43, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (32, 43, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (33, 44, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (34, 44, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (35, 44, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (36, 44, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (37, 44, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (38, 27, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (39, 27, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (40, 27, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (41, 27, 4)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (42, 27, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (43, 27, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (44, 26, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (45, 26, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (46, 26, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (47, 26, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (48, 26, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (49, 28, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (50, 28, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (51, 28, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (52, 28, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (53, 28, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (54, 29, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (55, 29, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (56, 29, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (57, 29, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (58, 29, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (59, 30, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (60, 30, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (61, 30, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (62, 30, 4)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (63, 30, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (64, 30, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (65, 31, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (66, 31, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (67, 31, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (68, 31, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (69, 31, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (70, 32, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (71, 32, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (72, 32, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (73, 32, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (74, 32, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (75, 33, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (76, 33, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (77, 33, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (78, 33, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (79, 33, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (80, 34, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (81, 34, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (82, 34, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (83, 34, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (84, 34, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (85, 46, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (86, 46, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (87, 46, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (88, 46, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (89, 46, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (90, 35, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (91, 35, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (92, 35, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (93, 35, 4)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (94, 35, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (95, 35, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (96, 3, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (97, 3, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (98, 3, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (99, 3, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (100, 3, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (101, 4, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (102, 4, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (103, 4, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (104, 4, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (105, 4, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (106, 5, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (107, 5, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (108, 5, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (109, 5, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (110, 5, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (111, 6, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (112, 6, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (113, 6, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (114, 6, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (115, 6, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (116, 7, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (117, 7, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (118, 7, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (119, 7, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (120, 7, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (121, 8, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (122, 8, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (123, 8, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (124, 8, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (125, 8, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (126, 12, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (127, 12, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (128, 12, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (129, 12, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (130, 12, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (131, 13, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (132, 13, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (133, 13, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (134, 13, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (135, 13, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (136, 14, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (137, 14, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (138, 14, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (139, 14, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (140, 14, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (141, 14, 7)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (142, 15, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (143, 15, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (144, 15, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (145, 15, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (146, 15, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (147, 16, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (148, 16, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (149, 16, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (150, 16, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (151, 16, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (152, 17, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (153, 17, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (154, 17, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (155, 17, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (156, 17, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (157, 45, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (158, 45, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (159, 45, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (160, 45, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (161, 45, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (162, 18, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (163, 18, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (164, 18, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (165, 18, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (166, 18, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (167, 19, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (168, 19, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (169, 19, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (170, 19, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (171, 19, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (172, 9, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (173, 9, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (174, 9, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (175, 9, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (176, 9, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (177, 10, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (178, 10, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (179, 10, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (180, 10, 4)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (181, 10, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (182, 10, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (183, 10, 7)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (184, 11, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (185, 11, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (186, 11, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (187, 11, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (188, 11, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (189, 20, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (190, 20, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (191, 20, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (192, 20, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (193, 20, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (194, 21, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (195, 21, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (196, 21, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (197, 21, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (198, 21, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (199, 48, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (200, 48, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (201, 48, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (202, 48, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (203, 48, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (204, 49, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (205, 49, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (206, 49, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (207, 49, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (208, 49, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (209, 51, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (210, 51, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (211, 51, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (212, 51, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (213, 51, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (214, 52, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (215, 52, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (216, 52, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (217, 52, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (218, 52, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (219, 53, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (220, 53, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (221, 53, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (222, 53, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (223, 53, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (224, 54, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (225, 54, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (226, 54, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (227, 54, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (228, 54, 6)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (229, 50, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (230, 50, 2)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (231, 50, 3)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (232, 50, 5)
GO
INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] ([Id], [CabinID], [AmenitiesID]) VALUES (233, 50, 6)
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_CabinsAmenities] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Dining_Photos] ON 
GO
INSERT [dbo].[tbl_CruiseBooking_Dining_Photos] ([Id], [DiningID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (5, 1, N'jaz-crown-prince_test-name1_14580_Colossi-of-Memnon.jpg', 100, 1, 460, 600)
GO
INSERT [dbo].[tbl_CruiseBooking_Dining_Photos] ([Id], [DiningID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (6, 1, N'jaz-crown-prince_test-name1_1820_edfu1.jpg', 100, 1, 460, 600)
GO
INSERT [dbo].[tbl_CruiseBooking_Dining_Photos] ([Id], [DiningID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (7, 1, N'jaz-crown-prince_test-name1_18464_edfu2.jpg', 100, 1, 460, 600)
GO
INSERT [dbo].[tbl_CruiseBooking_Dining_Photos] ([Id], [DiningID], [PhotoFile], [PhotoPosition], [PhotoStatus], [PhotoHieght], [PhotoWidth]) VALUES (8, 1, N'jaz-crown-prince_test-name1_3686_1.jpg', 100, 1, 460, 600)
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Dining_Photos] OFF
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'49ac27b9-fb95-491f-989e-4bd788d68166', N'User', N'USER', N'19a333e4-4608-4864-869a-c761e769687d')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'a3aea57e-706f-4611-be63-7346c613d38d', N'Admin', N'ADMIN', N'5f58117f-62f3-429f-acb2-e8b4324841d5')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [RefreshToken], [RefreshTokenExpirationDate]) VALUES (N'6dbe9f36-3ab9-41dd-967b-3524c66a0677', N'admin1', N'ADMIN1', N'admin1@gmail.com', N'ADMIN1@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEMDLI6iRztuXEeQODdjpYbxQOsQ+rBs3J5QJWsIa9ipJMd6NaBlsL0G/FzM93ZII+A==', N'SJE5ZRXEVMGZCOSP4CTFXBXUZQ55OOVF', N'b9b75724-dbd0-4c44-8780-75437a47d788', NULL, 0, 0, NULL, 1, 0, N'hMnNEY2hR61TSgS0KQefEz3Q/0H50lyRsAPVz8T3bco=', CAST(N'2024-01-19T14:35:14.550' AS DateTime))
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [RefreshToken], [RefreshTokenExpirationDate]) VALUES (N'a090c7a2-12f6-4ca4-94ad-90f2b6c76d69', N'Admin', N'ADMIN', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEAjU7FKLPj757SHgKv5yYHg2grgabHqOEPkPpa8aWdJsXGAVVsktRftC6PIzp5KLkg==', N'GKS2UY2QBMPBU4VKPBH2LPKBCFBJHSLY', N'4a0d5b04-3f26-43db-9c7e-66340079c65d', NULL, 0, 0, NULL, 1, 0, NULL, NULL)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [RefreshToken], [RefreshTokenExpirationDate]) VALUES (N'dbc513a2-d55b-4c48-88c2-eb1e4b7b1196', N'Mostafa1', N'MOSTAFA1', N'mostafa1@gmail.com', N'MOSTAFA1@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEELV6XDk++9yNPW2+4tHOJWtr5jQK1l0n9FZfmH9bRnfG7P2GP3F7dX6/aGDfHhRvQ==', N'ACKC6KQVVMOUVWBSYCZDCNZGCSBK7ZKH', N'c17a2d19-ab1a-49a1-88ee-0dd3a1cda999', NULL, 0, 0, NULL, 1, 0, N'57liNoB7Eil+CRzCngbC3+srfxv5iYBL0JKdNKts7x4=', CAST(N'2023-12-20T16:37:13.223' AS DateTime))
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [RefreshToken], [RefreshTokenExpirationDate]) VALUES (N'dbf9353f-03a4-4fa2-903f-6b62b335d1ef', N'ahmed', N'AHMED', N'ahmed@gmail.com', N'AHMED@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEMn80l5a+9m18JE+ARn7nGtmh/XHKyEzKzag+iwPlrvEXmMSAyRmAGixq0LjRRJ9wA==', N'HCFMVCSCMRKGUGG776XQNID75RPUOWD5', N'cf513026-bd22-4317-98d9-8a93e30e8529', NULL, 0, 0, NULL, 1, 0, N'nXjh2enirOU+7epUwx1JZnu4fkWDKX7iYM2jt8j4oH0=', CAST(N'2024-01-16T16:29:42.320' AS DateTime))
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [RefreshToken], [RefreshTokenExpirationDate]) VALUES (N'ef580838-b9fa-4f93-957b-80156d403396', N'Mostafa', N'MOSTAFA', N'mostafa.draven@gmail.com', N'MOSTAFA.DRAVEN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEKrGOBa1Z+zbURgxxiyzythi60XqpGNwyYD5n8ThEdySIaD47CFbGesA+fdME2NA2g==', N'6MUSFRDIUKZVH74YZME5GRZG4O72RYUI', N'7f030784-a04c-4bd4-ac6e-be6e00384ded', NULL, 0, 0, NULL, 1, 0, N'VOzEVraYh8akayNH1pYDXQkFSwpmC+O4CVjixcj8yF8=', CAST(N'2023-12-24T10:08:30.280' AS DateTime))
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a090c7a2-12f6-4ca4-94ad-90f2b6c76d69', N'a3aea57e-706f-4611-be63-7346c613d38d')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'dbc513a2-d55b-4c48-88c2-eb1e4b7b1196', N'a3aea57e-706f-4611-be63-7346c613d38d')
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Amenities] ON 
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (1, N'Hairdryer', NULL, 0, 100, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (2, N'Air Conditioning', NULL, 0, 100, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (3, N'Satellite Television', NULL, 0, 100, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (4, N'Shower with Bathtub', NULL, 0, 100, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (5, N'Minibar', NULL, 0, 100, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (6, N'Safe', NULL, 0, 100, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (7, N'Jacuzzi', NULL, 0, 100, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (8, N'private safe box', NULL, 0, 100, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (9, N'Private bathroom', NULL, 0, 100, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (10, N'smoke detector', NULL, 0, 100, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (11, N'Toilet paper', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (12, N'Towels', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (13, N'Toilet', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (14, N'Free toiletries', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (15, N'Bath', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (16, N'Shower', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (17, N'Flat-screen TV', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (18, N'Cable channels', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (19, N'Satellite channels', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (20, N'Telephone', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (21, N'TV', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (22, N'Socket near the bed', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (23, N'Sofa bed', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (24, N'Clothes rack', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (25, N'Dining area', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities] ([Id], [AmenitiesNameSys], [AmenitiesIcon], [AmenitiesStatus], [AmenitiesPosition], [AmenitiesIcon_Width], [AmenitiesIcon_Height]) VALUES (26, N'Seating Area', NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Amenities] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ON 
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (1, 1, 1, 0, N'Hairdryer')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (2, 1, 2, 0, N'Hairdryer')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (3, 2, 1, 0, N'Air Conditioning')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (4, 2, 2, 0, N'Air Conditioning')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (5, 3, 1, 0, N'Satellite Television')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (6, 3, 2, 0, N'Satellite Television')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (7, 4, 1, 0, N'Shower with Bathtub')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (8, 4, 2, 0, N'Shower with Bathtub')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (9, 5, 1, 0, N'Minibar')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (10, 5, 2, 0, N'Minibar')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (11, 6, 1, 0, N'Safe')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (12, 6, 2, 0, N'Safe')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (13, 7, 1, 0, N'Jacuzzi')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (14, 7, 2, 0, N'Jacuzzi')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (15, 8, 1, 0, N'private safe box')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (16, 8, 2, 0, N'private safe box')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (17, 9, 1, 0, N'private bathroom')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (18, 9, 2, 0, N'private bathroom')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (19, 10, 1, 0, N'smoke detector')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (20, 10, 2, 0, N'smoke detector')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (21, 11, 1, 0, N'Toilet paper')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (22, 11, 2, 0, N'Toilet paper')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (23, 12, 1, 0, N'Towels')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (24, 12, 2, 0, N'Towels')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (25, 13, 1, 0, N'Toilet')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (26, 13, 2, 0, N'Toilet')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (27, 14, 1, 0, N'Free toiletries')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (28, 14, 2, 0, N'Free toiletries')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (29, 15, 1, 0, N'Bath')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (30, 15, 2, 0, N'Bath')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (31, 16, 1, 0, N'Shower')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (32, 16, 2, 0, N'Shower')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (33, 17, 1, 0, N'Flat-screen TV')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (34, 17, 2, 0, N'Flat-screen TV')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (35, 18, 1, 0, N'Cable channels')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (36, 18, 2, 0, N'Cable channels')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (37, 19, 1, 0, N'Satellite channels')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (38, 19, 2, 0, N'Satellite channels')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (39, 20, 1, 0, N'Telephone')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (40, 20, 2, 0, N'Telephone')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (41, 21, 1, 0, N'TV')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (42, 21, 2, 0, N'TV')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (43, 22, 1, 0, N'Socket near the bed')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (44, 22, 2, 0, N'Socket near the bed')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (45, 23, 1, 0, N'Sofa bed')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (46, 23, 2, 0, N'Sofa bed')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (47, 24, 1, 0, N'Clothes rack')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (48, 24, 2, 0, N'Clothes rack')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (49, 25, 1, 0, N'Dining area')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (50, 25, 2, 0, N'Dining area')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (51, 26, 1, 0, N'Seating Area')
GO
INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] ([Id], [AmenitiesID], [LangID], [ContentLangStatus], [AmenitiesName]) VALUES (52, 26, 2, 0, N'Seating Area')
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Amenities_Content] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Cities] ON 
GO
INSERT [dbo].[tbl_CruiseBooking_Cities] ([Id], [CityNameSys], [CityURL], [CityPhoto], [CityBanner], [CityStatus], [CityPhoto_Width], [CityPhoto_Height], [CityBanner_Width], [CityBanner_Height]) VALUES (1, N'Luxor', NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cities] ([Id], [CityNameSys], [CityURL], [CityPhoto], [CityBanner], [CityStatus], [CityPhoto_Width], [CityPhoto_Height], [CityBanner_Width], [CityBanner_Height]) VALUES (2, N'Aswan', NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cities] ([Id], [CityNameSys], [CityURL], [CityPhoto], [CityBanner], [CityStatus], [CityPhoto_Width], [CityPhoto_Height], [CityBanner_Width], [CityBanner_Height]) VALUES (3, N'Abu Simbel', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Cities] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Cities_Content] ON 
GO
INSERT [dbo].[tbl_CruiseBooking_Cities_Content] ([Id], [CityID], [LangID], [ContentLangStatus], [CityName]) VALUES (1, 1, 1, 0, N'Luxor')
GO
INSERT [dbo].[tbl_CruiseBooking_Cities_Content] ([Id], [CityID], [LangID], [ContentLangStatus], [CityName]) VALUES (2, 1, 2, 0, N'Luxor')
GO
INSERT [dbo].[tbl_CruiseBooking_Cities_Content] ([Id], [CityID], [LangID], [ContentLangStatus], [CityName]) VALUES (3, 2, 1, 0, N'Aswan')
GO
INSERT [dbo].[tbl_CruiseBooking_Cities_Content] ([Id], [CityID], [LangID], [ContentLangStatus], [CityName]) VALUES (4, 2, 2, 0, N'Aswan')
GO
INSERT [dbo].[tbl_CruiseBooking_Cities_Content] ([Id], [CityID], [LangID], [ContentLangStatus], [CityName]) VALUES (5, 3, 1, 0, N'Abu Simbel')
GO
INSERT [dbo].[tbl_CruiseBooking_Cities_Content] ([Id], [CityID], [LangID], [ContentLangStatus], [CityName]) VALUES (6, 3, 2, 0, N'Abu Simbel')
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Cities_Content] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Cruise_Itineraries] ON 
GO
INSERT [dbo].[tbl_CruiseBooking_Cruise_Itineraries] ([Id], [CruiseID], [ItineraryID]) VALUES (4, 2, 1)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruise_Itineraries] ([Id], [CruiseID], [ItineraryID]) VALUES (5, 2, 2)
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Cruise_Itineraries] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Cruise_Itineraries_Days] ON 
GO
INSERT [dbo].[tbl_CruiseBooking_Cruise_Itineraries_Days] ([Id], [CruiseItinerariesID], [DayNumber], [DayTitle], [DayDetails]) VALUES (9, 4, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruise_Itineraries_Days] ([Id], [CruiseItinerariesID], [DayNumber], [DayTitle], [DayDetails]) VALUES (10, 4, 2, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruise_Itineraries_Days] ([Id], [CruiseItinerariesID], [DayNumber], [DayTitle], [DayDetails]) VALUES (11, 4, 3, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruise_Itineraries_Days] ([Id], [CruiseItinerariesID], [DayNumber], [DayTitle], [DayDetails]) VALUES (12, 4, 4, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruise_Itineraries_Days] ([Id], [CruiseItinerariesID], [DayNumber], [DayTitle], [DayDetails]) VALUES (13, 5, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruise_Itineraries_Days] ([Id], [CruiseItinerariesID], [DayNumber], [DayTitle], [DayDetails]) VALUES (14, 5, 2, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruise_Itineraries_Days] ([Id], [CruiseItinerariesID], [DayNumber], [DayTitle], [DayDetails]) VALUES (15, 5, 3, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruise_Itineraries_Days] ([Id], [CruiseItinerariesID], [DayNumber], [DayTitle], [DayDetails]) VALUES (16, 5, 4, NULL, NULL)
GO
INSERT [dbo].[tbl_CruiseBooking_Cruise_Itineraries_Days] ([Id], [CruiseItinerariesID], [DayNumber], [DayTitle], [DayDetails]) VALUES (17, 5, 5, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Cruise_Itineraries_Days] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_CruiseCategoryContent] ON 
GO
INSERT [dbo].[tbl_CruiseBooking_CruiseCategoryContent] ([Id], [CruiseCategoryID], [LangID], [CruiseCategoryName], [ContentLangStatus]) VALUES (7, 12, 1, N'5 Star', 1)
GO
INSERT [dbo].[tbl_CruiseBooking_CruiseCategoryContent] ([Id], [CruiseCategoryID], [LangID], [CruiseCategoryName], [ContentLangStatus]) VALUES (8, 12, 2, N'5 Star', 0)
GO
INSERT [dbo].[tbl_CruiseBooking_CruiseCategoryContent] ([Id], [CruiseCategoryID], [LangID], [CruiseCategoryName], [ContentLangStatus]) VALUES (9, 13, 1, N'4 Stars', 0)
GO
INSERT [dbo].[tbl_CruiseBooking_CruiseCategoryContent] ([Id], [CruiseCategoryID], [LangID], [CruiseCategoryName], [ContentLangStatus]) VALUES (10, 13, 2, N'4 Stars', 0)
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_CruiseCategoryContent] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Facilities] ON 
GO
INSERT [dbo].[tbl_CruiseBooking_Facilities] ([Id], [FacilityNameSys], [FacilityStatus], [FacilityIcon], [FacilityPosition], [FacilityIcon_Width], [FacilityIcon_Height]) VALUES (1, N'Fitness Equipment', 0, NULL, 100, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Facilities] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Facilities_Content] ON 
GO
INSERT [dbo].[tbl_CruiseBooking_Facilities_Content] ([Id], [FacilitiyID], [LangID], [ContentLangStatus], [FacilityName]) VALUES (1, 1, 1, 0, N'Fitness Equipment')
GO
INSERT [dbo].[tbl_CruiseBooking_Facilities_Content] ([Id], [FacilitiyID], [LangID], [ContentLangStatus], [FacilityName]) VALUES (2, 1, 2, 0, N'Fitness Equipment')
GO
SET IDENTITY_INSERT [dbo].[tbl_CruiseBooking_Facilities_Content] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Master_Brands] ON 
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (1, N'Jaz Hotels & Resorts', N'jaz-hotels-resorts', 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (6, N'Steigenberger Hotels & Resorts', N'steigenberger-hotels-resorts', 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (7, N'TUI Magic Life', N'tui-magic-life', 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (8, N'Oberoi Hotels & Resorts', N'oberoi-hotels-resorts', 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (9, N'Marriott Hotels & Resorts', N'marriott-hotels-resorts', 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (10, N'Hilton Hotels & Resorts', N'hilton-hotels-resorts', 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (11, N'Kempinski', N'kempinski', 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (12, N'Rixos', N'rixos', 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (13, N'Mövenpick', N'mövenpick', 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (14, N'Sheraton', N'sheraton', 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (15, N'Mercure', N'mercure', 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (16, N'The Three Corners Hotels & Resorts', N'the-three-corners-hotels-resorts', 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (17, N'Labranda Hotels', N'labranda-hotels', 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (18, N'
Cleopatra Luxury Resorts', N'
cleopatra-luxury-resorts', 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (19, N'Novotel', N'novotel', 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (20, N'Renaissance Hotels & Resorts', N'renaissance-hotels-resorts', 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (21, N'Barceló Hotels & Resorts', N'barceló-hotels-resorts', 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (22, N'Maritim', N'maritim', 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (23, N'Rotana Hotels & Resorts', N'rotana-hotels-resorts', 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (24, N'Domina Hotels & Resorts', N'domina-hotels-resorts', 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (25, N'Four Seasons Hotels and Resorts', N'four-seasons-hotels-and-resorts', 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (26, N'Iberotel Hotels & Resorts', N'iberotel-hotels-resorts', 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (27, N'Sol Y Mar Hotels & Resorts', N'sol-y-mar-hotels-resorts', 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (28, N'Pickalbatros', N'pickalbatros', 0, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (29, N'Jaz Cruises', N'jaz-cruises', 0, N'brand-cruise-jaz.jpg', NULL, NULL, NULL, NULL, NULL, 2, 1)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (30, N'Iberotel Cruises', N'iberotel-cruises', 0, N'brand-cruise-iberotel.jpg', NULL, NULL, NULL, NULL, NULL, 2, 1)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (31, N'Steigenberger Cruises', N'steigenberger-cruises', 0, N'brand-stien.jpg', NULL, NULL, N'', NULL, NULL, 2, 1)
GO
INSERT [dbo].[tbl_Master_Brands] ([Id], [BrandNameSys], [BrandURL], [IsDeleted], [BrandPhoto], [BrandPhoto_Width], [BrandPhoto_Height], [BrandBanner], [BrandBanner_Width], [BrandBanner_Height], [BrandTypeID], [IsTravco]) VALUES (1033, N'Dahabeyat', N'dahabeyat', 0, N'brand-dahabeyat.jpg', NULL, NULL, N'banner-brand-dahbeyat.jpg', NULL, NULL, 2, 1)
GO
SET IDENTITY_INSERT [dbo].[tbl_Master_Brands] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Master_Brands_Content] ON 
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (1, 1, 1, 0, N'Jaz Hotels & Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (2, 1, 2, 0, N'Jaz Hotels & Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (11, 6, 1, 0, N'Steigenberger Hotels & Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (12, 6, 2, 0, N'Steigenberger Hotels & Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (13, 7, 1, 0, N'TUI Magic Life', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (14, 7, 2, 0, N'TUI Magic Life', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (15, 8, 1, 0, N'Oberoi Hotels & Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (16, 8, 2, 0, N'Oberoi Hotels & Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (17, 9, 1, 0, N'Marriott Hotels & Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (18, 9, 2, 0, N'Marriott Hotels & Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (19, 10, 1, 0, N'Hilton Hotels & Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (20, 10, 2, 0, N'Hilton Hotels & Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (21, 11, 1, 0, N'Kempinski', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (22, 11, 2, 0, N'Kempinski', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (23, 12, 1, 0, N'Rixos', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (24, 12, 2, 0, N'Rixos', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (25, 13, 1, 0, N'Mövenpick', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (26, 13, 2, 0, N'Mövenpick', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (27, 14, 1, 0, N'Sheraton', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (28, 14, 2, 0, N'Sheraton', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (29, 15, 1, 0, N'Mercure', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (30, 15, 2, 0, N'Mercure', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (31, 16, 1, 0, N'The Three Corners Hotels & Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (32, 16, 2, 0, N'The Three Corners Hotels & Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (33, 17, 1, 0, N'Labranda Hotels', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (34, 17, 2, 0, N'Labranda Hotels', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (35, 18, 1, 0, N'
Cleopatra Luxury Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (36, 18, 2, 0, N'
Cleopatra Luxury Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (37, 19, 1, 0, N'Novotel', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (38, 19, 2, 0, N'Novotel', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (39, 20, 1, 0, N'Renaissance Hotels & Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (40, 20, 2, 0, N'Renaissance Hotels & Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (41, 21, 1, 0, N'Barceló Hotels & Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (42, 21, 2, 0, N'Barceló Hotels & Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (43, 22, 1, 0, N'Maritim', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (44, 22, 2, 0, N'Maritim', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (45, 23, 1, 0, N'Rotana Hotels & Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (46, 23, 2, 0, N'Rotana Hotels & Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (47, 24, 1, 0, N'Domina Hotels & Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (48, 24, 2, 0, N'Domina Hotels & Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (49, 25, 1, 0, N'Four Seasons Hotels and Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (50, 25, 2, 0, N'Four Seasons Hotels and Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (51, 26, 1, 0, N'Iberotel Hotels & Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (52, 26, 2, 0, N'Iberotel Hotels & Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (53, 27, 1, 0, N'Sol Y Mar Hotels & Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (54, 27, 2, 0, N'Sol Y Mar Hotels & Resorts', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (55, 28, 1, 0, N'Pickalbatros', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (56, 28, 2, 0, N'Pickalbatros', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (57, 29, 1, 0, N'Jaz Cruises', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (58, 29, 2, 0, N'Jaz Cruises', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (59, 30, 1, 0, N'Iberotel Cruises', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (60, 30, 2, 0, N'Iberotel Cruises', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (61, 31, 1, 0, N'Steigenberger Cruises', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (62, 31, 2, 0, N'Steigenberger Cruises', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (1057, 1033, 1, 0, N'Dahabeyat', N'', NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Brands_Content] ([Id], [BrandID], [LangID], [ContentLangStatus], [BrandName], [BrandIntro], [MetatagTitleBrand], [MetatagTitleDescription], [BrandDetails]) VALUES (1058, 1033, 2, 0, N'Dahabeyat', N'', NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[tbl_Master_Brands_Content] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Master_Destinations] ON 
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (1, 1, N'Hurghada', N'HRG', 3, 1, 1, N'', 0, N'hurghada', N'travco-travel_14060_Untitled-1.jpg', N'_15990_1.jpg', 0, 0, 0, 1, 690, 450, 2000, 500, 1, N'travco-travel_13407_Egypt-3.jpg', NULL, N'travco-travel_13703_Untitled-1-Recovered.jpg', NULL, N'travco-travel_7835__3067_Untitled-1.jpg', NULL, 1000, NULL, 690, NULL, 690, NULL, 600, NULL, 450, NULL, 450, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (2, 1, N'Aswan', N'ASW', 1, 1, 1, NULL, 0, N'aswan', N'travco-travel_3411_Untitled-1.jpg', N'_17610_1.jpg', 0, 1, 0, 1, 690, 450, 2000, 500, 1, NULL, NULL, N'travco-travel_8837_Untitled-1-Recovered.jpg', NULL, NULL, NULL, NULL, NULL, 690, NULL, NULL, NULL, NULL, NULL, 450, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (3, 1, N'Cairo', N'CAI', 1, 1, 1, NULL, 0, N'cairo', N'travco-travel_8495_Untitled-1.jpg', N'_2182_1.jpg', 0, 0, 0, 1, 690, 450, 2000, 500, 1, NULL, NULL, N'travco-travel_17084_Untitled-1-Recovered.jpg', NULL, N'travco-travel_13599__3067_Untitled-1.jpg', NULL, NULL, NULL, 690, NULL, 690, NULL, NULL, NULL, 450, NULL, 450, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (4, 1, N'Luxor', N'LXR', 1, 1, 1, NULL, 0, N'luxor', N'travco-travel_17821_Untitled-1.jpg', N'banner-luxor.jpg', 0, 1, 0, 1, 690, 450, NULL, NULL, 1, NULL, NULL, N'travco-travel_1703_Untitled-1-Recovered.jpg', NULL, N'travco-travel_4723__3067_Untitled-1.jpg', NULL, NULL, NULL, 690, NULL, 690, NULL, NULL, NULL, 450, NULL, 450, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (5, 1, N'Sharm El Sheikh', N'SSH', 1, 1, 1, N'https://www.youtube.com/embed/4OQ9KA1hjfQ?rel=0', 1, N'sharm-el-sheikh', N'travco-travel_7671_Untitled-1.jpg', N'_16934_1.jpg', 0, 0, 0, 1, 690, 450, 2000, 500, 1, NULL, NULL, N'travco-travel_912_Untitled-1-Recovered.jpg', NULL, N'travco-travel_5563__3067_Untitled-1.jpg', NULL, NULL, NULL, 690, NULL, 690, NULL, NULL, NULL, 450, NULL, 450, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (6, 1, N'Marsa Alam', N'RMF', 3, 1, 1, N'https://www.youtube.com/embed/vyaxKu3dLrM', 1, N'marsa-alam', N'travco-travel_1994_Untitled-1.jpg', N'_16601_1.jpg', 0, 0, 0, 1, 690, 450, 2000, 500, 1, NULL, NULL, N'travco-travel_3959_Untitled-1-Recovered.jpg', NULL, N'travco-travel_932__3067_Untitled-1.jpg', NULL, NULL, NULL, 690, NULL, 690, NULL, NULL, NULL, 450, NULL, 450, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (7, 1, N'Dahab', NULL, 3, 1, 1, NULL, 0, N'dahab', N'travco-travel_13245_Untitled-1.jpg', N'_7032_Untitled-1.jpg', 0, 0, 0, 1, 690, 450, 1920, 530, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (8, 1, N'Nuweiba', NULL, 3, 1, 1, NULL, 0, N'nuweiba', N'travco-travel_264_Untitled-1.jpg', N'_8189_Untitled-1.jpg', 0, 0, 0, 1, 690, 450, 1920, 530, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (9, 1, N'Taba', NULL, 1, 1, 0, NULL, 0, N'taba', N'travco-travel_19585_Untitled-1.jpg', NULL, 0, 0, 0, 1, 690, 450, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (10, 1, N'St. Catherine', NULL, 1, 0, 0, NULL, 0, N'st-catherine', N'travco-travel_19900_Untitled-1.jpg', NULL, 0, 0, 0, 0, 690, 450, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (11, 1, N'Port Said', NULL, 1, 1, 0, NULL, 0, N'port-said', N'travco-travel_1282_Untitled-1.jpg', N'_19950_1.jpg', 1, 0, 0, 1, 690, 450, 2000, 500, 0, NULL, NULL, NULL, N'travco-travel_6076_Untitled-1-Recovered.jpg', NULL, NULL, NULL, NULL, NULL, 690, NULL, NULL, NULL, NULL, NULL, 450, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (12, 1, N'Alexandria', NULL, 1, 1, 0, NULL, 0, N'alexandria', N'travco-travel_318_Untitled-1.jpg', N'_14674_1.jpg', 1, 0, 0, 1, 690, 450, 2000, 500, 1, NULL, NULL, N'travco-travel_14932_Untitled-1-Recovered.jpg', N'travco-travel_5303_Untitled-1-Recovered.jpg', NULL, NULL, NULL, NULL, 690, 690, NULL, NULL, NULL, NULL, 450, 450, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (13, 1, N'Safaga', NULL, 1, 1, 0, NULL, 0, N'safaga', N'travco-travel_15701_Untitled-1.jpg', N'travco-travel_17415_Untitled-1.jpg', 1, 0, 0, 1, 690, 450, 1920, 530, 0, NULL, NULL, NULL, N'travco-travel_13395_Untitled-1-Recovered.jpg', N'travco-travel_6004_pexels-photo-4857556.jpeg', NULL, NULL, NULL, NULL, 690, 1880, NULL, NULL, NULL, NULL, 450, 1253, NULL, NULL, NULL, NULL, N'banner-safaga-shore.jpg', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (14, 1, N'Ain El Sokhna', NULL, 3, 1, 1, NULL, 0, N'ain-el-sokhna', N'travco-travel_667_Untitled-1.jpg', N'_17428_1.jpg', 1, 0, 0, 1, 690, 450, 2000, 500, 0, NULL, NULL, NULL, N'travco-travel_13077_Untitled-1-Recovered.jpg', NULL, NULL, NULL, NULL, NULL, 690, NULL, NULL, NULL, NULL, NULL, 450, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (15, 1, N'Abu Simbel', NULL, 1, 1, 0, NULL, 0, N'abu-simbel', N'travco-travel_8523_Untitled-1.jpg', N'travco-travel_5630_banner-Recovered.jpg', 0, 1, 0, 1, 690, 450, 1920, 530, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (31, 2, N'Dubai', NULL, 1, 0, 0, NULL, 0, N'dubai', N'travco-travel_2219_Untitled-1.jpg', NULL, 0, 0, 0, 1, 690, 450, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (32, 3, N'Amman', NULL, 1, 0, 0, NULL, 0, N'amman', N'travco-travel_9460_Untitled-1.jpg', NULL, 0, 0, 0, 1, 690, 450, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (33, 4, N'Muscat', NULL, 1, 0, 0, NULL, 0, N'muscat', N'travco-travel_17985_Untitled-1.jpg', NULL, 0, 0, 0, 1, 690, 450, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (34, 5, N'Tunisia', NULL, 1, 0, 0, NULL, 0, N'tunisia', N'travco-travel_10368_Untitled-1.jpg', NULL, 0, 0, 0, 1, 690, 450, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (35, 1, N'El Dakhla Oasis', NULL, NULL, 0, 0, NULL, 0, N'el-dakhla-oasis', N'travco-travel_6592_Untitled-1.jpg', NULL, 0, 0, 0, 1, 690, 450, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (36, 3, N'Aqaba', NULL, NULL, 0, 0, NULL, 0, N'aqaba', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (37, 3, N'Petra', NULL, NULL, 0, 0, NULL, 0, N'petra', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (38, 3, N'Wadi el Mujib', NULL, NULL, 0, 0, NULL, 0, N'wadi-el-mujib', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (39, 3, N'Um Qais', NULL, NULL, 0, 0, NULL, 0, N'um-qais', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (40, 3, N'The Dead Sea', NULL, NULL, 0, 0, NULL, 0, N'the-dead-sea', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (41, 3, N'Wadi Rum', NULL, NULL, 0, 0, NULL, 0, N'wadi-rum', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (42, 2, N'Abu Dhabi', NULL, NULL, 0, 0, NULL, 0, N'abu-dhabi', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (43, 2, N'Sharjah', NULL, NULL, 0, 0, NULL, 0, N'sharjah', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (44, 2, N'Fujairah', NULL, NULL, 0, 0, NULL, 0, N'fujairah', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (45, 2, N'Ajman', NULL, NULL, 0, 0, NULL, 0, N'ajman', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (46, 2, N'Ras Al Khaimah', NULL, NULL, 0, 0, NULL, 0, N'ras-al-khaimah', NULL, NULL, 0, 0, 0, 0, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (47, 4, N'Salalah', NULL, NULL, 0, 0, NULL, 0, N'salalah', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (48, 4, N'Nizwa', NULL, NULL, 0, 0, NULL, 0, N'nizwa', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (49, 4, N'Jabal Shams', NULL, NULL, 0, 0, NULL, 0, N'jabal-shams', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (50, 4, N'Jabal Akhdar', NULL, NULL, 0, 0, NULL, 0, N'jabal-akhdar', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (51, 1, N'Fayoum Oasis', NULL, NULL, 1, 0, NULL, 0, N'fayoum-oasis', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (52, 1, N'Abu Soma', NULL, NULL, 0, 0, NULL, 0, N'abu-soma', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (53, 1, N'Madinat Makadi', NULL, NULL, 0, 0, NULL, 0, N'madinat-makadi', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (54, 1, N'Madinat Coraya', NULL, NULL, 0, 0, NULL, 0, N'madinat-coraya', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (55, 1, N'Al Kharga Oasis', NULL, NULL, 0, 0, NULL, 0, N'al-kharga-oasis', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (56, 1, N'Almaza Bay', NULL, NULL, 0, 0, NULL, 0, N'almaza-bay', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (57, 1, N'Lake Nasser', NULL, NULL, 0, 0, NULL, 0, N'lake-nasser', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (58, 1, N'Quseir', NULL, NULL, 0, 0, NULL, 0, N'quseir', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (59, 1, N'Bahariya Oasis', NULL, NULL, 0, 0, NULL, 0, N'bahariya-oasis', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (60, 1, N'Farafra Oasis', NULL, NULL, 0, 0, NULL, 0, N'farafra-oasis', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations] ([Id], [CountryID], [DestinationNameSys], [SejourCode], [LocationID], [IsMainMenu], [IsTravelGuide], [DestinationMainVideo], [IntroIsVideo], [DestinationURL], [DestinationMainPhoto], [DestinationMainBanner], [IsPort], [IsEmbarkationCruise], [IsDeleted], [DestinationStatus], [DestinationMainPhoto_Width], [DestinationMainPhoto_Height], [DestinationMainBanner_Width], [DestinationMainBanner_Height], [IsFetaure], [DestinationMainPhoto_Packages], [DestinationMainPhoto_Cruises], [DestinationMainPhoto_Excursions], [DestinationMainPhoto_Shore], [DestinationMainPhoto_Transfers], [DestinationMainPhoto_Hotels], [DestinationMainPhoto_Packages_Width], [DestinationMainPhoto_Cruises_Width], [DestinationMainPhoto_Excursions_Width], [DestinationMainPhoto_Shore_Width], [DestinationMainPhoto_Transfers_Width], [DestinationMainPhoto_Hotels_Width], [DestinationMainPhoto_Packages_Height], [DestinationMainPhoto_Cruises_Height], [DestinationMainPhoto_Excursions_Height], [DestinationMainPhoto_Shore_Height], [DestinationMainPhoto_Transfers_Height], [DestinationMainPhoto_Hotels_Height], [DestinationMainBanner_Packages], [DestinationMainBanner_Cruises], [DestinationMainBanner_Excursions], [DestinationMainBanner_Shore], [DestinationMainBanner_Transfers], [DestinationMainBanner_Hotels], [DestinationMainBanner_Packages_Width], [DestinationMainBanner_Cruises_Width], [DestinationMainBanner_Excursions_Width], [DestinationMainBanner_Shore_Width], [DestinationMainBanner_Transfers_Width], [DestinationMainBanner_Hotels_Width], [DestinationMainBanner_Packages_Height], [DestinationMainBanner_Cruises_Height], [DestinationMainBanner_Excursions_Height], [DestinationMainBanner_Shore_Height], [DestinationMainBanner_Transfers_Height], [DestinationMainBanner_Hotels_Height]) VALUES (61, 1, N'Siwa Oasis', NULL, NULL, 0, 0, NULL, 0, N'siwa-oasis', NULL, NULL, 0, 0, 0, 1, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[tbl_Master_Destinations] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Master_Destinations_Content] ON 
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (1, 1, 1, N'Hurghada', N'Hurghada is the comprehensive seafront destination where the sun shines every day. Its sparkling sandy beaches, majestic deserts and superb climate makes it the sanctuary of absolute serenity and the land that opens up unlimited new adventure possibilities.
', N'<p>Hurghada is the comprehensive seafront destination where the sun shines every day. Its sparkling sandy beaches, majestic deserts and superb climate makes it the sanctuary of absolute serenity and the land that opens up unlimited new adventure possibilities.</p><p>Hurghada is the ideal relaxed and laid back destination that is more than suitable for those who love to take part in exploring aquatic recreation. The city is eminent for its magnificent underwater garden offshore and mesmerizing coral reefs that are considered one of the best in the world. Hurghada’s warm crystal waters provide a gateway to ultimate diving or snorkeling experiences through which an extensive variety of underwater species and reefs can be witnessed. </p><p>With its abundant prime diving sites , Hurghada is the destination that will introduce you to new ways of enjoying undersea views. You can take a glass-bottom boat ride that cruises over some beautiful coral reefs, where you can see a variety of brightly colored fish and maybe even sharks, or you could head underwater and take a ride aboard one of the small submarines.</p><p>Those who seek less dynamic activities can enjoy the sunny atmosphere and lucid water by going on deep sea fishing trips to uninhabited locations such as the Giftone Island , Abu Menkar Isle , or Mahmya Beach , or they can enjoy discovering Hurghada’s marine life’s treasures at the Aquarium . Other favorable activities include windsurfing, sailing, submarine tours, and glass bottomed boat excursions that provide vistas of the underwater world are also available. You may also be surprised to find a number of alluring historical landmarks &amp; Monuments around the city.&nbsp;&nbsp;</p><p>Jeep, camel, and quad biking safaris are among many activities that you will find around Hurghada’s fascinating deserts. Hurghada’s eastern desert is an enchanting and vast landscape of sand, rocks, oases and mountains, and is also home to the Bedouins. While you are there, a ride to a Bedouin village can’t be missed, as you will learn about Bedouin life, heritage and traditions.</p><p>Hurghada, the special community where local habits and culture is presented next to resort lifestyle and behavior, embraces a diverse collection of museums &amp; art galleries&nbsp; that present an assortment of flora and fauna of the Red Sea.</p><p>The town is ample with nightlife destinations</p> ', 1, N'Hurghada', N'Hurghada')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (2, 1, 2, N'Hurghada', N'', N'', 1, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (3, 2, 1, N'Aswan', N'Aswan, the third largest city in Egypt is home to some of Egypt’s most historic sites, with some of the most beautiful surroundings. Come visit Aswan and please your eyes with one of the most enchanting natural sceneries in the world. Tranquility and superb natural landscapes aren’t only what Aswan has to offer. This city invites you to trace back Egypt’s ancient mysteries through its legendary temples . Aswan is also home to plenty of attractions  that need to be seen when visiting this historic city.', N'<div><div>Today, Aswan is characterized by its abundance of palm trees and tropical gardens standing beside one of the wildest parts of the Nile River. As such, it has many islands dotted off its shores.</div><div><br></div><div>Aswan enjoys a distinctive African atmosphere. Nubian Dancers perform live in several hotels, and are surely a sight not to be missed as you will get a real taste of this ancient culture. Nubian villages must be visited, as they have an enchanting taste of Egypt in addition to the warm hospitality and fascinating culture, and The Nubian Cultural center&nbsp; is also a good option.</div><div><br></div><div>Hugely attractive, Aswan is the busy market center of the region. In fact, its ancient name of Sewent means “trade”. Aswan is still keeping its bustling spirit, as it’s lively with its colorful shops and bazaars.</div><div><br></div><div>Cruising the Nile in Aswan is definitely a memorable experience as you will be enjoying an enthralling blend of nature’s exquisiteness and the grace of the Pharaohs. Being a serene destination with magnificent scenery, Aswan also makes for an ideal gateway for honeymooners.</div><div><br></div><div>Located roughly where the Western Desert and the Eastern Desert meet, and just north of the great expanse of water created by the Aswan High Dam&nbsp; known as Lake Nasser , Aswan has a gorgeous winter climate and is a popular sun resort from November through to March with Egyptians as well as International vacationers.</div></div>   ', 1, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (4, 2, 2, N'Aswan', N'', N'', 1, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (5, 3, 1, N'Cairo', N'Cairo, the city that has never known how to sleep, isn’t only Egypt’s capital, but it’s the budding heart and the exuberant side of the serene land of the Nile. When you visit Cairo, you will never run out of things to do and see, as this city never fails to surprise its visitors. It is the ultimate blend of the grandeur of one of the world’s oldest civilizations and the modern day’s activities. As soon as you get there, the first thing you will be doing is joining the bee-lines that are formed around the Pyramids ; but don’t waste the whole time there, as this city has much more beyond these remarkable edifices.', N'<div>A large portion of the cultural and historical heritage of Egypt revolves around old Cairo; so when you’re there, don’t miss the opportunity of being taken on an enchanting tour to envision the glorious times of a once by-gone era. From the narrow streets of old Cairo, Coptic treasures , and Islamic Monuments&nbsp; and historical buildings which are punctuated by mosques, edged by the city gates and presided over with the Citadel . Cairo also never runs out of plentiful must-see sights .</div><div><br></div><div>As the sun sets, the Nile River lights up with cruising restaurants and feluccas (sail boats), and the boisterous city starts to unleash its nightlife surprises.&nbsp; The city has dozens of nightspots and a variety of settings where you can enjoy your night. Cairo’s bustling nightlife is diverse and has something for everyone, from quite intimate nights to those wild ones and from the austere dinner experiences to the posh five star service overlooking the Nile at a grand city hotel. Whatever your choice is, you can be sure to enjoy a night out. Lovers of traditional folklore may enjoy performances by talented artists at&nbsp; the Cairo Opera House. Cairo caters to all tastes, so if you are well cultured, and if exploring new cultures is part of your journey, then El Sawy Wheel&nbsp; makes an idyllic place for you. That isn’t all what the sprawling metropolis has to amuse you, as it invites you to relive the legend of the mysterious pharos at the Sound &amp; Light shows&nbsp; by the plateau of the great pyramids of Giza.</div><div><br></div><div>Dining in Cairo is a culinary adventure, as it offers a variety of the finest restaurants that serve different international cuisines, but if you really want to get introduced to the genuine taste of Egypt, you have to try its local cuisine. The Egyptian cuisine isn’t about tossing up delicious recipes, but it has something that suites that palate of one and all. Egyptian cuisine is served at the Imperial restaurants.&nbsp;</div><div><br></div><div><span style="color: var(--bs-card-color) ;">When your visit comes to an end, don’t pack up and fly back just yet, as there are some places where you need to stop by and grab a reminder of your holiday in Egypt. In addition to Khan El Khalily , Cairo boasts an extensive collection of shopping outlets&nbsp; from where you can buy souvenirs and gifts for your loved ones.</span><br></div> ', 1, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (6, 3, 2, N'Cairo', N'', N'', 1, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (7, 4, 1, N'Luxor', N'Imagine a very large and natural outdoor museum, and Luxor will more than measure up to the vision. Built on the 4,000-year old site of ancient Thebes, once ruled by great pharaohs such as Ramses II, this fascinating city stands on the east bank of the Nile and quite literally, resonates with history.', N'<div>Imagine a very large and natural outdoor museum, and Luxor will more than measure up to the vision. Built on the 4,000-year old site of ancient Thebes, once ruled by great pharaohs such as Ramses II, this fascinating city stands on the east bank of the Nile and quite literally, resonates with history. As well as incredible backdrops against its busy centre, the flat plains around it offer endless treasures. Yet for all these ancient relics, Luxor remains a lively modern city, pulsing with colorful life, bazaars and 4 and 5 star hotels which provide visitors with placid retreats from their action-packed itineraries.</div><div><br></div><div>Your first must-see here is the incredible Temple of Luxor&nbsp; in the heart of the modern town. Gaze wide-eyed at the incredible Obelisks&nbsp; built by Ramses II and wonder at an unimaginably long-gone world, and then finish up with a tour of the Mummified Museum . Luxor''s two other highpoints lie outside the city. Head north to gaze at the Temple of Karnak , a jaw-dropping series of vast shrines and pillars. Across the Nile the legendary Valley of the Kings , with its 62 hill-carved tombs, including those of Tutankhamun and Ramses II, awaits your presence. Descend into the eerie hieroglyphic-inscribed burial chambers and you''ll feel totally humbled. When you can lift your jaw off the floor - don''t forget the haunting Valleys of the Nobles and Queens also on the West Bank - head back to your hotel or cruise ship to cool off in the pool or at the bar, the latter providing the nightlife of choice for most visitors here. You''ll need time to recharge your batteries for the next day’s time traveling, after all.</div> ', 1, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (8, 4, 2, N'Luxor', N'', N'', 1, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (9, 5, 1, N'Sharm El Sheikh', N'Sharm El Sheikh, the city of peace, is your ticket to a world of unlimited rewards. It has what satisfies all tastes and inclinations. If you are a nature lover, relaxation seeker, or an adventure enthusiast, then Sharm El Sheikh is your ideal holiday destination.

Sharm El Sheikh is a memorable retreat at the Red Sea, standing as one of the world’s premier destinations. It enjoys year around sunshine and boasts an array of attractions  catering to different travelers.', N'<div>Sharm El Sheikh, the city of peace, is your ticket to a world of unlimited rewards. It has what satisfies all tastes and inclinations. If you are a nature lover, relaxation seeker, or an adventure enthusiast, then Sharm El Sheikh is your ideal holiday destination.</div><div><br></div><div>Sharm El Sheikh is a memorable retreat at the Red Sea, standing as one of the world’s premier destinations. It enjoys year around sunshine and boasts an array of attractions&nbsp; catering to different travelers.</div><div><br></div><div>The area consists of downtown Sharm El Maya, the busy Naama Bay&nbsp; and Sharks Bay&nbsp; further up the coast. Sharm El Sheikh, the holiday destination that will leave you with breathtaking memories is the most popular destination in South Sinai. It is also a perfect base from which to explore the region’s stunning coastline and rugged interior. You can dive, snorkel or simply paddle in the waters of the Red Sea at&nbsp; Ras Um El Sid , Turtle Bay&nbsp; and the Strait of Tiran . You can also visit the amazing national park of Ras Mohamed.</div><div><br></div><div>The city is renowned for housing one of the world’s best diving sites . The dazzling diversity of corals and aquatic species offer a picturesque adventure over the surface and through the depths of the Red Sea. For those who enjoy watching the splendid marine life of the Red Sea without being involved in any diving or snorkeling activities, there are scheduled submarine or glass boat trips that could be arranged. For the more adventurous travelers, mountain climbing is an intriguing experience in Sharm El Sheikh, given its mountain landscape.</div><div><br></div><div>Apart from aquatic activities, you can take a camel trek into the desert to visit Bedouin villages, mystical oases, or the mangrove forests of Nabq . Or you can stay in town, and enjoy the most exotic culinary experience at one of its world class international restaurants.</div><div><br></div><div>If you are looking for a luxurious lifestyle, then Sharm El Sheikh is the place to be as the city boasts an extensive collection of the world’s high-end hotels &amp; resorts. At night, the city thrives on the variety of nightlife&nbsp; and entertainment choices; there are plenty of bars, discotheques, and clubs.</div><div><br></div><div>After your trip to Sharm El Sheikh comes to an end, stop at its various shopping outlets&nbsp; to bring a souvenir for your loved ones. Shops offer beautiful handicrafts and other magnificent options to choose form.</div> ', 1, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (10, 5, 2, N'Sharm El Sheikh', N'', N'', 1, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (11, 6, 1, N'Marsa Alam', N'About 220 km south of Hurghada lies Marsa Alam; a tropical paradise boasting rich blue sea with coral reef barriers, paradisiacal beaches and palm trees. ', N'<p>About 220 km south of Hurghada  lies Marsa Alam; a tropical paradise boasting rich blue sea with coral reef barriers, paradisiacal beaches and palm trees. It’s among the fastest growing holiday resorts on the Red Sea Riviera, and is popular with windsurfers, scuba divers, snorkelers and sun worshipers fortunate enough to have already discovered the resort’s remote tranquility.

</p><p>For diving enthusiasts, Marsa Alam’s diving sites  are considered to be a glorious treasure waiting to be discovered, boasting beautiful coral reefs and an abundance of magnificently colored sea life where spinner dolphins and sea turtles swim freely.

</p><p>Adventure seekers have plenty of attractions to discover in the deserts near Marsa Alam. Visitors can go on quad bikes or jeep safaris off-road into the desert, and combine it with a visit to a Bedouin village, marking an unforgettable and adventurous experience. A mouthwatering barbecue dinner and a camel ride cannot be missed while visiting a Bedouin village.

</p><p>If history is what you’re after, then this is the right city. It is believed that the Pharaohs mined brilliant green emeralds in the mountainous areas of the Eastern Desert southwest of Marsa Alam. The Cleopatra Mines or Mons Smaragdus  became the most famous mining complex in the ancient world, and at various times the mines at Wadi Gemal , Wadi Nuqrus and Gebel Zabara were in use during the Ptolemaic and Roman periods. If you are interested in tracing back the Roman glory, the Roman Settlement of Myos Hormos  is not far from Marsa Alam.

</p><p>Being a relatively remote location that enjoys a peaceful and relaxing atmosphere, Marsa Alam is considered the ideal destination for honeymooners. As the night falls, the stars light up the sky and Marsa Alam is magically transformed into a romantic getaway. Cuddling up on the beach or in one of the many cozy cafes along the water and watching the countless shooting stars, while drinking freshly brewed tea definitely qualifies as a perfect end to the day.

</p><p>With crystal blue waters, tranquil sandy beaches, and the mysterious touch of the desert, Marsa Alam is the ideal gateway from a mundane life and conventional vacation spots.</p>', 1, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (12, 6, 2, N'Marsa Alam', N'', N'', 1, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (13, 7, 1, N'Dahab', N'Dahab, the pearl of the gulf, is situated between Sinai’s mountainous landscape and the Red Sea’s prestigious shoreline.', N'<p>Dahab, the pearl of the gulf, is situated between Sinai’s mountainous landscape and the Red Sea’s prestigious shoreline. Dahab, which means “Gold”, is named for the town’s spectacular beaches, sandy coastline, and its peaceful atmosphere.</p><p>Dahab is globally recognized as a splendid setting for windsurfing, owing to its natural atmosphere of reliable winds and flat water conditions in its sand spit. With its magnificent dive sites , Dahab is the city which will bring you closer to the thrilling diving experience of your dreams.</p><p>Predominantly a Bedouin enclave at its heart, visiting Dahab will be taking you on a journey to discover the Bedouin’s fascinating traditions and lifestyle, in addition to a Bedouin dinner. This also makes it a preferred base for desert excursions into the interior deserts, as well as to the lofty heights of the nearby Mount Sinai. You can also discover the beauty of land and sea by visiting Abu Gallum National Park.</p><p>Also on dry land, Wadi Gnai&nbsp; is a perfect spot for rock climbing enthusiasts, or simply a beautiful oasis in which to enjoy a pot of tea.</p><p>Dahab’s main city is Assala , the most developed conglomeration of campgrounds, hotels, shops, and bars that lie along the seashore. A few miles south of Dahab lies the beautiful adventurous spots of Qnai El Rayan and Qnai El Atshcan valleys.</p><p>With its charming combination of local Bedouin culture, magnificent landscape, gorgeous mountain and sea views, Dahab is considered an ocean-side refuge from the unrelenting heat of the desert.<br></p> ', 1, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (14, 7, 2, N'Dahab', N'', N'', 1, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (15, 8, 1, N'Nuweiba', N'Nuweiba, a haven of tranquility on the coast of south Sinai, is situated around 180 km south of Sharm El Sheikh ', N'<p>Nuweiba, a haven of tranquility on the coast of south Sinai, is situated around 180 km south of Sharm El Sheikh . It boasts an ideal central location and natural beauty, with turquoise waters edged by fine sandy beaches and rugged mountain chains. This scenery highlights Nuweiba as one of the most attractive destinations among Sinai’s resort towns.</p><p>It is divided to three primary sectors. The first is Nuweiba Tarabin , the northern area, and the second is the Town&nbsp; which was founded around the former Moshav Neviot, and the third part which is the Dunes .</p><p>Although it remains Egypt’s wild land of implausible splendor, Nuweiba has risen to become a unique vacation off the beaten path for tourists who seek a personal experience of the kind and friendly hospitality of Bedouins. It is also surrounded by various national parks , other popular destinations to visit, and a seemingly endless list of natural and historical places&nbsp; of interest. Not only that, but everyday in Nuweiba can be as energetic or relaxing as you desire.</p><p>Underwater activities are the main attraction in Nuweiba. Shallow reefs create interesting locations for snorkeling; and diving sites&nbsp; are considered a promise of the unsurpassed diving experience. Opportunities exist, too, for trekking, either by camel or jeep, into the astounding Sinai interior or through the Coastline Mountains.</p><p>If you are seeking a destination where hotel options are available as well as camps and laid back accommodation, all combined with local charm, culture, and character, Nuweiba should certainly be high on your list<br></p><p> </p>', 1, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (16, 8, 2, N'Nuweiba', N'', N'', 1, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (17, 9, 1, N'Taba', N'If a simple hippy lifestyle is what you are searching for, then come and visit this serene city. Situated approximately 200 kilometers from Sharm El Sheikh , Taba is a charming resort ideally positioned to meld beautifully into the overwhelming untamed desert, the natural backdrop of unspoiled mountains, and the pulsating sea.', N'<div>If a simple hippy lifestyle is what you are searching for, then come and visit this serene city. Situated approximately 200 kilometers from Sharm El Sheikh , Taba is a charming resort ideally positioned to meld beautifully into the overwhelming untamed desert, the natural backdrop of unspoiled mountains, and the pulsating sea.</div><div><br></div><div>Its magnificent tranquil atmosphere makes it the perfect sanctuary of your dreams; and its splendid surroundings are complemented by a diversity of lavish hotels to provide an unrivalled experience combining comfort and leisure.</div><div><br></div><div>Taba is abundant with water sports that include windsurfing, water skiing, parasailing, sailing, and canoeing. Its extravagant location makes it the perfect place for snorkelers and divers who seek a sensational adventure in exploring the prosperous natural marine life. It’s also home to one of the world’s most colorful diving sites .</div><div><br></div><div>For non-divers, the hotels in Taba offer plenty of other activities, such as golf, water-sports, camel rides, quad bike rides and boat-trips. A visit to the stunning landscapes of the Sinai Desert is a must while holidaying in Taba, as is a traditional Bedouin dinner under the stars. Taba is ideally placed to explore the fascinating historical sites of the area, being at the point where Egypt, Israel and Jordan meet. Visit the stunning St. Catherine Monastery , climb the majestic peak of Mount Sinai&nbsp; or take a trip to Pharaohs'' Island .</div><div><br></div><div>With the peaceful beauty of its Bedouin camps offering simple accommodations with unbeatable views of the sea, Taba will be the place where you get in touch with yourself and others.</div> ', 1, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (18, 9, 2, N'Taba', N'', N'', 1, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (19, 10, 1, N'St. Catherine', N'', N'', 1, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (20, 10, 2, N'St. Catherine', N'', N'', 1, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (21, 11, 1, N'Port Said', N'', N'', 1, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (22, 11, 2, N'Port Said', N'', N'', 1, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (23, 12, 1, N'Alexandria', N'Alexandria, Egypt’s second capital, is a true Mediterranean jewel that hovers between illusion and reality, between substance and poetic images, it’s the city developed from a mere anchorage to “The Pearl of the Mediterranean”. Alexandria has first come to existence when the young Macedonian leader, Alexander the Great, chose it to become the capital of Graeco- Roman Egypt in 332 B.C. It wasn’t only an ancient Egyptian center for learning, but it was also a historical setting that witnessed the stormy relationship between Mark Antony and Cleopatra.', N' <p>Alexandria, Egypt’s second capital, is a true Mediterranean jewel that hovers between illusion and reality, between substance and poetic images, it’s the city developed from a mere anchorage to “The Pearl of the Mediterranean”. Alexandria has first come to existence when the young Macedonian leader, Alexander the Great, chose it to become the capital of Graeco- Roman Egypt in 332 B.C. It wasn’t only an ancient Egyptian center for learning, but it was also a historical setting that witnessed the stormy relationship between Mark Antony and Cleopatra.</p>', 1, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (24, 12, 2, N'Alexandria', N'', N'', 1, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (25, 13, 1, N'Safaga', N'53 kilometers south of Hurghada, stands Safaga, an ancient marine port that is renowned for its unpolluted atmosphere, black sand dunes and mineral springs. Safaga is considered Egypt’s primary phosphate export center and vital marine port.', N'<div>Holidays in Safaga. All inclusive, Low-Cost, Package Holidays &amp; Late Deals</div><div><br></div><div>53 kilometers south of Hurghada, stands Safaga, an ancient marine port that is renowned for its unpolluted atmosphere, black sand dunes and mineral springs. Safaga is considered Egypt’s primary phosphate export center and vital marine port. It’s also an exceptionally important therapeutic destination, offering its visitors an extraordinary potential of curing psoriasis, rheumatoid, arthritis, mild neck and back aliment, and improving blood circulation. It also has an enormous effect for skin treatment and beautification purposes.</div><div><br></div><div>Safaga’s pure beaches and stiff breezes make it an outstanding spot for diving holidays . In spite of being an eminent diving and snorkeling site, Safaga is more renowned for kite and wind surfing which made it the ideal setting for the 1993 World Windsurfing Championship.</div><div><br></div><div>It also makes a perfect base for sightseeing, with the desert&nbsp; to the west holding as many treasures on dry land as the Red Sea holds beneath the surface to the east.</div><div><br></div><div>Day trips by speed boats to the Fire Wall , Forbidden Reef , and the ferry wreck&nbsp; of Arish El Tor can be coordinated with local guides. Furthermore, trips could be arranged to the famous Tobia Islands , Panorama of Abu Qitan&nbsp; towering reefs, and the legendary Mons Claudianus , the ruins of a Roman Settlement dating back to 68 A.D where granite buildings rocks from surrounding mountains were used for the sole purpose of beautifying Imperial Rome.</div> ', 1, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (26, 13, 2, N'Safaga', N'', N'', 1, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (27, 14, 1, N'Ain El Sokhna', N'If exploration is what you are looking for, then Ain El Sokhna should be your destination of choice. The city is a short drive away from Cairo, marking the perfect location from which to enjoy both the Pyramids of Cairo and the glorious beaches.', N' <p>If exploration is what you are looking for, then Ain El Sokhna should be your destination of choice. The city is a short drive away from Cairo, marking the perfect location from which to enjoy both the Pyramids of Cairo and the glorious beaches.</p>

<p>The name Ain El Sokhna (which translates as ‘hot springs’) refers to the nearby sulfur springs that flow from Gebel Ataqa, the Eastern Desert’s northernmost mountain. Being a year-round sunshine destination with gentle waves of the clear Red Sea that is located barely more than an hour from the capital make Ain El Sokhna the ideal destination to have a break from the congestion of the city.</p>

<p>Its crystal waters and pristine beaches are the reason why Ain El Sokhna is known as a center for deep- sea fishing, while Zaafarana  is among the world''s premier diving locations and famous for its wind and kite surfing too. Beaches and water sports aren’t only what this tourist resort has to offer you, as it is also a favorite spot for underwater photography, as well as an ideal one for camping. With a constant breeze, windsurfing is also popular in this city. In land, desert safaris in the nearby oasis and mountain canyons add to the list of attractions.</p>

<p>For those who want to cram in some sightseeing, there are appealing options: One of the world’s greatest feats of engineering, the Suez Canal , is less than an hour’s drive away. Make stops at St. Anthony’s Monastery  and the Monastery of St. Paul . The former, which bears the name of one of the earliest advocates of Christian monasticism, is among the oldest inhabited monasteries in Egypt. With fortress-style architecture built to withstand Bedouin attacks, it encloses gardens, a mill, a bakery and five churches, and features a series of unique wall paintings of holy knights and the hermits who founded the monastery. Its library is home to over 1,700 handwritten manuscripts. A picturesque two-kilometer hike from the monastery will bring you to panoramic views of the mountains and the Red Sea at the cave where St. Anthony lived as a hermit.</p>

<p>The spectacular high mountains, glistening sandy beaches, and clear water make Ain El Sokhna the holiday destination where you will discover the true meaning of fishing, diving, skating, and mountain climbing. It also plays a major role in therapeutic tourism as it contains a lot of sulfur and mineral springs that cure various diseases.</p> ', 1, N'Ain El Sokhna', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (28, 14, 2, N'Ain El Sokhna', N'', N'', 1, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (29, 15, 1, N'Abu Simbel', N'Situated near Egypt’s southern borders with Sudan, 280 km south of Aswan, the Temples of Abu Simbel are amongst the most interesting of all Pharaonic temples.  There are two temples cut into the rock dating back to king Ramses II - one is for Ramses and the other for Nefertari.', N' 	<p>Abu Simbel Temples</p> <p>Situated near Egypt’s southern borders with Sudan, 280 km south of Aswan, the Temples of Abu Simbel are amongst the most interesting of all Pharaonic temples. &nbsp;There are two temples cut into the rock dating back to king Ramses II - one is for Ramses and the other for Nefertari.</p> <p>The Great Temple</p> <p>Ramses II built this for himself to be adored beside the gods Amun-Re, Re-Horakhty, and Ptah. It is 33m high and 38m wide and 56m deep. King Ramses II built this temple for himself not only as a king but also as a god as the facade of the temple shows how king Ramses was worshiping himself as a god. It also showed him as a warrior and after that as a peace maker when he signed the first peace treaty in history and married the daughter of the Hittites.</p> <p>Temple of Nefertari<br> The Temple of Queen Nefertari is located 120m from the Temple of Ramses II and was also built by Ramses II, dedicated to the Goddess Hathor and to his wife Queen Nefertari. Queen Nefertari was the principal, and the most beloved, wife of King Ramses II. It is also a rock-cut Temple with a façade of about 28m long and 12m high, which contains 6 standing colossi, each one being about 11m in height. Four of them represent Ramses II and the other two represent Queen Nefertari, each accompanied by two smaller figures of their children.</p> <p>The entrance leads to a square hall, which is supported by 6 Hathor-headed pillars decorated with scenes depicting the King and the Queen making offerings to different deities. At the end of the hall there is a doorway leading to a transverse vestibule decorated with scenes of King Ramses II making offerings to Re-Horakhty, while the Queen is presenting flowers to Khenum, Sat-tet and Anket.The Transverse Hall leads to the Sanctuary, which contains a niche in the rear wall with a statue of Goddess Hathor, as a cow, protecting Ramses II.</p> <p><br> The view from this place is incredible. Imagine yourself in the middle of the desert, and at the shores of Lake Nasser. &nbsp;The temples got world fame when an international UNESCO operation was needed to save them from the rising water of Lake Nasser. The bright colors in the carvings are essentially intact.&nbsp;</p>', 1, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (30, 15, 2, N'Abu Simbel', N'', N'', 1, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (31, 31, 1, N'Dubai', N'', N'', 1, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (32, 31, 2, N'Dubai', N'', N'', 1, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (33, 32, 1, N'Amman', N'', N'', 1, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (34, 32, 2, N'Amman', N'', N'', 1, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (35, 33, 1, N'Muscat', N'', N'', 1, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (36, 33, 2, N'Muscat', N'', N'', 1, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (37, 34, 1, N'Tunisia', N'Destination Intro', N'Destination Overview ', 1, N'Meta Tag Title', N'Meta Tag Description')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (38, 34, 2, N'Tunisia', N'', N'', 1, NULL, NULL)
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (39, 35, 1, N'El Dakhla Oasis', N'Dakhla Oasis, one of Egypt’s mot remote oases, is a splendid refugee that is surrounded by a wall of colorful rock formations and fertile cultivated areas scattered between sand dunes within the area, offering natural magnificent scenery.

If you are interested in ancient history, then visiting Mut , Dakhla’s largest city, is a must. Another attractive site to visit is Al Qasr , the Oasis’s second main city. Dakhla is also the home to many ancient remains including the amazing Deir El Haggar  and the memorable Muzawaka Tombs .', N'  <p>Dakhla Oasis, one of Egypt’s mot remote oases, is a splendid refugee that is surrounded by a wall of colorful rock formations and fertile cultivated areas scattered between sand dunes within the area, offering natural magnificent scenery.</p> <p>If you are interested in ancient history, then visiting Mut , Dakhla’s largest city, is a must. Another attractive site to visit is Al Qasr , the Oasis’s second main city. Dakhla is also the home to many ancient remains including the amazing Deir El Haggar &nbsp;and the memorable Muzawaka Tombs .</p> <p>If exploration is what you seek, then you can’t miss visiting Dakhla’s numerous thrilling villages &nbsp;that are waiting to be discovered. Dakhla is also abundant with charming natural springs, one of which is Ain Al Qasr springs , In addition to several lakes, and fish ponds .</p> <p>The enchanting blend of the desert’s mystery and the Bedouin’s simplicity makes safari trips another god bet here.</p> <p>Being a lush region that is brimming with green gardens, orchards, and diverse wildlife against a mountainous backdrop, the Dakhla Oasis is the perfect gateway for a vacation of unlimited relaxation.</p>', 1, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (40, 35, 2, N'El Dakhla Oasis', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (41, 36, 1, N'Aqaba', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (42, 36, 2, N'Aqaba', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (43, 37, 1, N'Petra', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (44, 37, 2, N'Petra', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (45, 38, 1, N'Wadi el Mujib', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (46, 38, 2, N'Wadi el Mujib', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (47, 39, 1, N'Um Qais', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (48, 39, 2, N'Um Qais', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (49, 40, 1, N'The Dead Sea', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (50, 40, 2, N'The Dead Sea', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (51, 41, 1, N'Wadi Rum', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (52, 41, 2, N'Wadi Rum', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (53, 42, 1, N'Abu Dhabi', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (54, 42, 2, N'Abu Dhabi', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (55, 43, 1, N'Sharjah', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (56, 43, 2, N'Sharjah', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (57, 44, 1, N'Fujairah', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (58, 44, 2, N'Fujairah', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (59, 45, 1, N'Ajman', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (60, 45, 2, N'Ajman', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (61, 46, 1, N'Ras Al Khaimah', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (62, 46, 2, N'Ras Al Khaimah', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (63, 47, 1, N'Salalah', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (64, 47, 2, N'Salalah', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (65, 48, 1, N'Nizwa', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (66, 48, 2, N'Nizwa', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (67, 49, 1, N'Jabal Shams', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (68, 49, 2, N'Jabal Shams', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (69, 50, 1, N'Jabal Akhdar', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (70, 50, 2, N'Jabal Akhdar', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (71, 51, 1, N'Fayoum Oasis', N'Fayoum is a wonderful area of Egypt with a rich and interesting history. It is an area where Egyptians often vacation and which is constantly growing more popular among Europeans.

This 692 square mile depression was a lush paradise during prehistoric times. Its water level was eighty-five meters higher than today (currently 45 meters below sea level) and the Nile regularly flooded through the low mountains separating it from the Fayoum.', N' <p>Fayoum is a wonderful area of Egypt with a rich and interesting history. It is an area where Egyptians often vacation and which is constantly growing more popular among Europeans.</p> <p>This 692 square mile depression was a lush paradise during prehistoric times. Its water level was eighty-five meters higher than today (currently 45 meters below sea level) and the Nile regularly flooded through the low mountains separating it from the Fayoum.</p> <p>At 215 square km, the current lake Qaroun remains Egypt''s largest salt water lake. The prehistoric people who lived here were, at first, nomadic hunters and gatherers, but later began harvesting plants near the lake.</p> <p>This developed into what is said to be the earliest agricultural area in the world, where fences were erected and guarded warehouses built. The peacefulness of the area is a relief from the hustle and bustle of Cairo , from which it is a brief trip.</p> <p>Bird life still abounds around Lake Qaroun, bordered by semi-nomadic Bedouin settlements and fishing villages. Here, on the edge of the desert, you can sail, windsurf, swim and fish. Other places of outstanding natural beauty near Fayoum are the hot springs at Ain Al Siliyin, where you can bath and the waterfalls at Wadi Al Rayan, 40km towards Bahareya , also suitable for swimming and picnics.</p> ', 1, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (72, 51, 2, N'Fayoum Oasis', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (1071, 52, 1, N'Abu Soma', N'Located approximately 45 km south of Hurghada on the Red Sea, Abu Soma & Soma Bay are one half of the fantastically windy Kriasi Bay popular for those who enjoy kite surfing and windsurfing.  The Resort is situated on a peninsula surrounded by sparkling turquoise waters with excellent reefs & corals providing perfect sites for good snorkeling and scuba diving, soft sandy beaches and impressive desert scenery. Holidays in Abu Soma are relaxing yet a great option for families & those seeking a comfortable hotel- based holiday with loads of activities on & off the water. Apart from the stunning beaches', N' <p>Located approximately 45 km south of&nbsp;<em><strong>Hurghada</strong></em>&nbsp;on the Red Sea,&nbsp;<em><strong>Abu Soma &amp; Soma Bay&nbsp;</strong></em>are one half of the fantastically windy Kriasi Bay popular for those who enjoy kite surfing and windsurfing.&nbsp; The Resort is situated on a peninsula surrounded by sparkling turquoise waters with excellent reefs &amp; corals providing perfect sites for good snorkeling and scuba diving, soft sandy beaches and impressive desert scenery. Holidays in&nbsp;<strong><em>Abu Soma&nbsp;</em></strong>are relaxing yet a great option for families &amp; those seeking a comfortable hotel- based holiday with loads of activities on &amp; off the water. Apart from the stunning beaches,&nbsp;<strong><em>Abu Soma</em></strong>&nbsp;is close to amazing desert scenery making fun day trips to places like the temples of Luxor and Karnak a feasible option for those interested in exploring the culture- rich cities of Luxor &amp; Aswan. Not to mention the day trips to Marsa Alam &amp; Alexandria cities as well.<br> The sea water is highly saline and very rich in minerals which are extremely beneficial for the skin.&nbsp; Together with its unpolluted atmosphere and mineral springs, the destination has acquired a reputation as a popular curative or health spa destination said to be very effective in alleviating rheumatoid arthritis and psoriasis.</p>', 1, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (1072, 52, 2, N'Abu Soma', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (1073, 53, 1, N'Madinat Makadi', N'Madinat Makadi is a thriving holiday Egypt destination with an impressive variety of hotels and family resorts that provide something for everyone.

Makadi Bay has a long beach with a spectacular house reef and is the ideal setting for pure relaxation. Madinat Makadi offers the magnificent Red Sea and stunning beaches, majestic desert and surrounding mountains with breathtaking views.', N' <p><strong>Madinat Makadi</strong> is a thriving holiday Egypt destination with an impressive variety of hotels and family resorts that provide something for everyone.</p> <p>Makadi Bay has a long beach with a spectacular house reef and is the ideal setting for pure relaxation. <strong>Madinat Makadi</strong> offers the magnificent Red Sea and stunning beaches, majestic desert and surrounding mountains with breathtaking views.</p> <p>Located just 30 km away from Hurghada International Airport, <strong>Madinat Makadi</strong> covers 617 acres of four and five-star hotels &nbsp;located directly on the beach along with essential services and entertainment venues including numerous Spas, a Championship Golf Course and Academy &nbsp;and a Tennis Academy under development.</p>', 1, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (1074, 53, 2, N'Madinat Makadi', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (1075, 54, 1, N'Madinat Coraya', N'Madinat Coraya is located about 65 km from Marsa Alam  City and just 5 km from Marsa Alam International Airport. The resorts of Madinat Coraya overlook Coraya Bay, an untouched Red Sea paradise renowned for astonishing emerald and turquoise waters.

Visitors can enjoy an unhurried pace and tranquillity with first class service against majestic mountain views, a breathtaking sea environment and mystifying reefs set in the protected beauty of a nature reserve stretches from Madinat Coraya to Gebel Elba in the south. Madinat Coraya and Coraya Bay in particular are tipped to be the next diving "hot spot".', N' <p>Madinat Coraya is located about 65 km from Marsa Alam &nbsp;City and just 5 km from Marsa Alam International Airport. The resorts of Madinat Coraya overlook Coraya Bay, an untouched Red Sea paradise renowned for astonishing emerald and turquoise waters.</p> <p>Visitors can enjoy an unhurried pace and tranquillity with first class service against majestic mountain views, a breathtaking sea environment and mystifying reefs set in the protected beauty of a nature reserve stretches from Madinat Coraya to Gebel Elba in the south. Madinat Coraya and Coraya Bay in particular are tipped to be the next diving "hot spot".</p> <p>The whole coastline offers exceptional diving sites as well as an array of sporting activities on land and in the water for those who prefer a more active Egypt holiday experience. The most immediate attraction of the area is undoubtedly the underwater world of reefs and marine wildlife.</p> <p>Madinat Coraya is one of Egypt''s most peaceful destinations on the Red Sea coast. It’s a truly idyllic getaway and is the perfect base for a relaxing or exciting Egypt holiday. Aside from its growing reputation as one of the best diving resorts on the Red Sea, Madinat Coraya’s proximity to Luxor &nbsp;makes it an excellent base for trips to the various historical sites inland to the west along the Nile. However you decide to spend your time, Madinat Coraya will deliver a truly memorable holiday under the Egyptian sun.</p>', 1, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (1076, 54, 2, N'Madinat Coraya', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (1077, 55, 1, N'Al Kharga Oasis', N'El Kharga Oasis is one of Egypt most modern and bustling oases that still retains the allure of the desert. As soon as you arrive there, the tang of dates will assault your nose and the sight of the date palms will capture your eyes marking the typical oasis mirage.

If a desert expedition is what you’re after, then come to Kharga Oasis and let your self be enchanted by the mystery of its sand dunes. You can also let the warm water of its thermal springs cuddle you while pleasing your eyes with a breathtaking view of the glittering stars.', N' <p>El Kharga Oasis is one of Egypt most modern and bustling oases that still retains the allure of the desert. As soon as you arrive there, the tang of dates will assault your nose and the sight of the date palms will capture your eyes marking the typical oasis mirage.</p> <p>If a desert expedition is what you’re after, then come to Kharga Oasis and let your self be enchanted by the mystery of its sand dunes. You can also let the warm water of its thermal springs cuddle you while pleasing your eyes with a breathtaking view of the glittering stars.</p> <p>El Kharga Oasis is your ticket to a journey through various eras of fame and glory. Historical references indicate that expeditions to El Kharga Oasis date back to the Old Kingdom, although little evidence remains about its existence in Pharaonic times. With the arrival of Romans to Egypt, El Kharga’s prosperity escalated as they created new wells of cultivation and a series of settlements to protect caravan trade routes. These Roman Settlements &nbsp;are considered a must to see sight in Kharga. History enthusiast have just find their place to be, as Kharga has numerous awe inspiring historical attractions &nbsp;that worth visiting.</p> <p>Pottery is one if the crafts celebrated in Kharga, so when you are there don’t miss visiting the various shops selling ceramic products as well as the pottery factory. You can also get some good bargains at Kharga’s lively bazaar or souk.</p>', 1, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (1078, 55, 2, N'Al Kharga Oasis', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (1079, 56, 1, N'Almaza Bay', N'Nestling on a bay on the shores of the Mediterranean Sea, Mersa Matruh (often called Marsa Matruh in some holiday brochures or occasionally spelled Marsa Matrouh) is less than 149 miles west of Alexandria and can easily be reached by air through Matrouh International Airport or Burg El Arab Airport in Alexandria. Whether you spell it Mersa Matruh, Marsa Matruh or Marsa Matrouh this small harbour town and the newly developed Almaza Bay Resort Complex are great places for a holiday in Egypt! ', N' <p>Nestling on a bay on the shores of the Mediterranean Sea, Mersa Matruh (often called Marsa Matruh in some holiday brochures or occasionally spelled Marsa Matrouh) is less than 149 miles west of Alexandria and can easily be reached by air through Matrouh International Airport or Burg El Arab Airport in Alexandria. Whether you spell it Mersa Matruh, Marsa Matruh or Marsa Matrouh this small harbour town and the newly developed Almaza Bay Resort Complex are great places for a holiday in Egypt!&nbsp;<br> Founded by Alexander the Great, it was used as a port by the Egyptians of Ptolemaic times, the Byzantines and the Romans.&nbsp;&nbsp; It is justly renowned for its four and a half miles of exquisite soft white sandy beaches and the calm, gentle, azure waters of its bay which is enclosed and protected by a natural rock harbour. Almaza Bay is just a short drive from Mersa Matruh and the International airport, and is the perfect location for all inclusive Egypt holidays.&nbsp;&nbsp; It is a relatively unspoilt and tastefully developed Egypt holiday resort that offers virtually constant sunshine and calm waters.&nbsp; Mersa Matruh is well connected to other towns and cities like Alexandria and Cairo by road and rail. The town enjoys a lively, relaxed, night life and atmosphere boosted by the fact that it’s becoming popular as a get-away for residents of Cairo escaping the capital city’s sweltering summer months.<br> During World War II, the railway station named Marsa Matruh was the terminus for the British 8th Army’s single-track railway which shipped men and material to El Alamein, where Rommel’s offensive against the allied forces in the western desert ultimately ground to a halt.&nbsp; Rommel''s Cave, which the Desert Fox used as his staff headquarters, is also close to the town and has been converted into a museum.</p>', 1, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (1080, 56, 2, N'Almaza Bay', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (1081, 57, 1, N'Lake Nasser', N'Lake Nasser was formed when the High Dam was built above Aswan on the Nile. Built between 1960 and 1972 by Russian engineers, the High Dam has meant the end of Egypt''s dependence on the annual flooding of the Nile, but has brought its own problems.  The most pressing of these at the time of construction was the flooding of the Nile Valley in Nubia, which would cover both modern villages and many ancient Egyptian sites in deep water.', N' <p>Lake Nasser was formed when the High Dam was built above Aswan on the Nile. Built between 1960 and 1972 by Russian engineers, the High Dam has meant the end of Egypt''s dependence on the annual flooding of the Nile, but has brought its own problems. &nbsp;The most pressing of these at the time of construction was the flooding of the Nile Valley in Nubia, which would cover both modern villages and many ancient Egyptian sites in deep water.</p> <p>Several important Nubian and Ancient Egyptian archaeological sites, most spectacularly the temples at Abu Simbel, were dismantled block by block and moved to higher ground. The Sudanese river port and railway terminal of Wadi Halfa was lost beneath the waters and Egypt''s entire Nubian community from the upper reaches of the Nile saw their villages disappear and were forced to relocate. Named in honour of Gamal Abdel Nasser, the second President of Egypt who led the bloodless coup that toppled the monarchy of King Farouk, Lake Nasser is a now a vast reservoir straddling southern Egypt and northern Sudan.&nbsp;</p> <p>Strictly speaking, “Lake Nasser" refers only to the 83% of the man-made lake that is in Egyptian territory. &nbsp;The Sudanese prefer to call their smaller body of water Lake Nubia. Sport fishing among tourists, especially for Nile Perch, has become increasingly popular on the lake both on the shore and from boats. &nbsp;Very few Nile cruise companies cruise the lake itself, but Travcotels offer a choice of two ships: the Five-star Deluxe Jaz Omar El Khayam and the more intimate, four-star Tania.</p>', 1, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (1082, 57, 2, N'Lake Nasser', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (1083, 58, 1, N'Quseir', N'Al Quseir holds the distinction of being one of the Red Sea’s most charming towns. It is situated 85km south of Safaga , and has been used as both a trade port and a base for exploration by many different civilizations. One of Egypt’s earliest places, the city stands at the end of the shortest route between the Nile and the Red Sea, which made it a vital link between Egypt and the wider world in the days before the Suez Canal. With over than 4000 years of ancient history, Al Quseir is home to several attractions  that bring life to the history.', N' <p>Al Quseir holds the distinction of being one of the Red Sea’s most charming towns. It is situated 85km south of Safaga , and has been used as both a trade port and a base for exploration by many different civilizations. One of Egypt’s earliest places, the city stands at the end of the shortest route between the Nile and the Red Sea, which made it a vital link between Egypt and the wider world in the days before the Suez Canal. With over than 4000 years of ancient history, Al Quseir is home to several attractions &nbsp;that bring life to the history.</p> <p>Being the place where Queen Hatshepsut set off from an expedition to the mystical African land of Punt, Al Quseir represents the touch of mystery given to the tranquility of the Red Sea. Being the city that witnessed all the phases of the World’s transformation, Al Quseir is the tale teller of many international civilizations that lived on its land. It hosts 200 hieroglyphic tablets adorning the cliffs at Wadi Hamamat , which joins Al Quseir to Qift on the Nile. Many of these tablets are 4,000 years old, and depict international reed boats traveling to the Nile. The Pharaohs weren’t the only guests who were hosted on this land, as Romans too built watch towers along this Wadi, and many of them are still standing today. The Ottoman culture represents another major influence on the look of the city, as the Ottoman Fortress of Sultan Selim &nbsp;stands here. Napoleon and the British army also had an impact on this land, as they occupied its port, which now has varied architecture from both of these influences. There are British and French 19th century buildings juxtaposed with the Islamic influenced buildings along with the ancient structures from Roman times and beyond.</p> <p>Al Quseir enjoys a year- round climate that makes it perfect for strolling its delightful historic districts, with its narrow streets, colorful bazaars, as well as cafes and restaurants serving mouth watering seafood dishes.</p> <p>Complementing the historically themed attractions are contemporary adventures never imagined by ancient explorers. Desert safaris will take you on a journey where you will be discovering the desert’s vats expanses of sand, past rocks, and mountains until you land in a Bedouin village. Upon arrival, you may get a chance to go on a camel ride, in addition to experiencing true Bedouin hospitality and entertainment. If you are willing to take in as much of Egypt as possible, you can easily reach Luxor &nbsp;and even Cairo , both well known throughout the world as centers of ancient history. Or you can also have a day trip to the serene city of Aswan .</p> <p>If you are a water sports enthusiast, then you have just found your place to be. Al Quseir coral reefs are extremely diverse with scattered pinnacles, tunnels, chimneys, outcrops, and caves waiting to be discovered. Al Quseir has plenty of diving sites &nbsp;that showcase one of the world’s most astonishing underwater views.</p>', 1, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (1084, 58, 2, N'Quseir', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (1085, 59, 1, N'Bahariya Oasis', N'If you want to feel the thrill of a true desert exploration, then you have to visit Bahariya Oasis. Bahariya Oasis, Egypt’s most peaceful oasis, accommodates a vast array of natural recourses and a significant assortment of historical relics and monuments. It is situated in a depression about 30 kilometers away from Cairo, and Bawati  is its capital', N' <p>If you want to feel the thrill of a true desert exploration, then you have to visit Bahariya Oasis. Bahariya Oasis, Egypt’s most peaceful oasis, accommodates a vast array of natural recourses and a significant assortment of historical relics and monuments. It is situated in a depression about 30 kilometers away from Cairo, and Bawati &nbsp;is its capital</p> <p>After an exciting trip in the desert, head to the springs to wash up. The oasis is renowned to produce approximately 400 minerals and hot sulfur springs, most imperatively are Bir Hakima, Bir Haifa, Bir Al Matar and Bir Al Ghaba. Moreover, there are the exceptional springs of Ein El Bishmo that are exclusive in the flow of both cold and hot water from distinct sources to blend through cracked stones in a rocky creek.</p> <p>Bahariya Oasis, &nbsp;an unspoilt refugee, isn’t only the place where you can sense adventures through desert safaris and excursions, but it is also the place that will take you on a journey through the mysterious life of the Pharaohs. It is home to most antiquities and relics that belong to the 26th dynasty that is also known as the Saite Period. One of the major archeological sites to visit is Alexander the Great Temple . Another interesting monument is the largest Ptolemaic necropolis dedicated to the Ibis bird, an object of religious veneration in ancient Egypt. The Valley of the Golden Mummies &nbsp;is a must see site too.</p> <p>Bahariya Oasis is your entrance gate to a supernatural holiday where you can blend the sense of adventure with the simplicity of the Bedouins’ life. The attractive scenery of palm trees along with the magical sand dunes and the Bedouin folklore will gather to grant you with the most pleasurable holiday experience.</p>', 1, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (1086, 59, 2, N'Bahariya Oasis', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (1087, 60, 1, N'Farafra Oasis', N'The peaceful Farafra oasis has a distinctive charm of its own. It is the nearest oasis to the white desert , marking the perfect sanctuary for a tranquil holiday among the white creamy desert and its gigantic rock formations.

If you are fund of arts, then Farafra will represent a true exploration experience for you. Its art center accommodates a museum and a studio where paintings and ceramic art work of local artists are displayed, in addition to a garden teeming with sculptures made of natural elements extracted from the desert. The oasis is eminent for the diverse assortment of beautiful hand-kitted camel-hair sweaters and scarves as well as safari day trips by jeep and camel treks.', N' 	<p>The peaceful Farafra oasis has a distinctive charm of its own. It is the nearest oasis to the white desert , marking the perfect sanctuary for a tranquil holiday among the white creamy desert and its gigantic rock formations.</p> <p>If you are fund of arts, then Farafra will represent a true exploration experience for you. Its art center accommodates a museum and a studio where paintings and ceramic art work of local artists are displayed, in addition to a garden teeming with sculptures made of natural elements extracted from the desert. The oasis is eminent for the diverse assortment of beautiful hand-kitted camel-hair sweaters and scarves as well as safari day trips by jeep and camel treks.</p> <p>In Pharaonic times, Farafra was known as Taiht, the Land of the Cow. The oldest part of the oasis lies on a hillside in a serene context next to palm orchards near the hot sulphur springs . If you want to be introduced to the nomadic culture, Qasr Farafra &nbsp;is waiting to be discovered.</p>', 1, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (1088, 60, 2, N'Farafra Oasis', N'', N'', 0, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (1089, 61, 1, N'Siwa Oasis', N'With an ambience that is genuinely relaxing, Siwa, An oasis of surprises in a stunning desert landscape, is the true magical place to be. It’s one of the most mysterious of all Egypt''s oases, and is also the most fascinating. Its history has not only been shaped by all major civilizations, but also by the contrast of the surrounding desert with the lush soil of the oasis setting.', N' 	<p>With an ambience that is genuinely relaxing, Siwa, An oasis of surprises in a stunning desert landscape, is the true magical place to be. It’s one of the most mysterious of all Egypt''s oases, and is also the most fascinating. Its history has not only been shaped by all major civilizations, but also by the contrast of the surrounding desert with the lush soil of the oasis setting.</p> <p>Come and experience the delights that Siwa has to offer. Climb through the ruins of the old city for magnificent views of the whole oasis. Walk, hire a bicycle or ride in a caretta (donkey cart) to the outlying sights &nbsp;and bathing places. Take a dip in one of the many cool and refreshing springs . Taste traditional Siwan food. Enjoy a truly unforgettable and unique cultural experience. Or you wonder in its traditional souks (markets) making new friends and drinking too much tea. Siwa has it all; you just need time and an open mind to explore it.</p> <p>Siwais legitimately a place for thrill seekers and safari enthusiasts. Picture yourself sleeping in the desert''s enormous sand dunes under the moon and the stars, warming by the fire andis legitimately a place for thrill seekers and safari enthusiasts. Picture yourself sleeping in the desert''s enormous sand dunes under the moon and the stars, warming by the fire and sipping on their special green tea as your traditional Siwan dinner is being cooked. That isn’t all, as you will be enjoying Siwan music while lying under the stars. You can also relax in Bir Wahid , an amazing hot water spring and after, cool off in the breathtaking cold water spring. Take a walk back in time into ancient Roman tombs and search for remains from the times of the Pharaohs.</p> <p>Siwa, historically known as Palm Land, is the home to a diversity of relics and untouched culture due to its remoteness and isolation from modern day community. Though relaxing and certainly now a part of the tourist community in Egypt, it is very traditional, and visitors should keep this in mind when traveling to the area. It celebrates the prosperity and diversity of its culture during the annual Tourist Festivals that are held annually.</p>', 1, N'', N'')
GO
INSERT [dbo].[tbl_Master_Destinations_Content] ([Id], [DestinationID], [LangID], [DestinationName], [DestinationIntro], [DestinationDetails], [LangStatus], [DestinationMetatagTitle], [DestinationMetatagDescription]) VALUES (1090, 61, 2, N'Siwa Oasis', N'', N'', 0, N'', N'')
GO
SET IDENTITY_INSERT [dbo].[tbl_Master_Destinations_Content] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Master_CabinCategoryTypes] ON 
GO
INSERT [dbo].[tbl_Master_CabinCategoryTypes] ([Id], [CabinCategoryTypeName]) VALUES (1, N'Cabin')
GO
INSERT [dbo].[tbl_Master_CabinCategoryTypes] ([Id], [CabinCategoryTypeName]) VALUES (2, N'Suite')
GO
SET IDENTITY_INSERT [dbo].[tbl_Master_CabinCategoryTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Master_CruiseLocations] ON 
GO
INSERT [dbo].[tbl_Master_CruiseLocations] ([Id], [LocationName]) VALUES (1, N'Nile')
GO
INSERT [dbo].[tbl_Master_CruiseLocations] ([Id], [LocationName]) VALUES (2, N'Lake Nasser')
GO
SET IDENTITY_INSERT [dbo].[tbl_Master_CruiseLocations] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Master_Days] ON 
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (1, N'1 Day', 1, 0, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (2, N'2 Days / 1 Night', 2, 1, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (3, N'3 Days / 2 Nights', 3, 2, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (4, N'4 Days / 3 Nights', 4, 3, 1)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (5, N'5 Days / 4 Nights', 5, 4, 1)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (6, N'6 Days / 5 Nights', 6, 5, 1)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (7, N'7 Days / 6 Nights', 7, 6, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (8, N'8 Days / 7 Nights', 8, 7, 1)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (9, N'9 Days / 8 Nights', 9, 8, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (10, N'10 Days / 9 Nights', 10, 9, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (11, N'11 Days / 10 Nights', 11, 10, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (12, N'12 Days / 11 Nights', 12, 11, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (13, N'13 Days / 12 Nights', 13, 12, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (14, N'14 Days / 13 Nights', 14, 13, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (15, N'15 Days / 14 Nights', 15, 14, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (16, N'16 Days / 15 Nights', 16, 15, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (17, N'17 Days / 16 Nights', 17, 16, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (18, N'18 Days / 17 Nights', 18, 17, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (19, N'19 Days / 18 Nights', 19, 18, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (20, N'20 Days / 19 Nights', 20, 19, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (21, N'21 Days / 20 Nights', 21, 20, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (22, N'22 Days / 21 Nights', 22, 21, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (23, N'23 Days / 22 Nights', 23, 22, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (24, N'24 Days / 23 Nights', 24, 23, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (25, N'25 Days / 24 Nights', 25, 24, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (26, N'26 Days / 25 Nights', 26, 25, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (27, N'27 Days / 26 Nights', 27, 26, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (28, N'28 Days / 27 Nights', 28, 27, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (29, N'29 Days / 28 Nights', 29, 28, 0)
GO
INSERT [dbo].[tbl_Master_Days] ([Id], [DayNameSys], [DayNumber], [DayNights], [IsCruises]) VALUES (30, N'30 Days / 29 Nights', 30, 29, 0)
GO
SET IDENTITY_INSERT [dbo].[tbl_Master_Days] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Master_DiningCategoryTypes] ON 
GO
INSERT [dbo].[tbl_Master_DiningCategoryTypes] ([Id], [DiningCategoryType]) VALUES (1, N'Restaurant')
GO
INSERT [dbo].[tbl_Master_DiningCategoryTypes] ([Id], [DiningCategoryType]) VALUES (2, N'Bar')
GO
SET IDENTITY_INSERT [dbo].[tbl_Master_DiningCategoryTypes] OFF
GO
INSERT [dbo].[tbl_Master_FacilitiesCostType] ([Id], [CostType]) VALUES (1, N'Free')
GO
INSERT [dbo].[tbl_Master_FacilitiesCostType] ([Id], [CostType]) VALUES (2, N'Extra Cost')
GO
SET IDENTITY_INSERT [dbo].[tbl_Master_Itineraries] ON 
GO
INSERT [dbo].[tbl_Master_Itineraries] ([Id], [ItineraryName], [ItineraryDays], [ItineraryNights], [CruiseLocationID]) VALUES (1, N'3 Nights - Aswan - Luxor', 4, 3, 1)
GO
INSERT [dbo].[tbl_Master_Itineraries] ([Id], [ItineraryName], [ItineraryDays], [ItineraryNights], [CruiseLocationID]) VALUES (2, N'4 Nights - Luxor - Aswan', 5, 4, 1)
GO
INSERT [dbo].[tbl_Master_Itineraries] ([Id], [ItineraryName], [ItineraryDays], [ItineraryNights], [CruiseLocationID]) VALUES (3, N'7 Nights - Luxor - Aswan - Luxor', 8, 7, 1)
GO
INSERT [dbo].[tbl_Master_Itineraries] ([Id], [ItineraryName], [ItineraryDays], [ItineraryNights], [CruiseLocationID]) VALUES (4, N'7 Nights - Aswan - Luxor - Aswan', 8, 7, 1)
GO
INSERT [dbo].[tbl_Master_Itineraries] ([Id], [ItineraryName], [ItineraryDays], [ItineraryNights], [CruiseLocationID]) VALUES (5, N'3 Nights - Abu Simbel - Aswan', 4, 3, 2)
GO
INSERT [dbo].[tbl_Master_Itineraries] ([Id], [ItineraryName], [ItineraryDays], [ItineraryNights], [CruiseLocationID]) VALUES (6, N'4 Nights - Aswan - Abu Simbel', 5, 4, 2)
GO
INSERT [dbo].[tbl_Master_Itineraries] ([Id], [ItineraryName], [ItineraryDays], [ItineraryNights], [CruiseLocationID]) VALUES (7, N'7 Nights - Aswan - Abu Simbel - Aswan', 8, 7, 2)
GO
INSERT [dbo].[tbl_Master_Itineraries] ([Id], [ItineraryName], [ItineraryDays], [ItineraryNights], [CruiseLocationID]) VALUES (8, N'7 Nights - Abu Simbel - Aswan - Abu Simbel', 8, 7, 2)
GO
SET IDENTITY_INSERT [dbo].[tbl_Master_Itineraries] OFF
GO
INSERT [dbo].[tbl_Master_WeekDays] ([Id], [WeekDayName], [WeekDayNameShort]) VALUES (0, N'Sunday', N'Sun')
GO
INSERT [dbo].[tbl_Master_WeekDays] ([Id], [WeekDayName], [WeekDayNameShort]) VALUES (1, N'Monday', N'Mon')
GO
INSERT [dbo].[tbl_Master_WeekDays] ([Id], [WeekDayName], [WeekDayNameShort]) VALUES (2, N'Tuesday', N'Tue')
GO
INSERT [dbo].[tbl_Master_WeekDays] ([Id], [WeekDayName], [WeekDayNameShort]) VALUES (3, N'Wednesday', N'Wed')
GO
INSERT [dbo].[tbl_Master_WeekDays] ([Id], [WeekDayName], [WeekDayNameShort]) VALUES (4, N'Thursday', N'Thr')
GO
INSERT [dbo].[tbl_Master_WeekDays] ([Id], [WeekDayName], [WeekDayNameShort]) VALUES (5, N'Friday', N'Fri')
GO
INSERT [dbo].[tbl_Master_WeekDays] ([Id], [WeekDayName], [WeekDayNameShort]) VALUES (6, N'Saturday', N'Sat')
GO
