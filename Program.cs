Conta c1 = new Conta(1);
Conta c2 = new Conta(2);

c1.Depositar(1000.00);
c1.Sacar(200.00);
/* Console.WriteLine(c1.Saldo); */

c2.Depositar(200.00);
c2.Sacar(100.00);
/* Console.WriteLine(c2.Saldo); */

c1.Transferir(500.00, c2);
Console.WriteLine(c2.Saldo);
Console.WriteLine(c1.Saldo);