using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilitySpawner : MonoBehaviour
{

    public GameObject[] powerups;
    public float MinTimeToSpawn;
    // Update is called once per frame
    private void Start()
    {
        StartCoroutine(powerupSpawner());
    }
    IEnumerator powerupSpawner()
    {
        float a =MinTimeToSpawn* Random.RandomRange(3, 6);
        yield return new WaitForSeconds(a);
        Instantiate(powerups[Random.Range(0, 3)], gameObject.transform.position, Quaternion.identity);
        StartCoroutine(powerupSpawner());
       
    }
   /* void Update()
    {

        MinTimeToSpawn += Time.deltaTime;
        if(MinTimeToSpawn >= 10)
        {
            //spawnPowerup();
            MinTimeToSpawn = 0;
        }
    }*/
}
