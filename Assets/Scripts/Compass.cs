using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour
{
    public Transform playerTransform;
    public GameObject compass;
    public bool hideCompass;
    Vector3 dir;

    void Start()
    {
        hideCompass = false;
    }

    void Update()
    {
        if (!PausMenu.paused)
        {

            dir.z = playerTransform.eulerAngles.y;
            compass.transform.localEulerAngles = dir;

            if (Input.GetKeyDown(KeyCode.C))
            {
                if (!hideCompass)
                {
                    compass.SetActive(true);
                    hideCompass = true;
                }
                else
                {
                    compass.SetActive(false);
                    hideCompass = false;
                }
            }
        }
    }

}
