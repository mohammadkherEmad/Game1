using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CollectFood : MonoBehaviour
{

    public int Score;

    void OnTriggerEnter(Collider other)
    {

        ScoringSystem.Score += 1;
        Destroy(gameObject);

    }
}
