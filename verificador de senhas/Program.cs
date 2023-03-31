// Escreva um programa que verifique a validade de uma senha fornecida pelo usuário. A senha válida é o número 1234. 

// algorismo 
// entrada: senha
// procedimento: comparar a senha digitada com a requisitada

Console.WriteLine($"Digite a senha:");
int senhaRequisitada = int.Parse(Console.ReadLine()); 
int senha = 1234;

if (senhaRequisitada == senha) {
    Console.WriteLine($"Acesso permitido!");
}
else {
    Console.WriteLine($"Acesso negado!");
}
