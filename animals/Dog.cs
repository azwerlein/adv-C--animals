namespace animals
{
    public class Dog : Pet, Talkable
    {
        public bool Friendly { get; }
        public Dog(bool friendly, string name) : base(name)
        {
            Friendly = friendly;
        }

        public string Talk()
        {
            return "Bau";
        }

        public override string ToString()
        {
            return "Dog: " + "name=" + Name + " friendly=" + Friendly;
        }
    }
}