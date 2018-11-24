using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DuckController : MonoBehaviour
{
    public int points;
    public float speed;
    

    private Transform playerPos;
    private GrannyController player;
    

    void Start()
    {
        //Find Player
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<GrannyController>();
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
        


    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            //Player losing health
        {
            player.health--;


           //Removes duck if hit
            Destroy(gameObject);
        }

        if (other.CompareTag("Bread"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        
    }
}