Console.WriteLine("Digite uma string para inverte-la: ");
string palavra = Console.ReadLine();
string palavraInvertida = "";

for(int i = palavra.Length - 1; i >= 0; i--){
    palavraInvertida += palavra[i];
};
Console.WriteLine(palavraInvertida);
