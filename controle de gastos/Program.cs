// Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.


// Algarismo
// entrada: salário e gasto mensal da pessoa
// processo: comparar o salário com o gasto mensal 


Console.WriteLine($"informe o seu salário: ");
int salario = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o seu gasto mensal: ");
int gastoMensal = int.Parse(Console.ReadLine());

if (salario > gastoMensal) {
    Console.WriteLine($"Tá certin. Gasto dentro do orçamento.");
}

else {
    Console.WriteLine($"Gastou demais! Estourou o orçamento");
}



