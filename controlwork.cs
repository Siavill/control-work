
string[] array1 = new string[7] {"1234", "1567", "-2", "world", "C++", "GB.ru", " "};
string[] array2 = new string[array1.Length];
void poisk(string[] array1, string[] array2){
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <=3){
            array2[count] = array1[i];
            count ++;
        }
    }
}

void shoewarray(string[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
poisk(array1, array2);
shoewarray(array2);
