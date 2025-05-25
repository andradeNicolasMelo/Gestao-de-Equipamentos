namespace Gestao_de_Equipamentos.ConsoleApp1
{
    public class Repositorio
    {
        Equipamentos[] historicoDeRegistros = new Equipamentos[101];
        public int indiceHistorico = 0;
        public int id = 0;

        public void CadastrarEquipamento(Equipamentos dadosObtidos)
        {
            dadosObtidos.id = indiceHistorico;
            historicoDeRegistros[indiceHistorico] = dadosObtidos;

            indiceHistorico++;
            id++;
        }

        public void VisualizarEquipamentos()
        {

            for (int i = 0; i < historicoDeRegistros.Length; i++)
            {

                Equipamentos e = historicoDeRegistros[i];

                if (e == null)
                    continue;

                Console.WriteLine(
                "{0, -3} | {1, -20} | {2, -15} | {3, -15} | {4, -20} | {5, -15}",
                e.id, e.nome, e.precoAquisicao.ToString("C2"), e.serie, e.fabricante, e.dataFabricacao.ToShortTimeString()
                );
            }
            Console.ReadLine();
        }
    }
}
