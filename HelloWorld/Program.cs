using HelloWorld;


ContaCorrente cc = new ContaCorrente();
cc.correntista = "Eduardo";
cc.Depositar(100000.99);

Console.WriteLine(cc.correntista);
Console.WriteLine(cc.Sacar(10));
Console.WriteLine(cc.GetSaldo());
