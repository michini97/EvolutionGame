using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class LastExplosion : MonoBehaviour {

    public GameObject planet;
    public GameObject green;
    public GameObject red;
    public GameObject grey;
    public GameObject pink;
    public Text stopTimer;
    // Use this for initialization
    void Start () {
        StartCoroutine(Bombplanet());
        planet = GameObject.Find("Planet");
        green = GameObject.Find("GreenRocket");
        red = GameObject.Find("RedRocket");
        grey = GameObject.Find("GreyRocket");
        pink = GameObject.Find("PinkRocket");
    }
	
    IEnumerator Bombplanet() {
        yield return new WaitForSeconds(4.0f);
        Object explosion = Instantiate(Resources.Load("WFX_Nuke"));

        if (explosion == true)
        {
            Destroy(planet);
            Destroy(green);
            Destroy(red);
            Destroy(grey);
            Destroy(pink);            
        }   
    }
}
