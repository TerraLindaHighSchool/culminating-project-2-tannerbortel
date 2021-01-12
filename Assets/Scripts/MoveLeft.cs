using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private PlayerController playerControllerScript;
    private float leftBound = -15;
    private int score;
    public TextMeshProUGUI scoreText;
    public GameObject tenpoints;
    public GameObject twentyfivepoints;
    public GameObject fiftypoints;
    public GameObject hundredpoints;


    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        score = 0;
    }

    public void StartGame()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        
            if (playerControllerScript.gameOver == false)
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }

            if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
            {
                Destroy(gameObject);
            UpdateScore(1);
            }
        
    }

    public void UpdateScore(int add)
    {
        score += add;
        scoreText.text = "Score: " + score;

        if (score == 25)
        {
            twentyfivepoints.gameObject.SetActive(true);
        }

        if (score == 29)
        {
            twentyfivepoints.gameObject.SetActive(false);
        }


        if (score == 10)
        {
            tenpoints.gameObject.SetActive(true);
        }

        if (score == 15)
        {
            tenpoints.gameObject.SetActive(false);
        }

        if (score == 50)
        {
            fiftypoints.gameObject.SetActive(true);
        }

        if (score == 55)
        {
            fiftypoints.gameObject.SetActive(false);
        }

        if (score == 100)
        {
            hundredpoints.gameObject.SetActive(true);
        }

        if (score == 105)
        {
            hundredpoints.gameObject.SetActive(false);
        }
    }




}
