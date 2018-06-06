using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour {
	public GameObject zidan1;
	public float bulletSpeed;
    // Update is called once per frame
    void Update()
    {
		for (int i = 0; i < Input.touchCount; ++i)	{
             if (Input.GetTouch (i).phase == TouchPhase.Began) {
 
                 Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                 Vector2 dir = touchPos - (new Vector2(transform.position.x, transform.position.y));
                 dir.Normalize ();
                 GameObject bullet = Instantiate (zidan1, transform.position, Quaternion.identity)as GameObject;
                 bullet.GetComponent<Rigidbody2D> ().velocity = dir * bulletSpeed; 

				 GameObject.Destroy(bullet, 3f);
             }
         }
    }


	// bool CheckForLongPress() {
	// 	if (Input.touches[0].phase == TouchPhase.Began) {
	// 		_timePressed = Time.time - _timeLastPress;
	// 	}

	// 	if (Input.touches[0].phase == TouchPhase.Ended) {
	// 		_timeLastPress = Time.time;
	// 		if (_timePressed > WaitingSeconds/2f) {
	// 			return true;
	// 		}
	// 	}
	// 	return false;
	// }
}


