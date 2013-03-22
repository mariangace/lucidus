using UnityEngine;
using System.Collections;

public class TriggerControl : MonoBehaviour {
	public CuartoControl cuarto;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		cuarto.cambioOrientacion(this.collider);
	}
}
