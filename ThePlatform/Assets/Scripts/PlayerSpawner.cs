using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject Player;
    private float delayTime = 0f;
    public float XRange = 17f;
    public float ZRange = 18.5f;




    void Start()
    {
        
        Invoke("SpawnPlayerRandomly", delayTime);
    }

    private void SpawnPlayerRandomly()
    {
        
        float XRandom = Random.Range(-XRange, XRange);

        float ZRandom = Random.Range(-ZRange, ZRange);

        Vector3 SpawnPos = new Vector3(XRandom, 0.7f, ZRandom);

        Instantiate(Player, SpawnPos, Player.transform.rotation);
    }
}
