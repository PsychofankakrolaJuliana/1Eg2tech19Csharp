//1.Powtórka
// Definiowanie Tablicy:
//int[] T = new int[4]; //Tablica która ma 4 sloty (liczone od 0)
//T[0] = 1; //Ustawanie elemntu 0 na wartość 1
//T[1] = 2;
//T[2] = 3;
//int x = int.Parse(Console.ReadLine());
//T[3] = x; // Element 3 na wartość x

////Wypisanie kolejno elementów tablicy
//for (int i = 0; i < T.Length; i++)
//{
//    Console.WriteLine(T[i]);
//}
//// Robienie randomowej tablicy
//int[] K= new int[4];
//Random r = new Random();
//for(int i = 0; i < 4; i++)
//{
//    K[i] = r.Next();
//    Console.WriteLine(K[i]);
//}
//2.ZADANIA
//int[] T = new int[5];
//Random r = new Random();
//for(int j = 0; j < 5; j++)
//{
//    T[j] = r.Next(1,100);
//}
//Maksymalna wartość w tablicy
//int maks = 0;
//for(int i = 0; i < T.Length; i++)
//{
//    if (T[i] > maks)
//    {
//        maks = T[i];
//    }
//}
//Console.WriteLine(maks);
//Minimalna wartość w tablicy
//int min= 101;
//for(int i = 1; i < T.Length; i++)
//{
//    if (T[i] < min)
//    {
//        min = T[i];
//    }
//}
//Console.WriteLine(min);
