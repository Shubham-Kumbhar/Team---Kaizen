using UnityEngine;
using System.Collections;

public class MeteorSpawner: MonoBehaviour
{
    private bool isSpawned=true;
    
    [SerializeField]private GameObject[] meteors;
    public float spawnInterval=2f;
    ObjectPooling pooling;
    
    private ScoreManager sm;
    void Start()
    {
        sm=FindObjectOfType<ScoreManager>();
        pooling = FindObjectOfType<ObjectPooling>();
    }
    void Update()
    {
    
        if(isSpawned)
        {
            isSpawned=false;
            StartCoroutine(SpawnMeteors());
        }
    }
    IEnumerator SpawnMeteors()
    {
        yield return new WaitForSeconds(spawnInterval);
        Vector3 x1=Camera.main.ViewportToWorldPoint(new Vector3(0,1,0));
        Vector3 x2=Camera.main.ViewportToWorldPoint(new Vector3(1,1,0));
        int y=0;
        Vector3 x = new Vector3(Random.Range(x1.x,x2.x),5.08f,0);
        if(sm.DistTravelled<=500)
        y=Random.Range(0,meteors.Length-2);
        else if(sm.DistTravelled<=750)
        y=Random.Range(0,meteors.Length-1);
        else if(sm.DistTravelled<=1000)
        y=Random.Range(1,meteors.Length-1);


        switch(y)
        {
            case 2:
                GameObject go = pooling.getPooledMetoroid3();
                if (go != null)
                {
                    go.transform.position = x;
                    go.SetActive(true);
                }
                break;
            case 1:
                GameObject go1 = pooling.getPooledMetoroid2();
                if (go1 != null)
                {
                    go1.transform.position = x;
                    go1.SetActive(true);
                }

                break;
            case 0:
                GameObject go2 = pooling.getPooledMetoroid1();
                if (go2 != null)
                {
                    go2.transform.position = x;
                    go2.SetActive(true);
                }
               
                break;
        }
        isSpawned=true;
    }
    // GameObject ProbabilityDecider()
    // {
    //     for(int i=0;i<meteors.Length-1;i++)
    //     {
    //         Meteor m=meteors[i].GetComponent<Meteor>();
    //         if(m.probability>=0.5f)
    //         return m.gameObject;
    //     }
    //     return null;
    // }

}