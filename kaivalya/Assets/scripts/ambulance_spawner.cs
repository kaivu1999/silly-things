using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ambulance_spawner : MonoBehaviour
{
    public GameObject car;
    public GameObject boundary;
    public GameObject char_succ;
    public GameObject char_fail;
    // Start is called before the first frame update
    void Start()
    {
        char_fail = GameObject.Find("fail");
        char_succ = GameObject.Find("success");
    } 

    // Update is called once per frame
    void Update()
    {
    }


}
