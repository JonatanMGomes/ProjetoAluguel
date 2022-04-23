namespace ProjetoAluguel
{
    public class Morador
    {
        private string Nome { get; set; }
        private string CPF { get; set; }
        private DateTime DataNascimento { get; set; }
        public string GetNome(){
            return Nome;
        }
        public void SetNome(string nome){
            Nome = nome;
        }
        public string GetNomeCPF(){
            return CPF;
        }
        public void SetCPF(string cpf){
            CPF = cpf;
        }
        public DateTime GetDataNascimento(){
            return DataNascimento;
        }
        public void SetDataNascimento(DateTime dataNascimento){
            DataNascimento = dataNascimento;
        }
    }
}