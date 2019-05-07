using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public AudioClip HappySong;  
    public AudioClip SadSong;
    public AudioSource BGM;

    // Start is called before the first frame update
    void Start()
    {
        if(stats.result == true)
        {
            Debug.Log("Happy Song");
            BGM.Stop();
            BGM.clip = HappySong;
            BGM.Play();
        }
        else if (stats.result == false)
        {
            Debug.Log("Sad Song");
            BGM.Stop();
            BGM.clip = SadSong;
            BGM.Play();

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
