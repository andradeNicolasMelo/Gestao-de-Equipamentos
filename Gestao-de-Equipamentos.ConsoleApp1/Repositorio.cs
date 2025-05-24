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
    }
}
