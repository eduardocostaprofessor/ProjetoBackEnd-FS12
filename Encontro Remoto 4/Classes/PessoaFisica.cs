using CadastroPessoaFS12.Interfaces;

namespace CadastroPessoaFS12.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {

        // sobrecarga
        public PessoaFisica()
        {

        }

        public PessoaFisica(string parCpf)
        {
            this.Cpf = parCpf;
        }
        public PessoaFisica(string parCpf, DateTime parDtNasc)
        {
            this.Cpf = parCpf;
        }

        public string? Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;
            double idade = (dataAtual - dataNasc).TotalDays / 365;

            if (idade >= 18)
            {
                return true;
            }

            return false;
        }

        public bool ValidarDataNascimento(String dataNasc)
        {
            DateTime dataConvertida;

            if (DateTime.TryParse(dataNasc, out dataConvertida))
            {
                // Console.WriteLine(dataConvertida);

                DateTime dataAtual = DateTime.Today;//pega a data de hoje
                double idade = (dataAtual - dataConvertida).TotalDays / 365;
                
                // Console.WriteLine(dataAtual);
                // Console.WriteLine(idade);
                if (idade >= 18)
                {
                    return true;
                }

            }

            return false;
        }

    }
}
