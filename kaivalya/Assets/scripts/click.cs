using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
   public void changemenuscene(string scene_name)
    {
        Application.LoadLevel(scene_name);
        stats.Lives = 3;
    }
    public void doquit()
    {
        Application.Quit();
    }
}
