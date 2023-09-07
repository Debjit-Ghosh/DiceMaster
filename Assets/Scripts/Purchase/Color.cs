using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Color : MonoBehaviour
{
    public Image bg;
    [SerializeField] Button button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ColorChange()
    {
        bg.color = button.image.color;
        Debug.Log("s");
    }
}
