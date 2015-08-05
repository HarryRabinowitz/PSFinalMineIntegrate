using UnityEngine;
using System.Collections;

public class minePickup : MonoBehaviour {


	public float respawnTimer;
	public float spin = 10f;

	void OnTriggerEnter (Collider other)
	{
		//if (GameObject.FindWithTag ("Player").GetComponent<runnerOneControls> ().hasMine) {
			GameObject.FindWithTag ("Player").GetComponent<runnerOneControls> ().hasMine = true;
			GameObject.FindWithTag ("Player2").GetComponent<runnerTwoControls> ().hasMine = true;
			DestroyObject(gameObject);
			
		//} else {
		//	Debug.Log ( "Already has a mine" );
		//}
	}
	//
			
	//	}
		//Debug.Log ("We have trigged");
	//}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		transform.Rotate (Vector3.right, spin * Time.deltaTime);


	}
}
