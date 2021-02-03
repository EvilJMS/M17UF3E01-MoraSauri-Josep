using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score Instance;
    public TMP_Text score;
    public TMP_Text combo;

    public int scoreInt;

    public int comboInt;
    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        score.SetText("0");
        scoreInt = 0;
    }

    

    public void updateScore(int score)
    {
        if (comboInt>0)
        {
            scoreInt += score*comboInt;
        }
        else
        {
            scoreInt += score;
            
        }
        comboInt++;
        this.score.SetText(scoreInt+"");
        combo.SetText(comboInt+"");
    }

    public void setCombo(int combo)
    {
        comboInt = combo;
        this.combo.SetText(comboInt+"");
    }
}
