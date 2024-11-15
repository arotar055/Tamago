class Health
{
    public bool IsSick { get; set; }
    private bool alive;

    public Health()
    {
        IsSick = false;
        alive = true;
    }

    public void CheckHealth()
    {
        if (IsSick)
        {
            Console.WriteLine("Тамагочи заболел! Необходимо лечение.");
        }
        if (!alive)
        {
            Console.WriteLine("Тамагочи умер! Конец игры.");
        }
    }

    public void Heal()
    {
        if (IsSick)
        {
            IsSick = false;
            Console.WriteLine("Тамагочи вылечен!");
        }
        else
        {
            Console.WriteLine("Тамагочи не болен.");
        }
    }

    public bool IsAlive()
    {
        return alive;
    }
}
