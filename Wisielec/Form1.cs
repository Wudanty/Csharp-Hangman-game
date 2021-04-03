using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Wisielec {
    public partial class Form1 : Form {
        private GameState gameState = new GameState();
        public Form1() {
            InitializeComponent();
        }


        private void ButtonStart_Click(object sender, EventArgs e) {
            if (textBoxWord.Text == "") {
                MessageBox.Show("You need to enter the sentence in a proper textbox");
            }
            else {
                gameState.hiddenWord = "";
                gameState.word = textBoxWord.Text;
                for (int i = 0; i < gameState.word.Length; i++) {
                    if (gameState.word[i].ToString() == " ") {
                        gameState.hiddenWord += " ";
                        gameState.globalHits++;
                    }
                    else {
                        gameState.hiddenWord += "-";
                    }
                }

                labelWordView.Text = gameState.hiddenWord;
                gameState.wordIsSet = true;
            }
            textBoxWord.Text = "";
        }

        private void textBox_TextChanged(object sender, EventArgs e) {
        }


        private void ButtonCheck_Click(object sender, EventArgs e) {
            if (textBoxLetter.Text.Length > 1 || Char.IsLetter(textBoxLetter.Text[0]) == false) {
                MessageBox.Show("Thats not a letter");
            }
            else if (gameState.maxMisses > 0 && gameState.globalHits != gameState.word.Length) {
                int hits = 0;
                if (gameState.checkedLetters.Contains(textBoxLetter.Text)) {
                    MessageBox.Show("This letter was already checked. Pick a different one.");
                }
                else {
                    Utility.gameFunctionality(gameState, textBoxLetter, hits);
                }
                labelWordView.Text = gameState.hiddenWord;
            }
            else if (gameState.maxMisses == 0) {
                MessageBox.Show("Sorry, you've lost. Press the restart button to try again.");
            }
            else {
                MessageBox.Show("You've won! Congratulations. Press the restart button to play again.");
            }

            textBoxLetter.Text = "";
        }

        private void buttonReset_Click(object sender, EventArgs e) {
            Utility.reset(textBoxWord, gameState, labelWordView, labelGameResult);

        }


        private void timerGameState_Elapsed(object sender, ElapsedEventArgs e) {
            pictureBoxHG.Image = Image.FromFile(Utility.CheckGameState(gameState.maxMisses));
            Utility.setResult(gameState,labelWordView);
            Utility.checkResult(gameState,labelGameResult);
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}