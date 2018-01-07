using UnityEngine;
namespace CurvedVRKeyboard {

    /// <summary>
    /// Setup class derived by all classes who are part of keyboard,
    /// so those variables are easy accessable everywhere
    /// </summary>
    public abstract class KeyboardComponent: MonoBehaviour {

        // Special signs. Feel free to change
        public const string SPACE = "  ";
        public const string BACK = "Back";
        public const string ABC = "ABC";
        public const string QEH = "123\n?!#";
        public const string UP = "more";
        public const string LOW = "more";

        public const int CENTER_ITEM = 15;
        public const int KEY_NUMBER = 30;
        public const int POSITION_SPACE = 28;

        public enum KeyLetterEnum {
            LowerCase, UpperCase, NonLetters
        }



        // Feel free to change (but do not write strings in place of
        // special signs, change variables values instead).
        // Remember to always have 30 values
        public static readonly string[] allLettersLowercase = new string[]
        {
        "Sin","Cos","Tan","<",">","+","-","7","8","9",
        "(",")","!","=","*","/","4","5","6",
        UP,"X","Y","Z",".","1","2","3",
        BACK,SPACE,"0"
        };

        // Feel free to change (but do not write strings in place of
        // special signs, change variables values instead)
        // Remember to always have 30 values
        public static readonly string[] allLettersUppercase = new string[]
        {
        "Asin","Acos","Atan","Abs","Pi","Sqrt","Pow","7","8","9",
        "(",")","~","Floor","Ceiling","Round","4","5","6",
        LOW,"X","Y","Z",".","1","2","3",
        BACK,SPACE,"0"
        };

        // Feel free to change (but do not write strings in place of
        // special signs, change variables values instead)
        // Remember to always have 30 values
        public static readonly string[] allSpecials = new string[]
        {
        "1","2","3","4","5","6","7","8","9","0",
        "@","#","£","_","&","-","+","(",")",
        "*","\"","'",":",";","/","!","?",
        ABC,SPACE,BACK
        };

        // Number of items in a row
        public static readonly int[] lettersInRowsCount = new int[] { 10, 9, 8, 6 };

        /// <summary>
        /// Checks for errrors with array of keys. 
        /// </summary>
        public static void CheckKeyArrays () {
            if(allLettersLowercase.Length != KEY_NUMBER) {
                ErrorReporter.Instance.SetMessage("There is incorrect amount of letters in Lowercase array. Check KeyboardComponent class", ErrorReporter.Status.Error);
                return;
            } else if(allLettersUppercase.Length != KEY_NUMBER) {
                ErrorReporter.Instance.SetMessage("There is incorrect amount of letters in Uppercase array. Check KeyboardComponent class", ErrorReporter.Status.Error);
                return;
            } else if(allSpecials.Length != KEY_NUMBER) {
                ErrorReporter.Instance.SetMessage("There is incorrect amount of letters in Special array. Check KeyboardComponent class", ErrorReporter.Status.Error);
                return;
            }
        }
    }
}