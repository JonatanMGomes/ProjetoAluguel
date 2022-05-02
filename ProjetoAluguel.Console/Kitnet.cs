namespace ProjetoAluguel
{
    public class Kitnet : Moradia
    {
        public Kitnet(string endereco, string cep, double tamanhoMetros, int quantidadeBanheiros, int quantidadeQuartos) : base (endereco, cep, tamanhoMetros, quantidadeBanheiros, quantidadeQuartos){

        }
        public override void SetQuantidadeBanheiros(int quantidadeBanheiros){
            if(quantidadeBanheiros > 0 && quantidadeBanheiros <= 2) 
            QuantidadeBanheiros = quantidadeBanheiros;
            else
            QuantidadeBanheiros = 0;
        }
        public override void SetTamanhoMetros(double tamanhoMetros){
            if(tamanhoMetros > 0 && tamanhoMetros <= 50)
            TamanhoMetros = tamanhoMetros;
            else
            TamanhoMetros = 0;
        }
        public override double CalcularValorAluguel()
        {
            return TamanhoMetros*30;
        }
    }
}