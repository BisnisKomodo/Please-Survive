using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletprefabs;
    [SerializeField] private float bulletspeed;

    [SerializeField] private Transform Gunoffset;
    private bool firecontinously;
    private bool firesingle;
    [SerializeField] private float timebetweenshots;
    private float lastfiretime;
    void Update()
    {
        if (firecontinously || firesingle)
        {
            float timesincelastfire = Time.time - lastfiretime;

            if (timesincelastfire >= timebetweenshots)
            {
                FireBullet();

                lastfiretime = Time.time;
                firesingle = false;
            }
        }
    }

    private void FireBullet()
    {
        GameObject bullet = Instantiate(bulletprefabs, Gunoffset.position, transform.rotation);
        Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();

        rigidbody.velocity = bulletspeed * transform.up;
    }
    private void OnFire(InputValue inputvalue)
    {
        firecontinously = inputvalue.isPressed;

        if (inputvalue.isPressed)
        {
            firesingle = true;
        }
    }
}
