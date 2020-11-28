using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatDat : MonoBehaviour
{
    public Text statpoints;
    public Text strength;
    public Text agility;
    public Text intelligence;
    public Text resilience;
    public int StrengthScore;
    public int AgilityScore;
    public int IntelligenceScore;
    public int ResilienceScore;
    public int StatScore = 20;
    public void StrengthPlus()
    {      
        if(StatScore>0 && StrengthScore < 5) {
            strength = strength.GetComponent<Text>();
            strength.text = "";
            StrengthScore += 1;
            strength.text = StrengthScore.ToString();
            statpoints = statpoints.GetComponent<Text>();
            statpoints.text = "";
            StatScore -= 1;
            statpoints.text = StatScore.ToString();
        }
        else if(StatScore>1 && StrengthScore >= 5 && StrengthScore < 8)
        {
            strength = strength.GetComponent<Text>();
            strength.text = "";
            StrengthScore += 1;
            strength.text = StrengthScore.ToString();
            statpoints = statpoints.GetComponent<Text>();
            statpoints.text = "";
            StatScore -= 2;
            statpoints.text = StatScore.ToString();
        }
        
    }
    public void AgilityPlus()
    {
        if (StatScore > 0 && AgilityScore < 5)
        {
            agility = agility.GetComponent<Text>();
            agility.text = "";
            AgilityScore += 1;
            agility.text = AgilityScore.ToString();
            statpoints = statpoints.GetComponent<Text>();
            statpoints.text = "";
            StatScore -= 1;
            statpoints.text = StatScore.ToString();
        }
        else if (StatScore > 1 && AgilityScore >= 5 && AgilityScore < 8)
        {
            agility = agility.GetComponent<Text>();
            agility.text = "";
            AgilityScore += 1;
            agility.text = AgilityScore.ToString();
            statpoints = statpoints.GetComponent<Text>();
            statpoints.text = "";
            StatScore -= 2;
            statpoints.text = StatScore.ToString();
        }
        
    }
    public void IntelligencePlus()
    {
        if (StatScore > 0 && IntelligenceScore < 5)
        {
            intelligence = intelligence.GetComponent<Text>();
            intelligence.text = "";
            IntelligenceScore += 1;
            intelligence.text = IntelligenceScore.ToString();
            statpoints = statpoints.GetComponent<Text>();
            statpoints.text = "";
            StatScore -= 1;
            statpoints.text = StatScore.ToString();
        }
        else if (StatScore > 1 && IntelligenceScore >= 5 && IntelligenceScore < 8)
        {
            intelligence = intelligence.GetComponent<Text>();
            intelligence.text = "";
            IntelligenceScore += 1;
            intelligence.text = IntelligenceScore.ToString();
            statpoints = statpoints.GetComponent<Text>();
            statpoints.text = "";
            StatScore -= 2;
            statpoints.text = StatScore.ToString();
        }

    }
    public void ResiliencePlus()
    {
        if (StatScore > 0 && ResilienceScore < 5)
        {
            resilience = resilience.GetComponent<Text>();
            resilience.text = "";
            ResilienceScore += 1;
            resilience.text = ResilienceScore.ToString();
            statpoints = statpoints.GetComponent<Text>();
            statpoints.text = "";
            StatScore -= 1;
            statpoints.text = StatScore.ToString();
        }
        else if (StatScore > 1 && ResilienceScore >= 5 && ResilienceScore < 8)
        {
            resilience = resilience.GetComponent<Text>();
            resilience.text = "";
            ResilienceScore += 1;
            resilience.text = ResilienceScore.ToString();
            statpoints = statpoints.GetComponent<Text>();
            statpoints.text = "";
            StatScore -= 2;
            statpoints.text = StatScore.ToString();
        }
        
    }
}
