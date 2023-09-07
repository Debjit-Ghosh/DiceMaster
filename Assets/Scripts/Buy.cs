using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Buy : MonoBehaviour
{
    public List<Button> coinPurchase = new List<Button> { };
    public List<int> coinValue = new List<int> { };

    public List<Button> gemPurchase = new List<Button> { };
    public List<int> gemValue = new List<int> { };

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < coinPurchase.Count; i++)    //coin buttons initialize
        {
            int _i = i;
            coinPurchase[_i].onClick.AddListener(() => CoinValue(coinValue[_i]));
        }
        //for (int i = 0; i < coinPurchase.Count; i++)  //gem buttons initialize
        //{
        //    int _i = i;
        //    gemPurchase[_i].onClick.AddListener(() => GemValue(gemValue[_i]));
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CoinValue (int n)
    {
        //perform Action
        Debug.Log("BuyCoin"+n);
    }
    void GemValue(int n)
    {
        //perform Action
        Debug.Log("BuyGem");

    }
}
