using OptionsPlay.DAL.EF.Core.Helpers;

namespace OptionsPlay.DAL.EF.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdminUser : DbMigration
	{
		private const string InsertUser =
			@"INSERT INTO[Users]
						([Role_Id]
						,[RoleId]
						,[RegistrationDate])
					VALUES
						(1
						,1
						,GetDate())";

		private const string InsertWebUser =
				@"INSERT INTO [WebUsers]
						([Id]
						,[LoginName]
						,[DisplayName]
						,[PasswordHash]
						,[PasswordSalt])
					VALUES
						({0}
						,'admin'
						,'Administrator'
						,'ozv8q0bDO80txn83Cc5t7Un72s4yGPe1'
						,'SfvazjIY97UZDui3oTeNM4JkQtH1AphmQ1WxcdOncpc=')";

		public override void Up()
		{
			int adminUserId = SqlExecute.ExecuteNonQueryAndGetInt32Identity(InsertUser);
			SqlExecute.ExecuteNonQuery(string.Format(InsertWebUser, adminUserId));
		}

		public override void Down()
		{
			long userId = SqlExecute.ExecuteScalar<long>("SELECT TOP 1 [Id] FROM [WebUsers] WHERE [LoginName] LIKE 'admin';");

			Sql(string.Format("DELETE FROM [WebUsers] WHERE [Id] = '{0}';", userId));
			Sql(string.Format("DELETE FROM [Users] WHERE [Id] = '{0}';", userId));
		}
    }
}
