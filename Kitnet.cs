namespace ProjetoAluguel
{
    public class Kitnet : Moradia
    {
        public Kitnet(string endereco, int cep, double tamanhoMetros, int quantidadeBanheiros, int quantidadeQuartos) : base (endereco, cep, tamanhoMetros, quantidadeBanheiros, quantidadeQuartos){

        }
        public override double CalcularValorAluguel()
        {
            return TamanhoMetros*30;
        }
    }
}