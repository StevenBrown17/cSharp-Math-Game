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
    public partial class Form3 : Form{
        /// <summary>
        /// Form3 contructor populates highscores list
        /// </summary>
        public Form3(){
            InitializeComponent();
            setAdditionlist();
            setMultiplicationlist();
            setSubtrationlist();
            setDivisionlist();
            SoundPlayer music = new SoundPlayer(Properties.Resources.cheer2);
            music.Play();
        }

        /// <summary>
        /// closes Form3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHome_Click(object sender, EventArgs e){
            this.Close();
            SoundPlayer music2 = new SoundPlayer(Properties.Resources.ole_ole);
            music2.Play();
        }//end click()

        /// <summary>
        /// adds all highscores to the addition listview
        /// </summary>
        public void setAdditionlist(){

            for(int i=0; i< GameUtil.additionList.Count; i++){
                Highscores hs = GameUtil.additionList[i];
                listAdd.Items.Add(hs.name +"\t"+ hs.totalScore);
            }

        }//end addlist

        /// <summary>
        /// adds highscores to the multiplication listview
        /// </summary>
        public void setMultiplicationlist(){

            for (int i = 0; i < GameUtil.multiplicationList.Count; i++){
                Highscores hs = GameUtil.multiplicationList[i];
                listMultiply.Items.Add(hs.name + "\t" + hs.totalScore);
            }

        }//end mullist

        /// <summary>
        /// adds highscores to the subtraction listview
        /// </summary>
        public void setSubtrationlist(){

            for (int i = 0; i < GameUtil.substrationList.Count; i++){
                Highscores hs = GameUtil.substrationList[i];
                listSubtract.Items.Add(hs.name + "\t" + hs.totalScore);
            }

        }//end sublist

        /// <summary>
        /// adds highscores to the division listview
        /// </summary>
        public void setDivisionlist(){

            for (int i = 0; i < GameUtil.divisionList.Count; i++){
                Highscores hs = GameUtil.divisionList[i];
                listDivide.Items.Add(hs.name + "\t" + hs.totalScore);
            }

        }//end divlist


    }//end class
}//end namespace
