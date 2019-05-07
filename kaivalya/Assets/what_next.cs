using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class what_next : MonoBehaviour
{
    float start_time;
    // Start is called before the first frame update
    void Start()
    {
        start_time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - start_time > 2)
        {
            //Application.LoadLevel("road");
            stats.what_next();
        }
    }
}
