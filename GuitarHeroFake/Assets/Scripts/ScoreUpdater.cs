using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUpdater : MonoBehaviour
{
    public TMP_Text score;
    public TMP_Text combo;

    private int scoreInt;

    public int comboInt;
    // Start is called before the first frame update
    void Start()
    {
        scoreInt = Score.Instance.scoreInt;
        comboInt = Score.Instance.comboInt;

        score.SetText("Score: "+scoreInt);
        combo.SetText("Combo Max: "+comboInt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
