using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class uimanage_fail_screen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void retry()
    {
        stats.clear();
        SceneManager.LoadScene("road");
    }

    public void close()
    {
        Application.Quit();
    }
}
