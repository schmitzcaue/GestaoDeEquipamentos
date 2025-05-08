

using GestaoDeEquipamentos.ConsoleApp.ModuloEquipamento;

namespace GestaoDeEquipamentos.ConsoleApp.ModuloFabricante;

public class RepositorioFabricante
{
    public Fabricante[] fabricantes = new Fabricante[100];
    public int contadorFabricantes = 0;

    public void CadastrarFabricante(Fabricante novoFabricante)
    {
        fabricantes[contadorFabricantes] = novoFabricante;

        contadorFabricantes++;
    }

    public bool EditarFabricante(int idSelecionado, Fabricante fabricanteAtualizado)
    {
        Fabricante fabricanteSelecionado = SelecionarFabricantePorId(idSelecionado);

        if (fabricanteSelecionado == null)
            return false;

        fabricanteSelecionado.nome = fabricanteAtualizado.nome;
        fabricanteSelecionado.email = fabricanteAtualizado.email;
        fabricanteSelecionado.telefone = fabricanteAtualizado.telefone;

        return true;
    }

    public Fabricante[] SelecionarFabricantes()
    {
        return fabricantes;
    }

    public Fabricante SelecionarFabricantePorId(int idSelecionado)
    {
        for (int i = 0; i < fabricantes.Length; i++)
        {
            Fabricante f = fabricantes[i];

            if (f == null)
                continue;

            if (f.id == idSelecionado)
                return f;
        }

        return null;
    }
}