using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterControl : MonoBehaviour {

	public float speed = 0.1f;

	int coins = 0;

	int hearts = 0;

	int stars = 0;

	public Text contadorCoins;

	public Text contadorHearts;

	public Text contadorStars;

	// Use this for initialization
	void Start () {
		
	

	}

	public void clickEnElBoton(){
		print ("Botón salto presionado");
		this.gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 7, ForceMode2D.Impulse);


	}
	
	// Update is called once per frame
	void Update () {

		// movimiento hacia la derecha

		if (Input.GetKey (KeyCode.RightArrow)) {
			this.gameObject.transform.Translate (speed, 0f, 0f);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.gameObject.transform.Translate (-speed, 0f, 0f);
		}
		// salto
		if (Input.GetKeyDown (KeyCode.Space)) {
			this.gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 7, ForceMode2D.Impulse);

		}



		
	}

	// Collision 
	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Coins"){
			


			// Aumentar la cantidad de monedas del jugador. 

			coins = coins + 1;

			// Actualizar el componente texto.

			contadorCoins.text = coins.ToString ();

			GameObject.Destroy (coll.gameObject);



		}

		if (coll.gameObject.tag == "Hearts"){



			// Aumentar la cantidad de monedas del jugador. 

			hearts = hearts + 1;

			// Actualizar el componente texto.

			contadorHearts.text = hearts.ToString ();

			GameObject.Destroy (coll.gameObject);



		}

		if (coll.gameObject.tag == "Stars"){



			// Aumentar la cantidad de monedas del jugador. 

			stars = stars + 1;

			// Actualizar el componente texto.

			contadorStars.text = stars.ToString ();

			GameObject.Destroy (coll.gameObject);



		}

		if (coll.gameObject.tag == "Enemies"){



			// Aumentar la cantidad de monedas del jugador. 

			hearts = hearts - 1;

			// Actualizar el componente texto.

			contadorHearts.text = hearts.ToString ();

			GameObject.Destroy (coll.gameObject);



		}
	}

}

	

