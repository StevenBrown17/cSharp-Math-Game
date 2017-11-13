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
    public partial class Form5 : Form{
        /// <summary>
        /// Form5 constructor sets label with player name
        /// </summary>
        public Form5(){
            InitializeComponent();
            lblLevel.Text = "Okay "+ GameUtil.playerList[(GameUtil.selectedPlayer)].getName() + " \nSelect a level!";
        }

        /// <summary>
        /// sets the game level to + and opens Form4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e){
            SoundPlayer music = new SoundPlayer(Properties.Resources.FOOTBALLKICK);
            music.Play();
            GameUtil.level = "+";
            this.Close();
            Form4 form4 = new Form4();
            form4.Show();
        }//end click()

        /// <summary>
        /// Sets the game level to - and opens Form4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e){
            SoundPlayer music = new SoundPlayer(Properties.Resources.FOOTBALLKICK);
            music.Play();
            GameUtil.level = "-";
            this.Close();
            Form4 form4 = new Form4();
            form4.Show();
        }//end click()

        /// <summary>
        /// sets the game level to * and opens Form4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e){
            SoundPlayer music = new SoundPlayer(Properties.Resources.FOOTBALLKICK);
            music.Play();
            GameUtil.level = "*";
            this.Close();
            Form4 form4 = new Form4();
            form4.Show();
        }//end click()

        /// <summary>
        /// sets the level to / and opens Form5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e){
            SoundPlayer music = new SoundPlayer(Properties.Resources.FOOTBALLKICK);
            music.Play();
            GameUtil.level = "/";
            this.Close();
            Form4 form4 = new Form4();
            form4.Show();
        }//end click()


    }//end class
}//end namespace
