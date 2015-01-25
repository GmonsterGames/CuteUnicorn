using UnityEngine;
using System.Collections;

public class MoverFuegoArriba : MonoBehaviour {

	public GameObject TodoElFuegoGO;
	public float velocidadFuegoMovimiento = 0.1f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

			transform.position = Vector3.MoveTowards(transform.position, new Vector3(0.5f,25,0), velocidadFuegoMovimiento);		
			if (transform.position == new Vector3 (0.5f,25,0)) {
				Destroy(TodoElFuegoGO);
			}


	}
}
