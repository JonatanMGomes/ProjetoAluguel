namespace ProjetoAluguel
{
    public class Moradia
    {
        protected string Endereco { get; set; }
        protected string CEP { get; set; }
        protected double TamanhoMetros { get; set; }
        protected int QuantidadeBanheiros { get; set; }
        protected int QuantidadeQuartos { get; set; }
        protected List<Morador> Moradores { get; set; }
        public Moradia(string endereco, string cep, double tamanhoMetros, int quantidadeBanheiros, int quantidadeQuartos){
            SetEndereco(endereco);
            SetCEP(cep);
            SetTamanhoMetros(tamanhoMetros);
            SetQuantidadeBanheiros(quantidadeBanheiros);
            SetQuantidadeQuartos(quantidadeQuartos);
            Moradores = new List<Morador>();
        }
        public string GetEndereco(){
            return Endereco;
        }
        public void SetEndereco(string endereco){
            Endereco = endereco;
        }
        public string GetCEP(){
            return CEP;
        }
        public void SetCEP(string cep){
            if (cep.Length != 8)
            {
                CEP = null;
            }
            else
            {
                CEP = cep;
            }
        }
        public double GetTamanhoMetros(){
            return TamanhoMetros;
        }
        public virtual void SetTamanhoMetros(double tamanhoMetros){
            TamanhoMetros = tamanhoMetros;
        }
        public int GetQuantidadeBanheiros(){
            return QuantidadeBanheiros;
        }
        public virtual void SetQuantidadeBanheiros(int quantidadeBanheiros){
            QuantidadeBanheiros = quantidadeBanheiros;
        }
        public int GetQuantidadeQuartos(){
            return QuantidadeQuartos;
        }
        public virtual void SetQuantidadeQuartos(int quantidadeQuartos){
            QuantidadeQuartos = quantidadeQuartos;
        }
        public virtual double CalcularValorAluguel(){
            return 0;
        }
        public void AdicionarMorador(Morador morador){
            Moradores.Add(morador);
        }
        public void RemoverMorador(string cpf){
            Moradores.RemoveAll(morador => morador.GetCPF() == cpf);
        }

    }
}