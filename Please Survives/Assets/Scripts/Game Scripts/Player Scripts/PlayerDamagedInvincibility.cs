using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamagedInvincibility : MonoBehaviour
{
    private InvincibilityController invincibilitycontroller;
    [SerializeField]private float invincibilityduration;

    private void Awake()
    {
        invincibilitycontroller = GetComponent<InvincibilityController>();
    }
    public void startinvincibility()
    {
        invincibilitycontroller.startinvincibility(invincibilityduration);
    }
}
