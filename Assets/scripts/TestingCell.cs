using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingCell : MonoBehaviour{
    bool isOccupy = false;//是否占用位置
    public float startTime;//车占用的起始时间。未被占用方格时为0
    public float endTime;
    public int x, y;//index
    public static string testText = "";//每次实验需要得到的代码文本

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        startTime = CentalHub.Instance.timer;
        this.GetComponent<MeshRenderer>().enabled = true;//show the paht with cube
       // print("Entered");//debug
    }

    private void OnTriggerExit(Collider other)
    {
        endTime = CentalHub.Instance.timer;
        // print("Exit");//debug
        // print("new Cell(" + startTime + "," + endTime + "," + isOccupy + ")" + "["+x+","+y+"]");
       // PathTesting.Instance.testPath.pathCells[x, y].SetValue(startTime,endTime,x,y);
        testText += "result.pathCells["+x+", "+y+"].SetValue("+startTime+"f,"+endTime+"f,"+x+","+y+");\n";
    }

    //打印代码
    public static void PrintResults()
    {
        print(TestingCell.testText);
    }
}
