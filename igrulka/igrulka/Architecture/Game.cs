using System.Windows.Forms;

namespace igrulka
{
    public class Game
    {
        public static ICreature[,] Map;

        public static Keys KeyPressed;
        public static int MapWidth => Map.GetLength(0);
        public static int MapHeight => Map.GetLength(1);

        public static void CreateMap()
        {
            //TODO: map + mapParser
        }
    }
}