
using GestaoDeEquipamentos.ConsoleApp.Compartilhado;

namespace GestaoDeEquipamentos.ConsoleApp.ModuloFabricante;

public class TelaFabricante : TelaBase
{
    private RepositorioFabricante repositorioFabricante;

    public TelaFabricante(RepositorioFabricante repositorioFabricante)
        : base("Fabricante", repositorioFabricante)
    {
        this.repositorioFabricante = repositorioFabricante;
    }

    public void EditarRegistro()
    {
        ExibirCabecalho();

        Console.WriteLine("Edição de Fabricantes");

        Console.WriteLine();

        VisualizarRegistros(false);

        Console.Write("Digite o id do registro que deseja selecionar: ");
        int idSelecionado = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Fabricante fabricanteAtualizado = ObterDados();

        repositorioFabricante.EditarRegistro(idSelecionado, fabricanteAtualizado);

        Console.WriteLine($"\nFabricante \"{fabricanteAtualizado.nome}\" editado com sucesso!");
        Console.ReadLine();
    }

    public void ExcluirRegistro()
    {
        ExibirCabecalho();

        Console.WriteLine("Exclusão de Fabricantes");

        Console.WriteLine();

        VisualizarRegistros(false);

        Console.Write("Digite o id do registro que deseja selecionar: ");
        int idSelecionado = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        repositorioFabricante.ExcluirRegistro(idSelecionado);

        Console.WriteLine($"\nFabricante excluído com sucesso!");
        Console.ReadLine();
    }

    public void VisualizarRegistros(bool exibirCabecalho)
    {
        if (exibirCabecalho == true)
            ExibirCabecalho();

        Console.WriteLine("Visualização de Fabricantes");

        Console.WriteLine();

        Console.WriteLine(
            "{0, -10} | {1, -20} | {2, -30} | {3, -15}",
            "Id", "Nome", "Email", "Telefone"
        );

        EntidadeBase[] fabricantes = repositorioFabricante.SelecionarRegistros();

        for (int i = 0; i < fabricantes.Length; i++)
        {
            Fabricante f = (Fabricante)fabricantes[i];

            if (f == null)
                continue;

            Console.WriteLine(
               "{0, -10} | {1, -20} | {2, -30} | {3, -15}",
                f.id, f.nome, f.email, f.telefone
            );
        }

        Console.ReadLine();
    }

    protected override Fabricante ObterDados()
    {
        Console.Write("Digite o nome do fabricante: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o endereço de email do fabricante: ");
        string email = Console.ReadLine();

        Console.Write("Digite o telefone do fabricante: ");
        string telefone = Console.ReadLine();

        Fabricante fabricante = new Fabricante(nome, email, telefone);

        return fabricante;
    }
}