namespace ProjetoAluguel
{
    public class Casa : Moradia
    {
        private bool ComQuintal { get; set; }
        public Casa(string endereco, string cep, double tamanhoMetros, int quantidadeBanheiros, int quantidadeQuartos, bool comQuintal) : base(endereco, cep, tamanhoMetros, quantidadeBanheiros, quantidadeQuartos){
            SetComQuintal(comQuintal);
        }
        public override void SetQuantidadeBanheiros(int quantidadeBanheiros){
            if(quantidadeBanheiros > 0 && quantidadeBanheiros <= 5) 
            QuantidadeBanheiros = quantidadeBanheiros;
            else
            QuantidadeBanheiros = 0;
        }
        public override void SetTamanhoMetros(double tamanhoMetros){
            if(tamanhoMetros > 0 && tamanhoMetros <= 100)
            TamanhoMetros = tamanhoMetros;
            else
            TamanhoMetros = 0;
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