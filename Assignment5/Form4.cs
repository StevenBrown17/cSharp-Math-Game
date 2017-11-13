using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5{

    public partial class Form4 : Form{
        
        /// <summary>
        /// variable to hold the time
        /// </summary>
        double time = 0.00;
        /// <summary>
        /// keeps track of number of problems played
        /// </summary>
        int counter = 0;
        /// <summary>
        /// num1 and num2 hold the two numbers in the problem
        /// </summary>
        int num1, num2;
        /// <summary>
        /// keeps track of how many problems you have gotten right
        /// </summary>
        int score=0;
        /// <summary>
        /// captures what level you are playing ( + - * / )
        /// </summary>
        String op = GameUtil.level;
        /// <summary>
        /// captures the age of the player to determine what problems to display
        /// </summary>
        int age = GameUtil.playerList[GameUtil.selectedPlayer].getAge();
        /// <summary>
        /// keeps track of the problems you missed to display at the end of round
        /// </summary>
        String missed = "";
        /// <summary>
        /// holds the problem to be displayed
        /// </summary>
        String problem;

        /// <summary>
        /// Form4 constructor starts timer, assigns problem, sets labels
        /// </summary>
        public Form4(){
            InitializeComponent();
            timer.Enabled = true;
            problem = getProblem(op, age);
            lblProblem.Text = problem +"=";
            if(op == "+") { lblGameType.Text = "Addition"; }
            else if(op == "-") { lblGameType.Text = "Subtraction"; }
            else if(op == "*") { lblGameType.Text = "Multiplication"; }
            else { lblGameType.Text = "Division"; }
            lblCurrentPlayer.Text = GameUtil.playerList[GameUtil.selectedPlayer].getName() +" age: "+ GameUtil.playerList[GameUtil.selectedPlayer].getAge();
        }

        
        /// <summary>
        /// calls the turnEvent() method and focuses back in the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e){
            turnEvent();
            txtAnswer.Focus();

        }//end click

        /// <summary>
        /// adds 0.01 to the time and sets the time label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e){
            time += 0.01;
            time = Math.Round(time, 2);
            lblTime.Text = time+"";
        }//end tick


        /// <summary>
        /// based on level and age, a problem is generated and returned
        /// </summary>
        /// <param name="op"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        public String getProblem(String op, int age){
            Random rnd = new Random();
            if(op == "+"){
                if(age <= 5){
                    num1 = rnd.Next(5);
                    num2 = rnd.Next(5);
                }
                else if (age <= 10){
                    num1 = rnd.Next(15);
                    num2 = rnd.Next(15);
                }
                else if (age <= 15){
                    num1 = rnd.Next(20);
                    num2 = rnd.Next(20);
                }
                else{
                    num1 = rnd.Next(75);
                    num2 = rnd.Next(75);
                }

                return num1 + "+" + num2;
            }
            else if(op == "-"){
                if (age <= 5)
                {
                    num1 = rnd.Next(5);
                    num2 = rnd.Next(0,num1);
                }
                else if (age <= 10)
                {
                    num1 = rnd.Next(15);
                    num2 = rnd.Next(0,num1);
                }
                else if (age <= 15)
                {
                    num1 = rnd.Next(20);
                    num2 = rnd.Next(20);
                }
                else
                {
                    num1 = rnd.Next(75);
                    num2 = rnd.Next(75);
                }

                return num1 + "-" + num2;
            }
            else if(op == "*"){
                if (age <= 5){
                    num1 = rnd.Next(5);
                    num2 = rnd.Next(5);
                }
                else if (age <= 10){
                    num1 = rnd.Next(10);
                    num2 = rnd.Next(10);
                }
                else if (age <= 15){
                    num1 = rnd.Next(15);
                    num2 = rnd.Next(15);
                }
                else{
                    num1 = rnd.Next(25);
                    num2 = rnd.Next(25);
                }

                return num1 + "*" + num2;

            }
            else if(op == "/"){
                if (age <= 5){
                    int i = rnd.Next(14);
                    String[] arr = {"1/1", "2/1","2/2","3/1","6/3","6/2","4/2","8/4","8/8","8/2",
                                    "8/1","10/2","10/5","10/10"};
                    String[] nums = arr[i].Split('/');
                    num1 = Int32.Parse(nums[0]);
                    num2 = Int32.Parse(nums[1]);
                    return num1 + "/" + num2; 
                }
                else if (age <= 10){
                    int i = rnd.Next(28);
                    String[] arr = {"1/1", "2/1", "2/2", "3/1", "6/3", "6/2", "4/2", "8/4", "8/8", "8/2",
                                    "8/1", "10/2", "10/5", "10/10","15/5","15/3","16/4","18/3","18/2","20/2",
                                    "20/10","20/5","20/20","30/3", "30/10", "30/30", "25/5", "24/8" };
                    String[] nums = arr[i].Split('/');
                    num1 = Int32.Parse(nums[0]);
                    num2 = Int32.Parse(nums[1]);
                    return num1 + "/" + num2;
                }
                else if (age <= 15){
                    int i = rnd.Next(40);
                    String[] arr = {"1/1", "2/1", "2/2", "3/1", "6/3", "6/2", "4/2", "8/4", "8/8", "8/2",
                                    "8/1", "10/2", "10/5", "10/10","15/5","15/3","16/4","18/3","18/2","20/2",
                                    "20/10","20/5","20/20","30/3", "30/10", "30/30", "25/5", "24/8","32/8","35/7",
                                    "42/7","48/8","52/6","54/6","81/9","72/9","45/5","46/2","62/2","90/2",
                                    ""};
                    String[] nums = arr[i].Split('/');
                    num1 = Int32.Parse(nums[0]);
                    num2 = Int32.Parse(nums[1]);
                    return num1 + "/" + num2;
                }
                else
                {
                    int i = rnd.Next(60);
                    String[] arr = {"1/1", "2/1", "2/2", "3/1", "6/3", "6/2", "4/2", "8/4", "8/8", "8/2",
                                    "8/1", "10/2", "10/5", "10/10","15/5","15/3","16/4","18/3","18/2","20/2",
                                    "20/10","20/5","20/20","30/3", "30/10", "30/30", "25/5", "24/8","32/8","35/7",
                                    "42/7","48/8","52/6","54/6","81/9","72/9","45/5","46/2","62/2","90/2",
                                    "132/4","120/6","200/10","200/5","156/3","126/4","96/2","1000/40","121/11","54/2",
                                    "88/11","78/2","64/2","96/3","88/2","88/4","600/5","82/2","44/4","102/2"};
                    String[] nums = arr[i].Split('/');
                    num1 = Int32.Parse(nums[0]);
                    num2 = Int32.Parse(nums[1]);
                    return num1 + "/" + num2;
                }


            }

            return "";
        }

        /// <summary>
        /// validates input. only allows digits, minus sign, and enter. if enter, run turnEven();
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e){
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)8) && e.KeyChar != 45){
                if (e.KeyChar == (char)13){
                    turnEvent();
                }
                e.Handled = true;
            }

        }

        /// <summary>
        /// checks answers and returns true if correct
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="op"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <returns></returns>
        public bool checkAnswer(int num1, string op, int num2, int num3){

            if(op == "+"){
                if ((num1 + num2) == num3){
                    return true;
                }
                else
                    return false;
            }
            else if (op == "-"){
                if ((num1-num2) == num3){
                    return true;
                }
                else
                    return false;
            }
            else if (op == "*"){
                if ((num1 * num2) == num3){
                    return true;
                }
                else
                    return false;
            }
            else if (op == "/"){
                if ((num1 / num2) == num3){
                    return true;
                }
                else
                    return false;
            }

            return false;
        }


        /// <summary>
        /// increments counter
        /// calls checkAnswers(), if true add 1 to score, else add problem to missed string
        /// if counter == 10 run endGame()
        /// </summary>
        public void turnEvent(){
            if (txtAnswer.Text == "")
                txtAnswer.Text = "-99";
            counter++;

            try{
                if (checkAnswer(num1, op, num2, Int32.Parse(txtAnswer.Text))){
                    //lblStatus.Text = "CORRECT!";
                    SoundPlayer music = new SoundPlayer(Properties.Resources.right);
                    music.Play();
                    score++;
                    lblScore.Text = "SCORE: " + score;

                }
                else{
                    SoundPlayer music = new SoundPlayer(Properties.Resources.wrong);
                    music.Play();
                    missed += problem + "\n";
                    //lblStatus.Text = "WRONG!";
                }
            }catch(Exception e) {
                SoundPlayer music = new SoundPlayer(Properties.Resources.wrong);
                music.Play();
                missed += problem + "\n"; }

            if(counter == 10) {
                endGame();
            }


            problem = getProblem(op, age);
            lblProblem.Text = problem + "=";

            txtAnswer.Clear();

        }//end turn event

        /// <summary>
        /// stops times, calculates score, displays message with score, correct answers, time, and missed problems.
        /// Creates a highscore object, and adds to whatever list the level was.
        /// sorts the list based on score
        /// closes Form4
        /// </summary>
        public void endGame(){
            timer.Enabled = false;
            SoundPlayer music1 = new SoundPlayer(Properties.Resources.cheer2);
            music1.Play();
            double totalScore;
            //if you play on higher difficulty, you get more points. Difficulty based on age
            if (age <= 5) totalScore = (100 - time) * score;
            else if (age <= 10) totalScore = (100 - time) * score * 1.5;
            else if (age <= 15) totalScore = (100 - time) * score * 2;
            else totalScore = (100 - time) * score * 2.5;
            MessageBox.Show("Your score: " + totalScore + "\nAnswered Correctly: " + score + "\nTime: " + time+" seconds" + "\nProblems missed:\n" + missed);


            Highscores highscore = new Highscores(GameUtil.playerList[(GameUtil.selectedPlayer)].getName(), op, score, time, totalScore);

            if (op == "+") GameUtil.additionList.Add(highscore);
            else if (op == "-") GameUtil.substrationList.Add(highscore);
            else if (op == "*") GameUtil.multiplicationList.Add(highscore);
            else if (op == "/") GameUtil.divisionList.Add(highscore);

            //GameUtil.additionList.OrderBy(a => a.score).ThenBy(a => a.time).ToList();

            GameUtil.additionList.Sort((y, x) => x.totalScore.CompareTo(y.totalScore));
            GameUtil.substrationList.Sort((y, x) => x.totalScore.CompareTo(y.totalScore));
            GameUtil.multiplicationList.Sort((y, x) => x.totalScore.CompareTo(y.totalScore));
            GameUtil.divisionList.Sort((y, x) => x.totalScore.CompareTo(y.totalScore));


            this.Close();
            SoundPlayer music2 = new SoundPlayer(Properties.Resources.ole_ole);
            music2.Play();

        }//end endgame()


    }//end class
}//namespace
