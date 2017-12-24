using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {
    public float norVelocity= 11.11111f;//一般速度
    Rigidbody rig;//rigidbody
    public Dire dir;//转弯方向
    float radiusLeft=CentalHub.d*2.5f;//左转弯半径
    float radiusRight = CentalHub.d;//右转半径
    bool isTurning = false;//是否在转弯
    public bool isApproval = false;//路径是否被批准
    public CarPath carP;//本车的路径
	public CarPath carPStart;//车初始化的路径，更新路径应该在此基础之上
    private bool isRequiring = false;//是否正在向服务器请求（在斑马线停靠时才请求，得到批准后不再发出请求
    public Material materialBall;


    public bool IsRequiring
    {
        get
        {
            return isRequiring;
        }

        set
        {
            isRequiring = value;
            if (value)
            {
                this.GetComponentInChildren<MeshRenderer>().material.color = Color.red;
               // materialBall.color = Color.red;
            }
            else
            {
                this.GetComponentInChildren<MeshRenderer>().material.color = Color.green;
              //  materialBall.color = Color.green;


            }
        }
    }


    // Use this for initialization
    void Start () {
        rig = this.GetComponent<Rigidbody>();
        rig.velocity = transform.forward*norVelocity;
      // print(this.GetComponent<BoxCollider>().bounds.size);//1.8   3.7


    }

    // Update is called once per frame
    void Update () {
#if PATH
        print(path.tv);
#endif
        if (isTurning)//转向模式
        {
            if (dir==Dire.Left)
            {
                transform.Rotate(new Vector3(0, -1, 0), norVelocity / radiusLeft * 180f / Mathf.PI * Time.deltaTime);
                rig.velocity = transform.forward * norVelocity;
            }
            else if (dir==Dire.Right)
            {
                transform.Rotate(new Vector3(0, 1, 0), norVelocity / radiusRight * 180f / Mathf.PI * Time.deltaTime);
                rig.velocity = transform.forward * norVelocity;
            }

        }

        if (IsRequiring)
        {
            carP= CarPath.CarPStartTime(carPStart, CentalHub.Instance.timer);//更新自己的路径
            if (CentalHub.Instance.Request(carP))//申请自己的路径
            {
            //    print("approvaled");
                isApproval = true;//被批准
                norVelocity = CentalHub.carVelocity;
                rig.velocity = transform.forward * norVelocity;//开始移动 v
                IsRequiring = false;//不再申请
            }
          
        }

    }

    
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "TurnLeft" && dir != Dire.Straight)//如果进入转向区域，则为转向模式
        {
            /*  print("testing cell!");
              rig.AddForce(-transform.right * ForceLeft);
              transform.RotateAround(transform.position - transform.right * radiusLeft, new Vector3(0, -1, 0), norVelocity/radiusLeft*180f/Mathf.PI*Time.deltaTime);
    */
            isTurning = true;
            
        }
    }

    //如果推出转向区域则为不转向模式
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "TurnLeft")//如果在转向区域，则为转向模式
        {
            isTurning = false;
        }
        else if (other.tag=="Player"&&!isTurning)//前面的车离开时，本车继续行驶
        {
            norVelocity = CentalHub.carVelocity;
            rig.velocity = transform.forward * norVelocity;

        }
    }
    


    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag=="Player"&&isApproval==false)//前面的车停下时，本车停再后方.已经被批准时无视后方车
        {
          //  print("car peng car");
            norVelocity = 0;
           // print("the front stop");
            rig.velocity = new Vector3(0,0,0);
        }
        else if (other.tag=="CentalTurn"&&!isApproval&&dir!=Dire.Right)//在斑马线，而且没有被批准，则停在斑马线处
        {
        //    print("car 斑马线");
            norVelocity = 0;
            rig.velocity = new Vector3(0, 0, 0);
            IsRequiring = true;//此时开始申请批准
          //  print("isRequiring"+isRequiring);
        }
        
    }

    public void SetPath(CarPath cp)
    {
        carPStart = cp;
    }


    //完成任务后销毁自身的路径
    private void OnDestroy()
    {
        CentalHub.Instance.FinishRequest(this.carP);
    }
}

public enum Dire
{
    Left,Right,Straight
}
