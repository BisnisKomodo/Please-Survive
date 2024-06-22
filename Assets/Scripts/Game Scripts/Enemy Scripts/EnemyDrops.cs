using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDrops : MonoBehaviour
{
    [SerializeField] private float chanceofcollectabledrop;
    private CollectibleSpawner collectablespawner;

    private void Awake()
    {
        collectablespawner = FindObjectOfType<CollectibleSpawner>();
    }

    public void RandomlyDropCollectables()
    {
        float random = Random.Range(0f, 1f);
        if (chanceofcollectabledrop >= random)
        {
            collectablespawner.SpawnCollectable(transform.position);
        }
    }
}
