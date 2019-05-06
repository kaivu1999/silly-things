using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class text_script : MonoBehaviour
{
    Text mytext;
    // Start is called before the first frame update
    void Start()
    {
        mytext = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        mytext.text = "Lives :" + stats.Lives;   
    }
}
