using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Toggle pauseButton;
    public GameObject gameOverPage;
    

    public GameObject player;

    public GameObject building;
    float buildingPosY;

    public Text pointText;
    public int point = 0;
    public Text highScoreText;
    public int highScore;

    // Start is called before the first frame update

    
    void Start()
    {
       

        highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = highScore.ToString();

        
    }


    // Update is called once per frame
    void Update()
    {
        pointText.text = point.ToString();

        if (gameOverPage.activeSelf)
        {
            building.SetActive(false);
        }
        else
        {
            building.SetActive(true);
        }

        
    
    }


    public void PlayButton() 
    {
        SceneManager.LoadScene(1);
    }


    public void RetryButton()
    {
        SceneManager.LoadScene(1);
    }

    public void PauseButton()
    {
        if (pauseButton.isOn)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }


    public void HomeButton()
    {
        SceneManager.LoadScene(0);
    }


    void SpawningBuilding()
    {
        buildingPosY = Random.Range(-3, -10);
        Instantiate(building, new Vector3(30, buildingPosY, 0), Quaternion.identity);
    }
    public void  UpdateHighScore()
    {
        if (highScore < point)
        {
            highScore = point;
            PlayerPrefs.SetInt("HighScore",highScore);
            
        }
            
        
    }
    
}
