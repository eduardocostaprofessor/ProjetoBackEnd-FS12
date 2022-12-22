using CadastroPessoaFS12.Classes;
using System.Text.RegularExpressions;

// Métodos genéricos
PessoaFisica metodosPf = new PessoaFisica();
PessoaJuridica metodosPj = new PessoaJuridica();
// Listas de pf e pj
List<PessoaFisica> listaPf = new List<PessoaFisica>();//inicializa uma lista vazia PessoaFisica
List<PessoaJuridica> listaPj = new List<PessoaJuridica>();//inicializa uma lista vazia de PessoaJuridica

// Cabeçalho do sistema
Console.WriteLine(@$"
============================================
|    Bem vindo ao sistema de cadastro de   |
|        Pessoas Físicas e Jurídicas       |
============================================
");

Utils.Loading("Sistema do Edu Iniciando ", 4, 500, ConsoleColor.Yellow, ConsoleColor.Green);

Console.WriteLine();//pula uma linha

//1000ms = 1s

string opcao;//null

do
{
    //desenhar o menu
    Console.WriteLine(@$"
============================================
|    Escolha uma das opções abaixo         |
|------------------------------------------|
|       1 - Pessoa Física   - Play         | 
|       2 - Pessoa Jurídica                |
|                                          |
|       0 - Sair                           |
============================================
");

    opcao = Console.ReadLine();//espera o usuário digitar a opção
    //escolhar a opção 
    switch (opcao)
    {
        case "1"://************** PESSOA FÍSICA **************
            string opcaoPf;
            do
            {
                //desenhar o SUB-MENU (o jogos)
                Console.WriteLine(@$"
                =================================================
                |    Escolha uma das opções abaixo              |
                |------------------------------------------     |
                |       1 - Cadastrar Pessoa Física (Sonic)     | 
                |       2 - Listar Pessoa Física  (Mortal Kbt)  |
                |                                               |
                |       0 - Voltar ao menu anterior (Emulators) |
                =================================================
                ");
                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1"://aqui vamos cadastrar a pessoa física
                        Console.Clear();
                        //CADASTRO - preenchimento dos dados
                        Endereco enderecoPf = new Endereco();
                        Console.WriteLine($"Digite o Endereço:");
                        enderecoPf.Logradouro = Console.ReadLine();
                        Console.WriteLine($"Digite o número:");
                        enderecoPf.Numero = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Endereço comercial? s/n:");
                        string comercial = Console.ReadLine();
                        
                        if (comercial == "s")
                        {
                            enderecoPf.Comercial = true;

                        } else 
                        {
                            enderecoPf.Comercial = false;
                        }

                        //Pessoa Física
                        PessoaFisica novaPf = new PessoaFisica();
                        Console.WriteLine("Digite o nome");
                        novaPf.Nome = Console.ReadLine();
                        novaPf.DataNascimento = new DateTime(2005, 7, 20);
                        Console.WriteLine("Digite o CPF: ");
                        novaPf.Cpf = Console.ReadLine();
                        Console.WriteLine("Informe o rendimento Bruto: ");
                        novaPf.Rendimento = float.Parse(Console.ReadLine());
                        novaPf.Endereco = enderecoPf;

                        //cadastrando na lista
                        listaPf.Add(novaPf);//guarda uma pessoa física na lista

                        Utils.ParadaNoConsole("Pessoa Física cadastrada com sucesso!");

                        break;

                    case "2"://aqui vamos listar a pessoa física
                        // EXIBIÇÃO

                        Console.Clear();
                        Console.WriteLine($"********* Listagem de Pessoas Físicas *********");

                        foreach (var pessoa in listaPf)
                        {//cada pessoa cadastrada
                            Console.WriteLine();//linha vazia
                            Console.WriteLine($"Nome: {pessoa.Nome}");
                            Console.WriteLine($"CPF: {pessoa.Cpf}");
                            Console.WriteLine($"Rendimento: {pessoa.Rendimento}");
                            Console.WriteLine($"Rendimento Líquido: {metodosPf.PagarImposto(pessoa.Rendimento)}");
                            Console.WriteLine($"Data Nascimento: {pessoa.DataNascimento}");
                            // Console.WriteLine($"Maior de Idade? {metodosPf.ValidarDataNascimento(pessoa.DataNascimento)}");//datetime
                            Console.WriteLine( metodosPf.ValidarDataNascimento(pessoa.DataNascimento) ? "Maior de Idade: Sim" : "Maior de Idade? Não");//datetime
                            Console.WriteLine($"Rua: {pessoa.Endereco.Logradouro}");
                            Console.WriteLine($"Número: {pessoa.Endereco.Numero}");
                            // Console.WriteLine($"Endereço Comercial: {pessoa.Endereco.Comercial}");
                            // string endComercial = ( pessoa.Endereco.Comercial == true ) ? "Endereço Comercial? Sim" : "Endereço Comercial? Não";
                            // Console.WriteLine(endComercial);
                            Console.WriteLine( (pessoa.Endereco.Comercial) ? "Endereço Comercial: Sim" : "Endereço Comercial: Não" );
                        }

                        Console.WriteLine();//linha vazia
                        Utils.ParadaNoConsole("********* Fim da listagem *********");
                        break;

                    case "0"://aqui vamos listar a pessoa física
                        Console.Clear();//linha vazia
                        Utils.ParadaNoConsole("Voltando ao menu anterior");
                        break;

                    default: //qualquer opção diferente do menu
                        Console.Clear();//linha vazia
                        Utils.ParadaNoConsole("Opção Inválida");
                        break;
                }

            } while (opcaoPf != "0");//fim do sub-menu

            break;

        case "2"://************** PESSOA JURÍDICA **************
            Console.Clear();
            Console.WriteLine($"************** PESSOA JURÍDICA **************");

            // CADASTRO
            Endereco endPj = new Endereco();
            endPj.Logradouro = "Rua Niterói";
            endPj.Numero = 180;
            endPj.Comercial = true;

            PessoaJuridica novaPj = new PessoaJuridica();
            novaPj.Nome = "Paulo";
            novaPj.Endereco = endPj;
            novaPj.Rendimento = 10000.01f;
            novaPj.Cnpj = "62.236.353/0002-42";
            // novaPj.Cnpj = "62236353000142";
            novaPj.Fantasia = "SENAI";
            novaPj.RazaoSocial = "Serviço Nacional de Aprendizagem Industrial";

            //EXIBIÇÃO
            Console.WriteLine(@$"
Razão Social: {novaPj.RazaoSocial}
Nome Fantasia: {novaPj.Fantasia}
Representante: {novaPj.Nome}
CNPJ: {novaPj.Cnpj}
CNPJ Válido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
Rendimento Anual: {novaPj.Rendimento}
Rendimento Líquido: {metodosPj.PagarImposto(novaPj.Rendimento)}
Endereço: {novaPj.Endereco.Logradouro}, {novaPj.Endereco.Numero}
Endereço Comercial: {novaPj.Endereco.Comercial}
");

            Utils.ParadaNoConsole("Pessoa Jurídica cadastrada com sucesso!");
            break;

        case "0":
            Console.Clear();
            Utils.ParadaNoConsole("Obridado por utilizar nosso sistema");
            break;

        default:
            Console.Clear();

            Utils.ParadaNoConsole("Opção Inválida", ConsoleColor.Gray);//parada no console
            break;
    }

} while (opcao != "0"); //fim do menu principal




// Loading
Utils.Loading("Finalizando ", 3, 300);
Console.WriteLine();





















// *********************** ESTUDO DE CASO ****************************

//EXEMPLO COM O USUÁRIO DIGITANDO/DANDO INPUT OS DADOS
// Console.WriteLine($"Nome Fantasia? ");
// novaPj.Fantasia = Console.ReadLine();
// Console.WriteLine($"Qual é o Rendimento");
// novaPj.Rendimento = float.Parse(Console.ReadLine()) ;


// CNPJ Válido: {novaPj.ValidarCnpj(novaPj.Cnpj)}

// Substring
//             0123456789...
// string nome = "Eduardo Costa";

// Console.WriteLine( nome.Substring(3) );
// Console.WriteLine( nome.Substring(8) );
// Console.WriteLine( nome.Substring(0, 4) );
// Console.WriteLine( nome.Substring(4, 5) );
// Console.WriteLine(nome.Length);
// string data = "03/20/2022";

// bool dataValida = Regex.IsMatch(data, @"^\d{2}/\d{2}/\d{4}$");

// Console.WriteLine(data);
// Console.WriteLine(dataValida);

// if (dataValida)
// {
//     String[] partes = data.Split("/");
//     if (int.Parse(partes[1]) >= 1 && int.Parse(partes[1]) <= 12)
//     {
//         Console.WriteLine("Mês Válido");
//     }
//     else
//     {
//         Console.WriteLine("Mês INVÁLIDO");
//     }
// }


// DateTime data = new DateTime(1982, 7, 20);
// Console.WriteLine(thePeople.ValidarDataNascimento(data));
