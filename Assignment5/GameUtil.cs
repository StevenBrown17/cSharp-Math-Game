using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{

    /// <summary>
    /// GameUtil holds all the global variables all forms will need to access
    /// </summary>
    public static class GameUtil
    {

        /// <summary>
        /// selectedPlayer holds the index of the player which the user selected
        /// </summary>
        public static int selectedPlayer;
        /// <summary>
        /// Holds a list of player objects
        /// </summary>
        public static List<Player> playerList = new List<Player>();
        /// <summary>
        /// holds the highscores of the addition level
        /// </summary>
        public static List<Highscores> additionList = new List<Highscores>();
        /// <summary>
        /// holds the highscores of the subtraction level
        /// </summary>
        public static List<Highscores> substrationList = new List<Highscores>();
        /// <summary>
        /// holds the highscores of the multiplication level
        /// </summary>
        public static List<Highscores> multiplicationList = new List<Highscores>();
        /// <summary>
        /// holds the highscores of the division level
        /// </summary>
        public static List<Highscores> divisionList = new List<Highscores>();
        /// <summary>
        /// holds the level that the user selected
        /// </summary>
        public static String level;

    }
}
