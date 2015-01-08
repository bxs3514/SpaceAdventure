using UnityEngine;
using System.Collections;

public class Rock1Rotate : MonoBehaviour {

	public float rotateSpeed;
	
	void Start () {
		rigidbody.angularVelocity = Random.insideUnitSphere * rotateSpeed;
	}
}
