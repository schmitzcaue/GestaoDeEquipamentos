﻿
using GestaoDeEquipamentos.ConsoleApp.ModuloEquipamento;

namespace GestaoDeEquipamentos.ConsoleApp.ModuloFabricante;

public class TelaFabricante
{
    public RepositorioFabricante repositorioFabricante;

    public void ExibirCabecalho()
    {
        Console.Clear();
        Console.WriteLine("Gestão de Fabricantes");
        Console.WriteLine();
    }

    public char ApresentarMenu()
    {
        ExibirCabecalho();

        Console.WriteLine("1 - Cadastro de Fabricante");
        Console.WriteLine("2 - Visualizar Fabricantes");
        Console.WriteLine("3 - Editar Fabricante");
        Console.WriteLine("4 - Excluir Fabricante");
        Console.WriteLine("S - Sair");

        Console.WriteLine();

        Console.Write("Digite uma opção válida: ");
        char opcaoEscolhida = Console.ReadLine().ToUpper()[0];

        return opcaoEscolhida;
    }

    public void CadastrarRegistro()
    {
        ExibirCabecalho();

        Console.WriteLine("Cadastro de Fabricantes");

        Console.WriteLine();

        Fabricante novoFabricante = ObterDados();

        repositorioFabricante.CadastrarFabricante(novoFabricante);

        Console.WriteLine($"\nFabricante \"{novoFabricante.nome}\" cadastrado com sucesso!");
        Console.ReadLine();
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

        repositorioFabricante.EditarFabricante(idSelecionado, fabricanteAtualizado);

        Console.WriteLine($"\nFabricante \"{fabricanteAtualizado.nome}\" editado com sucesso!");
        Console.ReadLine();
    }

    public void ExcluirRegistro()
    {
        throw new NotImplementedException();
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

        Fabricante[] fabricantes = repositorioFabricante.SelecionarFabricantes();

        for (int i = 0; i < fabricantes.Length; i++)
        {
            Fabricante f = fabricantes[i];

            if (f == null)
                continue;

            Console.WriteLine(
               "{0, -10} | {1, -20} | {2, -30} | {3, -15}",
                f.id, f.nome, f.email, f.telefone
            );
        }

        Console.ReadLine();
    }

    public Fabricante ObterDados()
    {
        Console.Write("Digite o nome do fabricante: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o endereço de email do fabricante: ");
        string email = Console.ReadLine();

        Console.Write("Digite o telefone do fabricante: ");
        string telefone = Console.ReadLine();

        Fabricante fabricante = new Fabricante();
        fabricante.nome = nome;
        fabricante.email = email;
        fabricante.telefone = telefone;

        return fabricante;
    }
}