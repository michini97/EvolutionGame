using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInfo: MonoBehaviour {

    public static CubeInfo cubeInfo;
    private Quaternion rotations;
    private float totalTime = 0;

    public void Awake()
    {
        if (cubeInfo != null)
        {
            GameObject.Destroy(cubeInfo);
        } else
        {
            cubeInfo = this;
        }
        DontDestroyOnLoad(this);
    }

    // updates the eulerangles
    public void setRotation(Quaternion eulerAngles)
    {
        rotations = eulerAngles;
    }

    public Quaternion getRotation()
    {
        return rotations;
    }

    public void UpdateTime(float newTime) {
        totalTime += newTime;
    }

    public float GetTime() {
        return totalTime;
    }
	
}
