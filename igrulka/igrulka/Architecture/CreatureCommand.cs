using System.Drawing;

namespace igrulka
{
    public class CreatureCommand
    {
        public int DeltaX;
        public int DeltaY;
        public bool EventTrigger;
        public ICreature ConvertTo;
        public ICreature CreateCreature;
        public Weapon ChangeWeapon;
    }
}