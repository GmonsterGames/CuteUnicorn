using UnityEngine;
using System.Collections;

public class PosicionCadena : MonoBehaviour {

	public Transform cuerpoPony;
	public float speed = 1;
	
	// Update is called once per frame
	void Update () {
		MoveTowardsTarget ();
	}

	private void MoveTowardsTarget() {
		//the speed, in units per second, we want to move towards the target
		//move towards the center of the world (or where ever you like)
		Vector3 targetPosition = cuerpoPony.position;
		
		Vector3 currentPosition = this.transform.position;
		//first, check to see if we're close enough to the target
		if(Vector3.Distance(currentPosition, targetPosition) > .01f) { 
			Vector3 directionOfTravel = targetPosition - currentPosition;
			//now normalize the direction, since we only want the direction information
			//directionOfTravel.Normalize();
			//scale the movement on each axis by the directionOfTravel vector components
			
			this.transform.Translate(
				(directionOfTravel.x * speed * Time.deltaTime),
				(directionOfTravel.y * speed * Time.deltaTime),
				(directionOfTravel.z * speed * Time.deltaTime),
				Space.World);
		}
	}
}
