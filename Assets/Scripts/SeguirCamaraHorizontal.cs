using UnityEngine;
using System.Collections;

public class SeguirCamaraHorizontal : MonoBehaviour {

	public Transform laCamara;
	public float step;
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (laCamara.position.x, transform.position.y, 0);
		//transform.position = Vector3.Lerp(transform.position, new Vector3 (laCamara.position.x, 0, 0), Time.deltaTime * step);	
	}
}
