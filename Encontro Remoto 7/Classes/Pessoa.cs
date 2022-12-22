using CadastroPessoaFS12.Interfaces;

namespace CadastroPessoaFS12.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string ? Nome {get;set;}
 
        public Endereco ? Endereco {get;set;}

        public float Rendimento{get;set;}

        public abstract float PagarImposto(float rendimento);

        

    }
}