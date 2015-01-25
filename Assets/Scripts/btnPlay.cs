using UnityEngine;
using System.Collections;

public class btnPlay : MonoBehaviour {

	public GameObject laCamara;

	void OnMouseDown(){
		transform.localScale = new Vector3 (0.8f, 0.8f, 1);
		gameObject.GetComponent<Animator> ().enabled = false;
	}

	void OnMouseUp(){
		transform.localScale = new Vector3 (1,1,1);
		IniciarJuego ();
	}

	void IniciarJuego(){
		laCamara.GetComponent<laCamarascript> ().MoverCamaraHaciaAbajo = true;

	}

}
