using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomSample : MonoBehaviour {
	public Image cbody;
	public Image cface;
	public Image chair;
	public Image ckit;
	public Sprite[] body;
	public Sprite[] face;
	public Sprite[] hair;
	public Sprite[] kit;
	public Color[] background;
	private Camera cam;


	// Use this for initialization
	void Start () {
		cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        Debug.Log("Sart !!" + stats.result);
        if (stats.result == true)
        {
            Debug.Log("Happy");
            HappyCharacter();
        }
        else if (stats.result == false)
        {
            Debug.Log("Sad");
            SadCharacter();
        }
        // RandomizeCharacter();
    }

    public bool prev_status;
    private void Update()
    {
     
    }
    public void RandomizeCharacter(){
		cbody.sprite = body[0];
		cbody.sprite = body[Random.Range(0,body.Length)];
		cface.sprite = face[Random.Range(0,face.Length)];
		chair.sprite = hair[Random.Range(0,hair.Length)];
		ckit.sprite = kit[Random.Range(0,kit.Length)];
        cam.backgroundColor = background[Random.Range(0,background.Length)];
	}
    public void HappyCharacter()
    {
        // happy face
        cbody.sprite = body[0];
        cface.sprite = face[1];
        chair.sprite = hair[10];
        ckit.sprite = kit[Random.Range(7,10)];
        cam.backgroundColor = background[Random.Range(0, background.Length)];
    }
    public void SadCharacter()
    {
        // sad face
        cbody.sprite = body[0];
        cface.sprite = face[2];
        chair.sprite = hair[10];
        ckit.sprite = kit[Random.Range(7, 10)];

        cam.backgroundColor = background[Random.Range(0, background.Length)];
    }

}
