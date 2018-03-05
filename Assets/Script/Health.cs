using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float BallProg;
    public Image healthImage;

    private void Update()
    {
        healthImage.fillAmount = (BallProg / 5);
    }
}

