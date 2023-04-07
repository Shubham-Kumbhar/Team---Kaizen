using UnityEngine;
using System.Collections;

public class MeteorSpawner: MonoBehaviour
{
    private bool isSpawned=true;
    
    [SerializeField]private GameObject[] meteors;
    public float spawnInterval=3f;
    [SerializeField]private Transform spawnPoint1;
    [SerializeField]private Transform spawnPoint2;
    private ScoreManager sm;
    void Start()
    {
        sm=FindObjectOfType<ScoreManager>();
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
        int y=0;
        Vector3 x=new Vector3(Random.Range(spawnPoint1.position.x,spawnPoint2.position.x),Random.Range(spawnPoint1.position.y,spawnPoint2.position.y),Random.Range(spawnPoint1.position.z,spawnPoint2.position.z));
        if(sm.DistTravelled<=100)
        y=Random.Range(0,meteors.Length-1);
        else if(sm.DistTravelled<=200)
        y=Random.Range(0,meteors.Length);
        else if(sm.DistTravelled<=350)
        y=Random.Range(1,meteors.Length);
        else
        y=meteors.Length-1;
        Instantiate(meteors[y],x, spawnPoint1.rotation);
        isSpawned=true;
    }
    GameObject ProbabilityDecider()
    {
        for(int i=0;i<meteors.Length-1;i++)
        {
            Meteor m=meteors[i].GetComponent<Meteor>();
            if(m.probability>=0.5f)
            return m.gameObject;
        }
        return null;
    }

}