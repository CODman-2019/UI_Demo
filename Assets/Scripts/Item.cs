using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public float speed;
    public Text description;
    public Text bought;
    bool paid;

    // Start is called before the first frame update
    void Start()
    {
        paid = false;
        description.enabled = false;
        bought.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!paid)
            {
                description.enabled = true;
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    paid = true;
                }
            }
            else
            {
                description.enabled = false;
                bought.enabled = true;
            }
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        description.enabled = false;
        bought.enabled = false;
    }

}
