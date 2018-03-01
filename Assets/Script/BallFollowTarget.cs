using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFollowTarget : MonoBehaviour {
    public Transform mTarget;
    private bool collide;
   

    float mSpeed = 5f;

	// Use this for initialization
	void Start () {
        collide = false;
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(mTarget.position);
        transform.Translate(0.0f, 0.0f, mSpeed * Time.deltaTime);
	}

    public void collided()
    {
        collide = true;
    }

    public bool getCollided()
    {
        return collide;
    }
}
