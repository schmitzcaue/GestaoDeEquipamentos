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

    public Fabricante[] SelecionarFabricantes()
    {
        return fabricantes;
    }
}