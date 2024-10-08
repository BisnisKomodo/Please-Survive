using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    private ICollect collectbehavior;

    private void Awake()
    {
        collectbehavior = GetComponent<ICollect>();
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        var player = collision.GetComponent<PlayerMovement>();

        if (player != null)
        {
            collectbehavior.OnCollected(player.gameObject);
            Destroy(gameObject);
        }
    }
}
