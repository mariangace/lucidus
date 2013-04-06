using UnityEngine;
using System.Collections;

public class Escena2GUI : MonoBehaviour {

	// Use this for initialization
	

	public GUISkin guiSkin;
	bool isPaused = false;
	public Rect winRect = new Rect(10,10,300,300);
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.Escape) && !isPaused){
   		
      		print("Paused");
      		Time.timeScale = 0.01f;
      		isPaused = true;
  		}else
    	if(Input.GetKeyDown(KeyCode.Escape) && isPaused){
   
      		print("Unpaused");
      		Time.timeScale = 1.0f;
      		isPaused = false;    
   		} 
	}
	
	void miVentana(int winID){
		GUI.Label(new Rect(50,80,200,50), "RESUME");

		if (GUI.Button(new Rect(50,150,200,40), "Salir del Juego")){
			print("Salir");
			Application.Quit();
		}
		if (GUI.Button(new Rect(100,180,100,50), "Cerrar")){
			print("Continuar");
			//Application.LoadLevel("Nivel1");
         	Time.timeScale = 1.0f;
        	isPaused = false;  
			
		}
		GUI.DragWindow();
	}
	
	void OnGUI(){
		GUI.skin = guiSkin;
		
		/*if (GUI.Button(new Rect(100,100,93,38), "Regresar")){	
		}*/
		
		/*if(Input.GetKeyDown(KeyCode.Escape)){
			Application.LoadLevel("Pause");	
		}*/
		if(isPaused){
			winRect = GUI.Window(0, winRect , miVentana, "Mi Ventana");
		}
		
		
	}
}
