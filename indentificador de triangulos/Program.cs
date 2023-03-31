// Escreva um programa que leia as medidas dos lados de um triângulo e escreva se ele  é  Equilátero, Isósceles ou  Escaleno.

// algoritmo
// entrada: medida dos lados de um triangulo qualquer
// procedimento: comparar as medidas dos lados dos triangulos.

Console.WriteLine($"Digite a medida do lado 1: ");
int lado1 = int.Parse(Console.ReadLine ());

Console.WriteLine($"Digite a medida do lado 2: ");
int lado2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite a medida do lado 3: ");
int lado3 = int.Parse(Console.ReadLine());

if ((lado1 == lado2) && (lado2 == lado3)) {
    Console.WriteLine($"O triangulo é equilatero!");
}
else if ((lado1 != lado2) &&  (lado2 != lado3)){
    Console.WriteLine($"O triangulo escaleno!");
}
else {
    Console.WriteLine($"O triangulo é isóceles!");
}




