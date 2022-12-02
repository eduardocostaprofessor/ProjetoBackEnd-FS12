using CadastroPessoaFS12.Interfaces;
using System.Text.RegularExpressions;

namespace CadastroPessoaFS12.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? Cnpj { get; set; }
        public string? RazaoSocial { get; set; }
        public string? Fantasia { get; set; }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)
        {
            // 62.236.353/0001-42       18 dígitos
            // 62236353000142           14 dígitos
            // Verificar se tem o 0001

            if (Regex.IsMatch(cnpj, @"^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$"))
            {

                if (cnpj.Length == 18)
                {//18 dígitos
                    if (cnpj.Substring(11, 4) == "0001")
                    { // 0001
                        return true;
                    }
                }
                else if (cnpj.Length == 14)
                {//14 dígitos
                    if (cnpj.Substring(8, 4) == "0001")
                    { // 0001
                        return true;
                    }
                }
            }

            return false;
        }
    }
}