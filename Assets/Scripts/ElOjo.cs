using UnityEngine;
using System.Collections;

public class ElOjo : MonoBehaviour {
	
	
	float rotacion = 0f;
	float targetRotacion = 0;
	bool freeze = false;
	float diferencial = 0;
	public GameObject jugador ;
	bool enable = true;
	bool parchesito = false;
	int orientacionCuarto;
	
	
	
	public void cambioOrientacion(Collider other)
	{
		if(other.CompareTag("TriggerEste"))
		{
			switch(orientacionCuarto)
			{
			case 0:
				rotarDerecha();
				break;
			default:
				break;
			case 2:
				rotarIzquierda();
				break;	
			case 3:
				Voltear();
				break;
			}
		orientacionCuarto = 1;
		}
		
		if(other.CompareTag("TriggerOeste"))
		{
			switch(orientacionCuarto)
			{
			case 0:
				rotarIzquierda();
				break;
			case 1:
				Voltear();
				break;
			case 2:
				rotarDerecha();
				break;
			default:
				break;
			}
		orientacionCuarto = 3;

		}
		
		if(other.CompareTag("TriggerSur"))
		{
			switch(orientacionCuarto)
			{
			default:
				break;
			case 1:
				rotarIzquierda();
				break;
			case 2:
				Voltear();
				break;
			case 3:
				rotarDerecha();
				break;
			}
		orientacionCuarto = 0;
		}
		
		if(other.CompareTag("TriggerNorte"))
		{
			switch(orientacionCuarto)
			{
			case 0:
				Voltear();
				break;
			case 1:
				rotarDerecha();
				break;
			default:
				break;
			case 3:
				rotarIzquierda();
				break;
			}
				orientacionCuarto = 2;
		}
	}
	
	// Use this for initialization
	void Start () {
		
		orientacionCuarto = 0;
	
	}
	
	public void rotarDerecha()
	{
		
		jugador.GetComponent<Control>().enable = false;
		diferencial = -1f;
		
		targetRotacion = rotacion-90;
			
	}
	
	public void rotarIzquierda()
	{
		
		jugador.GetComponent<Control>().enable = false;
		diferencial = 1f;
			targetRotacion = rotacion+90;
			
	}
	
	public void Voltear()
	{
		
		
		jugador.GetComponent<Control>().enable = false;
		diferencial = 2f;
		targetRotacion = rotacion+180;
			
		
		
			
	}
	
	
	
	// Update is called once per frame
	void Update () {
		
		if(freeze)
			Time.timeScale = 0;
		else
			Time.timeScale = 1;
		

		
		
		if(rotacion != targetRotacion)
		{
			enable = false;
			freeze = true;
			
			transform.Rotate(0,0,diferencial);
			jugador.transform.Rotate(0,0,-diferencial);
			rotacion+=diferencial;
		}
		else
		{
			diferencial = 0;
			jugador.GetComponent<Control>().enable = true;
			freeze = false;
		}
	
	
		
		
	}
	
	
}
