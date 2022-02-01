namespace Lecture.Farming
{
    public class Cow : FarmAnimal, ISellable
    {
        public Cow() : base("Cow", "moo")
        {
        }

        public decimal Price { get; } = 500.00M;
    }
}
