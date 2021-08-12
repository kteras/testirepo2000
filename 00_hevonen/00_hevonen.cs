using System;

class Hevonen {
    public string nimi;
    public float paino;
}

class Main {
  
    // Main Method
    static public void Main(String[] args)
    {
        Hevonen polle=new Hevonen();
        Console.WriteLine(nimi+" "+paino);
        polle.nimi="Histamiini";
        polle.paino=89;
        Console.WriteLine(nimi+" "+paino);
    }
}