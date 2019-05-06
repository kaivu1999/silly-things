using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ui_manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void fail()
    {
        stats.Lives -= 1;
        Application.LoadLevel("road");
    }
    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }
    public void OnGUI()
    {
        if (GUI.Button(new Rect(0, 10, 100, 32), "Vibrate!"))
            Handheld.Vibrate();
    }
}
