using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameUI))]
public class GameController : MonoBehaviour
{
    
    public static GameController Instance { get; private set; }
    public GameUI GameUI { get; private set; }

    private float score = 0;

    public void ScoreIncrement(float count)
    {
        //score += Mathf.Round(house.GetComponent<House>().GetCount());
        score += Mathf.Round(count);
        GameUI.ShowCount(score);
    }

    private void Awake()
    {
        Instance = this;
        GameUI = GetComponent<GameUI>();
    }
}
