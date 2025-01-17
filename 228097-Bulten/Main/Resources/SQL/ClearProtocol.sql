DELETE [VisiWin#Orders].[dbo].[Boxes] WHERE [Start] < dateadd(YEAR, -1, cast(getdate() as date))
DELETE [VisiWin#Orders].[dbo].[Charges] WHERE [Start] < dateadd(YEAR, -1, cast(getdate() as date))
DELETE [VisiWin#Orders].[dbo].[Errors] WHERE [ActivationTime] < dateadd(YEAR, -1, cast(getdate() as date))
DELETE [VisiWin#Orders].[dbo].[Orders] WHERE [Start] < dateadd(YEAR, -3, cast(getdate() as date))
DELETE [VisiWin#Orders].[dbo].[Recipes_Article] WHERE [TimeStamp] < dateadd(YEAR, -1, cast(getdate() as date))
DELETE [VisiWin#Orders].[dbo].[Recipes_Coating] WHERE [TimeStamp] < dateadd(YEAR, -1, cast(getdate() as date))
DELETE [VisiWin#Orders].[dbo].[Recipes_MR] WHERE [TimeStamp] < dateadd(YEAR, -3, cast(getdate() as date))
DELETE [VisiWin#Orders].[dbo].[Trends] WHERE [Start] < dateadd(YEAR, -1, cast(getdate() as date))
DELETE [VisiWin#Orders].[dbo].[Runs] WHERE [Start] < dateadd(YEAR, -1, cast(getdate() as date))

DELETE [VisiWin#Orders].[dbo].[SetValues] WHERE [TimeStamp] < dateadd(YEAR, -1, cast(getdate() as date))
DELETE [VisiWin#Orders].[dbo].[ActualValues]WHERE [TimeStamp] < dateadd(YEAR, -1, cast(getdate() as date))