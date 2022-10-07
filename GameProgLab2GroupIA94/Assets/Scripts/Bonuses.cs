using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bonuses : MonoBehaviour
{

    public static int bonuses = 0;
    Text Score;

    // Start is called before the first frame update
    void Start()
    {
        Score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "Score: " + bonuses;
    }
}
