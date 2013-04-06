using UnityEngine;
using System.Collections;

public class CuartoControl : MonoBehaviour {
	
	// Public elements
	public GameObject jugador ;
	
	// Pivate elements
	int orientacion = 0; // 0 => suelo, 1 => derecha, 2 => techo, 3 => izquierda
	float targetRotacion = 0;
	float rotacion = 0;
	float delta = 0;
	bool freeze = false;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		if(freeze) Time.timeScale = 0;
		else Time.timeScale = 1;
		
		if(rotacion != targetRotacion)
		{
			freeze = true;
			
			transform.Rotate(delta,0,0);
			jugador.transform.Rotate(0,0,delta);
			rotacion += delta;
		}
		else
		{
			delta = 0;
			jugador.GetComponent<PersonajeControl>().setEnable(true);
			freeze = false;
		}
		
	}
	
	public void cambioOrientacion(Collider other) {
		
		if(other.CompareTag("TriggerEste"))
		{
			switch(orientacion) {
			case 0: rotar(2); break;
			case 2: rotar(1); break;
			case 3: rotar(0); break;
			}
			orientacion = 1;
		}
		if(other.CompareTag("TriggerOeste"))
		{
			switch(orientacion) {
			case 0: rotar(1); break;
			case 1: rotar(0); break;
			case 2: rotar(2); break;
			}
			orientacion = 3;
		}
		if(other.CompareTag("TriggerSur"))
		{
			switch(orientacion) {
			case 1: rotar(1); break;
			case 2: rotar(0); break;
			case 3: rotar(2); break;
			}
			orientacion = 0;
		}
		if(other.CompareTag("TriggerNorte"))
		{
			switch(orientacion) {
			case 0: rotar(0); break;
			case 1: rotar(2); break;
			case 3: rotar(1); break;
			}
			orientacion = 2;
		}
		
	}
	
	void rotar(int i) {  // 0 => 180, 1 => izquierda, 2 => derecha
		
		jugador.GetComponent<PersonajeControl>().setEnable(false);
		
		if(i == 0) { delta = -2.0f; targetRotacion = rotacion-180; }
		if(i == 1) { delta = -1.0f; targetRotacion = rotacion-90;}
		if(i == 2) { delta = 1.0f; targetRotacion = rotacion+90;}
		
	}
}
