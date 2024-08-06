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
    int highScore;

    public AudioSource audioSource;
    public AudioClip audio_ButtonClick;
    public AudioClip audio_PlayerJumb;
    public AudioClip audio_GameOver;

    // Start is called before the first frame update

    private void Awake()
    {
        //DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
       
        
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = highScore.ToString();

        
    }


    // Update is called once per frame
    void Update()
    {
        pointText.text = point.ToString();
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
        audioSource.PlayOneShot(audio_ButtonClick);
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
            highScoreText.text = highScore.ToString();

        }
            
        
    }
    
}
