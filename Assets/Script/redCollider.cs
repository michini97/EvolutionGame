using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class redCollider : MonoBehaviour {

    public GameObject gameObj;
    public string color;
    public int ballAmount = 0;
    public LevelManager lvlman;
    public GameObject something;

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
            if (lvlman.red < lvlman.GetRedMax())
            {
                lvlman.red++;
            }
            Debug.Log("red: " + lvlman.red);

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
