using UnityEngine;
using System.Collections;

public class MeteorSpawner: MonoBehaviour
{
    private bool isSpawned=true;
    
    [SerializeField]private GameObject[] meteors;
    public float spawnInterval=3f;
    [SerializeField]private Transform spawnPoint1;
    [SerializeField]private Transform spawnPoint2;
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
        yield return new WaitForSeconds(spawnInterval);
        Vector3 x=new Vector3(Random.Range(spawnPoint1.position.x,spawnPoint2.position.x),Random.Range(spawnPoint1.position.y,spawnPoint2.position.y),Random.Range(spawnPoint1.position.z,spawnPoint2.position.z));
        int y=Random.Range(0,meteors.Length);
        Instantiate(meteors[y],x, spawnPoint1.rotation);
        isSpawned=true;
    }

}