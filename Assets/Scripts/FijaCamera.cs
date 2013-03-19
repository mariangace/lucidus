using UnityEngine;
using System.Collections;

public class FijaCamera : MonoBehaviour {

	static int numCuartos = 2;
	public GameObject[] centro = new GameObject[numCuartos];
	public GameObject personaje;
	Vector3 posicion;
	int temp = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.Alpha1))
		{
			
			
	 		posicion[0] = centro[temp].transform.localPosition.x;
			posicion[1] = centro[temp].transform.localPosition.y;
			posicion[2] = -10;
			
			print(posicion[0].ToString()+", "+posicion[1].ToString()+", "+posicion[2].ToString());
			
			transform.position = new Vector3(posicion[0],posicion[1],posicion[2]);
			
			if(temp < numCuartos-1){
				temp++;
				print(temp.ToString());
			}
			else{
				temp = 0;
				print(temp.ToString());
			}
			print("mueve derecha");
		
		
		} 
	}
	
	
	
	public void SetCamera(GameObject nvoCentro){
		posicion[0] = nvoCentro.transform.localPosition.x;
		posicion[1] = nvoCentro.transform.localPosition.y;
		posicion[2] = -10;
		
		transform.position = new Vector3(posicion[0],posicion[1],posicion[2]);
	}
}
