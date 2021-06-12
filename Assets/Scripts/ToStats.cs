using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToStats : MonoBehaviour
{
    public void ToState(){
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
