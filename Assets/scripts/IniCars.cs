using Assets.scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IniCars : MonoBehaviour {
    public float T = 3f;//周期
    public GameObject Car;//car's prefab
    public float timer;
    public char fromWhere;//出发点
 
    public float maxRandT = 5f;//随机周期里最大值
    public float minRandT = 1f;

  
	// Use this for initialization
	void Start () {
        StartCoroutine(CycleGen());
        //Invoke("",);
    }

    // Update is called once per frame
    void Update () {
       // print(CarPath.EToS() == null);
	}

    

    //循环调用自身，周期性调用ProductCars
    IEnumerator CycleGen()
    {
        for (timer = 0f; timer < T; timer+=Time.deltaTime)
        {
            yield return 0;
        }
        System.Random r = new System.Random();
        int i;
        i= RandFloat.RandomInt(0, 6);
        switch (i)
        {
            case 0:
                SProductCars();
                break;
            case 1:
                LProductCars();//生成左转车
                break;
            case 2:
                RProductCars();//生成右转车
                break;
            case 3:
                SProductCars();
                LProductCars();//生成左转车
                break;
            case 4:
                LProductCars();//生成左转车
                RProductCars();//生成右转车
                break;
            case 5:
                RProductCars();//生成右转车
                SProductCars();
                break;
            default:
                break;
        }
        T = 1f + Random.Range(minRandT, maxRandT);//随机周期
        StartCoroutine(CycleGen());

    }

    /// <summary>
    /// 生成车
    /// </summary>
    void SProductCars()
    {

        GameObject sCar = (GameObject)Instantiate(Car,transform.position,transform.rotation);//生成车
        sCar.GetComponent<Car>().dir = Dire.Straight;//车的方向设置为直行
       // print(sCar.GetComponent<Car>().carP == null);

        switch (fromWhere)
        {
            case 'S':
                sCar.GetComponent<Car>().SetPath(CarPath.SToN());
                break;
            case 'E':
                sCar.GetComponent<Car>().SetPath(CarPath.EToW());
                break;
            case 'N':
                sCar.GetComponent<Car>().SetPath(CarPath.NToS());
                break;
            case 'W':
                sCar.GetComponent<Car>().SetPath(CarPath.WToE());
                break;
            default:
                break;
        }
       // print(sCar.GetComponent<Car>().carP == null);

    }



    void RProductCars()
    {

       GameObject rCar=(GameObject)Instantiate(Car, transform.position+transform.right*3.5f, transform.rotation);//右行车距离直行只右方3.5米
        rCar.GetComponent<Car>().dir = Dire.Right;//设置为右行
        rCar.GetComponent<Car>().isApproval = true;//右转车永远允许通过
    }


    void LProductCars()
    {

        GameObject rCar = (GameObject)Instantiate(Car, transform.position - transform.right * 3.5f, transform.rotation);//右行车距离直行只右方3.5米
        rCar.GetComponent<Car>().dir = Dire.Left;//设置为左行
        switch (fromWhere)
        {
            case 'S':
                rCar.GetComponent<Car>().SetPath(CarPath.SToW());
                break;
            case 'E':
                rCar.GetComponent<Car>().SetPath(CarPath.EToS());
                break;
            case 'N':
                rCar.GetComponent<Car>().SetPath(CarPath.NToE());
                break;
            case 'W':
                rCar.GetComponent<Car>().SetPath(CarPath.WToN());
                break;
            default:
                break;
        }
       // print(rCar.GetComponent<Car>().carP==null);
    }

}
