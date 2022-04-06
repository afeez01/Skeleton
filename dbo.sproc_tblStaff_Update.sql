CREATE PROCEDURE sproc_tblStaff_Update
	--create parameters for the stored procedure
		@StaffId int,
		@FullName varchar(50),
		@Salary money,
		@DateAdded date,
		@Address varchar(50),
		@PermanentEmployment bit
AS
	--update the record as specified by @StaffId value
	update tblStaff 
	set	FullName = @FullName,
		Salary = @Salary,
		DateAdded = @DateAdded,
		Address = @Address,
		PermanentEmployment = @PermanentEmployment 

		where StaffId = @StaffId