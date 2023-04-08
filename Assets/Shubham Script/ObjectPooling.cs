using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{

    public int poolBulletAmount = 15;
    private List<GameObject> BulletPooled1 = new List<GameObject>();
    private List<GameObject> BulletPooled2 = new List<GameObject>();
    private List<GameObject> BulletPooled3 = new List<GameObject>();


    [SerializeField] private GameObject bullet1;
    [SerializeField] private GameObject bullet2;
    [SerializeField] private GameObject bullet3;


    public int poolMetoroidAmount = 10;
    private List<GameObject> MetoroidPooled1 = new List<GameObject>();
    private List<GameObject> MetoroidPooled2 = new List<GameObject>();
    private List<GameObject> MetoroidPooled3 = new List<GameObject>();


    [SerializeField] private GameObject Metoroid1;
    [SerializeField] private GameObject Metoroid2;
    [SerializeField] private GameObject Metoroid3;


    private void Start()
    {
        for (int i = 0; i < poolBulletAmount; i++)
        {
            GameObject go = Instantiate(bullet1);
            go.SetActive(false);
            BulletPooled1.Add(go);
        }
        for (int i = 0; i < poolBulletAmount; i++)
        {
            GameObject go = Instantiate(bullet2);
            go.SetActive(false);
            BulletPooled2.Add(go);
        }
        for (int i = 0; i < poolBulletAmount; i++)
        {
            GameObject go = Instantiate(bullet3);
            go.SetActive(false);
            BulletPooled3.Add(go);
        }

        //metaroid
        for (int i = 0; i < poolMetoroidAmount; i++)
        {
            GameObject go = Instantiate(Metoroid1);
            go.SetActive(false);
            MetoroidPooled1.Add(go);
        }
        for (int i = 0; i < poolMetoroidAmount; i++)
        {
            GameObject go = Instantiate(Metoroid2);
            go.SetActive(false);
            MetoroidPooled2.Add(go);
        }
        for (int i = 0; i < poolMetoroidAmount; i++)
        {
            GameObject go = Instantiate(Metoroid3);
            go.SetActive(false);
            MetoroidPooled3.Add(go);
        }
    }

    public GameObject getPooledBullet1()
    {
        for (int i = 0; i < BulletPooled1.Count; i++)
        {
            if(!BulletPooled1[i].activeInHierarchy)
            {
                return BulletPooled1[i];
            }
        }
        return null;
    }
    public GameObject getPooledBullet2()
    {
        for (int i = 0; i < BulletPooled2.Count; i++)
        {
            if (!BulletPooled2[i].activeInHierarchy)
            {
                return BulletPooled2[i];
            }
        }
        return null;
    }
    public GameObject getPooledBullet3()
    {
        for (int i = 0; i < BulletPooled3.Count; i++)
        {
            if (!BulletPooled3[i].activeInHierarchy)
            {
                return BulletPooled3[i];
            }
        }
        return null;
    }
    //meteriod call function
    public GameObject getPooledMetoroid1()
    {
        for (int i = 0; i < MetoroidPooled1.Count; i++)
        {
            if (!MetoroidPooled1[i].activeInHierarchy)
            {
                return MetoroidPooled1[i];
            }
        }
        return null;
    }
    public GameObject getPooledMetoroid2()
    {
        for (int i = 0; i < MetoroidPooled2.Count; i++)
        {
            if (!MetoroidPooled2[i].activeInHierarchy)
            {
                return MetoroidPooled2[i];
            }
        }
        return null;
    }
    public GameObject getPooledMetoroid3()
    {
        for (int i = 0; i < MetoroidPooled3.Count; i++)
        {
            if (!MetoroidPooled3[i].activeInHierarchy)
            {
                return MetoroidPooled3[i];
            }
        }
        return null;
    }
}
