using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class House : MonoBehaviour
{
    private float count;

    [SerializeField]
    private float countPerSecond;
 
    void Start()
    {
        count = 0;
    }

    public float GetCount()
    {
        return count;
    }

    public void Click()
    {
        GameController.Instance.ScoreIncrement(count);
        count = 0;
    }
    void Update()
    {
        count += countPerSecond * Time.deltaTime;
        gameObject.transform.GetChild(0).GetComponent<Text>().text = Mathf.Round(count).ToString();
    }
}
