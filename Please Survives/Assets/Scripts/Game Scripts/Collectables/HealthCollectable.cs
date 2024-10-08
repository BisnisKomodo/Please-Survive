using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectable : MonoBehaviour, ICollect
{
    [SerializeField] private float healthAmount;
    public void OnCollected(GameObject player)
    {
        player.GetComponent<HealthController>().AddHealth(10);
    }
}
