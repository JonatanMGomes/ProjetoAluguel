namespace ProjetoAluguel
{
    public class Moradia
    {
        protected string Endereco { get; set; }
        protected int CEP { get; set; }
        protected double TamanhoMetros { get; set; }
        protected int QuantidadeBanheiros { get; set; }
        protected int QuantidadeQuartos { get; set; }
        protected List<Morador> Moradores { get; set; }
        public Moradia(string endereco, int cep, double tamanhoMetros, int quantidadeBanheiros, int quantidadeQuartos){
            Endereco = endereco;
            CEP = cep;
            TamanhoMetros = tamanhoMetros;
            QuantidadeBanheiros = quantidadeBanheiros;
            QuantidadeQuartos = quantidadeQuartos;
        }
        public string GetEndereco(){
            return Endereco;
        }
        public void SetEndereco(string endereco){
            Endereco = endereco;
        }
        public int GetCEP(){
            return CEP;
        }
        public void SetCEP(int cep){
            CEP = cep;
        }
        public double GetTamanhoMetros(){
            return TamanhoMetros;
        }
        public void SetTamanhoMetros(double tamanhoMetros){
            TamanhoMetros = tamanhoMetros;
        }
        public int GetQuantidadeBanheiros(){
            return QuantidadeBanheiros;
        }
        public void SetQuantidadeBanheiros(int quantidadeBanheiros){
            QuantidadeBanheiros = quantidadeBanheiros;
        }
        public int GetQuantidadeQuartos(){
            return QuantidadeQuartos;
        }
        public void SetQuantidadeQuartos(int quantidadeQuartos){
            QuantidadeQuartos = quantidadeQuartos;
        }
        /*public virtual double CalcularValorAluguel(){
            return 0;
        }
        public void AdicionarMorador(Morador morador){
            Moradores.Add(morador);
        }
        public void RemoverMorador(string cpf){
            Moradores.RemoveAll(morador => morador.);
        }*/

    }
}