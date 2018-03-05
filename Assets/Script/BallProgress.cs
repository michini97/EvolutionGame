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
    private int BallAmount = 0;
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

        Bar.fillAmount = (Lvlman.GetAmount(color) / 5);
    }
}
