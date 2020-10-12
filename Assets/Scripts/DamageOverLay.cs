using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class DamageOverLay : MonoBehaviour
{
    public UnityEngine.UI.Image overlay;
    Coroutine _currentCoroutine = null;

    float r;
    float b;
    float g;
    float a;

    // Start is called before the first frame update
    void Start()
    {
        r = overlay.color.r;
        b = overlay.color.b;
        g = overlay.color.g;
        a = overlay.color.a;
    }



    public void StartFlash(float tDuration, float maxAlpha)
    {
        maxAlpha = Mathf.Clamp(maxAlpha, 0, 1);

        if (_currentCoroutine != null) StopCoroutine(_currentCoroutine);

        _currentCoroutine = StartCoroutine(Flash(tDuration, maxAlpha));
    }

    IEnumerator Flash(float seconds, float maxAlpha)
    {
        //flash in
        float flashIn = seconds / 2;
        for(float i = 0; i <= flashIn; i += Time.deltaTime)
        {
            //color change
            Color currentcolor = overlay.color;
            currentcolor.a = Mathf.Lerp(0, maxAlpha, i / flashIn);
            overlay.color = currentcolor;
            
            yield return null;
        }

        //flash out

        float flashOut = seconds / 2;
        for (float t = 0; t <= flashOut; t += Time.deltaTime) 
        {
            Color curColor = overlay.color;
            curColor.a = Mathf.Lerp(maxAlpha, 0, t / flashOut);
            overlay.color = curColor;
            yield return null;
        }
    }
}
