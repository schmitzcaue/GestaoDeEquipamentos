using GestaoDeEquipamentos.ConsoleApp.ModuloFabricante;

namespace GestaoDeEquipamentosConsoleApp1.Compartilhado;

public abstract class EntidadeBase 

{
    public int id;

    public abstract void AtualizarRegistro(EntidadeBase registroAtualizado);
   
}
