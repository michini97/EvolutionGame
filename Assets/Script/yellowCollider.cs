using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowCollider : MonoBehaviour
{

    public GameObject gameObj;
    public string color;
    public int ballAmount = 0;
    public GameObject something;
    public LevelManager lvlman;

    // Audio
    private AudioSource src;
    public AudioClip sound;
    private float vol = 1.0f;

    void Start()
    {
        lvlman = something.GetComponent<LevelManager>();
        src = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision col)
    {
        BallFollowTarget collideInfo = col.gameObject.GetComponent<BallFollowTarget>();
        if (col.gameObject.tag == gameObject.tag && !collideInfo.getCollided())

           
        {
            if(lvlman.yellow < lvlman.GetLifeMax())lvlman.yellow++;
            Debug.Log("yellow: " + lvlman.yellow);

            src.PlayOneShot(sound, vol);

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
