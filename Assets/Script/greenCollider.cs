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
        BallFollowTarget collideInfo = col.gameObject.GetComponent<BallFollowTarget>();
        if (col.gameObject.tag == gameObject.tag && !collideInfo.getCollided())
        {

            lvlman.green++;
            Debug.Log("green: " + lvlman.green);

            ParticleSystem ps = col.gameObject.GetComponent<ParticleSystem>();
            ps.Play();
            collideInfo.collided();
            Destroy(col.gameObject, 0.2f);

        } else if (col.gameObject.tag != gameObject.tag)
        {
            Destroy(col.gameObject);
        }
    }
}
