using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enlarger : MonoBehaviour
{

    private Animation anim;
    private float ScalingFactor = 1.1f;
    private float TimeScale = 0.5f;
    private Vector3 InitialScale;
    private Vector3 FinalScale;

    public GameObject planet;

    public void Awake()
    {
        anim = GetComponent<Animation>();
        planet = GameObject.Find("Planet");
    }

    public void Start()
    {
        InitialScale = transform.localScale;

        FinalScale = new Vector3(InitialScale.x * ScalingFactor,
                                 InitialScale.y * ScalingFactor,
                                 InitialScale.z * ScalingFactor);
    }

    IEnumerator ScaleOverTime(float time)
    {
        Vector3 originalScale = planet.transform.localScale;
        Vector3 destinationScale = new Vector3(2.0f, 2.0f, 2.0f);

        float currentTime = 0.0f;

        do
        {
            planet.transform.localScale = Vector3.Lerp(originalScale, destinationScale, currentTime / time);
            currentTime += Time.deltaTime;
            yield return null;

        } while (currentTime <= time);

        Destroy(gameObject);
    }
}