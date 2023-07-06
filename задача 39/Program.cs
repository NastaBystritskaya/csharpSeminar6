// Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, а первый на последнем)
// [1 2 3 4 5 ] -> [5 4 3 2 1]  

int[] GetArray() {
    System.Console.WriteLine("Введите массив: ");
    String[] temp = System.Console.ReadLine().Split(", ");
    int[] Massive = Array.ConvertAll(temp,int.Parse);
    return Massive;
}

int[] GetSwap(int[] Massive) {
    for (int i = 0; i < Massive.Length; i++) {
        if (i >= Massive.Length - 1 - i) {
            break;
        }
        int first = Massive[i];
        int last = Massive[Massive.Length - 1 - i];
        Massive[i] = last;
        Massive[Massive.Length - 1 - i] = first;

    }
    return Massive;
}

void Main() {
    int[] array = GetArray();
    System.Console.WriteLine("[" + String.Join(", ", array) + "]");
    int[] result = GetSwap(array);
    System.Console.WriteLine("[" + String.Join(", ", result) + "]");
}

Main();