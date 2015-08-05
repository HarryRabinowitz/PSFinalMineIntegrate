using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
	
	public float speed = 5f;
	public float turnSpeed = 90f;
	public ForceMode forceMode;
	
	
	void FixedUpdate ()
	{
		float x = Input.GetAxis ("Horizontal"); 
		float y = Input.GetAxis ("Vertical"); 
		
		Rigidbody rbody = GetComponent<Rigidbody> ();
		rbody.AddRelativeForce (0f, 0f, y * speed * Time.deltaTime, forceMode);

		transform.Translate (0f, 0f, y * speed * Time.deltaTime);
		transform.Rotate (0f, x * turnSpeed * Time.deltaTime, 0f);
		

	}
	
}