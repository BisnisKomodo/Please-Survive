using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibilityController : MonoBehaviour
{
    private HealthController healthcontroller;
    private void Awake()
    {
        healthcontroller = GetComponent<HealthController>();
    }

    public void startinvincibility(float invincibilityduration)
    {
        StartCoroutine(InvincibilityCoroutine(invincibilityduration));
    }

    private IEnumerator InvincibilityCoroutine(float invincibilityduration)
    {
        healthcontroller.IsInvincible = true;
        yield return new WaitForSeconds(invincibilityduration);
        healthcontroller.IsInvincible = false;
    }
}
