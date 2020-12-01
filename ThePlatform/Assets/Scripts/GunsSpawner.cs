using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunsSpawner : MonoBehaviour
{
    public GameObject[] Guns = new GameObject[8];
    private float delayTime = 5f;
    private float repeatTime = 7f;
    public float XRange = 15f;
    public float ZRange = 16.5f;




    void Start()
    {
        InvokeRepeating("SpawnGunsRandomly", delayTime, repeatTime);
    }

    private void SpawnGunsRandomly()
    {
        int GunIndex = Random.Range(0, Guns.Length);

        float XRandom = Random.Range(-XRange, XRange);

        float ZRandom = Random.Range(-ZRange, ZRange);

        Vector3 SpawnPos = new Vector3(XRandom, 0.7f, ZRandom);

        Instantiate(Guns[GunIndex], SpawnPos, Guns[GunIndex].transform.rotation);
    }
}
