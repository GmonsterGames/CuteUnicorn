using UnityEngine;
using System.Collections;

public class PonyDetectaCortes : MonoBehaviour {

	public bool EntroCorte;

	public int[] PuntajeCorte;

	void Start(){


	}

	public float FuerzaCorte = 0;
	public float FuerzaConMetal = 2000;
	Vector2 direccionFuerza;

	private float lastCutTime;	

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Corte" && Time.time > lastCutTime + 0.1f) {
			EntroCorte = true;
			direccionFuerza = new Vector2(transform.position.x - other.transform.position.x, transform.position.y - other.transform.position.y);
			rigidbody2D.AddForceAtPosition(direccionFuerza*FuerzaCorte, other.transform.position);
			lastCutTime = Time.time;
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if (other.tag == "Corte") {
			if (EntroCorte){
			
				EntroCorte = false;
				GMScript.CorteNro += 1;
				GMScript.CorteMonedasNro += 1;
				if (GMScript.JuegoInicio){
					GMScript.SumaPuntos(PuntajeCorte[GMScript.elNivel]);
					FuerzaCorte = FuerzaConMetal;
				}
			}
			
		}
	}


	

}
