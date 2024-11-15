class PetState
{
    public int Hunger { get; set; }
    public int Energy { get; set; }
    public bool Sick { get; set; }
    public int Boredom { get; set; }
    public bool Sleepy { get; set; }

    public PetState()
    {
        Hunger = 0;
        Energy = 100;
        Sick = false;
        Boredom = 0;
        Sleepy = false;
    }

    public void UpdateState()
    {
        if (Hunger > 5) Sick = true;
        if (Energy < 10) Sleepy = true;
        if (Boredom > 5) Boredom = 0; 
    }

    public void Feed()
    {
        Hunger = 0;
        Boredom++;
        Console.WriteLine("Покормил Тамагочи.");
    }

    public void Walk()
    {
        Boredom = 0;
        Energy -= 10;
        Console.WriteLine("Погулял с Тамагочи.");
    }

    public void Play()
    {
        Boredom = 0;
        Energy -= 10;
        Console.WriteLine("Поиграл с Тамагочи.");
    }

    public void Sleep()
    {
        Energy = 100;
        Sleepy = false;
        Console.WriteLine("Уложил Тамагочи спать.");
    }
}
