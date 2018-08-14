using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

        public GameSession ()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Zebulon Pike";
            CurrentPlayer.Credits = 1000000;
            CurrentPlayer.CharacterClass = "Force-Sensitive Mandalorian";
            CurrentPlayer.HitPoints = 50;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;
            

        }
    }
}
