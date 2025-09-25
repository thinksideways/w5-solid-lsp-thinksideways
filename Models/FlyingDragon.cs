using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class FlyingDragon : Dragon, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine($"{Name} flies gracefully through the clouds....");
        }
    }
}
