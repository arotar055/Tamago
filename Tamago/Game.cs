class Game
{
    private Tamagotchi _tamagotchi;

    public Game(Tamagotchi tamagotchi)
    {
        _tamagotchi = tamagotchi;
    }

    
    public void Start()
    {
        while (_tamagotchi.IsAlive()) 
        {
            Console.Clear();
            _tamagotchi.Update();  

            
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Кормить");
            Console.WriteLine("2. Прогулка");
            Console.WriteLine("3. Играть");
            Console.WriteLine("4. Спать");
            Console.WriteLine("5. Лечить");
            Console.WriteLine("6. Выход");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    _tamagotchi.Feed();
                    break;
                case "2":
                    _tamagotchi.Walk();
                    break;
                case "3":
                    _tamagotchi.Play();
                    break;
                case "4":
                    _tamagotchi.Sleep();
                    break;
                case "5":
                    _tamagotchi.Heal();
                    break;
                case "6":
                    return;  
            }

            System.Threading.Thread.Sleep(1000);  
        }

        Console.WriteLine("Ваш Тамагочи умер.");
    }
}
