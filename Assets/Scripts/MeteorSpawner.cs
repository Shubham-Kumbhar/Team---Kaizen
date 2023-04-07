using UnityEngine;
using System.Collections;

public class MeteorSpawner: MonoBehaviour
{
    private bool isSpawned=true;
    [SerializeField]private GameObject[] meteors;
    [SerializeField]private Transform spawnPoint;
    void Start()
    {
    }
    void Update()
    {
        if(isSpawned)
        {
            isSpawned=false;
        StartCoroutine(SpawnMeteors());
    }}
    IEnumerator SpawnMeteors()
    {
        yield return new WaitForSeconds(3);
        int x=Random.Range(0,meteors.Length);
        Instantiate(meteors[x],spawnPoint.position, spawnPoint.rotation);
        isSpawned=true;
    }

}