using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greyCollider : MonoBehaviour {



    public string color;
    public int ballAmount = 0;
    public GameObject something;
    public LevelManager lvlman;
    public GameObject planet;

    void Start()
    {
        lvlman = something.GetComponent<LevelManager>();
        planet = GameObject.Find("Planet");
    }

    void OnCollisionEnter(Collision col)
    {
        BallFollowTarget collideInfo = col.gameObject.GetComponent<BallFollowTarget>();
        if (col.gameObject.tag == gameObject.tag && !collideInfo.getCollided())
        {
            
            lvlman.grey++;
            Debug.Log("grey: " + lvlman.grey);

            ParticleSystem ps = col.gameObject.GetComponent<ParticleSystem>();
            ps.Play();
            collideInfo.collided();
            Destroy(col.gameObject, 0.2f);

        }
        else if (col.gameObject.tag != gameObject.tag)
        {
            Destroy(col.gameObject);
        }
    }
}

