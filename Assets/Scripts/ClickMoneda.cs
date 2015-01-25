using UnityEngine;
using System.Collections;

public class ClickMoneda : MonoBehaviour {

	public int ValorMoneda = 1;
	public GameObject losGraficos;
	public GameObject lasParticulasClick;
	bool clickeada = false;
	bool click = false;
	public float tiempoAntesDeDestruir;
	public Animator elAnimator;
	public float TiempoParaDesaparecer;
	bool Desapareciendo = false;


	void OnMouseDown(){
		click = true;
		losGraficos.SetActive (false);
		lasParticulasClick.SetActive (true);
		rigidbody2D.AddForce (new Vector2 (0, 200));
	}

	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.identity;

		if (click) {
						tiempoAntesDeDestruir -= Time.deltaTime;

						if (!clickeada) {
								GMScript.SumarMonedas (ValorMoneda);
								clickeada = true;
						}

						if (tiempoAntesDeDestruir <= 0) {
								Destroy (gameObject);
						}
				}
		if (TiempoParaDesaparecer <= 0 && !Desapareciendo) {

			elAnimator.Play("AnimacionDesaparecer");
			Desapareciendo = true;

		} else {
			TiempoParaDesaparecer -= Time.deltaTime;		
		}
	}


}
