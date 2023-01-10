using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // Detecting the collisions and Destroying the collided objects
    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            gameManager.AddLives(-1);
            Destroy(other.gameObject);
        }
        else {
            gameManager.AddScore(5);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
    
}
