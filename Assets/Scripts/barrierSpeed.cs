using UnityEngine;
using System.Collections;

public class barrierSpeed : MonoBehaviour {

	public float speed;
	private Vector3 distance;
	private Vector3 direction;
	private Controler controler;
	private Player player;
	/*public GUIText testText;
	public GUIText initialText;
	public GUIText initialPlayerText;
	public GUIText initialRockText;
	public GUIText Distance;*/

	void Start () {
		GameObject controlerObject = GameObject.FindGameObjectWithTag ("Controler");
		GameObject playerObject = GameObject.FindGameObjectWithTag ("Player");

		if (controlerObject != null) {
			controler = controlerObject.GetComponent<Controler>();
			player = playerObject.GetComponent<Player>();
			distance = player.getPosition() - this.rigidbody.position;
			float d = Mathf.Sqrt(Mathf.Pow(distance.x, 2) + Mathf.Pow(distance.y, 2) + Mathf.Pow(distance.z, 2));
			//Distance.text = "Distance: " + d.ToString();
			direction = new Vector3(distance.x / d, distance.y / d, distance.z / d) * speed;
			rigidbody.velocity = direction;
			//initialText.text = direction.x / d + ", " + direction.y / d + ", " + direction.z / d;
			//initialPlayerText.text = "Player: " + player.getPosition().x + ", " + player.getPosition().y + ", " + player.getPosition().z;
			//initialRockText.text = "Rock: " + controler.getPosition().x + ", " + controler.getPosition().y + ", " + controler.getPosition().z;

		}
		else{
			Debug.Log("The Controler class doesn't exist.");	
		}
	}

	void FixedUpdate(){
		//testText.text = transform.position.x.ToString() + ", " + transform.position.y.ToString() + ", " + transform.position.z.ToString();
	}

	public void setDistance(Vector3 distance){
		this.distance = distance;
	}
}
