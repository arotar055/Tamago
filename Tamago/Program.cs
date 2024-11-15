using System;

class Program
{
    static void Main(string[] args)
    {
        Tamagotchi tamagotchi = new Tamagotchi(name: "Милый Тамагочи", initialMood: 100);
        Game game = new Game(tamagotchi);

        
        game.Start();
    }
}

