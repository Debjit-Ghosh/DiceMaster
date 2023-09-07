using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Roulette : MonoBehaviour
{
    public float rotatePower;
    public float stopPower;
    public Button spinButton;
    public Button add1, add2, add3;

    private Rigidbody2D rbody; //
    int inRotate=0;
    int noOfSpin=1;
    bool canRotate =true;

    List<int> rewardAngle = new List<int> { };
    //public List<int> reward = new List<int> { };    //Actual Reward
    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();


        spinButton.onClick.AddListener(Rotate);

        add1.onClick.AddListener(spinadd);
        add2.onClick.AddListener(spinadd1);
        add3.onClick.AddListener(spinadd2);

        loop();
    }

    float t;
    private void Update()
    {

        if (rbody.angularVelocity < 0)
        {
            canRotate = false;
            rbody.angularVelocity += stopPower*Time.deltaTime;

            rbody.angularVelocity = Mathf.Clamp(rbody.angularVelocity, -1440, 0);
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
            rbody.AddTorque(rotatePower);
            inRotate = 1;
            noOfSpin -= 1;
            //Debug.Log(noOfSpin);
        }
    }



    public void GetReward()
    {
        float rot = transform.eulerAngles.z;
        for (int n = 0; n < rewardAngle.Count; n++)
        {
            if (rot >= rewardAngle[n] && rot < rewardAngle[n + 1])
            {
                Debug.Log(rewardAngle[n]);
                Debug.Log(rewardAngle[n + 1]);
                GetComponent<RectTransform>().eulerAngles = new Vector3(0, 0, n+ rewardAngle[n]+ 360/(rewardAngle.Count*2));  //snapping
                break;
            }
            if(rot>= rewardAngle[rewardAngle.Count - 1] && rot < 360)
            {
                Debug.Log(rewardAngle[rewardAngle.Count - 1]);
                Debug.Log(360);
                break;

            }
        }
    }


    //public void Win(int _coin, int _gems)
    //{
    //    Debug.Log(_coin + " " + _gems);
    //    Rewards.instance.CoinCollect(_coin);
    //    Rewards.instance.GemsCollect(_gems);
    //}

    void loop() //ver2
    {
        int b = rewardAngle.Count;
        int a = 360 / b;
        float rot = transform.eulerAngles.z;

        for (int n = 0; n < b; n++)
        {
            if (n == 0)
            { rewardAngle[0] = 0; }
            else
            { rewardAngle[n] = rewardAngle[n - 1] + a;}
            // Console.WriteLine(rew[x]);
        }
    }

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