using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalago.Migrations
{
    public partial class PopulaProdutos : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Produtos(Nome,Descrição,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Coca-Cola Diet', 'Refrigerante de Cola 350ml' ,5.45, 'cocacola.jpg',50,now(),1)");

            mb.Sql("Insert into Produtos(Nome,Descrição,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Coxinha', 'Coxinha simples' ,4.50, 'coxinha.jpg',10,now(),2)");

            mb.Sql("Insert into Produtos(Nome,Descrição,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Acai', 'Acai 500ml com nutela e leite condecado' ,10.00, 'acai.jpg',25,now(),3)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Produtos");
        }
    }
}
