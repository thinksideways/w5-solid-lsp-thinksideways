using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class SeaDragon : Dragon, ISwimmable
    {
        public void Swim() {
            Console.WriteLine($"{Name} swims swiftly under water");
        }
    }
}
