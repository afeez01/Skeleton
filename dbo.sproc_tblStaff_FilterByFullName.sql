CREATE PROCEDURE sproc_tblStaff_FilterByFullName
--this stored procedure uses the like function to find post codes that match the value
--stored in the paramter @FullName
--the storec procedure does not return a value

	--declare the parameter as varchar(51)
	@FullName VARCHAR (51)
AS
	--select all fields from any records that have a full name like this full name 
	select * from tblStaff where FullName like @FullName + '%';