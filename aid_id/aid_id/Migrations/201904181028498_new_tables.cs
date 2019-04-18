namespace aid_id.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new_tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Analisis",
                c => new
                    {
                        Id_analisis = c.Long(nullable: false, identity: true),
                        valor = c.Byte(nullable: false),
                        fecha_hora = c.DateTime(nullable: false),
                        intensidad_deporte = c.Byte(nullable: false),
                        id_usuario = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id_analisis)
                .ForeignKey("dbo.Usuarios", t => t.id_usuario, cascadeDelete: true)
                .Index(t => t.id_usuario);
            
            CreateTable(
                "dbo.Comidas",
                c => new
                    {
                        Id_comida = c.Long(nullable: false, identity: true),
                        fecha_hora = c.DateTime(nullable: false),
                        tipocomida = c.String(),
                        carbo_totales = c.Decimal(precision: 18, scale: 2),
                        id_analisis = c.Long(),
                    })
                .PrimaryKey(t => t.Id_comida)
                .ForeignKey("dbo.Analisis", t => t.id_analisis)
                .Index(t => t.id_analisis);
            
            CreateTable(
                "dbo.Alimentos",
                c => new
                    {
                        Id_alimento = c.Long(nullable: false, identity: true),
                        nombre = c.String(),
                        carbohidratos = c.Decimal(nullable: false, precision: 18, scale: 2),
                        proteinas = c.Decimal(nullable: false, precision: 18, scale: 2),
                        grasas = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id_alimento);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id_usuario = c.Long(nullable: false, identity: true),
                        nombre = c.String(),
                        apellido = c.String(),
                        usuario = c.String(),
                        passcode = c.String(),
                        correo = c.String(),
                        edad = c.Byte(nullable: false),
                        peso = c.Byte(nullable: false),
                        altura = c.Decimal(nullable: false, precision: 18, scale: 2),
                        glucemia_min = c.Byte(nullable: false),
                        glucemia_max = c.Byte(nullable: false),
                        r_insulina_carb = c.Byte(nullable: false),
                        r_insulina_gluc = c.Byte(nullable: false),
                        total_insulina_diaria = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id_usuario);
            
            CreateTable(
                "dbo.AlimentosComidas",
                c => new
                    {
                        Alimentos_Id_alimento = c.Long(nullable: false),
                        Comidas_Id_comida = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.Alimentos_Id_alimento, t.Comidas_Id_comida })
                .ForeignKey("dbo.Alimentos", t => t.Alimentos_Id_alimento, cascadeDelete: true)
                .ForeignKey("dbo.Comidas", t => t.Comidas_Id_comida, cascadeDelete: true)
                .Index(t => t.Alimentos_Id_alimento)
                .Index(t => t.Comidas_Id_comida);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Analisis", "id_usuario", "dbo.Usuarios");
            DropForeignKey("dbo.Comidas", "id_analisis", "dbo.Analisis");
            DropForeignKey("dbo.AlimentosComidas", "Comidas_Id_comida", "dbo.Comidas");
            DropForeignKey("dbo.AlimentosComidas", "Alimentos_Id_alimento", "dbo.Alimentos");
            DropIndex("dbo.AlimentosComidas", new[] { "Comidas_Id_comida" });
            DropIndex("dbo.AlimentosComidas", new[] { "Alimentos_Id_alimento" });
            DropIndex("dbo.Comidas", new[] { "id_analisis" });
            DropIndex("dbo.Analisis", new[] { "id_usuario" });
            DropTable("dbo.AlimentosComidas");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Alimentos");
            DropTable("dbo.Comidas");
            DropTable("dbo.Analisis");
        }
    }
}
