using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrilNotasUp : MonoBehaviour
{
    public GameObject score;
    
    
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (other.CompareTag("Note"))
            {
                score.GetComponent<Score>().updateScore(-50);
                Destroy(other.gameObject);
            }           
        }
    }
}
