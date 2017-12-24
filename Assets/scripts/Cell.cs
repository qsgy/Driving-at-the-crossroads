using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Cell
{
    public bool isOccupy = false;//是否占用了这个元胞机
    public float startTime = 0;
    public float endTime=0;
    public int x, y;

    public Cell(float start, float end,bool oc,int x,int y)
    {
        endTime = end;
        startTime = start;
        isOccupy = oc;
        this.x = x;
        this.y = y;
    }

    public Cell()
    {
        
    }

    //设置占用时间，默认占用了这个元胞
    public void SetValue(float start, float end, int x, int y)
    {
        endTime = end;
        startTime = start;
        isOccupy = true;
        this.x = x;
        this.y = y;
    }
    //判断两个同位置元胞是否时间冲突
    public static bool IsConflict(Cell a,Cell b)
    {
        if (a.startTime>b.endTime||b.startTime>a.endTime)//如果a开始时间大于b结束时间，则两者不会冲突,返回false
        {
            return false;
        }
        return true;
    }

    public void PrintIF()
    {
        MonoBehaviour.print("new Cell("+startTime+","+endTime+","+isOccupy+","+x+","+y+")"+",");
    }
}
