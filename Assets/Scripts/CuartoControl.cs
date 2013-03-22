using UnityEngine;
using System.Collections;

public class CuartoControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	public void cambioOrientacion(Collider other) {
		
		if(other.CompareTag("TriggerEste"))
		{
			print ("Este");
			transform.Rotate(Vector3.forward, 90f);
		}
		
		if(other.CompareTag("TriggerOeste"))
		{
			print ("Oeste");
			transform.Rotate(0, 0, 45f);
		}
		
		if(other.CompareTag("TriggerSur"))
		{
			print ("Sur");
		}
		
		if(other.CompareTag("TriggerNorte"))
		{
			print ("Norte");
		}
		
	}
}
