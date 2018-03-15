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
    public AudioClip wrong;
    private float vol = 1.0f;
    private MusicBackground music;

    void Start()
    {
        lvlman = something.GetComponent<LevelManager>();
        src = GetComponent<AudioSource>();
        
        music = GameObject.Find("Music").GetComponent<MusicBackground>();
        if (music) {
            vol = music.GetVolume();
        }
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

            if (music && music.PlaySFX()) {
                src.PlayOneShot(sound, vol);
            }

            // ParticleSystem ps = col.gameObject.GetComponent<ParticleSystem>();
            // ps.Play();
            collideInfo.collided();
            Object explo = Instantiate(Resources.Load("RedExplosion"), col.gameObject.transform.position, transform.rotation);

            Destroy(col.gameObject);
            Destroy(explo, 1.1f);

        }
        else if (col.gameObject.tag != gameObject.tag)
        {
            if (music && music.PlaySFX()) {
                src.PlayOneShot(wrong, vol);
            }
            Destroy(col.gameObject);
        }
    }
}
