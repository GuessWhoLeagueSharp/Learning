using LeagueSharp;
using LeagueSharp.Common;

namespace OKTWPredictioner
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Game.Mode == GameMode.Running)
            {
                EventHandlers.Game_OnGameLoad(null);
            }

            CustomEvents.Game.OnGameLoad += EventHandlers.Game_OnGameLoad;
        }
    }
}