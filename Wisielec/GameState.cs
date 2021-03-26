using System.Collections.Generic;

namespace Wisielec {
    public class GameState {
         public string word = "";
         public string hiddenWord="";
         public int maxMisses = 10;
         public int globalHits = 0;
         public bool wordIsSet = false;
         public int result = 0;
         public List<string> checkedLetters = new List<string>();
        
    }
}