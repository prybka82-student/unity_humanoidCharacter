using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmController : MonoBehaviour
{
    bool armWaving = false;

    // Start is called before the first frame update
    void Start()
    {
        transform.GetComponent<Animator>().SetBool("reka", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            armWaving = !armWaving;
        }
        
        if (armWaving) 
        {
            transform.GetComponent<Animator>().SetBool("reka", true);
        }
        else
        {
            transform.GetComponent<Animator>().SetBool("reka", false);
        }
    }
}
