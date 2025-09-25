using Microsoft.Extensions.DependencyInjection;
using W5_assignment_template.Interfaces;
using W5_assignment_template.Models;
using W5_assignment_template.Services;

namespace W5_assignment_template
{
    class Program
    {
        static void Main(string[] args)
        {
            var character = new Character();
            var goblin = new Goblin();
            var ghost = new Ghost();

            // Type declaration is Dragon for no other reason to clearly demonstrate they inherit from a base class to help demonstrate LSP.
            // SeaDragon : ISwimmable && FlyingDragon : IFlyable inherit IEntity and their base class's (Dragon) implementations.
            Dragon seaDragon = new SeaDragon();
            Dragon flyingDragon = new FlyingDragon();

            var gameEngine = new GameEngine(character, goblin, ghost, seaDragon, flyingDragon);
            gameEngine?.Run();
        }

    }
}
