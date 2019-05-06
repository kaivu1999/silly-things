using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class share_text_script : MonoBehaviour
{
    Text mytext;
    // Start is called before the first frame update
    void Start()
    {
        mytext = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        mytext.text = "Saves : " + stats.Lives_saved + "\n" + "Water saved : " + stats.Water_saved + "\n" + "Electricity saved: " + stats.Electricity_saved + "\n" + "Contribution made:" + stats.Points + "\n" + " Can you beat my score ?";
    }
}
