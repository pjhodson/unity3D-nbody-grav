using UnityEngine;
using System.Collections;

public class gravity : MonoBehaviour {

	GameObject[] bodies;

	private float myMass;

	// Use this for initialization
	void Start () {

		myMass = rigidbody.mass;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		bodies = GameObject.FindGameObjectsWithTag("gravBody");
		foreach(GameObject nBody in bodies)
		{
			/*Vector3 heading = (nBody.transform.position - transform.position);
			Debug.DrawLine (transform.position, heading);*/

			float euclidDist = Mathf.Sqrt( Mathf.Pow((nBody.transform.position.x - transform.position.x),2) + Mathf.Pow((nBody.transform.position.y - transform.position.y),2) +Mathf.Pow((nBody.transform.position.z - transform.position.z),2));

			transform.LookAt(nBody.transform.position);
			//float newtonForce = ((myMass * nBody.rigidbody.mass)/Mathf.Pow(heading.magnitude,2));
			float newtonForce = ((myMass * nBody.rigidbody.mass)/Mathf.Pow(euclidDist,2));

			//Vector3 appliedForce = newtonForce * heading.normalized;
			Vector3 appliedForce = Mathf.Round(newtonForce) * transform.forward;

			if(!float.IsNaN (appliedForce.x) && !float.IsNaN (appliedForce.y) && !float.IsNaN (appliedForce.z) &&
			   !float.IsInfinity (appliedForce.x) && !float.IsInfinity (appliedForce.y) && !float.IsInfinity (appliedForce.z) &&
			   !float.IsNegativeInfinity (appliedForce.x) && !float.IsNegativeInfinity (appliedForce.y) && !float.IsNegativeInfinity (appliedForce.z))
			{
				//Debug.DrawLine (transform.position, appliedForce);
				rigidbody.AddForce(appliedForce);
			}

		}
	
	}
}
