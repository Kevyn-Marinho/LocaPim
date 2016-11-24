namespace Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrecaoIdFuncionario : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Usuarios", new[] { "Funcionario_Id" });
            RenameColumn(table: "dbo.Usuarios", name: "Funcionario_Id", newName: "Id");
            AlterColumn("dbo.Usuarios", "Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Usuarios", "Id");
            DropColumn("dbo.Usuarios", "IdFuncionario");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "IdFuncionario", c => c.Int(nullable: false));
            DropIndex("dbo.Usuarios", new[] { "Id" });
            AlterColumn("dbo.Usuarios", "Id", c => c.Int());
            RenameColumn(table: "dbo.Usuarios", name: "Id", newName: "Funcionario_Id");
            CreateIndex("dbo.Usuarios", "Funcionario_Id");
        }
    }
}
