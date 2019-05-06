using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AcceleratorInput : MonoBehaviour
{
    public float sc_right_bd = 2.0f;
    public float sc_left_bd = -2.0f;

    public float speed = 1.0f; 

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x_acc = Input.acceleration.x;
        float x_pos = gameObject.transform.position.x;
        if (x_acc < -0.1f && gameObject.transform.position.x > sc_left_bd)
        {
                moveleft();
        }
        else if (x_acc > 0.1f && gameObject.transform.position.x < sc_right_bd)
        {
                moveright();
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }
    }
    void moveleft()
    {
         rb.velocity = new Vector2(-2.0f, 0) * speed;
    }
    void moveright()
    {
       rb.velocity = new Vector2(2.0f, 0) * speed;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision"); 
        if(col.gameObject.tag == "Ambulance")
        {
            Destroy(gameObject);
            Application.LoadLevel("red_button");
            stats.Lives -= 1;
           // Destroy(col.gameObject);
        }
    }

}
