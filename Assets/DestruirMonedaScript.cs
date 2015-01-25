using UnityEngine;
using System.Collections;

public class DestruirMonedaScript : MonoBehaviour {

	public void Desaparecer(){
		Destroy (transform.parent.gameObject);
		
	}
		

}
