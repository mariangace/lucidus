using UnityEngine;
using System.Collections;

public class animcontroller : MonoBehaviour {
	private Texture[] texs;
	private int index = 0;
	private float nextFrame;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		texs = new Texture[20];
		
		if( Input.GetKey(KeyCode.RightArrow)){
			
			for (int k = 1; k<=20 ; k++){
				texs[k-1] = Resources.Load("Caminando"+k.ToString("0000")) as Texture;	
			}
			
			this.renderer.material.mainTexture = texs[index];
			index = (index + 1) % 20;
		}
		
		
		if( Input.GetKey(KeyCode.LeftArrow)){
			
			for (int k = 1; k<=20 ; k++){
				texs[k-1] = Resources.Load("Caminandoizq"+k.ToString("0000")) as Texture;	
			}
			
			this.renderer.material.mainTexture = texs[index];
			index = (index + 1) % 20;
		}
		
		nextFrame = Time.time + 0.5f;
				
		if (Time.time > nextFrame){
			this.renderer.material.mainTexture = texs[index];
			index = (index + 1) % 20;
			nextFrame = Time.time + (1.0f/60.0f);
		}
	}
}
