using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ambulance_move : MonoBehaviour
{
    public GameObject target_car;
    public float road_bottom = -2.0f;
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y_pos = gameObject.transform.position.y;
        float x_pos = gameObject.transform.position.y;
        float x_new;
        float y_new = y_pos;
        y_new += 1 * speed * Time.deltaTime;
        if ( y_pos < road_bottom )
        {
            x_new = target_car.transform.position.x;
            Vector2 position_new = new Vector2(x_new, y_new);
            transform.position = position_new;
        }
        else
        {

            float speed_factor_level = (stats.levels + 10) / 10;
            if ( speed_factor_level > 2)
            {
                speed_factor_level = 2; 
            }
            transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime * speed_factor_level );
        }

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "car")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            Debug.Log("fail");
        }
        else if (col.gameObject.name == "Destroyer")
        {
            Debug.Log("success");
        }
    }
}
