Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

void TestaArray(){
    int[] vetor = new int[5];

    for(int i=0; i<vetor.Length; i++){
        Console.WriteLine($"Digite o {i}° numero: ");
        vetor[i] = Console.ReadLine();
    }

    for(int i=0; i<vetor.Length; i++){
        Console.WriteLine(vetor[i]);
    }
}