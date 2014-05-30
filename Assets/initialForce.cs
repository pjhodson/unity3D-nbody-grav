using UnityEngine;
using System.Collections;

public class initialForce : MonoBehaviour {

	public Vector3 dir;
	public float velo;

	// Use this for initialization
	void Start () {
		rigidbody.AddForce (velo * dir, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
