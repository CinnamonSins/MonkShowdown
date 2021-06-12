using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatDatTwo : MonoBehaviour
{
    public Text redstatpoints;
    public Text redstrength;
    public Text redagility;
    public Text redintelligence;
    public Text redresilience;
    public Text redhp;
    public Button done;
    public int redstrengthScore;
    public int redagilityScore;
    public int redintelligenceScore;
    public int redresilienceScore;
    public static int redhpScore=0;
    public int StatScore = 20;
    public void redstrengtredhplus()
    {      
        if(StatScore>0 && redstrengthScore < 5) {
            redstrength = redstrength.GetComponent<Text>();
            redstrength.text = "";
            redstrengthScore += 1;
            redstrength.text = redstrengthScore.ToString();
            redstatpoints = redstatpoints.GetComponent<Text>();
            redstatpoints.text = "";
            StatScore -= 1;
            redstatpoints.text = StatScore.ToString();
        }
        else if(StatScore>1 && redstrengthScore >= 5 && redstrengthScore < 8)
        {
            redstrength = redstrength.GetComponent<Text>();
            redstrength.text = "";
            redstrengthScore += 1;
            redstrength.text = redstrengthScore.ToString();
            redstatpoints = redstatpoints.GetComponent<Text>();
            redstatpoints.text = "";
            StatScore -= 2;
            redstatpoints.text = StatScore.ToString();
        }
        
    }
    void Start()
    {
        done.interactable = false;
    }
    public void redagilityPlus()
    {
        if (StatScore > 0 && redagilityScore < 5)
        {
            redagility = redagility.GetComponent<Text>();
            redagility.text = "";
            redagilityScore += 1;
            redagility.text = redagilityScore.ToString();
            redstatpoints = redstatpoints.GetComponent<Text>();
            redstatpoints.text = "";
            StatScore -= 1;
            redstatpoints.text = StatScore.ToString();
        }
        else if (StatScore > 1 && redagilityScore >= 5 && redagilityScore < 8)
        {
            redagility = redagility.GetComponent<Text>();
            redagility.text = "";
            redagilityScore += 1;
            redagility.text = redagilityScore.ToString();
            redstatpoints = redstatpoints.GetComponent<Text>();
            redstatpoints.text = "";
            StatScore -= 2;
            redstatpoints.text = StatScore.ToString();
        }
        
    }
    public void redintelligencePlus()
    {
        if (StatScore > 0 && redintelligenceScore < 5)
        {
            redintelligence = redintelligence.GetComponent<Text>();
            redintelligence.text = "";
            redintelligenceScore += 1;
            redintelligence.text = redintelligenceScore.ToString();
            redstatpoints = redstatpoints.GetComponent<Text>();
            redstatpoints.text = "";
            StatScore -= 1;
            redstatpoints.text = StatScore.ToString();
        }
        else if (StatScore > 1 && redintelligenceScore >= 5 && redintelligenceScore < 8)
        {
            redintelligence = redintelligence.GetComponent<Text>();
            redintelligence.text = "";
            redintelligenceScore += 1;
            redintelligence.text = redintelligenceScore.ToString();
            redstatpoints = redstatpoints.GetComponent<Text>();
            redstatpoints.text = "";
            StatScore -= 2;
            redstatpoints.text = StatScore.ToString();
        }

    }
    public void redresiliencePlus()
    {
        if (StatScore > 0 && redresilienceScore < 5)
        {
            redresilience = redresilience.GetComponent<Text>();
            redresilience.text = "";
            redresilienceScore += 1;
            redresilience.text = redresilienceScore.ToString();
            redstatpoints = redstatpoints.GetComponent<Text>();
            redstatpoints.text = "";
            StatScore -= 1;
            redstatpoints.text = StatScore.ToString();
            redhp = redhp.GetComponent<Text>();
            redhp.text = "";
            int redhpSemiScore = 40 + 3 * redresilienceScore;
            redhpScore = nlightDat.NlightScore* redhpSemiScore;
            redhp.text = redhpScore.ToString();
        }
        else if (StatScore > 1 && redresilienceScore >= 5 && redresilienceScore < 8)
        {
            redresilience = redresilience.GetComponent<Text>();
            redresilience.text = "";
            redresilienceScore += 1;
            redresilience.text = redresilienceScore.ToString();
            redstatpoints = redstatpoints.GetComponent<Text>();
            redstatpoints.text = "";
            StatScore -= 2;
            redstatpoints.text = StatScore.ToString();
            redhp = redhp.GetComponent<Text>();
            redhp.text = "";
            int redhpSemiScore = 40 + 3 * redresilienceScore;
            redhpScore = nlightDat.NlightScore * redhpSemiScore;
            redhp.text = redhpScore.ToString();
        }
        
    }
    public void redagilityMinus()
    {
        if (StatScore > 0 && redagilityScore <= 5 && redagilityScore>0)
        {
            redagility = redagility.GetComponent<Text>();
            redagility.text = "";
            redagilityScore -= 1;
            redagility.text = redagilityScore.ToString();
            redstatpoints = redstatpoints.GetComponent<Text>();
            redstatpoints.text = "";
            StatScore += 1;
            redstatpoints.text = StatScore.ToString();
        }
        else if (StatScore > 1 && redagilityScore >= 5 && redagilityScore <= 8)
        {
            redagility = redagility.GetComponent<Text>();
            redagility.text = "";
            redagilityScore -= 1;
            redagility.text = redagilityScore.ToString();
            redstatpoints = redstatpoints.GetComponent<Text>();
            redstatpoints.text = "";
            StatScore += 2;
            redstatpoints.text = StatScore.ToString();
        }

    }
    public void redintelligenceMinus()
    {
        if (StatScore > 0 && redintelligenceScore <= 5 && redintelligenceScore > 0)
        {
            redintelligence = redintelligence.GetComponent<Text>();
            redintelligence.text = "";
            redintelligenceScore -= 1;
            redintelligence.text = redintelligenceScore.ToString();
            redstatpoints = redstatpoints.GetComponent<Text>();
            redstatpoints.text = "";
            StatScore += 1;
            redstatpoints.text = StatScore.ToString();
        }
        else if (StatScore > 1 && redintelligenceScore >= 5 && redintelligenceScore <= 8)
        {
            redintelligence = redintelligence.GetComponent<Text>();
            redintelligence.text = "";
            redintelligenceScore -= 1;
            redintelligence.text = redintelligenceScore.ToString();
            redstatpoints = redstatpoints.GetComponent<Text>();
            redstatpoints.text = "";
            StatScore += 2;
            redstatpoints.text = StatScore.ToString();
        }

    }
    public void redresilienceMinus()
    {
        if (StatScore > 0 && redresilienceScore <= 5 && redresilienceScore > 0)
        {
            redresilience = redresilience.GetComponent<Text>();
            redresilience.text = "";
            redresilienceScore -= 1;
            redresilience.text = redresilienceScore.ToString();
            redstatpoints = redstatpoints.GetComponent<Text>();
            redstatpoints.text = "";
            StatScore += 1;
            redstatpoints.text = StatScore.ToString();
            redhp = redhp.GetComponent<Text>();
            redhp.text = "";
            int redhpSemiScore = 40 + 3 * redresilienceScore;
            redhpScore = nlightDattwo.BlueNlightScore * redhpSemiScore;
            redhp.text = redhpScore.ToString();
        }
        else if (StatScore > 1 && redresilienceScore >= 5 && redresilienceScore <= 8)
        {
            redresilience = redresilience.GetComponent<Text>();
            redresilience.text = "";
            redresilienceScore -= 1;
            redresilience.text = redresilienceScore.ToString();
            redstatpoints = redstatpoints.GetComponent<Text>();
            redstatpoints.text = "";
            StatScore += 2;
            redstatpoints.text = StatScore.ToString();
            redhp = redhp.GetComponent<Text>();
            redhp.text = "";
            int redhpSemiScore = 40 + 3 * redresilienceScore;
            redhpScore = nlightDat.NlightScore * redhpSemiScore;
            redhp.text = redhpScore.ToString();
        }

    }
    public void redstrengthMinus()
    {
        if (StatScore > 0 && redstrengthScore <= 5 && redstrengthScore > 0)
        {
            redstrength = redstrength.GetComponent<Text>();
            redstrength.text = "";
            redstrengthScore -= 1;
            redstrength.text = redstrengthScore.ToString();
            redstatpoints = redstatpoints.GetComponent<Text>();
            redstatpoints.text = "";
            StatScore += 1;
            redstatpoints.text = StatScore.ToString();
        }
        else if (StatScore > 1 && redstrengthScore >= 5 && redstrengthScore <= 8)
        {
            redstrength = redstrength.GetComponent<Text>();
            redstrength.text = "";
            redstrengthScore -= 1;
            redstrength.text = redstrengthScore.ToString();
            redstatpoints = redstatpoints.GetComponent<Text>();
            redstatpoints.text = "";
            StatScore += 2;
            redstatpoints.text = StatScore.ToString();
        }

    }
    void Update()
    {  
        if(StatScore == 0)
        {
            done.interactable = true;
        }
    }
}
