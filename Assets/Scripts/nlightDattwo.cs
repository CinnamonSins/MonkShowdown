using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nlightDattwo : MonoBehaviour
{
    public Text bluenlightpoints;
    public static int BlueNlightScore = 1;
    public Button done;

    public void NlightPlus()
    {
        if (BlueNlightScore < 20)
        {
            bluenlightpoints = bluenlightpoints.GetComponent<Text>();
            bluenlightpoints.text = "";
            BlueNlightScore += 1;
            bluenlightpoints.text = BlueNlightScore.ToString();
        }

    }
    public void NlightMinus()
    {
        if (BlueNlightScore > 1)
        {
            bluenlightpoints = bluenlightpoints.GetComponent<Text>();
            bluenlightpoints.text = "";
            BlueNlightScore -= 1;
            bluenlightpoints.text = BlueNlightScore.ToString();
        }
    }
}
