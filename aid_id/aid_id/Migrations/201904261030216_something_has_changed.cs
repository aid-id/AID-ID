namespace aid_id.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class something_has_changed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NuevoAnalisis",
                c => new
                    {
                        Id_NuevoAnalisis = c.Guid(nullable: false),
                        Valor = c.Int(nullable: false),
                        NombreAlimento = c.String(),
                        IntensidadDeporte_DataGroupField = c.String(),
                        IntensidadDeporte_DataTextField = c.String(),
                        IntensidadDeporte_DataValueField = c.String(),
                        FechaHora = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id_NuevoAnalisis);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NuevoAnalisis");
        }
    }
}
