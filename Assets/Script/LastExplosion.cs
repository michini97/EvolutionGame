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
    public Text endingText;
    // Use this for initialization
    void Start () {
        StartCoroutine(Bombplanet());
        endingText.text = " ";
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
            EndingCredits();
        }   
    }
    public void EndingCredits()
    {
        endingText.text = "As the planet evolved and civilization began to advance, war erupted \r\n and the destruction of the planet was eventually inevitable.";

    }
}
