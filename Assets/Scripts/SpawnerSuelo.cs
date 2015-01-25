using UnityEngine;
using System.Collections;

public class SpawnerSuelo : MonoBehaviour {
	
	public GameObject PisoNuevo;
	public float DistanciaSpawn;


	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			Instantiate(PisoNuevo, new Vector3(transform.position.x+DistanciaSpawn, -4, 0), Quaternion.identity);
			Destroy(gameObject);
		}
	}
}
