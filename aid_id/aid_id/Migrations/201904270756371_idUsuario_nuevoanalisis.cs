namespace aid_id.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class idUsuario_nuevoanalisis : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NuevoAnalisis", "Id_Usuario", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NuevoAnalisis", "Id_Usuario");
        }
    }
}
