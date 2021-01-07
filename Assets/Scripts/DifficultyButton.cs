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

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        moveLeft = GameObject.Find("Background").GetComponent<MoveLeft>();
        spawnManager = GameObject.Find("Spawn Manager").GetComponent<SpawnManager>();
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
        spawnManager.StartGame();

    }
}
