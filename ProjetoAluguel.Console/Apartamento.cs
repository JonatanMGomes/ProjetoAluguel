namespace ProjetoAluguel
{
    public class Apartamento : Moradia
    {
        private int Andar { get; set; }
        private double ValorCondominio { get; set; }
        public Apartamento(string endereco, string cep, double tamanhoMetros, int quantidadeBanheiros, int quantidadeQuartos, int andar, double valorCondominio) : base(endereco, cep, tamanhoMetros, quantidadeBanheiros, quantidadeQuartos){
            SetAndar(andar);
            SetValorCondominio(valorCondominio);
        }
        public override void SetQuantidadeBanheiros(int quantidadeBanheiros){
            if(quantidadeBanheiros > 0 && quantidadeBanheiros <= 3) 
            QuantidadeBanheiros = quantidadeBanheiros;
            else
            QuantidadeBanheiros = 0;
        }
        public override void SetTamanhoMetros(double tamanhoMetros){
            if(tamanhoMetros > 0 && tamanhoMetros <= 60)
            TamanhoMetros = tamanhoMetros;
            else
            TamanhoMetros = 0;
        }
        public int GetAndar(){
            return Andar;
        }
        public void SetAndar(int andar){
            if(andar > 0 && andar <=10)
            Andar = andar;
            else
            Andar = 0;
        }
        public double GetValorCondominio(){
            return ValorCondominio;
        }
        public void SetValorCondominio(double valorCondominio){
            ValorCondominio = valorCondominio;
        }
        public double CalcularValorAluguel()
        {
            return (TamanhoMetros * 40) + (QuantidadeQuartos * 10) + (QuantidadeBanheiros * 5) + ValorCondominio;
        }
    }
}