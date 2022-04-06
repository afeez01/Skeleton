CREATE PROCEDURE sproc_tblStaff_Insert
	--create parameters for the stored procedure
		@FullName varchar(50),
		@Salary money,
		@DateAdded date,
		@Address varchar(50),
		@PermanentEmployment bit

AS
	--insert the new record
		INSERT INTO tblStaff (FullName, Salary, DateAdded, Address, PermanentEmployment)
		values (@FullName, @Salary, @DateAdded, @Address, @PermanentEmployment)
	
	--return the primary key value into the new record
		RETURN @@IDENTITY