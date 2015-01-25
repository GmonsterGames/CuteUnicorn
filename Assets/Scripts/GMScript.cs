using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GMScript : MonoBehaviour {

	public static int CorteNro = 0;
	public static int Puntaje = 0;
	public static int MejorPuntaje = 0;
	public static int elNivel = 0;
	public static int Monedas = 0;
	public int CortesNecesariosParaMoneda = 0;
	public GameObject laMoneda;
	public static int CorteMonedasNro = 0;
	GameObject UltimaMonedaInstanciada;
	public static int MenuInicio; 			//0 significa que si, 1 significa que no.
	public static bool JuegoInicio = false;
	public float elTiempo = 30f;
	public float[] SliderDecay;



	public GameObject GloboTextoPony;
	public AudioClip MusicaMetal;
	public GameObject FuegoquevaHaciaArriba;
	public GameObject elFondo;
	public Sprite castilloMetal;
	public Sprite pisoMetal;
	public Sprite fondoMetal;
	public Color colorNubesMetal;


	public Collider2D pata1;
	public Collider2D pata2;
	public Collider2D pata3;
	public Collider2D pata4;
	public Collider2D CuerpoPony;
	public Collider2D Cola;
	public Collider2D Corte;

	public GameObject Piso;

	void Start(){
		CorteNro = 0;
		Puntaje = 0;
		elNivel = 0;
		JuegoInicio = false;
		Physics2D.IgnoreCollision (pata1, pata2, true);
		Physics2D.IgnoreCollision (pata1, pata3, true);
		Physics2D.IgnoreCollision (pata1, pata4, true);
		Physics2D.IgnoreCollision (pata2, pata3, true);
		Physics2D.IgnoreCollision (pata2, pata4, true);
		Physics2D.IgnoreCollision (pata3, pata4, true);
		Physics2D.IgnoreCollision (pata1, Corte, true);
		Physics2D.IgnoreCollision (pata2, Corte, true);
		Physics2D.IgnoreCollision (pata3, Corte, true);
		Physics2D.IgnoreCollision (pata4, Corte, true);
		Physics2D.IgnoreCollision (Cola, Corte, true);
		Physics2D.IgnoreCollision (Cola, pata1, true);
		Physics2D.IgnoreCollision (Cola, pata2, true);
		Physics2D.IgnoreCollision (Cola, pata3, true);
		Physics2D.IgnoreCollision (Cola, pata4, true);
	}

	void Update(){

		if (CorteNro == 5 && !JuegoInicio) {
			PrenderMetal();
			JuegoInicio = true;

		}

		if (CorteMonedasNro >= CortesNecesariosParaMoneda) {
			CorteMonedasNro = 0;
			UltimaMonedaInstanciada = (GameObject)Instantiate (laMoneda, CuerpoPony.transform.position + new Vector3 (0,1,0), Quaternion.identity); 
			Collider2D UltimaMoneda = UltimaMonedaInstanciada.GetComponent<Collider2D>();
			Physics2D.IgnoreCollision (pata1, UltimaMoneda, true);
			Physics2D.IgnoreCollision (pata2, UltimaMoneda, true);
			Physics2D.IgnoreCollision (pata3, UltimaMoneda, true);
			Physics2D.IgnoreCollision (pata4, UltimaMoneda, true);
			Physics2D.IgnoreCollision (CuerpoPony, UltimaMoneda, true);
			Physics2D.IgnoreCollision (Cola, UltimaMoneda, true);
		}



	}

	void PrenderMetal (){
		try {
			GloboTextoPony.SetActive (false);
			FuegoquevaHaciaArriba.SetActive (true);
			//aca hay un bugggggggg!!!!!!!
			gameObject.audio.Stop ();
			gameObject.audio.PlayOneShot (MusicaMetal, 1);
			CambiarFondo();
		} catch (System.Exception ex) {
			Debug.LogError(ex);
		}


	}

	void CambiarFondo(){
		elFondo.transform.FindChild ("castillo").gameObject.GetComponent<SpriteRenderer> ().sprite = (castilloMetal);
		elFondo.transform.FindChild ("Fondo").gameObject.GetComponent<SpriteRenderer> ().sprite = (fondoMetal);
		Piso.GetComponent<SpriteRenderer> ().sprite = (pisoMetal);
	}




	public static void SumaPuntos(int Puntos){
		Puntaje += Puntos;
	}
	public static void SumarMonedas(int Cantidad){
		Monedas += Cantidad;
	}
	

	public void LevelUP(){
		switch (elNivel) {
		case 0:
			elNivel = 1;
			elTiempo += 15f;
			break;
		case 1:
			elNivel = 2;
			elTiempo += 15f;
			break;
		case 2:
			elNivel = 3;
			elTiempo += 15f;
			break;
		case 3:
			elNivel = 4;
			elTiempo += 15f;
			break;
		case 4:
			elNivel = 5;
			elTiempo += 15f;
			break;
		case 5:
			elNivel = 6;
			elTiempo += 15f;
			break;
		default:
			break;
		}

	}



	int numeroAleatorio(int min, int max){
		//Random.seed = (int)Time.time;
		int a;
		a = (int)Random.Range(min,max);
		return a;
	}


}
