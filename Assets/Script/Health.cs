using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

<<<<<<< HEAD
public class Health: MonoBehaviour
=======
public class Health : MonoBehaviour
>>>>>>> master
{
    public float BallProg;
    public Image healthImage;

    private void Update()
    {
        healthImage.fillAmount = (BallProg / 5);
    }
}
<<<<<<< HEAD
=======

>>>>>>> master
