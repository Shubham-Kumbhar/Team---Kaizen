using UnityEngine;
using System.Collections;

public class MeteorSpawner: MonoBehaviour
{
    [SerializeField]private GameObject[] meteors;
    [SerializeField]private Transform spawnPoint;
    void Start()
    {
    }
    void FixedUpdate()
    {
        int x=Random.Range(0,3);
        Instantiate(meteors[x],spawnPoint.position, spawnPoint.rotation);
    }

}