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
    public GameObject building;

    float buildingPosY;
    float  buildingSpawnigTime;

    // Start is called before the first frame update
    void Start()
    {
        buildingSpawnigTime = Random.Range(0.5f, 2);
        InvokeRepeating("spawningBuilding", 2f, buildingSpawnigTime);
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
    void spawningBuilding()
    {
        buildingPosY = Random.Range(-3, -10);

        buildingSpawnigTime = Random.Range(0.5f, 2);

        Instantiate(building, new Vector2(30, buildingPosY),Quaternion.identity);
    }
    
}
