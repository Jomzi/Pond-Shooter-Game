using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GrannyController : MonoBehaviour
{
    
    public float speed;
    public int health = 10;
    public Text healthDisplay;
    
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    public int score;
    public GameObject gameOverPanel;
    // Use this for initialization
    void Start()
    {
        score = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        healthDisplay.text = "Lives :" + health;

        if (health <= 0)
        {
           // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            GameOver();
        }

        {
            Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            moveVelocity = moveInput.normalized * speed;
        }
    }
        void FixedUpdate()

        {
            rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
        }

    void GameOver()
    {
        CancelInvoke();
        gameOverPanel.SetActive(true);
    }
    




}