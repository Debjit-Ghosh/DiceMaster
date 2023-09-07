using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MainScreen : MonoBehaviour
{
    public Button shopButton;
    public Button closeButton;

    public GameObject shopPanel;

    public int coin;
    public int gems;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI gemsText;

    public static MainScreen instance;
    private void Start()
    {
        instance = this;


        coinText.text = coin.ToString();
        gemsText.text = gems.ToString();


        shopButton.onClick.AddListener(OpenShop);
        closeButton.onClick.AddListener(CloseShop);
    }

    public void OpenShop()
    {
        shopPanel.SetActive(true);
    }
    void CloseShop()
    {
        shopPanel.SetActive(false);
    }
}
