using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInfo: MonoBehaviour {

    public static CubeInfo cubeInfo;
    private Quaternion rotations;

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
	
}
