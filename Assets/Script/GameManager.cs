using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject startingPage;
    public GameObject gameOverPage;
    public GameObject runningPage;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayButton() 
    {
        player.SetActive(true);
        startingPage .SetActive(false);
        runningPage .SetActive(true);
    }
    public void RetryButton()
    {
        player.SetActive(true);
        gameOverPage.SetActive(false);
        runningPage.SetActive(true);
    }
    public void HomeButton()
    {
        player.SetActive(false);
        gameOverPage .SetActive(false);
        startingPage .SetActive(true);
    }
    
}
