using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    void Update()
    {
        Vector2 mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);   
        Vector2 direction = mouseposition - (Vector2)transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle - 90f, Vector3.forward);
    }
}
