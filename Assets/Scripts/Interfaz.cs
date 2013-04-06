using UnityEngine;
using System.Collections;

public class Interfaz : MonoBehaviour {
	public GUIStyle estiloEtiqueta;
	public GUIStyle estiloBoton;
	public GUIStyle estiloBoton2;
	public GUISkin customSkin;
	public Rect winRect = new Rect(10,10,300,300);
	//private string nom="WriteYourNameHere";
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void miVentana(int winID){
		GUI.Label(new Rect(50,80,200,50), "MAIN MENU");
		//nom = GUI.TextField(new Rect(80,120,150,30), nom);
		if (GUI.Button(new Rect(100,150,93,38), "Jugar")){
			print("Jugar");
			//PlayerPrefs.SetString("nombre", nom);
			Application.LoadLevel("Nivel1");
		}
		if (GUI.Button(new Rect(50,180,200,40), "Salir")){
			print("Salir");
			Application.Quit();
		}
		if (GUI.Button(new Rect(100,210,100,50), "Cerrar")){
			print("Cerrar");
			
		}
		GUI.DragWindow();
	}
	
	void OnGUI(){
		GUI.skin = customSkin;
		
		//if (Input.GetMouseButton(0)){
			winRect = GUI.Window(0, winRect , miVentana, "Mi Ventana");
		//}
		
		 if (Input.GetKeyDown(KeyCode.Escape)) {
			Application.Quit();
		}
		
		/*
		GUI.Box(new Rect(50,0,280,300),"Ejemplo de skin");
		GUI.Label(new Rect(100,60,200,50), "MAIN MENU");
		if (GUI.Button(new Rect(150,100,93,38), "Jugar")){
			print("Jugar");
		}
		if (GUI.Button(new Rect(100,160,200,40), "Salir")){
			print("Salir");
		}
		if (GUI.Button(new Rect(150,190,100,50), "Cerrar")){
			print("Cerrar");
		}
		*/
	}
}
