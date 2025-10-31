

ususing System;

namespace brpatapim
{
    public class Animal
    {
        protected string name;

   
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

       
        public Animal(string name)
        {
            this.name = name;
        }
        
        public void Speak()
        {
            Console.WriteLine($"{name} издаёт звук.");
        }
    }

    public class Cat : Animal
    {
        private int lives;

       
        public int Lives
        {
            get { return lives; }
            set
            {
                if (value < 1 || value > 9)
                {
                    Console.WriteLine("Жизни кота должны быть от 1 до 9!");
                    lives = 9; 
                }
                else
                {
                    lives = value;
                }
            }
        }

       
        public Cat(string name, int lives) : base(name) 
        {
            this.lives = lives;
        }

        public Cat(string name) : this(name, 9) 
        {
        }

        public void Meow()
        {
            if (lives > 1)
            {
                lives--;
                Console.WriteLine($"{name} мяукнул, осталось жизней: {lives}.");
            }
            else
            {
                Console.WriteLine($"{name} мяукнул, осталось жизней: {lives}."); 
            }
        }
    }

    class Program
    {
        static void Main()
        {
          
            Cat cat1 = new Cat("Мурзик");
            Cat cat2 = new Cat("Барсик", 8);

           
            cat1.Speak();
            cat1.Meow();
            cat1.Meow();

            cat2.Speak();
            cat2.Meow();
            cat2.Meow();

            Console.ReadLine(); 
        }
    }
}