/*------------------------------------------------------------------------------------
Login
 -----------------------------------------------------------------------------------*/
if not exists (select 1 from sys.server_principals where name = N'Kanbang')
    create login [Kanbang]
        with password = 'password',
        default_database = [Kanbang],
        check_policy = off,
        check_expiration = off

/*------------------------------------------------------------------------------------
User
 -----------------------------------------------------------------------------------*/
use [Kanbang]

if exists (select 1 from sys.sysusers where name = N'Kanbang')
    drop user [Kanbang]

create user [Kanbang] for login [Kanbang] with default_schema=[dbo]

-- db_executor role might need to be created manually.
if not exists (select 1 from sys.database_principals where name = 'db_executor')
begin
	-- Create a db_executor role
	create role db_executor

	-- Grant execute rights to the new role
	grant execute to db_executor
end

execute sp_addrolemember @rolename = N'db_executor', @membername = N'Kanbang';
execute sp_addrolemember @rolename = N'db_datareader', @membername = N'Kanbang';
execute sp_addrolemember @rolename = N'db_datawriter', @membername = N'Kanbang';