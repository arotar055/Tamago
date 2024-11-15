using System;

class Character
{
    public int MoodPercentage { get; set; }  

    public Character(int moodPercentage = 100)  
    {
        MoodPercentage = moodPercentage;
    }

    
    public void ShowCharacter()
    {
        if (MoodPercentage > 63)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Энергия: " + MoodPercentage + "%");
            Console.WriteLine("  ^_^  ");
            Console.WriteLine("Он счастлив!");
            Console.ResetColor();
        }
        else if (MoodPercentage > 0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Энергия: " + MoodPercentage + "%");
            Console.WriteLine("  (－_－)  ");
            Console.WriteLine("Он болен");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Энергия: " + MoodPercentage + "%");
            Console.WriteLine("  RIP  ");
            Console.WriteLine("Он мертв");
            Console.ResetColor();
        }
    }

    
    public void ChangeMood(int change)
    {
        MoodPercentage += change;

        
        if (MoodPercentage > 100) MoodPercentage = 100;
        if (MoodPercentage < 0) MoodPercentage = 0;
    }
}
