using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNote : MonoBehaviour
{
    public float nextActionTime;

    public GameObject note;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DoCheck");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator DoCheck()
    {
        for (; ; )
        {
            Instantiate(note, transform.position, transform.rotation);
            yield return new WaitForSeconds(nextActionTime);
        }
    }
}

