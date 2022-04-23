namespace ProjetoAluguel
{
    public class Apartamento : Moradia
    {
        private int Andar { get; set; }
        private double ValorCondominio { get; set; }
        public Apartamento(string endereco, int cep, double tamanhoMetros, int quantidadeBanheiros, int quantidadeQuartos, int andar, double valorCondominio) : base(endereco, cep, tamanhoMetros, quantidadeBanheiros, quantidadeQuartos){
            Andar = andar;
            ValorCondominio = valorCondominio;
        }
        public int GetAndar(){
            return Andar;
        }
        public void SetAndar(int andar){
            Andar = andar;
        }
        public double GetValorCondominio(){
            return ValorCondominio;
        }
        public void SetValorCondominio(double valorCondominio){
            ValorCondominio = valorCondominio;
        }
    }
}