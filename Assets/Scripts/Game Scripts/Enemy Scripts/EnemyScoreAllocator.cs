using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScoreAllocator : MonoBehaviour
{
    [SerializeField] private int killscore;
    private ScoreController scorecontroller;

    private void Awake()
    {
        scorecontroller = FindObjectOfType<ScoreController>();
    }

    public void AllocateScore()
    {
        scorecontroller.AddScore(killscore);
    }
}
