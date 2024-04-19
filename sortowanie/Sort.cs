class Sort 
{ 
    private int[] tablica;
    /************************************** 
     * nazwa funkcji:        Sortuj 
     * parametry wejściowe:  int[] tablica
     * wartość zwracana:     nic
     * autor:                Sebastian Bolz
     * *************************************/
    public void Sortuj(int[] tablica)
    {
        this.tablica = tablica;
        for (int i = 0; i < tablica.Length - 1; i++)
        {
            int indeksMaksymalnej = i;
            for (int j = i + 1; j < tablica.Length; j++)
            {
                if (tablica[j] > tablica[indeksMaksymalnej])
                {
                    indeksMaksymalnej = j;
                }
            }
            Zamien(i, indeksMaksymalnej);
        }
    }
    /************************************** 
* nazwa funkcji:        Zamien
* parametry wejściowe:  indeks1 indeks2
* wartość zwracana:     nic
* autor:                Sebastian Bolz
* *************************************/
    private void Zamien(int indeks1, int indeks2)
    {
        int temp = tablica[indeks1];
        tablica[indeks1] = tablica[indeks2];
        tablica[indeks2] = temp;
    
    }
    
    /************************************** 
* nazwa funkcji:        ZnajdzMaksymalny
* parametry wejściowe:  tablica odIndeksu
* wartość zwracana:     indeksMaksymalnej
* autor:                Sebastian Bolz
* *************************************/
    private int ZnajdzMaksymalny(int[] tablica, int odIndeksu)
    {
     int indeksMaksymalnej = odIndeksu;
        
        for (int i = odIndeksu + 1; i < tablica.Length; i++)
        {
            
            if (tablica[i] > tablica[indeksMaksymalnej])
            { 
                indeksMaksymalnej = i;
            }
        }
      
        return indeksMaksymalnej; 
    } 
}