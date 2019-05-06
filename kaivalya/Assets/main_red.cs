using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_red : MonoBehaviour
{
    float startT;
    // Start is called before the first frame update
    void Start()
    {
        startT = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Time.time - startT) > 4)
        {
            fail_level();
        }
    }

    public void fail_level()
    {
         Application.LoadLevel("road");
    }

}
