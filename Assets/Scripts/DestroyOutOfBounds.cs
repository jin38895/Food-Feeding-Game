using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 20.0f;
    private float lowerBound = -10.0f;
    private float xBound = 20;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy the object if it go out of the Play View
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound || transform.position.x > xBound || transform.position.x < -xBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
