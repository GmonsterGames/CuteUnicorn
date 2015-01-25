using UnityEngine;
using System.Collections;

public class MovimientoCorteScript : MonoBehaviour {
	
	public GameObject elTrigger;
	CircleCollider2D elcolliderDelTrigger;

	void Start(){
		elcolliderDelTrigger = elTrigger.GetComponent<CircleCollider2D> ();
	}
	void Update () {
		if (Input.touchCount > 0 || Input.GetMouseButton(0)) {
			if (!elcolliderDelTrigger.enabled){
				elcolliderDelTrigger.enabled = true;
				}
		} else {
			if (elcolliderDelTrigger.enabled){
				elcolliderDelTrigger.enabled = false;
			}	
		}
	}
}
	
