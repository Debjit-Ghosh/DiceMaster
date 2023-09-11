using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ButtonPrefab : MonoBehaviour
{
    //toUse getcomp in children.

    public string amount;
    public string cost;
    public TextMeshProUGUI costText;
    public TextMeshProUGUI amountText;
    //public Image image;
    public Image logo;

    public Image offerImg;
    public bool offer;

    private void Start()
    {
        logo.GetComponent<Image>().sprite = Resources.Load<Sprite>("in_app_purchase_png/icon_coin");
        //image.GetComponent<Image>().sprite = Resources.Load<Sprite>("in_app_purchase_png/icon_coin");
        offerImg.GetComponent<Image>().sprite = Resources.Load<Sprite>("in_app_purchase_png/hot_deal");

        costText.text = cost;
        amountText.text = amount;

        if (offer)
        {
            offerImg.enabled = true;
        }
        else
        {
            offerImg.enabled = false;
        }
    }
}
