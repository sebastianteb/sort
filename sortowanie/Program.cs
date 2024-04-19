using System;
class Program 
{ 
    static void Main(string[] args)
    {
        // Utworzenie obiektu klasy Sort
         Sort sorter = new Sort();

        // Pobranie danych od użytkownika
        int[] tablica = new int[10]; 
        for (int i = 0; i < tablica.Length; i++)
        { 
            Console.Write($"Podaj liczbę {i + 1}: "); 
            tablica[i] = int.Parse(Console.ReadLine());
        } 
        // Posortowanie tablicy
        sorter.Sortuj(tablica); 
        
        // Wyświetlenie posortowanej tablicy
        Console.WriteLine("\nPosortowana tablica:");
        for (int i = 0; i < tablica.Length; i++) 
        {
        Console.Write(tablica[i] + " "); 
        } 
    }
}