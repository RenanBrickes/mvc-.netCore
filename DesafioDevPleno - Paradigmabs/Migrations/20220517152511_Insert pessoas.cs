using Microsoft.EntityFrameworkCore.Migrations;

namespace DesafioDevPleno___Paradigmabs.Migrations
{
    public partial class Insertpessoas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Departamento TI
            migrationBuilder.Sql("INSERT INTO Pessoa VALUES (NEWID(),'Joe', 7000, 'F26C6064-F0BA-45BC-BFCD-C1954CC7F9D4')");
            migrationBuilder.Sql("INSERT INTO Pessoa VALUES (NEWID(),'Max', 9000, 'F26C6064-F0BA-45BC-BFCD-C1954CC7F9D4')");

            //Departamento Vendas
            migrationBuilder.Sql("INSERT INTO Pessoa VALUES (NEWID(),'Henry', 8000, '61632E80-18FD-49AF-AA9A-F22AE19A648D')");
            migrationBuilder.Sql("INSERT INTO Pessoa VALUES (NEWID(),'Sam', 6000, '61632E80-18FD-49AF-AA9A-F22AE19A648D')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
