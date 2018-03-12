using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

<<<<<<< HEAD
public class BallProgress : MonoBehaviour {
=======
public class BallProgress : MonoBehaviour
{
>>>>>>> master

    public Image Bar;
    private float BallAmount = 0;
    private LevelManager Lvlman;
<<<<<<< HEAD
    private string color; 


    void Start ()
    {
        Lvlman = GameObject.Find("Planet").GetComponent<LevelManager>();
        color = gameObject.tag;
	}
	
	
	void Update ()
=======
    private string color;


    void Start()
    {
        Lvlman = GameObject.Find("Planet").GetComponent<LevelManager>();
        color = gameObject.tag;
    }


    void Update()
>>>>>>> master
    {
        BallAmount = Lvlman.GetAmount(color);
        if (BallAmount <= 0) {
            Bar.fillAmount = (0.05f);
        } else {
            Bar.fillAmount = (Lvlman.GetAmount(color) / 5);
        }
    }
}
