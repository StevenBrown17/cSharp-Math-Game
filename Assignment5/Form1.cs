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

namespace Assignment5
{
    public partial class Form1 : Form{

        /// <summary>
        /// Form1 constructor
        /// </summary>
        public Form1(){
            InitializeComponent();
            if(GameUtil.playerList.Count == 0) {
                btnHighscore.Enabled = false;
                btnStart.Enabled = false;
                SoundPlayer music = new SoundPlayer(Properties.Resources.ole_ole);
                music.Play();
            }
  
        }//end constructor

        /// <summary>
        /// Opens Form2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayer_Click(object sender, EventArgs e){
            SoundPlayer music = new SoundPlayer(Properties.Resources.FOOTBALLKICK);
            music.Play();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            if (GameUtil.playerList.Count != 0){
                btnHighscore.Enabled = true;
                btnStart.Enabled = true;
                lblCurrentPlayer.Text = "Current Player: "+ GameUtil.playerList[(GameUtil.selectedPlayer)].getName();

            }
        }//btnPlayerClick

        /// <summary>
        /// Opens Form4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e){
            SoundPlayer music = new SoundPlayer(Properties.Resources.FOOTBALLKICK);
            music.Play();
            Form5 form5 = new Form5();
            form5.Show();
        }//end btn click()

        /// <summary>
        /// Opens Form3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHighscore_Click(object sender, EventArgs e){
            SoundPlayer music = new SoundPlayer(Properties.Resources.FOOTBALLKICK);
            music.Play();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }//end btn click()



    }//end class
}//end namespace

