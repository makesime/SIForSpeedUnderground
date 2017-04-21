using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speedTextScript : MonoBehaviour {

	public Rigidbody objectToMeasure;
	private Text text;
	public bool disallowBackwards = false;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if(!disallowBackwards || Vector3.Dot(objectToMeasure.velocity, objectToMeasure.transform.forward) > 0.0f)
		{
			float speed = objectToMeasure.velocity.magnitude;
			speed *= 3.6f;

			text.text = Mathf.Round(speed).ToString() + " KMH";

			//text.text = objectToMeasure.velocity.magnitude.ToString();
		}

		else
		{
			text.text = "0 KMH";
		}
		
	}
}
