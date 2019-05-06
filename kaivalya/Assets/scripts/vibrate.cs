using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vibrate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnGUI()
    {
        if (GUI.Button(new Rect(0, 10, 100, 32), "Vibrate!"))
            Handheld.Vibrate();
    }

}
