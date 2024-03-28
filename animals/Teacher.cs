namespace animals
{
    public class Teacher : Person, Talkable
    {
        public int Age { get; set; }
        public Teacher(int age, string name) : base(name)
        {
            Age = age;
        }

        public string Talk()
        {
            return "Don't forget to write the assigned program!";
        }
    }
}
