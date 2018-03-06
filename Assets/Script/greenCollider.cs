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

    // Audio
    private AudioSource src;
    public AudioClip sound;
    public AudioClip wrong;
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

            if (lvlman.green < lvlman.GetGreenMax())
            {
                lvlman.green++;
            }
            Debug.Log("green: " + lvlman.green);

            src.PlayOneShot(sound, vol);

            ParticleSystem ps = col.gameObject.GetComponent<ParticleSystem>();
            ps.Play();
            collideInfo.collided();
            Destroy(col.gameObject, 0.2f);

        } else if (col.gameObject.tag != gameObject.tag)
        {
            src.PlayOneShot(wrong, vol);
            Destroy(col.gameObject);
        }
    }
}
