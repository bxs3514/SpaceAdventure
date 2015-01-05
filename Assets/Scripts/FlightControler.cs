using UnityEngine;
using System.Collections;

public class FlightControler : MonoBehaviour {
	public GUIText debugText;
	public float zoom;

	private Touch prevTouch;
	private Touch touch;
	private Vector2 moveVector;
	private float ratio;

	void Start(){
		moveVector = new Vector2 (0, 0);
	}

	void Update () {
		//if (Input.touchCount == 1) {
			//transform.Translate(Input.touches[0].deltaPosition.x*.01f,
			                    //Input.touches[0].deltaPosition.y*.01f,
			                    //0);
		if (Input.acceleration.y > -.75f) {
			transform.Translate (Input.acceleration.x * .15f,
		               			(Input.acceleration.y + 0.75f) * .2f,
		                    	0);
		}
		else{
			transform.Translate (Input.acceleration.x * .15f,
			                     (Input.acceleration.y + 0.75f) * .5f,
			                     0);
		}
			/*touch = Input.GetTouch(0);
			if(prevTouch.position == null){
				prevTouch = touch;
			}
			else{
				moveVector.x = prevTouch.position.x - touch.position.x; 
				moveVector.y = prevTouch.position.y - touch.position.y;
				transform.Translate(Input.touches[0].deltaPosition.x*.02f,
				                    Input.touches[0].deltaPosition.y*.01f,
				                    0);
				//prevTouch = touch;
			}*/
			//float x = zoom * touch.position.x / Screen.height;
			//float y = zoom * ratio * touch.position.y / Screen.width;

		debugText.text = Input.acceleration.x.ToString() + "," + Input.acceleration.y.ToString();
			//debugText.text = x + ", " + y;
			//transform.position = new Vector3(x, y, 3.5f);
		//}
	}
}
