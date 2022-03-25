using System;

namespace Teknoloid
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new TeknoloidBase())
                game.Run();
        }
    }
}
