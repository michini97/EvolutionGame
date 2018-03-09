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
            Debug.Log(lvlman.GetWhiteMax());
            if (lvlman.white < lvlman.GetWhiteMax())
            {
                lvlman.white++;
            }

            src.PlayOneShot(sound, vol);

            // Collider collider = col.gameObject.GetComponent<Collider>();
            // collider.enabled = false;

            // ParticleSystem ps = col.gameObject.GetComponent<ParticleSystem>();
            // ps.Play();

            collideInfo.collided();
            Object explo = Instantiate(Resources.Load("WhiteExplosion"), col.gameObject.transform.position, transform.rotation);

            Debug.Log("white: " + lvlman.white);
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
