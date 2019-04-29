namespace aid_id.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class carbohidratos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NuevoAnalisis", "Carbohidratos", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NuevoAnalisis", "Carbohidratos");
        }
    }
}
