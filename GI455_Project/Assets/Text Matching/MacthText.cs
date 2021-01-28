using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MacthText : MonoBehaviour
{
    public InputField matchInput;
    public Text wordOutput;

    public void MatchWord()
    {
        string word = matchInput.text;
        
        wordOutput.text = word;
        if (word == "Unity")
        {
            wordOutput.text = "[ <color=Green>Unity</color> ] is found";
        }

        else if (word == "Unreal")
        {
            wordOutput.text = "[ <color=Green>Unreal</color> ] is found";
        }

        else if (word == "ResidentEvil")
        {
            wordOutput.text = "[ <color=Green>ResidentEvil</color> ] is found";
        }

        else if (word == "Google")
        {
            wordOutput.text = "[ <color=Green>google</color> ] is found";
        }

        else if (word == "MongoDB")
        {
            wordOutput.text = "[ <color=Green>MongoDB</color> ] is found";
        }

        else if (word == "Tesla")
        {
            wordOutput.text = "[ <color=Green>Tesla</color> ] is found";
        }

        else if (word == "PS5")
        {
            wordOutput.text = "[ <color=Green>PS5</color> ] is found";
        }

        else
        {
            wordOutput.text = "No [ <color=Red>Keyword</color> ] found";
        }

    }
   
    
}
