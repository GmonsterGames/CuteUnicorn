using UnityEngine;
using System.Collections;

public class laCamarascript : MonoBehaviour {

	public bool MoverCamaraHaciaAbajo = false;
	public float velocidadCamaraMovimiento = 0.1f;
	bool seguirPersonaje = false;

	void Awake(){

		PlayerPrefs.SetInt ("MostrarMenuInicio", 1	);

		GMScript.MenuInicio = PlayerPrefs.GetInt ("MostrarMenuInicio");

		if (GMScript.MenuInicio == 1) {
			transform.position = new Vector3 (0, 0, -10);
			MoverCamaraHaciaAbajo = false;	
			seguirPersonaje = true;
			PlayerPrefs.SetInt ("MostrarMenuInicio", 0);
		} else {
			transform.position = new Vector3 (0, 10, -10);
		}

	}



	Vector3 wantedPosition;
	public Transform target;
	public float distance = 10.0f;
	public float height = -6.0f;
	public float with = -6.0f;
	public float damping = 5.0f;

	// Update is called once per frame
	void Update () {
	
		if (MoverCamaraHaciaAbajo) {
			transform.position = Vector3.MoveTowards(transform.position, new Vector3(0,0,-10), velocidadCamaraMovimiento);		
			if (transform.position == new Vector3 (0, 0, -10)) {
				MoverCamaraHaciaAbajo = false;
				seguirPersonaje = true;
			}
		}

		if (seguirPersonaje) {

				wantedPosition = new Vector3(target.position.x+with, height, -distance);
				transform.position = Vector3.Lerp (transform.position, wantedPosition, Time.deltaTime * damping);
				
		
		}


	}




	}
	
