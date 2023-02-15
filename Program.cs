// See https://aka.ms/new-console-template for more information
Console.WriteLine ("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrString = new string[size];

for(int count = 0; count < size; count++)
{
 Console.WriteLine ();
 Console.WriteLine ("Введите элемент массива: ");
 arrString[count] = Console.ReadLine();
}
    
void ShowArray(string [] array) 
{     
 for (int i = 0; i < array.Length; i++)     
    {         
       Console.Write(array[i] + "; ");     
    }     
 Console.WriteLine(); 
}
    
Console.WriteLine();
ShowArray(arrString);
