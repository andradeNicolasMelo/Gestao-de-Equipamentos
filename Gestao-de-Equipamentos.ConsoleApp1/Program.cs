namespace Gestao_de_Equipamentos.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                TelaUsuario telaUsuario = new TelaUsuario();
                Repositorio repositorio = new Repositorio();

                telaUsuario.Cabecalho();
                telaUsuario.ExibirOpcoes();

                switch (telaUsuario.ObterOpcaoUsuario())
                {
                    case '1':
                        telaUsuario.Registrar();
                        break;
                }
            }
        }
    }
}
