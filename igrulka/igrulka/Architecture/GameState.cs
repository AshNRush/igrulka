using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace igrulka
{
    public class GameState
    {
        // ObjectSize??
        public List<CreatureAnimation> Animations = new List<CreatureAnimation>();

        public void BeginAct()
        {
            Animations.Clear();
            for (var x = 0; x < Game.MapWidth; x++)
            for (var y = 0; y < Game.MapHeight; y++)
            {
                var creature = Game.Map[x, y];
                var command = creature.Act(x, y);

                Animations.Add(
                    new CreatureAnimation
                    {
                        Command = command,
                        Creature = creature,
                        Location = new Point(x, y),
                        TargetLogicalLocation = new Point(x + command.DeltaX, y + command.DeltaY)
                    });
            }

            Animations = Animations.OrderByDescending(z => z.Creature.DrawingPriority()).ToList();
        }

        public void EndAct()
        {
            //TODO...
        }
    }
}