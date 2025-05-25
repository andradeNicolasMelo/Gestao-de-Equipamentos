namespace Gestao_de_Equipamentos.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaUsuario telaUsuario = new TelaUsuario();
            Repositorio repositorio = new Repositorio();
            while (true)
            {
                telaUsuario.Cabecalho();
                telaUsuario.ExibirOpcoes();

                switch (telaUsuario.ObterOpcaoUsuario())
                {
                    case '1':
                        telaUsuario.Registrar();
                        break;
                    
                    case '2':
                        telaUsuario.Visualizar();
                        break;
                }
            }
        }
    }
}
