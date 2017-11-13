using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Highscores{
        /// <summary>
        /// holds the player name
        /// </summary>
        public String name { get; set; }
        /// <summary>
        /// holds the level that the highscore was achieved
        /// </summary>
        public String level { get; set; }
        /// <summary>
        /// holds the number of problems solved correctly
        /// </summary>
        public int score { get; set; }
        /// <summary>
        /// holds the seconds the player took to complete 10 problems
        /// </summary>
        public double time { get; set; }
        /// <summary>
        /// holds the score after calculations
        /// </summary>
        public double totalScore { get; set; }


        public Highscores(String name, String level, int score, double time, double totalScore)
        {
            this.name = name;
            this.level = level;
            this.score = score;
            this.time = time;
            this.totalScore = totalScore;
        }//end constructor

        /// <summary>
        /// getter to return an int
        /// </summary>
        /// <returns></returns>
        public int getintScore() { return this.score; }
        /// <summary>
        /// getter to return score as a string
        /// </summary>
        /// <returns></returns>
        public String getScore() { return this.score+""; }
        public void setScore(int score) { this.score = score; }
        public double getdoubleTime() { return this.time; }
        public String getTime() { return this.time +""; }
        public void setTime(double time) { this.time = time; }



    }//end class
}//end namespace

