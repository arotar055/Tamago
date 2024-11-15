using System;

class Tamagotchi
{
    public Character Character { get; set; }
    public PetState State { get; set; }
    public Health Health { get; set; }
    public Request Request { get; set; }
    public Game Game { get; set; }
    public int TimeAlive { get; set; }

    public Tamagotchi(string name = "Тамагочи", int initialMood = 100)
    {
        Character = new Character(initialMood);
        State = new PetState();
        Health = new Health();
        Request = new Request();
        Game = new Game(this);
        TimeAlive = 0;
    }

    
    public void Update()
    {
        TimeAlive++;
        State.UpdateState();
        Request.CheckForNewRequest();
        Health.CheckHealth();
        Character.ShowCharacter(); 
     }

    public bool IsAlive()
    {
        return Health.IsAlive();
    }

    public void Feed()
    {
        State.Feed();
        Character.ChangeMood(10);  
    }

    public void Walk()
    {
        State.Walk();
        Character.ChangeMood(5);  
    }

    public void Play()
    {
        State.Play();
        Character.ChangeMood(15);  
    }

    public void Sleep()
    {
        State.Sleep();
        Character.ChangeMood(-5);  
    }

    public void Heal()
    {
        Health.Heal();
        Character.ChangeMood(20);  
    }
}


