using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallProgress : MonoBehaviour {

    public Image Bar;
    private int BallAmount = 0;
    private LevelManager Lvlman;
    private string color; 


    void Start ()
    {
        Lvlman = GameObject.Find("Planet").GetComponent<LevelManager>();
        color = gameObject.tag;
	}
	
	
	void Update ()
    {

        Bar.fillAmount = (Lvlman.GetAmount(color) / 5);
    }
}
