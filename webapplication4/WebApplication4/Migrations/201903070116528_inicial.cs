namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Designacoes",
                c => new
                    {
                        DesignacaoId = c.Int(nullable: false, identity: true),
                        data = c.DateTime(nullable: false),
                        Parte = c.String(maxLength: 20, unicode: false),
                        Sala = c.String(maxLength: 1, unicode: false),
                        dataCadastro = c.DateTime(nullable: false),
                        ordemAdicional = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DesignacaoId);
            
            CreateTable(
                "dbo.Designados",
                c => new
                    {
                        DesignadoId = c.Int(nullable: false, identity: true),
                        DesignacaoId = c.Int(nullable: false),
                        PublicadorId = c.Int(nullable: false),
                        Qualificacao = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.DesignadoId)
                .ForeignKey("dbo.Designacoes", t => t.DesignacaoId, cascadeDelete: true)
                .ForeignKey("dbo.Publicadores", t => t.PublicadorId, cascadeDelete: true)
                .Index(t => t.DesignacaoId)
                .Index(t => t.PublicadorId);
            
            CreateTable(
                "dbo.Publicadores",
                c => new
                    {
                        PublicadorId = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 50, unicode: false),
                        Sexo = c.String(maxLength: 1, unicode: false),
                        Ativo = c.Int(nullable: false),
                        Dianteira = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PublicadorId);
            
            CreateTable(
                "dbo.Partes",
                c => new
                    {
                        ParteId = c.Int(nullable: false, identity: true),
                        ReuniaoId = c.Int(nullable: false),
                        Ordem = c.Int(nullable: false),
                        Descricao = c.String(maxLength: 20, unicode: false),
                        Ativo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ParteId)
                .ForeignKey("dbo.Reunioes", t => t.ReuniaoId, cascadeDelete: true)
                .Index(t => t.ReuniaoId);
            
            CreateTable(
                "dbo.Reunioes",
                c => new
                    {
                        ReuniaoId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ReuniaoId);
            
            CreateTable(
                "dbo.Qualificacoes",
                c => new
                    {
                        QualificacaoId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.QualificacaoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Partes", "ReuniaoId", "dbo.Reunioes");
            DropForeignKey("dbo.Designados", "PublicadorId", "dbo.Publicadores");
            DropForeignKey("dbo.Designados", "DesignacaoId", "dbo.Designacoes");
            DropIndex("dbo.Partes", new[] { "ReuniaoId" });
            DropIndex("dbo.Designados", new[] { "PublicadorId" });
            DropIndex("dbo.Designados", new[] { "DesignacaoId" });
            DropTable("dbo.Qualificacoes");
            DropTable("dbo.Reunioes");
            DropTable("dbo.Partes");
            DropTable("dbo.Publicadores");
            DropTable("dbo.Designados");
            DropTable("dbo.Designacoes");
        }
    }
}
