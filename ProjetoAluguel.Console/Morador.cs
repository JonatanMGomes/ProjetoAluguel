namespace ProjetoAluguel
{
    public class Morador
    {
        private string Nome { get; set; }
        private string CPF { get; set; }
        private DateTime DataNascimento { get; set; }
        public Morador(string nome, string cpf, string dataNascimento){
            SetNome(nome);
            SetCPF(cpf);
            SetDataNascimento(dataNascimento);
        }
        public string GetNome(){
            return Nome;
        }
        public void SetNome(string nome){
            Nome = nome;
        }
        public string GetCPF(){
            return CPF;
        }
        public void SetCPF(string cpf){
            CPF = cpf;
        }
        public DateTime GetDataNascimento(){
            return DataNascimento;
        }
        public void SetDataNascimento(string dataNascimento){
            var dataDesejada = DateTime.Parse(dataNascimento);
            DataNascimento = dataDesejada;
        }
    }
}