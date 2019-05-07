using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ambulance")
        {
            Destroy(collision.gameObject);
            stats.Lives_saved += 1;
            stats.Points += 1;
            stats.random_scene(true);

        }
       
    }
}
