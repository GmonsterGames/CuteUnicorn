using UnityEngine;
using System.Collections;

public class AutoDestroyScript : MonoBehaviour {

	public void AutoDestroy(){
		Destroy (gameObject);
		//gameObject.SetActive (false);
	}
}
