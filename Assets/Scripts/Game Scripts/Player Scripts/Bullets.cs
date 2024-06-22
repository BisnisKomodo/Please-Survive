using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    [SerializeField] public float destroyDelay;
    private bool isTriggered = false;
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.GetComponent<EnemyMovement>())
        {
            HealthController healthcontroller = collision.GetComponent<HealthController>();
            healthcontroller.TakeDamage(10);
            Destroy(gameObject);
        }  
    }

    private void Update()
    {
        if (!isTriggered)
        {
            destroyDelay -= Time.deltaTime;
            if (destroyDelay <= 0f)
            {
                Destroy(gameObject);
            }
        }
    }
}
