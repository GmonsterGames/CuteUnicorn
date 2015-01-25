using UnityEngine;
using System.Collections;

public class CadenaCompletaScriptMastrom : MonoBehaviour {

	public bool QuemarCadena = false;
	bool Quemandose = false;
	Animator[] EslabonesAnimators;

	// Update is called once per frame
	void Update () {
		if (QuemarCadena && !Quemandose) {
			EslabonesAnimators = gameObject.GetComponentsInChildren<Animator>();
			for (int i = 0; i < EslabonesAnimators.Length; i++) {
				EslabonesAnimators[i].Play("PrendeFuego");
			}
			Quemandose = true;
		}
		if (transform.childCount == 0 && Quemandose) {
			Destroy(gameObject);		
		}
	
	}
	
}
