-- Check if the stored procedure DEFAULT_SRPT does not exist and create it if needed
IF  Not EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].DEFAULT_SRPT') AND type in (N'P', N'PC'))
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].DEFAULT_SRPT As Select Null ID'
GO

-- Define the stored procedure DEFAULT_SRPT with the required parameters and logic
ALTER PROCEDURE [dbo].DEFAULT_SRPT
		DEFAULT_PARAMS

AS
BEGIN
	-- Added to prevent extra result sets from interfering with SELECT statements.
	SET NOCOUNT ON;
		
	-- Temporary table to show results
	CREATE TABLE #DEFAULT_TABLE (
		DEFAULT_COLUMNS
	)
	
	-- Insert data into #DEFAULT_TABLE from [DEFAULT_VIEW] table
	INSERT INTO #DEFAULT_TABLE
	SELECT DEFAULT_SELECT
	FROM [DEFAULT_VIEW]
	WHERE DEFAULT_WHERE
	
	/* SUBREPORTS */
	
	
	/* MASTER REPORT */	
	-- Return the results from the temporary table #DEFAULT_TABLE
	SELECT TOP ([dbo].[frpt_ReturnedRowsLimit]()) 
		Null AS DEFAULT_SRPT
		,* 
	FROM #DEFAULT_TABLE

END
GO