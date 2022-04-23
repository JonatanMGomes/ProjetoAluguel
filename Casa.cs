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
    }
}