using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmController : MonoBehaviour
{
    bool armWaving = false;

    public string ArmWavingPropertyName;

    // Start is called before the first frame update
    void Start()
    {
        // wyjsciowe ustawienie
        transform.GetComponent<Animator>().SetBool(ArmWavingPropertyName, false);
    }

    // Update is called once per frame
    void Update()
    {
        // jesli nacisnieto spacje
        if (Input.GetKeyDown(KeyCode.Space))
            armWaving = !armWaving;
        
        if (armWaving) 
            transform.GetComponent<Animator>().SetBool(ArmWavingPropertyName, true);
        else
            transform.GetComponent<Animator>().SetBool(ArmWavingPropertyName, false);
    }
}
