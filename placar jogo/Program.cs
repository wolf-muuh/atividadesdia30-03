// Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.


// Algoritmo
// entrada: gols do time da casa, gols do time visitante
// processo: comparação do placar através dos gols


Console.WriteLine($"HOJE FOI DIA DE DERBY PAULISTA! CORINTHIANS E PALMEIRAS!");

Console.WriteLine($"Corinthians: ");
int corinthians = int.Parse(Console.ReadLine());

Console.WriteLine($"Palmeiras: ");
int palmeiras = int.Parse(Console.ReadLine());

if (corinthians > palmeiras) {
    Console.WriteLine($"Vai corinthians! O timão mais leva uma partida em cima do Palmeiras!");
}
else if (palmeiras > corinthians) {
    Console.WriteLine($"Vamo porcada! O porcão leva mais uma partida em cima do Corinthians");
}

else  {
   Console.WriteLine($"Que jogo emocionante, jogo pegado, acabou empatado!");
    
}


