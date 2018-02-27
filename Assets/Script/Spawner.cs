using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] enemies;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;
    //public Transform Explosion;
    //ParticleSystem ps;


    int randEnemy;

	void Start ()
    {
        StartCoroutine(waitSpawner());
        //ps = Explosion.GetComponent<ParticleSystem>();
        //var em = ps.emission;
        //em.enabled = false;
    }
	

	void Update ()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);	

	}

    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds (startWait); 

        while (!stop)
        {
            randEnemy = Random.Range(0, enemies.Length); //picks an enemy nr between 0 and 2

            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), Random.Range(-spawnValues.y, spawnValues.y), Random.Range(-spawnValues.z, spawnValues.z));
        
            Instantiate(enemies[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            //ParticleSystem ps = enemies[randEnemy].GetComponent<ParticleSystem>();
            //var em = ps.emission;
            //em.enabled = false;

            yield return new WaitForSeconds(spawnWait);


        }
    }

}
