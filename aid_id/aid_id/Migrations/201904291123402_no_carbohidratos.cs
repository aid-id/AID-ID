namespace aid_id.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class no_carbohidratos : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.NuevoAnalisis", "Carbohidratos");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NuevoAnalisis", "Carbohidratos", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
