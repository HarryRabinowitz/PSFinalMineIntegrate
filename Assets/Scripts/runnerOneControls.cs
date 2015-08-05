using UnityEngine;
using System.Collections;

public class runnerOneControls : MonoBehaviour {


	public GameObject runnerOne; //Assign in Inspector
	public GameObject mine; //Assign in Inspector
	public bool hasMine = false;

	
	//floats to keep track of the players position.
	//These are so that when the mine is placed, it is placed where the player is
	public float currentXPosition;
	public float currentYPosition; 
	public float currentZPosition;
	public float yPositionAdjust;


	public float speed = 500f;
	//Used Speed + Drag
	//Mass 0.5f, Drag 1f, Speed 500f
	

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void FixedUpdate () {

		//Debug, check for hasMine
		if (hasMine == true ) {
			Debug.Log ("Obtained Mine");
		}

		//Setting our floats so that they equal the players position
		currentXPosition = (runnerOne.transform.localPosition.x);
		currentYPosition = (runnerOne.transform.localPosition.y);
		currentZPosition = (runnerOne.transform.localPosition.z);
		//Depending on the player object, this needs to be changed

		//However, it is here so that the mine near the ground instead of in the air
		//This is done by dividing the local Y position of the player to a smaller value
		yPositionAdjust = ((runnerOne.transform.localPosition.y) * .3f);


		//Control Axis' for running player 1
		float runnerOneX = Input.GetAxis ("runnerOneHorizontal") * speed * Time.deltaTime;
		float runnerOneZ = Input.GetAxis ("runnerOneVertical") * speed * Time.deltaTime;
	
		Rigidbody rbody = GetComponent<Rigidbody> ();


		//Implementing the controls

		//Left + Right
		rbody.AddRelativeForce (runnerOneX, 0f , 0f);
		//Up + Down
		rbody.AddRelativeForce (0f, 0f, runnerOneZ);
	
		//Mine placement, sets a mine if the player has one.
		if (Input.GetKeyDown (KeyCode.Q) && hasMine == true ) {
			GameObject placemine;
			placemine = (GameObject)Instantiate( mine, 
			                                    new Vector3 (currentXPosition, yPositionAdjust, currentZPosition),
			                                    Quaternion.Euler ( 0f, 0f, 0f ));
			hasMine = false;

			//Debug log, for coding purposed
			Debug.Log ("Placed Mine");

			                        }



	}
}
