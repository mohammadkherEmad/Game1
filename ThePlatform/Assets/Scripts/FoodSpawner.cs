using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{

    public GameObject[] Foods = new GameObject[17];
    private float delayTime = 2f;
    private float repeatTime = 1.5f;
    public float XRange = 15f;
    public float ZRange = 16.5f;



    
    void Start()
    {
        InvokeRepeating("SpawnFoodsRandomly", delayTime, repeatTime);
    }

    private void SpawnFoodsRandomly()
    {
        int FoodIndex = Random.Range(0, Foods.Length);

        float XRandom = Random.Range(-XRange, XRange);

        float ZRandom = Random.Range(-ZRange, ZRange);

        Vector3 SpawnPos = new Vector3(XRandom, 0.7f , ZRandom);

        Instantiate(Foods[FoodIndex], SpawnPos, Foods[FoodIndex].transform.rotation);
    }
}
