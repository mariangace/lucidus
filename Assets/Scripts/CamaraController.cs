using UnityEngine;
using System.Collections;

public class CamaraController : MonoBehaviour {
	
	public Camera camera;
	public GameObject centro;
	Vector3 posicion;
	
	void OnTriggerEnter(Collider other)
	{
		posicion[0] = centro.transform.localPosition.x;
			posicion[1] = centro.transform.localPosition.y;
			posicion[2] = -16;
			
			print(posicion[0].ToString()+", "+posicion[1].ToString()+", "+posicion[2].ToString());
			
			camera.transform.position = new Vector3(posicion[0],posicion[1],posicion[2]);
			
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
