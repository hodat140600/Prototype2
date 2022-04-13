using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int playerLife = 3;
    public int score = 0;
    public static GameManager _instance;
    void Start()
    {
        _instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 0) {
            Debug.Log("Game Over");
        }
    }
    public void AddScore(int amount) {
        score += amount;
    }public void AddLive(int amount) {
        playerLife += amount;
    }
}
