using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenCollider : MonoBehaviour
{

    public GameObject gameObj;
    public string color;
    public int ballAmount = 0;
    public LevelManager lvlman;
    public GameObject something;

    void Start()
    {
        lvlman = something.GetComponent<LevelManager>();
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == gameObject.tag)
        {
            lvlman.green++;
            Debug.Log("green: " + lvlman.green);
        }

        Destroy(col.gameObject);
    }
}
