double percentualBonus;
double percentualRetorno;
int pontosTransferidos;
double pontosAcrescentar;
double pontosReduzir;

Console.WriteLine();

Console.WriteLine("Programa de Transferência de Pontos");

Console.Write("Digite o percentual de bônus (em %): ");
percentualBonus = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o percentual de retorno (em %): ");
percentualRetorno = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a quantidade de pontos a serem transferidos: ");
pontosTransferidos = Convert.ToInt32(Console.ReadLine());

pontosReduzir = Convert.ToInt32(pontosTransferidos - (percentualRetorno / 100) * pontosTransferidos); 
pontosAcrescentar = Convert.ToInt32(pontosTransferidos + (percentualBonus / 100) * pontosTransferidos); 

Console.WriteLine($"\nQuantidade de pontos a reduzir na origem:  {pontosReduzir}");
Console.WriteLine($"Quantidade de pontos a acrescentar no destino: {pontosAcrescentar}");

Console.WriteLine();