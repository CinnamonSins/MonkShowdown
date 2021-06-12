using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPworkr : MonoBehaviour
{
    public Text RedHp;
    public Text BlueHp;
    // Update is called once per frame
    void Start()
    {
        BlueHp.text = StatDat.hpScore.ToString();
        RedHp.text = StatDatTwo.redhpScore.ToString();
    }
}
