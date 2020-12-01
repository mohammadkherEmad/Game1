using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingFlash : MonoBehaviour
{
    public GameObject[] FlickerLights;
    Light Lights;
    public float minFlickerTime = 0.1f;
    public float maxFlickerTime = 0.4f;
    
    void Start()
    {
        FlickerLights = GameObject.FindGameObjectsWithTag("Lightning");
        for (int i = 0; i < FlickerLights.Length; i++)
        {
            Lights = FlickerLights[i].GetComponent<Light>();
            StartCoroutine(Flicker(Lights));
        }
        
    }

    IEnumerator Flicker (Light Lights)
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minFlickerTime, maxFlickerTime));
            Lights.enabled = !Lights.enabled;
        }
    }
}
