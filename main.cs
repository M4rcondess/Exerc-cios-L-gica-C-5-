using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  Double nome_do_produto, quantidade, preco_unitario, total, desconto;
    String produto;
    Int16 aquisicao_quantitativa;
    Console.WriteLine("Digite o nome do produto: ");
    produto = Console.ReadLine();
    Console.WriteLine("Digite a quantidade: ");
    aquisicao_quantitativa = Int16.Parse(Console.ReadLine());
    Console.WriteLine("Digite o preço unitário: ");
    preco_unitario = Double.Parse(Console.ReadLine());
    total = aquisicao_quantitativa * preco_unitario;
    if (aquisicao_quantitativa <=5)
    {
      desconto = 2;
      }
    if (aquisicao_quantitativa >= 5 && aquisicao_quantitativa <= 10)
    {
      desconto = 3;
    }
    else { desconto = 5;
      } 
    total = (total*(desconto/100));
    Console.WriteLine("O valor total a ser pago é: " + total + " reais ");
  }
}