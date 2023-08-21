using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Rewards : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI gemsText;

    int coin;
    int gems;

    public int dayNo = 0;

    public Button[] days;

    public static Rewards instance;

    void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        coin = 0;
        gems = 0;
        coinText.text = "Coins: " + coin;
        gemsText.text = "Gems: " + gems;

        days[0].interactable = true;
        for (int i = 1; i< days.Length; i++)
        {
            days[i].interactable = false;
        }
    }

    // Update is called once per frame


    public void CoinCollect(int amount)
    {
        coin += amount;
        coinText.text = "Coins: " + coin;
    }
    public void GemsCollect(int amount)
    {
        gems += amount;
        gemsText.text = "Gems: " + gems;
    }

    private void Update()
    {
        days[0].onClick.AddListener(day0);
        days[1].onClick.AddListener(day1);
        days[2].onClick.AddListener(day2);
        days[3].onClick.AddListener(day3);
        days[4].onClick.AddListener(day4);
        days[5].onClick.AddListener(day5);
        days[6].onClick.AddListener(day6);
    }

    void day0()
    {
        days[0].interactable = false;
        days[1].interactable = true;

        CoinCollect(100);
    }
    void day1()
    {
        days[1].interactable = false;
        days[2].interactable = true;

        CoinCollect(200);
    }
    void day2()
    {
        days[2].interactable = false;
        days[3].interactable = true;

        CoinCollect(300);
    }
    void day3()
    {
        days[3].interactable = false;
        days[4].interactable = true;

        CoinCollect(400);
    }
    void day4()
    {
        days[4].interactable = false;
        days[5].interactable = true;

        CoinCollect(500);
    }
    void day5()
    {
        days[5].interactable = false;
        days[6].interactable = true;

        CoinCollect(600);
    }
    void day6()
    {
        days[6].interactable = false;
        days[0].interactable = true;

        CoinCollect(700);
    }
}
