namespace _1811060535_HuaVyNhan_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO  CATEGORIES (ID,NAME) VALUES (1,'Dev')");
            Sql("Insert INTO  CATEGORIES (ID,NAME) VALUES (2,'Busi')");
            Sql("Insert INTO  CATEGORIES (ID,NAME) VALUES (3,'Makerting')");
        }
        
        public override void Down()
        {
        }
    }
}
