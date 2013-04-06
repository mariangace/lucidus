using UnityEngine;
using System.Collections;

public class PausaInterfaz : MonoBehaviour {

	public GUISkin customSkin;
	public Rect winRect = new Rect(10,10,Screen.width,300);
	//private string nom="WriteYourNameHere";
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void miVentana(int winID){
		GUI.Label(new Rect(50,80,200,50), "RESUME");

		if (GUI.Button(new Rect(50,150,200,40), "Salir del Juego")){
			print("Salir");
			Application.Quit();
		}
		if (GUI.Button(new Rect(100,180,100,50), "Cerrar")){
			print("Cerrar");
			Application.LoadLevel("Nivel1");
			
		}
		GUI.DragWindow();
	}
	
	void OnGUI(){
		GUI.skin = customSkin;
		
			winRect = GUI.Window(0, winRect , miVentana, "Mi Ventana");
	
		 if (Input.GetKeyDown(KeyCode.Escape)) {
			Application.Quit();
		}

	}
}