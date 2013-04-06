using UnityEngine;
using System.Collections;

public class PersonajeControl : MonoBehaviour {
	public GameObject muro;
	
	bool jumping = false;
	int estado = 0; // 0 => reposo, 1 => caminando, 2 => brincando, 3 => creando, 4 => corriendo, 5 => afectado
	bool direccion = true; // true => derecha, false => izquierda
	float speed = 0.05f; // caminando => 0.05, corriendo => 0.1
	bool enable = true;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(enable) {  // controll general del personaje, false si esta girando
			
			// Movimiento lateral ================
			if(Input.GetKey(KeyCode.LeftArrow)) {  					// izquierda
				transform.Translate((-1*speed), 0, 0);
				estado = 1;
				direccion = false;
			}
			if(Input.GetKey(KeyCode.RightArrow)) {					// derecha
				transform.Translate(speed, 0, 0);
				estado = 1;
				direccion = true;
			}
			if((Input.GetKeyUp(KeyCode.LeftArrow))||				// Cuando se deja de presionar alguno de los botones de desplazamiento
			   (Input.GetKeyUp(KeyCode.RightArrow))) estado = 0;	// lateral se establece el estado a "reposo"
			
			// Correr =============================
			if(Input.GetKey(KeyCode.X)) {
				if((estado == 1)||(estado ==4)) { 					// Si esta caminando o corriendo su velocidad es 0.1
					speed = 0.1f;
				}
			}
			if(Input.GetKeyUp(KeyCode.X)) speed = 0.05f;			// Cuando se deja de correr se reestablece la velocidad normal
			
			// Brinco =============================
			if(Input.GetKeyDown(KeyCode.UpArrow)) {
				if(!jumping) {
					jumping = true;
					rigidbody.AddForce(0, 300f, 0);
					estado = 2;
				}
			}
			
			// Crecion ============================
			if(Input.GetKeyDown(KeyCode.C)) {
				
				if(!jumping) {
					Vector3 newPos = transform.position;
					if(direccion) newPos.x += 0.5f;
					else newPos.x -= 0.5f;
					if(Physics.Raycast(newPos, Vector3.down, 0.8f)) {
						estado = 3;
						Instantiate(muro, newPos, transform.rotation);
						estado = 0;
					}
				}
			}
		}
	}
	
	void OnCollisionEnter(Collision collision) {					// Cuando toca el suelo se puede saltar otra vez
		if(jumping) {
			jumping = false;
			estado = 0;
		}
	}
	
	// public methods =======================================
	public int getEstado() {
		return estado;
	}
	public bool getDireccion() {
		return direccion;
	}
	public void setEnable(bool status) {
		enable = status;
	}
	
	public void cambiaCuarto(GameObject destino) {
		transform.parent = destino.transform;
		Vector3 vec = destino.transform.position;
		vec.z = 8;
		vec.x -= 15;
		vec.y -= 15;
		transform.position = vec;
	}
}
