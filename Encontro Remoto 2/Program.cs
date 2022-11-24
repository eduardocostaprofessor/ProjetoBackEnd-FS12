using CadastroPessoaFS12.Classes;

PessoaFisica obj_Pf = new PessoaFisica();
PessoaFisica obj_Pf2 = new PessoaFisica();

obj_Pf.nome = "Lozano";
obj_Pf.cpf = "30430430404";
obj_Pf.rendimento = 1000;

obj_Pf2.nome = "Caio";



//Console.WriteLine(obj_Pf.cpf);
Console.WriteLine($"Nome: {obj_Pf.nome} recebe {obj_Pf.rendimento} de salario");

