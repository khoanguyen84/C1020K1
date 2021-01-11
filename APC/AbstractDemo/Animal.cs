namespace AbstractDemo
{
    abstract class Animal
    {
        public int Legs { get; set; }
        public Animal()
        {
            
        }

        public Animal(int legs)
        {
            Legs = legs;
        }

        public string Breath(){
            return "still breath still alive";
        }

        public abstract string HowToMove();
        public abstract string Speak();
    }
}