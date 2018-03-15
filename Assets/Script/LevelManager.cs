using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    //public GameObject top;
    //public GameObject bottom;
    //public GameObject left;
    //public GameObject right;
    //public GameObject front;
    //public GameObject back;


    public GameObject[] sides;
    public string[] levels;
    public int currentLevel;
    private string[] colors;

    //private int grey = 0;
    //private int blue = 0;
    //private int red = 0;
    //private int green = 0;
    //private int white = 0;
    //private int yellow = 0;

    public int grey = 0;
    public int blue = 0;
    public int red = 0;
    public int green = 0;
    public int white = 0;
    public int yellow = 0;

    //white progress bar
    private float WhiteProg;
    private Image WhiteImage;
    private int WhiteMax = 5;

    //Grey progress bar
    private float GreyProg;
    private Image GreyImage;
    private int GreyMax = 5;

    //Red progress bar
    private float RedProg;
    private Image RedImage;
    private int RedMax = 5;

    //Blue progress bar
    private float BlueProg;
    private Image BlueImage;
    private int BlueMax = 5;

    //Green progress bar
    private float GreenProg;
    private Image GreenImage;
    private int GreenMax = 5;

    //Life progress bar
    private float LifeProg;
    private Image LifeImage;
    private int LifeMax = 5;

    private static LevelManager lvlMan;
    private Timer timeCounter;
    private bool ended = false;

    private string[] endTxt = {"Gasses from the solar nebula densed through gravitational pull and created a solid form",
        "The collisions against the planet's surface has made volcanoes erupt",
        "The planet cools down and reaches a temperature where liquid water can exist",
        "As the planet is filled with water, nature has started to develop in the form of trees and bushes",
        "As your planet is filled with resources, life and civilization has started to develop"};

    public float GetAmount(string color)
    {
        float result = 0f;
        switch (color)
        {
            case "white":
                result = white;
                break;

            case "grey":
                result = grey;
                break;

            case "red":
                result = red;
                break;

            case "blue":
                result = blue;
                break;

            case "green":
                result = green;
                break;

            case "yellow":
                result = yellow;
                break;
        }

        return result;

    }

    private void Start()
    {
        timeCounter = GameObject.Find("GameUI").GetComponent<Timer>();
        Text lvlText = GameObject.Find("LevelText").GetComponent<Text>();
        lvlText.text = "Level " + currentLevel;

        colors = new string[] { "grey" , "blue" , "red" , "green" , "white" , "yellow" };
        levels = new string[] { "levelOne" , "levelTwo"};

         switch (currentLevel)
        {
            case 1:
                WhiteMax = 5;
                break;

            case 2:
                WhiteMax = 5;
                GreyMax = 5;
                break;

            case 3:
                WhiteMax = 5;
                GreyMax = 5;
                RedMax = 5;
                break;

            case 4:
                WhiteMax = 5;
                GreyMax = 5;
                RedMax = 5;
                BlueMax = 5;
                break;

            case 5:
                WhiteMax = 5;
                GreyMax = 5;
                RedMax = 5;
                BlueMax = 5;
                GreenMax = 5;
                break;

            case 6:
                WhiteMax = 5;
                GreyMax = 5;
                RedMax = 5;
                BlueMax = 5;
                GreenMax = 5;
                LifeMax = 5;
                break;

        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    for (int i = 0; i < sides.Length; i++)
    //    {
    //        BallCollision bc = sides[i].GetComponent<BallCollision>();
    //        if (sides[i].tag == colors[0])
    //        {
    //            grey += bc.ballAmount;
    //        }

    //        else if (sides[i].tag == colors[1])
    //        {
    //            blue += bc.ballAmount;
    //        }

    //        else if (sides[i].tag == colors[2])
    //        {
    //            red += bc.ballAmount;
    //        }

    //        else if (sides[i].tag == colors[3])
    //        {
    //            green += bc.ballAmount;
    //        }

    //        else if (sides[i].tag == colors[4])
    //        {
    //            white += bc.ballAmount;
    //        }

    //        else if (sides[i].tag == colors[5])
    //        {
    //            yellow += bc.ballAmount;
    //        }
    //    }

    //    Destroy(collision.gameObject);

    //    Debug.Log("grey: " + grey);
    //    Debug.Log("blue: " + blue);
    //}

    //void foo ()
    //{
    //    //     int tempgrey = 0;
    //    // int tempblue = 0;
    //    //int tempred = 0;
    //    // int tempgreen = 0;
    //    // int tempwhite = 0;
    //    // int tempyellow = 0;
    //    if (true) {
    //        for (int i = 0; i < sides.Length; i++)
    //        {
    //            BallCollision bc = sides[i].GetComponent<BallCollision>();
    //            if (sides[i].tag == colors[0])
    //            {
    //                grey += bc.ballAmount;
    //            }

    //            else if (sides[i].tag == colors[1])
    //            {
    //                blue += bc.ballAmount;
    //            }

    //            else if (sides[i].tag == colors[2])
    //            {
    //                red += bc.ballAmount;
    //            }

    //            else if (sides[i].tag == colors[3])
    //            {
    //                green += bc.ballAmount;
    //            }

    //            else if (sides[i].tag == colors[4])
    //            {
    //                white += bc.ballAmount;
    //            }

    //            else if (sides[i].tag == colors[5])
    //            {
    //                yellow += bc.ballAmount;
    //            }
    //        }
    //        //grey = tempgrey;
    //        //blue = tempblue;
    //        //red = tempred;
    //        //green = tempgreen;
    //        //white = tempwhite;
    //        //yellow = tempyellow;
    //    }
    //    Debug.Log("grey: " + grey);
    //    Debug.Log("blue: " + blue);

    //}

    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            if (currentLevel == 6) {
                SceneManager.LoadScene(currentLevel + 1);
                } else {
                    EndLevel();
                }
        } else if (Input.GetKeyDown("1")) {
            SceneManager.LoadScene(1);
        } else if (Input.GetKeyDown("2")) {
            SceneManager.LoadScene(2);
        } else if (Input.GetKeyDown("3")) {
            SceneManager.LoadScene(3);
        } else if (Input.GetKeyDown("4")) {
            SceneManager.LoadScene(4);
        } else if (Input.GetKeyDown("5")) {
            SceneManager.LoadScene(5);
        } else if (Input.GetKeyDown("6")) {
            SceneManager.LoadScene(6);
        }
        
        switch (currentLevel)
        {
            
            case 1:
                if(white >= 5)
                {
                    // SceneManager.LoadScene(currentLevel + 1);
                    EndLevel();
                }
                break;

            case 2:
                if(white >= 5 && grey >= 5)
                {
                    //SceneManager.LoadScene(levels[currentLevel + 1], LoadSceneMode.Additive);
                    // SceneManager.LoadScene(currentLevel + 1);
                    EndLevel();
                }   
                break;
            case 3:
                if (white >= 5 && grey >= 5 && red >= 5)
                {
                    // SceneManager.LoadScene(currentLevel + 1);
                    EndLevel();
                }
                break;
            case 4:
                if (white >= 5 && grey >= 5 && red >= 5 && blue >= 5)
                {
                    // SceneManager.LoadScene(currentLevel + 1);
                    EndLevel();
                }
                break;
            case 5:
                if (white >= 5 && grey >= 5 && red >= 5 && blue >= 5 && green >= 5)
                {
                    // SceneManager.LoadScene(currentLevel + 1);
                    EndLevel();              
                }
                break;
            case 6:
                if (white >= 5 && grey >= 5 && red >= 5 && blue >= 5 && green >= 5 && yellow >= 5)
                {
                    SceneManager.LoadScene(currentLevel + 1);
                }
                break;
        }
    }

    public int GetWhiteMax()
    {
        return WhiteMax;
    }

    public int GetGreyMax()
    {
        return GreyMax;
    }

    public int GetRedMax()
    {
        return RedMax;
    }

    public int GetBlueMax()
    {
        return BlueMax;
    }

    public int GetGreenMax()
    {
        return GreenMax;
    }

    public int GetLifeMax()
    {
        return LifeMax;
    }

    public int GetLevel() {
        return currentLevel;
    }

    void EndLevel() {
        Pauser pauser = GameObject.Find("Pause").GetComponent<Pauser>();
        pauser.PauseGame(false);

        Canvas endLvlScreen = GameObject.Find("EndLevelCanvas").GetComponent<Canvas>();
        endLvlScreen.enabled = true;

        
        if (!ended) {
            timeCounter.EndTimer();

            Text total = GameObject.Find("TotalTimeScore").GetComponent<Text>();
            total.text = CubeInfo.cubeInfo.GetTime().ToString("f1");

            Text level = GameObject.Find("LevelTimeScore").GetComponent<Text>();
            level.text = timeCounter.GetTime().ToString("f1");

            Text narrative = GameObject.Find("Narrative").GetComponent<Text>();
            narrative.text = endTxt[currentLevel - 1];
        }
        ended = true;
    }
}

