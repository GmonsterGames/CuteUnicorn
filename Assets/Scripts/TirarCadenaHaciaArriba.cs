using UnityEngine;
using System.Collections;

public class TirarCadenaHaciaArriba : MonoBehaviour {

	public GameObject ChainHolder;
	public float VelSubidaChainHolder;
	public float CantidadSubeCadena;
	Vector3 WantedPosition;
	bool TirarDeLaCadena = false;

	public Transform elPoni;


	void OnMouseDown(){
		if (!TirarDeLaCadena) {
			WantedPosition = new Vector3 (0, CantidadSubeCadena, 0);
						TirarDeLaCadena = true;
				}

	}

	public void SubirLaCadena(){
		if (!TirarDeLaCadena) {
			Debug.Log(Vector2.Distance((Vector2)WantedPosition, (Vector2)elPoni.position) - 7f);
			WantedPosition = new Vector3 (0, CantidadSubeCadena + (Vector2.Distance(new Vector2(0,5), (Vector2)elPoni.position)-5), 0);
			TirarDeLaCadena = true;
		}
	}
	void Update(){
		if (TirarDeLaCadena) {	
			ChainHolder.transform.localPosition = Vector3.MoveTowards(ChainHolder.transform.localPosition	, WantedPosition, VelSubidaChainHolder);			
			if (ChainHolder.transform.localPosition.y > WantedPosition.y - 0.1f) {
				TirarDeLaCadena = false;
			}	
		}

	}
}
