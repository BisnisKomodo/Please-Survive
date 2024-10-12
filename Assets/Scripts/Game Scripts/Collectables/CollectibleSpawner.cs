using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> collectablePrefabs;

    public void SpawnCollectable(Vector2 Position)
    {
        int index = Random.Range(0, collectablePrefabs.Count);
        var SelectedCollectable = collectablePrefabs[index];

        Instantiate(SelectedCollectable, Position, Quaternion.identity);
    }
}
