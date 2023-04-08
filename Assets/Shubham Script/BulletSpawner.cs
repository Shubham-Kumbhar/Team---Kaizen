using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] float speedOfBullet, noOfBullet;
    public int bulletType;
    ObjectPooling pooling;
    Shooting shoot;
    bool a=true;
    // Update is called once per frame

    private void Start()
    {
        shoot = FindObjectOfType<Shooting>();
        pooling = FindObjectOfType<ObjectPooling>();
    }
    void Update()
    {
        if(a & shoot.buttonPressed)
        {
            a = false;
            StartCoroutine(Spawn(speedOfBullet));
        }
    }
    
    IEnumerator Spawn(float t)
    {
        GameObject go= null;
        switch (bulletType)
        {
            case 2:
                go = pooling.getPooledBullet3();
                break;
            case 1:
                go = pooling.getPooledBullet2();
                break;
            case 0:
                go = pooling.getPooledBullet1();
                break;
               
        }
        //get coonpolent of object pooling 
       
        if(go!=null)
        {
            go.transform.position = transform.position;
            go.transform.rotation = transform.rotation;
            go.SetActive(true);
            yield return new WaitForSeconds(t);
            a = true;
        }
        yield return new WaitForSeconds(noOfBullet * speedOfBullet);
    }

}
