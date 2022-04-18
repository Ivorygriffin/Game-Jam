using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public enum CampType 
{
    socialising,
    relaxing

}
public enum ItemType 
{
    apple,
    water,
    tea,
    sleep,
    alcohol,
    candy,
    tv,
    fastFood


}


public class GameController : MonoBehaviour
{
    [Header("enums")]
    public CampType campType;
    public ItemType itemType;

    [Header("Text")]
    public TMP_Text ScoreText;
    public TMP_Text BallsRemaining;
    public TMP_Text PointsUntilNextCamp;

    [Header("Ints")]
    public int currentScore;
    public int camp1Score;
    public int camp2Score;
    public int finalCampScore;
    public int alcoholVal, appleVal, teaVal, sleepVal, candyVal, tvVal;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        ScoreTextUpdate();
        MountainClimbing();
        PointCheck();
    }

    public void ScoreTextUpdate()
    {
        ScoreText.text = currentScore.ToString();
    }

    public void MountainClimbing()
    {
        // UI person climbs more depending on score collected
    }

    public void CampReached()
    {
        switch (campType)
        {
            case CampType.socialising:
                Socialising();
                Debug.Log("socialising");
                break;

            case CampType.relaxing:
                Relaxing();
                Debug.Log("relaxing");
                break;

            default:
                Debug.Log("campType not set");
                break;

                //this wrong 
        }

  
    }

    public void Socialising()
    {
        //more good pegs on screen
    }

    public void Relaxing()
    {
        // super good appears
    }

    public void LevelComplete()
    {
        //third camp reached triggers end of level 
    }

    public void GameOver()
    {
        //ran out of balls without making it to the top of mountain
    }

    public void ItemHit()
    {
        //item collision determines number of points added
        switch (itemType) 
        {
            case ItemType.alcohol:
                currentScore += alcoholVal;
                Debug.Log("alcohol");
                break;

            case ItemType.apple:
                currentScore += appleVal;
                Debug.Log("apple");
                break;

            case ItemType.candy:
                currentScore += candyVal;
                Debug.Log("candy");
                break;

            case ItemType.fastFood:
                SuperBad();
                Debug.Log("fast");
                break;

            case ItemType.sleep:
                currentScore += sleepVal;
                Debug.Log("sleep");
                break;

            case ItemType.tea:
                currentScore += teaVal;
                Debug.Log("tea");
                break;

            case ItemType.tv:
                currentScore += tvVal;
                Debug.Log("tv");
                break;

            case ItemType.water:
                SuperGood();
                Debug.Log("water");
                break;

            default:
                Debug.Log("not item type assigned");
                break;



        }

    }

    public void PointCheck()
    {
        //checks if number of points reaches a camp
    }
    public void SuperBad()
    {
        //anti-refresh aka removes pegs from screen
    }

    public void SuperGood()
    {
        //refreshes pegs on screen
    }

}
