﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrilNotasDown : MonoBehaviour
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
    
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (other.CompareTag("Note"))
            {
                score.GetComponent<Score>().updateScore(-50);
                Destroy(other.gameObject);
            }           
        }
    }
}
