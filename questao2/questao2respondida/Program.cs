List<int> sequenciaDeFibonacci = new List<int>{0,1,1};
int numeroDaSequencia = 0;

void fibonacci( int numero){
    int anterior =0, atual = 1, proxima = 1;

    for(int i = 0; i < numero; i++){
        sequenciaDeFibonacci.Add(proxima);
        anterior = atual + proxima;
        atual = proxima;
        proxima = anterior;
    }
}

string verificarNumeroNaSequencia( int numero, List<int>sequencia){

    if(sequencia.Contains(numero)){
        return $"O numero {numero} pertence à sequência de fibonacci.";
    }else{
        return $"O numero {numero} não pertence à sequência de fibonacci.";
    }
}

Console.WriteLine("Digite o numero que deseja para a sequencia de Fibonacci: ");
numeroDaSequencia = int.Parse(Console.ReadLine());
fibonacci(numeroDaSequencia);
Console.WriteLine(string.Join(", ", sequenciaDeFibonacci));
string mensagem = verificarNumeroNaSequencia(numeroDaSequencia,sequenciaDeFibonacci);
Console.WriteLine(mensagem);