using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoduSkin : MonoBehaviour
{
    public GameObject Dice;
    public GameObject Token;
    public GameObject Bubble;
    public GameObject Theme;

    public void DicePanel()
    {
        Dice.SetActive(true);
        Token.SetActive(false);
        Bubble.SetActive(false);
        Theme.SetActive(false);
    }
    public void TokenPanel()
    {
        Dice.SetActive(false);
        Token.SetActive(true);
        Bubble.SetActive(false);
        Theme.SetActive(false);
    }
    public void BubblePanel()
    {
        Dice.SetActive(false);
        Token.SetActive(false);
        Bubble.SetActive(true);
        Theme.SetActive(false);
    }
    public void ThemePanel()
    {
        Dice.SetActive(false);
        Token.SetActive(false);
        Bubble.SetActive(false);
        Theme.SetActive(true);
    }
}
