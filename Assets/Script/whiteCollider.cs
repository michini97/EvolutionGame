using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class whiteCollider : MonoBehaviour
{

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
        BallFollowTarget collideInfo = col.gameObject.GetComponent<BallFollowTarget>();
        if (col.gameObject.tag == gameObject.tag && !collideInfo.getCollided())
        {

            if (lvlman.white < lvlman.GetWhiteMax())
            {
                lvlman.white++;
            }

            ParticleSystem ps = col.gameObject.GetComponent<ParticleSystem>();
            ps.Play();
            collideInfo.collided();

            Debug.Log("white: " + lvlman.white);
            Destroy(col.gameObject, 0.2f);

        }
        else if (col.gameObject.tag != gameObject.tag)
        {
            Destroy(col.gameObject);
        }
    }
}
