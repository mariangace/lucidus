using UnityEngine;
using System.Collections;

public class PersonajeControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		// Control de movimiento ===========================
		if(Input.GetKey(KeyCode.LeftArrow)) {
			transform.Translate(-0.05f, 0, 0);
		}
		if(Input.GetKey(KeyCode.RightArrow)) {
			transform.Translate(0.05f, 0, 0);
		}
		if(Input.GetKeyDown(KeyCode.UpArrow)) {
			if (Physics.Raycast(rigidbody.position, Vector3.down, 1f)) {
				rigidbody.AddForce(0, 300f, 0);		
			}
		}
	
	}
}
