using UnityEngine;
using System.Collections;

public class CSphere : MonoBehaviour {

	Vector3 velocity = new Vector3();

	float gravity = -0.001f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		velocity.y += gravity;

		this.transform.position += velocity;
	}

	void OnTriggerEnter(Collider enter){
		print ("OnTriggerEnter");
		print (enter.tag);
		if( enter.tag == "Plane" ){
			Vector3 AxisY = enter.transform.rotation * Vector3.up;
	
			this.velocity.y *= -1.0f;

			float angle = Vector3.Dot( velocity, AxisY );

			velocity = Quaternion.AngleAxis( angle, Vector3.right ) * velocity;
		}
	}
}
