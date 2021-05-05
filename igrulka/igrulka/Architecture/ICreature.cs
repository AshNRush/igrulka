using System;

namespace igrulka
{
    public interface ICreature
    {
        string GetImageFileName();
        int DrawingPriority();
        CreatureCommand Act(int x, int y);
        bool DeadInConflict(ICreature conflictedObject);
        bool TriggeredEvent(EventArgs e);
    }
}