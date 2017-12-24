using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PathTesting : MonoBehaviour {
    static PathTesting instance;//单例
    public const int len = 50;
    public Vector3 startPos;
    public GameObject[,] Cells=new GameObject[len ,len];
    public GameObject cell;
    public float cellScale;//检测胞相较于原来的倍数
    public CarPath strightPath=new CarPath();
    public CarPath rightPath = new CarPath();
    public CarPath leftPath = new CarPath();

    public string result = "";

    //单例模式
    public static PathTesting Instance
    {
        get
        {
            return instance;
        }

        set
        {
            instance = value;
        }
    }

    private void Awake()
    {
        Instance = this;
    }
    // Use this for initialization
    void Start () {
        cellScale = CentalHub.D / (float)len;//初始化胞体大小
        startPos = this.GetComponent<Transform>().position;
        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < len; j++)
            {
                Cells[i, j] =Instantiate(cell,startPos+new Vector3(((float)i+0.5f)*cellScale,0f,((float)j+0.5f)*cellScale),Quaternion.identity);
                Cells[i, j].transform.localScale = new Vector3(cellScale,1f,cellScale);//设置大小
                Cells[i, j].GetComponent<TestingCell>().x = i;//设置排列位置
                Cells[i, j].GetComponent<TestingCell>().y = j;
                Cells[i, j].transform.SetParent(transform);//将pathtesting设置为父物体
                //在场景中，从z洲正方向看过去，i为列，j为行
            }
        }

       // testPath.iniCells();//初始化测试路径

    }



    public void PrintPath()
    {

        // testPath.PrintCells();
        TestingCell.PrintResults();
        if (!File.Exists("D:\\TestTxt.txt"))
        {
            FileStream fs1 = new FileStream("D:\\TestTxt.txt", FileMode.Create, FileAccess.Write);//创建写入文件 
            StreamWriter sw = new StreamWriter(fs1);
            sw.WriteLine(TestingCell.testText);//开始写入值
            sw.Close();
            fs1.Close();
        }
        else
        {
            FileStream fs = new FileStream("D:\\TestTxt.txt", FileMode.Open, FileAccess.Write);
            StreamWriter sr = new StreamWriter(fs);
            sr.WriteLine(TestingCell.testText);//开始写入值
            sr.Close();
            fs.Close();
        }
    }
}
