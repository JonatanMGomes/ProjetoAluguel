namespace ProjetoAluguel
{
    public class Casa : Moradia
    {
        private bool ComQuintal { get; set; }
        public Casa(string endereco, int cep, double tamanhoMetros, int quantidadeBanheiros, int quantidadeQuartos, bool comQuintal) : base(endereco, cep, tamanhoMetros, quantidadeBanheiros, quantidadeQuartos){
            ComQuintal = comQuintal;
        }
        public bool GetComQuintal(){
            return ComQuintal;
        }
        public void SetComQuintal(bool comQuintal){
            ComQuintal = comQuintal;
        }
        public override double CalcularValorAluguel()
        {
            double valorAluguel = (TamanhoMetros * 35) + (QuantidadeQuartos * 10) + (QuantidadeBanheiros * 5);
            if(ComQuintal == true){
                valorAluguel = valorAluguel*1.1;
            }
            return valorAluguel;
        }
    }
}