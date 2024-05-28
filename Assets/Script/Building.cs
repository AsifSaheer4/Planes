using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public int buildingSpeed;
    //public GameObject gameOverPage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * buildingSpeed);

        if (transform.position.x <= -33)
        {
            Destroy(gameObject);
        }
    }

   
}
