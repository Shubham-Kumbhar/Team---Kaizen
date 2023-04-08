using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeMeteor : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private Sprite defaultShape;
    [SerializeField]private Sprite onehit;
    [SerializeField]private Sprite twohit;
    private Meteor m;
    void Start()
    {
        m=GetComponent<Meteor>();
    }

    // Update is called once per frame
    void Update()
    {
        StateDecide();
    }
    void StateDecide()
    {
        if(m.health==3)
        GetComponent<SpriteRenderer>().sprite=defaultShape;
        if(m.health==2)
        GetComponent<SpriteRenderer>().sprite=onehit;
        if(m.health==1)
        GetComponent<SpriteRenderer>().sprite=twohit;

    }
}
