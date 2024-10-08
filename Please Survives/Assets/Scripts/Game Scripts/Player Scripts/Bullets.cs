using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    [SerializeField] public float destroyDelay;
    [SerializeField] private GameObject particleSystemPrefab;
    private bool isTriggered = false;
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        // if (collision.GetComponent<EnemyMovement>())
        // {
        //     HealthController healthcontroller = collision.GetComponent<HealthController>();
        //     healthcontroller.TakeDamage(10);
        //     Destroy(gameObject);
        // }

        if (collision.GetComponent<EnemyMovement>())
        {
            HealthController healthcontroller = collision.GetComponent<HealthController>();
            healthcontroller.TakeDamage(10);
        }

        // Spread the blood out!
            if (particleSystemPrefab != null)
            {
                Instantiate(particleSystemPrefab, transform.position, transform.rotation);
            }

            Destroy(gameObject);
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
