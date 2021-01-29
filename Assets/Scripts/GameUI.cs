using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField]
    private GameObject scoreText;
    public void ShowCount(float count)
    {
        scoreText.GetComponent<Text>().text ="SCORE:"+ count.ToString();
    }
   
}
