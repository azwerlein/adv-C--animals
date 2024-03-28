namespace animals
{
    class Cat : Pet, Talkable
    {
        public int MiceKilled { get; set; }
        public Cat(int miceKilled, string name) : base(name)
        {
            MiceKilled = miceKilled;
        }

        public void AddMouse()
        {
            MiceKilled++;
        }

        public string Talk()
        {
            return "Meow";
        }

        public override string ToString()
        {
            return "Cat: " + "name=" + Name + " mousesKilled=" + MiceKilled;
        }
    }
}
