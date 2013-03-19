using UnityEngine;
using System.Collections;
using System;

public class Control : MonoBehaviour {
	
	float caminar = 0.1f;
	public GameObject elojo;
	ElOjo controlador;
	int orientacion;
	public bool enable;
	
	// Use this for initialization
	void Start () {
		transform.parent = elojo.transform;
		orientacion = 0;
		controlador = elojo.GetComponent<ElOjo>();
	
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.tag.Contains("Cuarto"))
		{
			cambioCuarto(other.gameObject.transform.parent.gameObject);
		}
		
		controlador.cambioOrientacion(other); // este codigo checa el cambio de gravedad
	}
	
	void cambioCuarto(GameObject entrada )// este es el indice en el arreglo de cuartos
	{
			controlador.enabled = false; // desactivamos el script anterior para evitar problemas.
			elojo = entrada;
			controlador  = elojo.GetComponent<ElOjo>();// y el script del controlador principal
			controlador.enabled = true;//activamos el script del controlador nuevo
			controlador.jugador = this.gameObject; // le pasamos al jugador como referencia al script por si no lo tiene.
			transform.parent = elojo.transform;//y hacemos el nuevo controlador el padre del jugador.
		
		
	}
	
	
	// Update is called once per frame
	void Update () {
	if(enable){
		
		if(Input.GetKeyDown(KeyCode.Space))
		{
			rigidbody.AddRelativeForce(0,250,0);
		}
			
		if(Input.GetKey(KeyCode.D))
		{
				//orientacion = true;
			transform.Translate(caminar, 0f,0f);
		}
		
		if(Input.GetKey(KeyCode.A))
		{
				//orientacion = false;
			transform.Translate(-caminar, 0f,0f);
		}
		

			
			
		
		
		}
	}
}
