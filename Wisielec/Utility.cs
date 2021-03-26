

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Wisielec {
    public class Utility {
        public static string ReplaceAt(string input, int index, string newChar) {
            input = input.Remove(index, 1);
            input = input.Insert(index, newChar);
            return input;
        }

        public static string CheckGameState(int maxMisses) {
            switch (maxMisses) {
                case 0: {
                        return "Stages/etap10.jpg";
                    }
                case 1: {
                        return "Stages/etap9.jpg";
                    }
                case 2: {
                        return "Stages/etap8.jpg";
                    }
                case 3: {
                        return "Stages/etap7.jpg";
                    }
                case 4: {
                        return "Stages/etap6.jpg";
                    }
                case 5: {
                        return "Stages/etap5.jpg";
                    }
                case 6: {
                        return "Stages/etap4.jpg";
                    }
                case 7: {
                        return "Stages/etap3.jpg";
                    }
                case 8: {
                        return "Stages/etap2.jpg";
                    }
                case 9: {
                        return "Stages/etap1.jpg";
                    }
                case 10: {
                        return "Stages/etap0.jpg";
                    }

            }

            throw new Exception("maxMisses value not in estimated scale.");
        }
        public static void gameFunctionality(GameState gameState, TextBox textBox, int hits) {
            gameState.checkedLetters.Add(textBox.Text.ToUpper());
            gameState.checkedLetters.Add(textBox.Text.ToLower());
            for (int i = 0; i < gameState.hiddenWord.Length; i++) {
                if (gameState.word[i].ToString() == textBox.Text
                    || gameState.word[i].ToString().ToUpper() == textBox.Text
                    || gameState.word[i].ToString().ToLower() == textBox.Text) {

                    if (gameState.word[i].ToString() == textBox.Text.ToUpper()) {
                        gameState.hiddenWord = Utility.ReplaceAt(gameState.hiddenWord, i, textBox.Text.ToUpper());
                    }
                    else {
                        gameState.hiddenWord = Utility.ReplaceAt(gameState.hiddenWord, i, textBox.Text.ToLower());
                    }

                    hits++;
                }
            }

            gameState.globalHits += hits;

            if (hits > 0) {

                MessageBox.Show("Good job! Hits: " + hits);
            }

            else {
                gameState.maxMisses--;
                if (gameState.maxMisses > 0) {
                    string message = "Miss! Tries left:" + gameState.maxMisses;
                    MessageBox.Show(message);
                }
                else if (gameState.maxMisses == 0) {
                    MessageBox.Show("Out of allowed misses. You've lost, press restart button to try again.");
                }
            }
        }
        public static void reset(TextBox textBox, GameState gameState, Label label, Label result) {
            textBox.Text = "";
            gameState.maxMisses = 10;
            gameState.globalHits = 0;
            gameState.checkedLetters = new List<string>();
            gameState.wordIsSet = false;
            label.Text = "";
            result.Text = "";

        }

        public static void setResult(GameState gameState, Label label) {
            if(gameState.maxMisses == 0) {
                gameState.result = 1;
            }
            else if(gameState.globalHits == label.Text.Length) {
                gameState.result = 2;
            }
            else {
                gameState.result = 0;
            }
        }

        public static void checkResult(GameState gameState, Label label) {
            if (gameState.wordIsSet == true) {
                switch (gameState.result) {
                    case 0:
                        label.Text = "";
                        break;
                    case 1:
                        label.Text = "You've Lost.";
                        break;
                    case 2:
                        label.Text = "You've Won!";
                        break;
                }
            }
        }
    }
}