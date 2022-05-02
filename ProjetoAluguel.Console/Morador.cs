namespace ProjetoAluguel
{
    public class Morador
    {
        private string Nome { get; set; }
        private string CPF { get; set; }
        private DateTime DataNascimento { get; set; }
        public Morador(string nome, string cpf, string dataNascimento)
        {
            SetNome(nome);
            SetCPF(cpf);
            SetDataNascimento(dataNascimento);
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetCPF()
        {
            return CPF;
        }
        public void SetCPF(string cpf)
        {
            if (cpf.Length != 11)
            {
                CPF = null;
            }
            else
            {
                CPF = cpf;
            }
        }
        public DateTime GetDataNascimento()
        {
            return DataNascimento;
        }
        public void SetDataNascimento(string dataNascimento)
        {
            if(string.IsNullOrEmpty(dataNascimento))
                return;
            var dataDesejada = DateTime.Parse(dataNascimento);
            if(dataDesejada.CompareTo(DateTime.Now) > 0)
                return;
            DataNascimento = dataDesejada;
        }
    }
}