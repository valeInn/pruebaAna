namespace ProyectoFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contratos",
                c => new
                    {
                        IDContrat = c.Int(nullable: false),
                        Fi = c.String(),
                        Ff = c.String(),
                        Garante_IDGr = c.Int(),
                        Locador_IDLod = c.Int(),
                        Locatario_IDLot = c.Int(),
                        Propiedades_IDPropiedad = c.Int(),
                    })
                .PrimaryKey(t => t.IDContrat)
                .ForeignKey("dbo.Garante", t => t.Garante_IDGr)
                .ForeignKey("dbo.Locador", t => t.Locador_IDLod)
                .ForeignKey("dbo.Locatario", t => t.Locatario_IDLot)
                .ForeignKey("dbo.Propiedades", t => t.Propiedades_IDPropiedad)
                .Index(t => t.Garante_IDGr)
                .Index(t => t.Locador_IDLod)
                .Index(t => t.Locatario_IDLot)
                .Index(t => t.Propiedades_IDPropiedad);
            
            CreateTable(
                "dbo.Garante",
                c => new
                    {
                        IDGr = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.IDGr);
            
            CreateTable(
                "dbo.Locador",
                c => new
                    {
                        IDLod = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.IDLod);
            
            CreateTable(
                "dbo.Locatario",
                c => new
                    {
                        IDLot = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.IDLot);
            
            CreateTable(
                "dbo.Propiedades",
                c => new
                    {
                        IDPropiedad = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.IDPropiedad);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contratos", "Propiedades_IDPropiedad", "dbo.Propiedades");
            DropForeignKey("dbo.Contratos", "Locatario_IDLot", "dbo.Locatario");
            DropForeignKey("dbo.Contratos", "Locador_IDLod", "dbo.Locador");
            DropForeignKey("dbo.Contratos", "Garante_IDGr", "dbo.Garante");
            DropIndex("dbo.Contratos", new[] { "Propiedades_IDPropiedad" });
            DropIndex("dbo.Contratos", new[] { "Locatario_IDLot" });
            DropIndex("dbo.Contratos", new[] { "Locador_IDLod" });
            DropIndex("dbo.Contratos", new[] { "Garante_IDGr" });
            DropTable("dbo.Propiedades");
            DropTable("dbo.Locatario");
            DropTable("dbo.Locador");
            DropTable("dbo.Garante");
            DropTable("dbo.Contratos");
        }
    }
}
