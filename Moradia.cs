namespace ProjetoAluguel
{
    public class Moradia
    {
        private string Endereco { get; set; }
        private int CEP { get; set; }
        private double TamanhoMetros { get; set; }
        private int QuantidadeBanheiros { get; set; }
        private int QuantidadeQuartos { get; set; }
        private List<Morador> Moradores { get; set; }
        /*public virtual double CalcularValorAluguel(){
            return 0;
        }
        public void AdicionarMoradores(List<Morador> moradores){

        }*/

    }
}