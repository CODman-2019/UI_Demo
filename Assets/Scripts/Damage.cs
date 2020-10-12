using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    int damage;
    public HealthBar healthCounter;
    public DamageOverLay screenFlash;

    // Start is called before the first frame update
    void Start()
    {
        damage = -1;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            healthCounter.AdjustHealth(damage);
            screenFlash.StartFlash(.5f, 0.5f);
        }
    }

}
