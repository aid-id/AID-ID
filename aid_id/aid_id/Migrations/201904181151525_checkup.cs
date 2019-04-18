namespace aid_id.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class checkup : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Analisis", new[] { "id_usuario" });
            DropIndex("dbo.Comidas", new[] { "id_analisis" });
            DropPrimaryKey("dbo.ComidasAlimentos");
            AddPrimaryKey("dbo.ComidasAlimentos", new[] { "Comidas_Id_comida", "Alimentos_Id_alimento" });
            CreateIndex("dbo.Comidas", "Id_analisis");
            CreateIndex("dbo.Analisis", "Id_usuario");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Analisis", new[] { "Id_usuario" });
            DropIndex("dbo.Comidas", new[] { "Id_analisis" });
            DropPrimaryKey("dbo.ComidasAlimentos");
            AddPrimaryKey("dbo.ComidasAlimentos", new[] { "Alimentos_Id_alimento", "Comidas_Id_comida" });
            CreateIndex("dbo.Comidas", "id_analisis");
            CreateIndex("dbo.Analisis", "id_usuario");
            RenameTable(name: "dbo.ComidasAlimentos", newName: "AlimentosComidas");
        }
    }
}
