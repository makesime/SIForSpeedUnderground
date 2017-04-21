using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFillBasedOnVelocity : MonoBehaviour {

	public Rigidbody objectToMeasure;
	public float minVelocity = 0.0f;
	public float maxVelocity = 10.0f; 
	private Image image;
	public bool disallowBackwards = false;

	// Use this for initialization
	void Start () 
	{
		image = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(!disallowBackwards || Vector3.Dot(objectToMeasure.velocity, objectToMeasure.transform.forward) > 0.0f)
		{
			image.fillAmount = objectToMeasure.velocity.magnitude/maxVelocity;	
		}

		else
		{
			image.fillAmount = 0.0f;
		}
	}
}
