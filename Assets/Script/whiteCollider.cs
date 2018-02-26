using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whiteCollider : MonoBehaviour
{

    public GameObject gameObj;
    public string color;
    public int ballAmount = 0;
    public GameObject something;
    public LevelManager lvlman;

    void Start()
    {
        lvlman = something.GetComponent<LevelManager>();
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == gameObject.tag)
        {
            lvlman.white++;
            Debug.Log("white: " + lvlman.white);
        }

        Destroy(col.gameObject);
    }
}
