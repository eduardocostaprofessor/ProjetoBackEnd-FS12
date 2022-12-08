﻿using CadastroPessoaFS12.Classes;
using System.Text.RegularExpressions;

// Métodos genéricos
PessoaFisica metodosPf = new PessoaFisica();
PessoaJuridica metodosPj = new PessoaJuridica();


//************** PESSOA FÍSICA **************

//CADASTRO
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
pf1.Rendimento = 5000.99f;
pf1.Endereco = endPf1;

// EXIBIÇÃO
Console.WriteLine($"PESSOA FÍSICA 1");
Console.WriteLine($"Nome: {pf1.Nome}");
Console.WriteLine($"CPF: {pf1.Cpf}");
Console.WriteLine($"Rendimento: {pf1.Rendimento}");
Console.WriteLine($"Rendimento Líquido: {metodosPf.PagarImposto(pf1.Rendimento)}");
Console.WriteLine($"Data Nascimento: {pf1.DataNascimento}");
Console.WriteLine($"Maior de Idade? {metodosPf.ValidarDataNascimento(pf1.DataNascimento)}");//datetime
Console.WriteLine($"Rua: {pf1.Endereco.Logradouro}");
Console.WriteLine($"Número: {pf1.Endereco.Numero}");
Console.WriteLine($"Endereço Comercial? {pf1.Endereco.Comercial}");


//************** PESSOA JURÍDICA **************
// CADASTRO
Endereco endPj = new Endereco();
endPj.Logradouro = "Rua Niterói";
endPj.Numero = 180;
endPj.Comercial = true;

PessoaJuridica novaPj = new PessoaJuridica();
novaPj.Nome = "Paulo";
novaPj.Endereco = endPj;
novaPj.Rendimento = 10000.01f ;
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