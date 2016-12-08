using System;
using LeagueSharp.Common;

namespace StandaloneOrbwalker
{
    class Program
    {
        public static Orbwalking.Orbwalker Orbwalker;

        public static Menu Menu;

        private static void Main()
        {
            CustomEvents.Game.OnGameLoad += OrbwalkerLoad;
        }

        private static void OrbwalkerLoad(EventArgs args)
        {
            Menu = new Menu("Standalone Orbwalker", "Standalone Orbwalker", true);
            {
                Menu orbwalkerMenu = Menu.AddSubMenu(new Menu("Orbwalker", "Orbwalker"));
                Orbwalker = new Orbwalking.Orbwalker(orbwalkerMenu);
                Menu.AddToMainMenu();
            }
        }
    }
}
