using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Button coinButton, gemButton;
    public GameObject coinPanel, gemPanel;

    private void Start()
    {
        coinButton.onClick.AddListener(OpenCoinPanel);
        gemButton.onClick.AddListener(OpenGemPanel);
    }

    void OpenCoinPanel() {
        coinPanel.SetActive(true);
        gemPanel.SetActive(false);
    }
    void OpenGemPanel()
    {
        coinPanel.SetActive(false); 
        gemPanel.SetActive(true);
    }
}
