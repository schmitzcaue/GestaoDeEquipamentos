using GestaoDeEquipamentos.ConsoleApp.ModuloFabricante;

namespace GestaoDeEquipamentosConsoleApp1.Compartilhado;

public abstract class RepositorioBase
    {
        private EntidadeBase[] registros = new EntidadeBase[100];
        private int contadorRegistros = 0;

    public void CadastrarRegistro(EntidadeBase novoRegistro)
    {
        registros[contadorRegistros] = novoRegistro;

        contadorRegistros++;
    }
    public bool EditarRegistro(int idSelecionado, EntidadeBase RegistroAtualizado)
    {
        EntidadeBase RegistroSelecionado = SelecionarRegistroPorId(idSelecionado);

        if (RegistroSelecionado == null)
            return false;

        RegistroSelecionado.AtualizarRegistro(RegistroAtualizado);

        return true;
    }
    public bool ExcluirRegistro(int idSelecionado)
    {
        for (int i = 0; i < registros.Length; i++)
        {
            if (registros[i] == null)
                continue;

            else if (registros[i].id == idSelecionado)
            {
                registros[i] = null;

                return true;
            }
        }

        return false;
    }

    public EntidadeBase[] selecionarRegistros()
    {
        return registros;
    }

    public EntidadeBase SelecionarRegistroPorId(int idSelecionado)
    {
        for (int i = 0; i < registros.Length; i++)
        {
            EntidadeBase registro = registros[i];

            if (registro == null)
                continue;

            if (registro.id == idSelecionado)
                return registro;
        }

        return null;
    }
}
