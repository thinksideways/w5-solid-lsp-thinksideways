using W5_assignment_template.Interfaces;
using W5_assignment_template.Models;

namespace W5_assignment_template.Services
{
    public class GameEngine
    {
        private readonly IEntity _character;
        private readonly IEntity _goblin;
        private readonly IEntity _ghost;
        private readonly IEntity _seaDragon;
        private readonly IEntity _flyingDragon;

        public GameEngine(IEntity character, IEntity goblin, IEntity ghost, IEntity seaDragon, IEntity flyingDragon)
        {
            _character = character;
            _goblin = goblin;
            _ghost = ghost;
            _seaDragon = seaDragon;
            _flyingDragon = flyingDragon;
        }

        public void Run()
        {
            _character.Name = "Hero";
            _goblin.Name = "Goblin";
            _ghost.Name = "Ghost";
            _seaDragon.Name = "Sea Dragon";
            _flyingDragon.Name = "Flying Dragon";

            _character.Move();
            _character.Attack(_goblin);

            _goblin.Move();
            _goblin.Attack(_character);

            _ghost.Move();
            _ghost.Attack(_character);
            ((Ghost) _ghost).Fly();

            _seaDragon.Move();
            _seaDragon.Attack(_character);
            ((SeaDragon) _seaDragon).Swim();

            _flyingDragon.Move();
            _flyingDragon.Attack(_goblin);
            ((FlyingDragon) _flyingDragon).Fly();
        }
    }
}
