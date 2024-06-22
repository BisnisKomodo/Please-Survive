using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Image HealthBarForeGroundImage;
    public void UpdateHealthBar(HealthController healthController)
    {
        HealthBarForeGroundImage.fillAmount = healthController.RemainingHealthPercentage;
    }
}
