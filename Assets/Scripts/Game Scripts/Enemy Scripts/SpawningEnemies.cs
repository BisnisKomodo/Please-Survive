using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningEnemies : MonoBehaviour
{
    [SerializeField] private GameObject Enemyprefab;
    [SerializeField] private float minimumspawntime;
    [SerializeField] private float maximumspawntime;
    private float Timeuntilspawn;

    void Awake()
    {
        SetTimeUntilSpawn();
    }

    void Update()
    {
        Timeuntilspawn -= Time.deltaTime;

        if(Timeuntilspawn <= 0)
        {
            Instantiate(Enemyprefab, transform.position, Quaternion.identity);
            SetTimeUntilSpawn();
        }
    }

    private void SetTimeUntilSpawn()
    {
        Timeuntilspawn = Random.Range(minimumspawntime, maximumspawntime);
    }
}
