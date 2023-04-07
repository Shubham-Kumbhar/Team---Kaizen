using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] float speedOfBullet, noOfBullet;
    public GameObject bullet;
    bool a=true;
    // Update is called once per frame
    void Update()
    {
        if(a)
        {
            StartCoroutine(Spawn(speedOfBullet));
            a = false;
        }
    }
    
    IEnumerator Spawn(float t)
    {
        yield return new WaitForSeconds(t);
        GameObject go= Instantiate(bullet, transform);
        go.transform.parent = null;
        Destroy(go, noOfBullet * speedOfBullet*2);
        a = true;
    }

}
