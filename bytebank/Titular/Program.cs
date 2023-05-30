using bytebank.Contas;
using bytebank.Titular;
using ByteBank;
using csharp_execption.Titular;


try
{
    LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
    leitor.Fechar();

}
catch (IOException)
/*
try
{
    ContaCorrente conta1 = new ContaCorrente(0, "1234-x");
    
    conta1.Sacar(50);
    Console.WriteLine(conta1.GetSaldo());
    conta1.Sacar(150);
    Console.WriteLine(conta1.GetSaldo());
    

}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.ParamName);
    Console.WriteLine("Não é possivel criar uma conta com o numero agência menor ou igual a zero!");
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.Message);

}
catch (SaldoInsuficienteException ex)
{ 
    Console.WriteLine("Operação negada! Saldo Insuficiente!");
    Console.WriteLine(ex.Message);
}
*/