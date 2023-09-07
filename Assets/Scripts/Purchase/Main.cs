using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject dominoPanel;
    public GameObject stickerPanel;
    public GameObject loduSkinPanel;
    // Start is called before the first frame update
    void Start()
    {
        mainPanel.SetActive(true);
        dominoPanel.SetActive(false);
        stickerPanel.SetActive(false);
        loduSkinPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DominoPanel()
    {
        mainPanel.SetActive(false);
        dominoPanel.SetActive(true);
        stickerPanel.SetActive(false);
        loduSkinPanel.SetActive(false);

    }

    public void StickerPanel()
    {
        mainPanel.SetActive(false);
        dominoPanel.SetActive(false);
        stickerPanel.SetActive(true);
        loduSkinPanel.SetActive(false);
    }

    public void LoduSkinPanel()
    {
        mainPanel.SetActive(false);
        dominoPanel.SetActive(false);
        stickerPanel.SetActive(false);
        loduSkinPanel.SetActive(true);
    }

    public void Back()
    {
        mainPanel.SetActive(true);
        dominoPanel.SetActive(false);
        stickerPanel.SetActive(false);
        loduSkinPanel.SetActive(false);
    }
}
