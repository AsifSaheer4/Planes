using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody2D rb;
    public int jumbingForce;
    public GameManager gm;

    



    // Start is called before the first frame update
    void Start()
    {
       
        rb= GetComponent<Rigidbody2D>();
        gm.InvokeRepeating("SpawningBuilding", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumbingForce;
        }

        gm.UpdateHighScore();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Building"))
        {
            Destroy(gameObject);
            gm.gameOverPage.SetActive(true);
            gm.CancelInvoke("SpawningBuilding");
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Point Zone"))
        {
            gm.point ++;
            
        }
    }
    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
        gm.gameOverPage.SetActive(true);
        gm.CancelInvoke("SpawningBuilding");
    }
   

}
