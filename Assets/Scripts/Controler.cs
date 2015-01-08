using UnityEngine;
using System.Collections;

public class Controler : MonoBehaviour {

	public GameObject barrier;

	private Vector3 barrierPosition;
	private int waveCount;
	private float waveWait;
	private float startTime;
	private float singleWait;

	void Start () {
		startTime = 1;
		waveWait = 10;
		waveCount = 10;
		singleWait = 0.5f;
		StartCoroutine (Wave());
	}

	void Update () {
	
	}

	IEnumerator Wave(){
		yield return new WaitForSeconds(startTime);
		barrierPosition = new Vector3(  Random.Range(-20f, 20f),
		                              Random.Range(-20f, 20f),
		                              50f );
		Quaternion barrierQuaternion = Quaternion.identity;
		Instantiate(barrier, barrierPosition, barrierQuaternion);
		yield return new WaitForSeconds(singleWait);
			/*while (true) {

			for(int i = 0; i < waveCount; i++){
				barrierPosition = new Vector3(  Random.Range(-40f, 40f),
				                                   	    Random.Range(-40f, 40f),
				                                   		50f );
				Quaternion barrierQuaternion = Quaternion.identity;
				Instantiate(barrier, barrierPosition, barrierQuaternion);
				yield return new WaitForSeconds(singleWait);
			}
			yield return new WaitForSeconds(waveWait);
		}*/
	}

	public Vector3 getPosition(){
		return barrierPosition;
	}
}
