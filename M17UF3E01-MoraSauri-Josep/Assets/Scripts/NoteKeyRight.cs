using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteKeyRight : MonoBehaviour
{
    public bool creatorMode;
    public GameObject[] notes;
    public GameObject score;
    

    // Update is called once per frame
    void Update()
    {
        if (creatorMode)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Instantiate(notes[(int )Random.Range(0,4)], transform.position, transform.rotation);
            }
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (other.CompareTag("Note"))
            {
                score.GetComponent<Score>().updateScore(100);
                Destroy(other.gameObject);
            }
        }
    }
}
