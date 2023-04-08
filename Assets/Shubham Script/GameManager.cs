using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] Spawners;
    bool a;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject spawner in Spawners)
        {
            spawner.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(a)
        {
            a = false;
            StartCoroutine(RandomSpawner());
        }
    }

    IEnumerator RandomSpawner()
    {
        int x = Random.Range(0,Spawners.Length);
        int y = Random.Range(0, Spawners.Length);
        while(x==y)
        {
            y = Random.Range(0, Spawners.Length);
        }
        Spawners[x].SetActive(true);
        Spawners[y].SetActive(true);
        yield return new WaitForSeconds(0.9f);
        Spawners[x].SetActive(false);
        Spawners[y].SetActive(false);
        a = true;

    }
}
