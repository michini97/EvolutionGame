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
    private int WhiteMax;

    //Grey progress bar
    private float GreyProg;
    private Image GreyImage;
    private int GreyMax;

    //Red progress bar
    private float RedProg;
    private Image RedImage;
    private int RedMax;

    //Blue progress bar
    private float BlueProg;
    private Image BlueImage;
    private int BlueMax;

    //Green progress bar
    private float GreenProg;
    private Image GreenImage;
    private int GreenMax;

    //Life progress bar
    private float LifeProg;
    private Image LifeImage;
    private int LifeMax;

    private static LevelManager lvlMan;

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
        switch (currentLevel)
        {
            case 1:
                if(white >= 5)
                {
                    SceneManager.LoadScene(currentLevel + 1);
                }
                break;

            case 2:
                if(white >= 5 && grey >= 5)
                {
                    //SceneManager.LoadScene(levels[currentLevel + 1], LoadSceneMode.Additive);
                    SceneManager.LoadScene(currentLevel + 1);
                }
                break;
            case 3:
                if (white >= 5 && grey >= 5 && red >= 5)
                {
                    SceneManager.LoadScene(currentLevel + 1);

                }
                break;
            case 4:
                if (white >= 5 && grey >= 5 && red >= 5 && blue >= 5)
                {
                    SceneManager.LoadScene(currentLevel + 1);
                }
                break;
            case 5:
                if (white >= 5 && grey >= 5 && red >= 5 && blue >= 5)
                {
                    SceneManager.LoadScene(currentLevel + 1);
                }
                break;
            case 6:
                if (white >= 5 && grey >= 5 && red >= 5 && blue >= 5 && green >= 5) 
                {
                    SceneManager.LoadScene(currentLevel + 1);
                }
                break;
            case 7:
                if (white >= 5 && grey >= 5 && red >= 5 && blue >= 5 && green >= 5 && yellow >= 5)
                {
                    //SceneManager.LoadScene(currentLevel + 1);
                    Debug.Log("You Win");
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

    void UpdateBar()
    {

    }
}

