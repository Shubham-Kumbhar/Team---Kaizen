using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int coins;
    [SerializeField]private Text text;
    void Start()
    {
        coins=PlayerPrefs.GetInt("Coins");
    }

    // Update is called once per frame
    void Update()
    {
        text.text=coins.ToString();   
    }
}
