namespace GestaoDeEquipamentosConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaEquipamento telaEquipamento = new TelaEquipamento();
            while (true)
            {
                char opcaoEscolhida = telaEquipamento.Apresentarmenu();

                if (opcaoEscolhida == 'S')
                    break;

                switch (opcaoEscolhida)
                {
                    case '1':
                        telaEquipamento.CadastrarRegistro();
                        break;
                }

            }
        }

    }

    public class TelaEquipamento
    {
        public char Apresentarmenu()
        {

            Console.Clear();
            Console.WriteLine("Gestão de Equipamentos");

            Console.WriteLine();

            Console.WriteLine("1 - Cadastro de Equipamentos");
            Console.WriteLine("2 - Sair");

            Console.WriteLine();

            Console.Write("Digite uma opção válida: ");
            char opcaoEscolhida = Console.ReadLine().ToUpper()[0];

            return opcaoEscolhida;
        }

        public void CadastrarRegistro()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine();
            Console.WriteLine("Cadastro de Equipamentos");

            Console.WriteLine();

            Console.WriteLine("Digite o nome do equipamento: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o preço de aquisição do equipamentos: ");
            decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o número de série do equipamento: ");
            string numeroSerie = Console.ReadLine();

            Console.WriteLine("Digite o nome fabricante do equipamento: ");
            string fabricante = Console.ReadLine();

            Console.WriteLine("Digite a data da fabricação do equipamento: ");
            DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());

            Equipamento equipamento = new Equipamento();
            equipamento.precoAquisicao = precoAquisicao;
            equipamento.numeroSerie = numeroSerie;
            equipamento.fabricante = fabricante;
            equipamento.dataFabricacao = dataFabricacao;

            

            Console.WriteLine($"\nEquipamento\"{equipamento.nome}\"cadastradao com sucesso!");
            Console.ReadLine();
        }
    }
    public class Equipamento
    {
        public int id;
        public string nome;
        public decimal precoAquisicao;
        public string numeroSerie;
        public string fabricante;
        public DateTime dataFabricacao;
    }
}
