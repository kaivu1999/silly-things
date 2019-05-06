using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_stuff : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        Debug.Log("GameObject2 collided with " + other.name);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
