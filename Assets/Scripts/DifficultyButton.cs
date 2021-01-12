using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button button;
    private PlayerController playerController;
    private MoveLeft moveLeft;
    private SpawnManager spawnManager;
    private RepeatBackground repeatBackground;
    public int difficulty;


    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        moveLeft = GameObject.Find("Crate_01").GetComponent<MoveLeft>();
        spawnManager = GameObject.Find("Spawn Manager").GetComponent<SpawnManager>();
        repeatBackground = GameObject.Find("Background").GetComponent<RepeatBackground>();
        button.onClick.AddListener(SetDifficulty);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SetDifficulty()
    {
        playerController.StartGame();
        moveLeft.StartGame();
        spawnManager.StartGame(difficulty);
        repeatBackground.StartGame();
    }
}
