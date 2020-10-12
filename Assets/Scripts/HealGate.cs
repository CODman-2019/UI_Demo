using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealGate : MonoBehaviour
{
    public HealthBar healthCounter;
    int fullHeal = 999;


    private void OnTriggerEnter(Collider other)
    {
        healthCounter.AdjustHealth(fullHeal);
    }
}
