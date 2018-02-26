using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueCollider : MonoBehaviour
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
            lvlman.blue++;
            Debug.Log("blue: " + lvlman.blue);
        }

        Destroy(col.gameObject);
    }
}
