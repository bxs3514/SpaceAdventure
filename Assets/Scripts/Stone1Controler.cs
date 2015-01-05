using UnityEngine;
using System.Collections;

public class Stone1Controler : MonoBehaviour {

	public GameObject rock1Explosion;
	public GameObject playerExplosion;
	public float speed;
	
	void Start () {
		rigidbody.velocity = transform.forward * speed;
	}

	void OnTriggerEnter(Collider others){
		if (others.tag == "Boundary") {
			Destroy(this.gameObject);
			return;
		}
		else if (others.tag == "Player"){
			BroadcastMessage ("SelectCamera", -1);
			Instantiate(rock1Explosion, transform.position, transform.rotation);
			Instantiate(playerExplosion, transform.position, transform.rotation);
		}
		else{
			Instantiate(rock1Explosion, transform.position, transform.rotation);
		}
		Destroy (others.gameObject);
		Destroy (this.gameObject);
	}
}
