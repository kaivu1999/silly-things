using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ui_manage : MonoBehaviour
{
    GameObject light;
    private bool status_light = true;
    private float startTime;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        light = GameObject.Find("Point Light");
    }

    // Update is called once per frame
    void Update()
    {
        float time_diff = (stats.Levels) / 10;
        if(time_diff > 1)
        {
            time_diff = 1;
        }

        if ((Time.time - startTime) > (4 - time_diff))
        {
            stats.random_scene(false);
            //fail_level();
        }

    }

    public void turn_off()
    {
        status_light = false;
        Destroy(light);    
    }
    public void get_out()
    {
        if(status_light == true)
        {
            stats.random_scene(false);
        }
        else
        {
            stats.Electricity_saved += 1;
            stats.Points += 1;
            stats.random_scene(true);
        }
    }


}

