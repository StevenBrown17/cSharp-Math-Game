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
    public partial class Form2 : Form{
        /// <summary>
        /// Form2 constructor
        /// </summary>
        public Form2(){
            InitializeComponent();
            loadList();
        }

        /// <summary>
        /// calls the addPlayer() method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e){
            addPlayer();
        }//end add click()

        /// <summary>
        /// Populates the ListView with the player in the playersList.
        /// </summary>
        private void loadList(){
            listPlayers.Items.Clear();
            for(int i=0; i < GameUtil.playerList.Count; i++){
                listPlayers.Items.Add(GameUtil.playerList[i].getName());
            }
        }//end loadList()

        /// <summary>
        /// When an item in the list is selected, set the playerIndex to the list index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listPlayers_SelectedIndexChanged(object sender, EventArgs e){

            String player = listPlayers.SelectedItem.ToString();
            int playerIndex = listPlayers.SelectedIndex;
            lblSelectedPlayer.Text = "Player selected: "+player +"!!!";
            GameUtil.selectedPlayer = playerIndex;

        }//end listSelected()

        /// <summary>
        /// validates user input, only to allow digits and backspace. if user presses enter, check to see if a name has been entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAge_KeyPress(object sender, KeyPressEventArgs e){

            if(!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)8)){
                if(e.KeyChar == (char)13 && txtName.Text != ""){
                    addPlayer();
                }
                e.Handled = true;
            }
                
        }//end age keypress

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == (char)13 && txtAge.Text != ""){
                addPlayer();
            }
        }//end name keypress

        /// <summary>
        /// Closes Frame2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e){
            SoundPlayer music = new SoundPlayer(Properties.Resources.FOOTBALLKICK);
            music.Play();
            this.Close();
        }

        /// <summary>
        /// Captures inputs and puts into a Player object, and adds to the playerList.
        /// Clears inputs, and populates list
        /// </summary>
        public void addPlayer(){
            if (txtName.Text != "" && txtAge.Text != "")
            {
                String name = txtName.Text;
                int age = Int32.Parse(txtAge.Text);
                Player player = new Player(name, age);
                GameUtil.playerList.Add(player);
                loadList();
                txtName.Clear();
                txtAge.Clear();
                listPlayers.SelectedIndex = (GameUtil.playerList.Count - 1);
                SoundPlayer music = new SoundPlayer(Properties.Resources.FOOTBALLKICK);
                music.Play();
            }

        }//end addPlayer()

    }//end class
}//end namespace
