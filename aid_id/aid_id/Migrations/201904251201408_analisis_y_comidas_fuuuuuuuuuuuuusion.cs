namespace aid_id.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class analisis_y_comidas_fuuuuuuuuuuuuusion : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.ComidasAlimentos", "Comidas_Id_comida", "dbo.Comidas");
            //DropForeignKey("dbo.ComidasAlimentos", "Alimentos_Id_alimento", "dbo.Alimentos");
            DropForeignKey("dbo.Comidas", "Id_analisis", "dbo.Analisis");
            DropIndex("dbo.Comidas", new[] { "Id_analisis" });
            //DropIndex("dbo.ComidasAlimentos", new[] { "Comidas_Id_comida" });
            //DropIndex("dbo.ComidasAlimentos", new[] { "Alimentos_Id_alimento" });
            CreateTable(
                "dbo.AnalisisAlimentos",
                c => new
                    {
                        Analisis_Id_analisis = c.Long(nullable: false),
                        Alimentos_Id_alimento = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.Analisis_Id_analisis, t.Alimentos_Id_alimento })
                .ForeignKey("dbo.Analisis", t => t.Analisis_Id_analisis, cascadeDelete: true)
                .ForeignKey("dbo.Alimentos", t => t.Alimentos_Id_alimento, cascadeDelete: true)
                .Index(t => t.Analisis_Id_analisis)
                .Index(t => t.Alimentos_Id_alimento);
            
            AddColumn("dbo.Analisis", "Tipocomida", c => c.String());
            AddColumn("dbo.Analisis", "Carbo_totales", c => c.Decimal(precision: 18, scale: 2));
            DropTable("dbo.Comidas");
            //DropTable("dbo.ComidasAlimentos");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ComidasAlimentos",
                c => new
                    {
                        Comidas_Id_comida = c.Long(nullable: false),
                        Alimentos_Id_alimento = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.Comidas_Id_comida, t.Alimentos_Id_alimento });
            
            CreateTable(
                "dbo.Comidas",
                c => new
                    {
                        Id_comida = c.Long(nullable: false, identity: true),
                        Fecha_hora = c.DateTime(nullable: false),
                        Tipocomida = c.String(),
                        Carbo_totales = c.Decimal(precision: 18, scale: 2),
                        Id_analisis = c.Long(),
                    })
                .PrimaryKey(t => t.Id_comida);
            
            DropForeignKey("dbo.AnalisisAlimentos", "Alimentos_Id_alimento", "dbo.Alimentos");
            DropForeignKey("dbo.AnalisisAlimentos", "Analisis_Id_analisis", "dbo.Analisis");
            DropIndex("dbo.AnalisisAlimentos", new[] { "Alimentos_Id_alimento" });
            DropIndex("dbo.AnalisisAlimentos", new[] { "Analisis_Id_analisis" });
            DropColumn("dbo.Analisis", "Carbo_totales");
            DropColumn("dbo.Analisis", "Tipocomida");
            DropTable("dbo.AnalisisAlimentos");
            CreateIndex("dbo.ComidasAlimentos", "Alimentos_Id_alimento");
            CreateIndex("dbo.ComidasAlimentos", "Comidas_Id_comida");
            CreateIndex("dbo.Comidas", "Id_analisis");
            AddForeignKey("dbo.Comidas", "Id_analisis", "dbo.Analisis", "Id_analisis");
            AddForeignKey("dbo.ComidasAlimentos", "Alimentos_Id_alimento", "dbo.Alimentos", "Id_alimento", cascadeDelete: true);
            AddForeignKey("dbo.ComidasAlimentos", "Comidas_Id_comida", "dbo.Comidas", "Id_comida", cascadeDelete: true);
        }
    }
}
