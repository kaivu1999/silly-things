using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackMove : MonoBehaviour
{
  
    public float speed = 0.5f;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(0,Time.time * speed);
        rend.material.mainTextureOffset = offset;
    }
}
