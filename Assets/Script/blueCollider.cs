﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueCollider : MonoBehaviour
{

    public GameObject gameObj;
    public string color;
    public int ballAmount = 0;
    public GameObject something;
    private LevelManager lvlman;

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
            if (lvlman.blue < lvlman.GetBlueMax())
            {
                lvlman.blue++;
            }
            Debug.Log("blue: " + lvlman.blue);

            src.PlayOneShot(sound, vol);

            // ParticleSystem ps = col.gameObject.GetComponent<ParticleSystem>();
            // ps.Play();

            collideInfo.collided();
            Object explo = Instantiate(Resources.Load("BlueExplosion"), col.gameObject.transform.position, transform.rotation);

            Destroy(col.gameObject);
            Destroy(explo, 1.1f);

        }
        else if (col.gameObject.tag != gameObject.tag)
        {
            src.PlayOneShot(wrong, vol);
            Destroy(col.gameObject);
        }
    }
}