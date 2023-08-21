using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Roulette : MonoBehaviour
{
    public float RotatePower;
    public float StopPower;
    public Button spinButton;

    private Rigidbody2D rbody;
    int inRotate=0;

    List<int> reward = new List<int>{100, 200, 300, 400, 500, 600, 700};

    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    float t;
    private void Update()
    {
        spinButton.onClick.AddListener(Rotate);

        Debug.Log(rbody.angularVelocity);

        if (rbody.angularVelocity > 0)
        {
            rbody.angularVelocity -= StopPower*Time.deltaTime;

            rbody.angularVelocity = Mathf.Clamp(rbody.angularVelocity, 0, 1440);
        }

        //if (rbody.angularVelocity == 0 && inRotate == 1)
        //{
        //    t += 1 * Time.deltaTime;
        //    if (t >= 0.5f)
        //    {
        //        GetReward();
        //        inRotate = 0;
        //        t = 0;
        //    }
        //}


    }


    public void Rotate()
    {
        if (inRotate == 0)
        {
            rbody.AddTorque(RotatePower);
            inRotate = 1;

            Debug.Log("a");
        }
    }



    public void GetReward()
    {
        float rot = transform.eulerAngles.z;

        if (rot > 0 + 22 && rot <= 45 + 22)
        {
            GetComponent<RectTransform>().eulerAngles = new Vector3(0, 0, 22.5f);
            //win(reward[0] ,0);
        }
        else if (rot > 45 + 22 && rot <= 90 + 22)
        {
            GetComponent<RectTransform>().eulerAngles = new Vector3(0, 0, 67.5f);
            //win(200, 0);
        }
        else if (rot > 90 + 22 && rot <= 135 + 22)
        {
            GetComponent<RectTransform>().eulerAngles = new Vector3(0, 0, 112.5f);
            //win(100, 0);
        }
        else if (rot > 135 + 22 && rot <= 180 + 22)
        {
            GetComponent<RectTransform>().eulerAngles = new Vector3(0, 0, 157.5f);
            //win(100, 0);
        }
        else if (rot > 180 + 22 && rot <= 225 + 22)
        {
            GetComponent<RectTransform>().eulerAngles = new Vector3(0, 0, 202.5f);
            //win(100, 0);
        }
        else if (rot > 225 + 22 && rot <= 270 + 22)
        {
            GetComponent<RectTransform>().eulerAngles = new Vector3(0, 0, 247.5f);
            //win(100, 0);
        }
        else if (rot > 270 + 22 && rot <= 315 + 22)
        {
            GetComponent<RectTransform>().eulerAngles = new Vector3(0, 0, 292.5f);
            //win(100, 0);
        }
        else if (rot > 315 + 22 && rot <= 360 + 22)
        {
            GetComponent<RectTransform>().eulerAngles = new Vector3(0, 0, 337.5f);
            //win(100, 0);
            
        }

    }


    //public void Win(int _coin, int _gems)
    //{
    //    Debug.Log(_coin + " " + _gems);
    //    Rewards.instance.CoinCollect(_coin);
    //    Rewards.instance.GemsCollect(_gems);
    //}

}