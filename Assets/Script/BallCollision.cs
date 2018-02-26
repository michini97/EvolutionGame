using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour {


    public GameObject gameObj;
    public string color;
    public int ballAmount = 0;

    void Start()
    {
    }

    void OnCollisionEnter(Collision col)
    {
        
        if(col.gameObject.tag == gameObject.tag)
        {
            ballAmount++;

            //Debug.Log(color + ": " + ballAmount);
        }

        //Destroy(col.gameObject);
    }

    
  
}
