Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

void TestaArray(){
    int[] vetor = new int[5];

    for(int i=0; i<vetor.Length; i++){
        Console.WriteLine($"Digite o {i+1}° numero: ");
        vetor[i] = Convert.ToInt32(Console.ReadLine());
    }

    for(int i=0; i<vetor.Length; i++){
        Console.WriteLine(vetor[i]);
    }
}

void AchaPalavraIgual(){
    string[] vetor = new string[5];
    for(int i=0; i<vetor.Length; i++){
        Console.WriteLine($"Digite a {i+1}° palavra: ");
        vetor[i] = Console.ReadLine();
    }

    Console.Write("Qual palavra deseja buscar: ");
    string busca = Console.ReadLine();

   /* for(int i=0; i<vetor.Length; i++){
        if(vetor.Equals(busca)){
            Console.WriteLine($"A palvra { busca } e igual a { vetor[i] }: ");
            return;
        }
    }*/
    // Also can use foreach

    foreach(string palavra in vetor){
        if(palavra.Equals(busca)){
            Console.WriteLine($"A palvra { busca } foi encontrada ");
            return;
        }
    }
}

//TestaArray();
AchaPalavraIgual();