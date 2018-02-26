using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFollowTarget : MonoBehaviour {
    public Transform mTarget;
   

    float mSpeed = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(mTarget.position);
        transform.Translate(0.0f, 0.0f, mSpeed * Time.deltaTime);
	}
}
