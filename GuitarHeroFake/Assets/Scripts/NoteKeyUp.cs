using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteKeyUp : MonoBehaviour
{
    public bool creatorMode;
    public GameObject[] notes;
    public GameObject score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (creatorMode)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Instantiate(notes[(int )Random.Range(0,4)], transform.position, transform.rotation);
            }
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (other.CompareTag("Note"))
            {
                score.GetComponent<Score>().updateScore(100);
                Destroy(other.gameObject);
            }
        }
    }
}
