using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Roulette : MonoBehaviour
{
    public float RotatePower;
    public float StopPower;
    public Button spinButton;
    public Button asd, asd1, asd2;

    private Rigidbody2D rbody;
    int inRotate=0;
    int noOfSpin=1;
    bool canRotate =true;

    //List<int> reward = new List<int>{100, 200, 300, 400, 500, 600, 700};


    //public int noOfRew;

    //List <int> rew = new List<int>();


    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();


        spinButton.onClick.AddListener(Rotate);

        asd.onClick.AddListener(spinadd);
        asd1.onClick.AddListener(spinadd1);
        asd2.onClick.AddListener(spinadd2);
    }

    float t;
    private void Update()
    {
        //if (canRotate && noOfSpin > 0)
        //{
        //    spinButton.interactable = true;
        //}
        //else {
        //    spinButton.interactable = false;
        //}


        //Debug.Log(rbody.angularVelocity);

        if (rbody.angularVelocity > 0)
        {
            canRotate = false;
            rbody.angularVelocity -= StopPower*Time.deltaTime;

            rbody.angularVelocity = Mathf.Clamp(rbody.angularVelocity, 0, 1440);
        }

        if (rbody.angularVelocity == 0 && inRotate == 1)
        {
            t += 1 * Time.deltaTime;
            if (t >= 0.5f)
            {
                GetReward();
                inRotate = 0;
                t = 0;
            }
        }


    }


    public void Rotate()
    {
        if (inRotate == 0 &&  noOfSpin>0)
        {
            rbody.AddTorque(RotatePower);
            inRotate = 1;
            noOfSpin -= 1;
            Debug.Log(noOfSpin);
        }
    }



    public void GetReward()
    {
        float rot = transform.eulerAngles.z;

        if (rot > 0 && rot <= 45)
        {
            GetComponent<RectTransform>().eulerAngles = new Vector3(0, 0, 22.5f);
            //win(reward[0] ,0);
        }
        else if (rot > 45 && rot <= 90)
        {
            GetComponent<RectTransform>().eulerAngles = new Vector3(0, 0, 67.5f);
            //win(200, 0);
        }
        else if (rot > 90 && rot <= 135)
        {
            GetComponent<RectTransform>().eulerAngles = new Vector3(0, 0, 112.5f);
            //win(100, 0);
        }
        else if (rot > 135 && rot <= 180)
        {
            GetComponent<RectTransform>().eulerAngles = new Vector3(0, 0, 157.5f);
            //win(100, 0);
        }
        else if (rot > 180 && rot <= 225)
        {
            GetComponent<RectTransform>().eulerAngles = new Vector3(0, 0, 202.5f);
            //win(100, 0);
        }
        else if (rot > 225 && rot <= 270)
        {
            GetComponent<RectTransform>().eulerAngles = new Vector3(0, 0, 247.5f);
            //win(100, 0);
        }
        else if (rot > 270 && rot <= 315)
        {
            GetComponent<RectTransform>().eulerAngles = new Vector3(0, 0, 292.5f);
            //win(100, 0);
        }
        else if (rot > 315 && rot <= 360)
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

    //void rewarddd()
    //{


    //    int a = 360 / noOfRew;
    //    int[] rew = new int[noOfRew];

    //    for (int x = 0; x < noOfRew; x++)
    //    {
    //        if (x == 0)
    //        { rew[x] = rew[x] + a; }
    //        else
    //        { rew[x] = rew[x - 1] + a; }
    //    }


        
    //}

    //void asd()
    //{
    //    int a = 360 / noOfRew;
    //    float rot = transform.eulerAngles.z;

    //    for (int x = 0; x < noOfRew + 1; x++)
    //    {
    //        if (x == 0)
    //        { rew[0] = 0; }
    //        else
    //        { rew[x] = rew[x - 1] + a; }

    //       // Console.WriteLine(rew[x]);
    //    }

    //    for (int q = 0; q < noOfRew; q++)
    //    {
    //        if ( rot>= rew[q] && rot < rew[q + 1])
    //        {
    //            Debug.Log(rew[q]);
    //            Debug.Log(rew[q+1]);
    //            //Console.WriteLine(rew[q]);
    //            //Console.WriteLine(rew[q + 1]);
    //        }
    //    }
    //}

    void spinadd()
    {
        noOfSpin ++;
        Debug.Log(noOfSpin);
    }
    void spinadd1()
    {
        noOfSpin+= 2;
        Debug.Log(noOfSpin);
    }
    void spinadd2()
    {
        noOfSpin+= 5;
        Debug.Log(noOfSpin);
    }
}