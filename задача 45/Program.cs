// Напишите программу, которая будет создавать копию заданного массива с помощью элементного копирования

int[] GetArray() {
    int[] Array = new int[5];
    for (int i = 0; i < Array.Length; i++)
    {
     Array[i] = new Random().Next(1, 10);   
    }
    return Array;
}

int[] CopyArray(int[] array) {
    int[] NewArray = new int[array.Length];
    for (int i = 0; i <array.Length; i++)
    {
        NewArray[i] = array[i];
    }
    return NewArray; 

}

void Main() {
    int[] ArrayOld = GetArray();
    int[] NewArray = CopyArray(ArrayOld);
    System.Console.WriteLine(String.Join(", ", ArrayOld));
    System.Console.WriteLine(String.Join(", ", NewArray));
}
Main();
