using UnityEngine;
using System.Collections;

public class ballerControls : MonoBehaviour {
	

	public float speed = 300f;

	
	//Optimal Speed + Drag
	//Mass 3f / varies, Drag 1f, Speed 300f / varies


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		//Adjust all controls + axis' in Edit -> Project Settings -> Input

		//Controls for ball player
		float ballerX = Input.GetAxis ("ballerHorizontal") * speed * Time.deltaTime;
		float ballerZ = Input.GetAxis ("ballerVertical") * speed * Time.deltaTime;

		//Moving the baller along the x and z axis
		Rigidbody rbody = GetComponent<Rigidbody> ();
		rbody.AddForce (ballerX, 0f, 0f); 
		rbody.AddForce (0f, 0f, ballerZ);






	}
}
