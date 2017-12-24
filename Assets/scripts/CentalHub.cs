//#define TestingPath
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentalHub : MonoBehaviour {
    private static CentalHub instance;
    public static float D = 21f;//单道路宽
    public static float d = D / 6;//单车道宽  3.5
    public static float width = D*3;//整个十字口宽度
    public static float carWidth = 1.8f;//车宽度
    public static float carLength = 4f;//车长度
    public static float sx = 5f;//车前后安全距离
    public static float sy = 0.5f;//车左右安全距离
    public static float sdx = sx+carLength;//安全区长度
    public static float sdy = sy + carWidth;//安全区宽度
    public static float carVelocity = 11.11111f;//车一般速度
    public static float minProDistance = 5f;//生成两车之间最小距离
    public float timer = 0;//计时器
    List<CarPath> requests = new List<CarPath>();//存放已经获得批准的车路径请求队列

    //单例模式
    public static CentalHub Instance
    {
        get
        {
            return instance;
        }
    }
    private void Awake()
    {
        instance = this;
    }


    private void Update()
    {
        timer += Time.deltaTime;//time
    }


    //离开十字路的物体被销毁
    private void OnTriggerExit(Collider other)
    {
       // print(requests.Count);
        Destroy(other.transform.gameObject);
#if TestingPath
        PathTesting.Instance.PrintPath();//debug
#endif
    }
    
    //获取请求，批准则加入请求队列中
    public bool Request(CarPath cp)
    {
       // print(requests.Count);

        foreach (CarPath e in requests)
        {
            if (CarPath.IsConflict(cp,e))
            {
                return false;//只有有冲突则不通过请求
           
            }
        }
        requests.Add(cp);//将没有冲突的请求添加进列表
        return true;
    }
   
    //移除完成了任务的路径
    public void FinishRequest(CarPath cp)
    {
        requests.Remove(cp);
    }
}
