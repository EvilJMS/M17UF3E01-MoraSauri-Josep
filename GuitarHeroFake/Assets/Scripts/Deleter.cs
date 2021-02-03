using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deleter : MonoBehaviour
{
    public GameObject score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Note"))
        {
            score.GetComponent<Score>().updateScore(-50);
            score.GetComponent<Score>().setCombo(0);
            Destroy(other.gameObject);
        }
        else {
            if (other.CompareTag("FinalNote")) 
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
