using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nlightDat : MonoBehaviour
{
    public Text nlightpoints;
    public static int NlightScore = 1;
    public Button done;

    public void NlightPlus()
    {
        if (NlightScore < 20)
        {
            nlightpoints = nlightpoints.GetComponent<Text>();
            nlightpoints.text = "";
            NlightScore += 1;
            nlightpoints.text = NlightScore.ToString();
        }

    }
    public void NlightMinus()
    {
        if (NlightScore > 1)
        {
            nlightpoints = nlightpoints.GetComponent<Text>();
            nlightpoints.text = "";
            NlightScore -= 1;
            nlightpoints.text = NlightScore.ToString();
        }
    }
}
