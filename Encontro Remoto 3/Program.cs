using CadastroPessoaFS12.Classes;


//Cadastro da pessoa física

// Endereço Pessoa Física 1
Endereco endPf1 = new Endereco();
endPf1.Logradouro = "Rua lá de Casa";
endPf1.Numero = 123;
endPf1.Comercial = false;

//Pessoa Física 1
PessoaFisica pf1 = new PessoaFisica();
pf1.Nome = "Eduardo Costa";
pf1.DataNascimento = new DateTime(2005, 7, 20);
pf1.Cpf = "30430430404";
pf1.Rendimento = 1000;
pf1.Endereco = endPf1;

PessoaFisica thePeople = new PessoaFisica("5423454");
thePeople.Nome = "João";
thePeople.DataNascimento = new DateTime(1980, 10, 12);
// thePeople.Cpf = "5423454";
thePeople.Rendimento = 31000;
thePeople.Endereco = endPf1;



// //Exibir os dados
Console.WriteLine($"PESSOA FÍSICA 1");
Console.WriteLine($"Nome: {pf1.Nome}");
Console.WriteLine($"CPF: {pf1.Cpf}");
Console.WriteLine($"Rendimento: {pf1.Rendimento}");
Console.WriteLine($"Data Nascimento: {pf1.DataNascimento}");
Console.WriteLine($"Maior de Idade? {pf1.ValidarDataNascimento(pf1.DataNascimento)}");//datetime
Console.WriteLine($"Rua: {pf1.Endereco.Logradouro}");
Console.WriteLine($"Número: {pf1.Endereco.Numero}");
Console.WriteLine($"Endereço Comercial? {pf1.Endereco.Comercial}");

Console.WriteLine();

Console.WriteLine($"PESSOA FÍSICA 2");

Console.WriteLine($"Nome: {thePeople.Nome}");
Console.WriteLine($"CPF: {thePeople.Cpf}");
Console.WriteLine($"Rendimento: {thePeople.Rendimento}");
Console.WriteLine($"Data Nascimento: {thePeople.DataNascimento.ToShortDateString()}");
Console.WriteLine($"Maior de Idade? {thePeople.ValidarDataNascimento("10/10/2010")}");//string
Console.WriteLine($"Rua: {thePeople.Endereco.Logradouro}");
Console.WriteLine($"Número: {thePeople.Endereco.Numero}");
Console.WriteLine($"Endereço Comercial? {thePeople.Endereco.Comercial}");



// DateTime data = new DateTime(1982, 7, 20);

// Console.WriteLine(thePeople.ValidarDataNascimento(data));



