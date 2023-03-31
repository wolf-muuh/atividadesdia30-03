// As    maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.

// algoritmo 
// entrada: quantidade de maçãs
// procedimento: contar o numero de maçãs e multiplicar pelo preço

Console.WriteLine($"Digite a quantidade de maçãs compradas:");
int macas = int.Parse(Console.ReadLine());

if (macas < 12) {
    Console.WriteLine($"{macas * 0.30}");
}
else {
    Console.WriteLine($"{macas * 0.25}");
}

