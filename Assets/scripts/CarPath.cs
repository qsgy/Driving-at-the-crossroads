using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CarPath {

    public  Cell[,] pathCells = new Cell[PathTesting.len, PathTesting.len];//一个元胞路径


   
    //判读两条路径是否冲突
    public static bool IsConflict(CarPath a,CarPath b)
    {
        bool result=false;//假设不冲突，只要有一个冲突，则是冲突
        for (int i = 0; i < PathTesting.len; i++)
        {
            for (int j = 0; j < PathTesting.len; j++)
            {
                if (Cell.IsConflict(a.pathCells[i, j], b.pathCells[i, j]))//只要有一个冲突
                {
                    result = true;//返回为冲突
                }
            }
        }
        return result;
    }

    //初始化路径，全部置零
    public void iniCarPath()
    {
        for (int i = 0; i < PathTesting.len; i++)
        {
            for (int j = 0; j < PathTesting.len; j++)
            {
               pathCells[i,j]=new Cell();
            }
        }
    }

    //打印
    public void PrintCells()
    {
        for (int i = 0; i < PathTesting.len; i++)
        {
            for (int j = 0; j < PathTesting.len; j++)
            {
                pathCells[i, j].PrintIF();
            }
        }
    }

#region Stright path
    //返回南去北的路径
    public static CarPath SToN()
    {
        CarPath result = new CarPath();
        result.iniCarPath();
        result.pathCells[35, 0].SetValue(0f, 0.3644673f, 35, 0);
        result.pathCells[36, 0].SetValue(0f, 0.3644673f, 36, 0);
        result.pathCells[37, 0].SetValue(0f, 0.3644673f, 37, 0);
        result.pathCells[38, 0].SetValue(0f, 0.3644673f, 38, 0);
        result.pathCells[39, 0].SetValue(0f, 0.3644673f, 39, 0);
        result.pathCells[35, 1].SetValue(0.03313161f, 0.3976002f, 35, 1);
        result.pathCells[36, 1].SetValue(0.03313161f, 0.3976002f, 36, 1);
        result.pathCells[37, 1].SetValue(0.03313161f, 0.3976002f, 37, 1);
        result.pathCells[38, 1].SetValue(0.03313161f, 0.3976002f, 38, 1);
        result.pathCells[39, 1].SetValue(0.03313161f, 0.3976002f, 39, 1);
        result.pathCells[35, 2].SetValue(0.06626545f, 0.4474385f, 35, 2);
        result.pathCells[36, 2].SetValue(0.06626545f, 0.4474385f, 36, 2);
        result.pathCells[37, 2].SetValue(0.06626545f, 0.4474385f, 37, 2);
        result.pathCells[38, 2].SetValue(0.06626545f, 0.4474385f, 38, 2);
        result.pathCells[39, 2].SetValue(0.06626545f, 0.4474385f, 39, 2);
        result.pathCells[35, 3].SetValue(0.09969662f, 0.4804328f, 35, 3);
        result.pathCells[36, 3].SetValue(0.09969662f, 0.4804328f, 36, 3);
        result.pathCells[37, 3].SetValue(0.09969662f, 0.4804328f, 37, 3);
        result.pathCells[38, 3].SetValue(0.09969662f, 0.4804328f, 38, 3);
        result.pathCells[39, 3].SetValue(0.09969662f, 0.4804328f, 39, 3);
        result.pathCells[35, 4].SetValue(0.1326189f, 0.5145595f, 35, 4);
        result.pathCells[36, 4].SetValue(0.1326189f, 0.5145595f, 36, 4);
        result.pathCells[37, 4].SetValue(0.1326189f, 0.5145595f, 37, 4);
        result.pathCells[38, 4].SetValue(0.1326189f, 0.5145595f, 38, 4);
        result.pathCells[39, 4].SetValue(0.1326189f, 0.5145595f, 39, 4);
        result.pathCells[35, 5].SetValue(0.1822332f, 0.5632667f, 35, 5);
        result.pathCells[36, 5].SetValue(0.1822332f, 0.5632667f, 36, 5);
        result.pathCells[37, 5].SetValue(0.1822332f, 0.5632667f, 37, 5);
        result.pathCells[38, 5].SetValue(0.1822332f, 0.5632667f, 38, 5);
        result.pathCells[39, 5].SetValue(0.1822332f, 0.5632667f, 39, 5);
        result.pathCells[35, 6].SetValue(0.2153662f, 0.5963979f, 35, 6);
        result.pathCells[36, 6].SetValue(0.2153662f, 0.5963979f, 36, 6);
        result.pathCells[37, 6].SetValue(0.2153662f, 0.5963979f, 37, 6);
        result.pathCells[38, 6].SetValue(0.2153662f, 0.5963979f, 38, 6);
        result.pathCells[39, 6].SetValue(0.2153662f, 0.5963979f, 39, 6);
        result.pathCells[35, 7].SetValue(0.2650667f, 0.6141326f, 35, 7);
        result.pathCells[36, 7].SetValue(0.2650667f, 0.6141326f, 36, 7);
        result.pathCells[37, 7].SetValue(0.2650667f, 0.6141326f, 37, 7);
        result.pathCells[38, 7].SetValue(0.2650667f, 0.6141326f, 38, 7);
        result.pathCells[39, 7].SetValue(0.2650667f, 0.6141326f, 39, 7);
        result.pathCells[35, 8].SetValue(0.2982018f, 0.6626669f, 35, 8);
        result.pathCells[36, 8].SetValue(0.2982018f, 0.6626669f, 36, 8);
        result.pathCells[37, 8].SetValue(0.2982018f, 0.6626669f, 37, 8);
        result.pathCells[38, 8].SetValue(0.2982018f, 0.6626669f, 38, 8);
        result.pathCells[39, 8].SetValue(0.2982018f, 0.6626669f, 39, 8);
        result.pathCells[35, 9].SetValue(0.331333f, 0.6960136f, 35, 9);
        result.pathCells[36, 9].SetValue(0.331333f, 0.6960136f, 36, 9);
        result.pathCells[37, 9].SetValue(0.331333f, 0.6960136f, 37, 9);
        result.pathCells[38, 9].SetValue(0.331333f, 0.6960136f, 38, 9);
        result.pathCells[39, 9].SetValue(0.331333f, 0.6960136f, 39, 9);
        result.pathCells[35, 10].SetValue(0.3813469f, 0.7454991f, 35, 10);
        result.pathCells[36, 10].SetValue(0.3813469f, 0.7454991f, 36, 10);
        result.pathCells[37, 10].SetValue(0.3813469f, 0.7454991f, 37, 10);
        result.pathCells[38, 10].SetValue(0.3813469f, 0.7454991f, 38, 10);
        result.pathCells[39, 10].SetValue(0.3813469f, 0.7454991f, 39, 10);
        result.pathCells[35, 11].SetValue(0.3976002f, 0.7786325f, 35, 11);
        result.pathCells[36, 11].SetValue(0.3976002f, 0.7786325f, 36, 11);
        result.pathCells[37, 11].SetValue(0.3976002f, 0.7786325f, 37, 11);
        result.pathCells[38, 11].SetValue(0.3976002f, 0.7786325f, 38, 11);
        result.pathCells[39, 11].SetValue(0.3976002f, 0.7786325f, 39, 11);
        result.pathCells[35, 12].SetValue(0.4474385f, 0.8117677f, 35, 12);
        result.pathCells[36, 12].SetValue(0.4474385f, 0.8117677f, 36, 12);
        result.pathCells[37, 12].SetValue(0.4474385f, 0.8117677f, 37, 12);
        result.pathCells[38, 12].SetValue(0.4474385f, 0.8117677f, 38, 12);
        result.pathCells[39, 12].SetValue(0.4474385f, 0.8117677f, 39, 12);
        result.pathCells[35, 13].SetValue(0.4804328f, 0.8614793f, 35, 13);
        result.pathCells[36, 13].SetValue(0.4804328f, 0.8614793f, 36, 13);
        result.pathCells[37, 13].SetValue(0.4804328f, 0.8614793f, 37, 13);
        result.pathCells[38, 13].SetValue(0.4804328f, 0.8614793f, 38, 13);
        result.pathCells[39, 13].SetValue(0.4804328f, 0.8614793f, 39, 13);
        result.pathCells[35, 14].SetValue(0.5145595f, 0.8945981f, 35, 14);
        result.pathCells[36, 14].SetValue(0.5145595f, 0.8945981f, 36, 14);
        result.pathCells[37, 14].SetValue(0.5145595f, 0.8945981f, 37, 14);
        result.pathCells[38, 14].SetValue(0.5145595f, 0.8945981f, 38, 14);
        result.pathCells[39, 14].SetValue(0.5145595f, 0.8945981f, 39, 14);
        result.pathCells[35, 15].SetValue(0.5632667f, 0.9442981f, 35, 15);
        result.pathCells[36, 15].SetValue(0.5632667f, 0.9442981f, 36, 15);
        result.pathCells[37, 15].SetValue(0.5632667f, 0.9442981f, 37, 15);
        result.pathCells[38, 15].SetValue(0.5632667f, 0.9442981f, 38, 15);
        result.pathCells[39, 15].SetValue(0.5632667f, 0.9442981f, 39, 15);
        result.pathCells[39, 16].SetValue(0.5963979f, 0.9608653f, 39, 16);
        result.pathCells[38, 16].SetValue(0.5963979f, 0.9608653f, 38, 16);
        result.pathCells[37, 16].SetValue(0.5963979f, 0.9608653f, 37, 16);
        result.pathCells[36, 16].SetValue(0.5963979f, 0.9608653f, 36, 16);
        result.pathCells[35, 16].SetValue(0.5963979f, 0.9608653f, 35, 16);
        result.pathCells[35, 17].SetValue(0.6460984f, 0.9946275f, 35, 17);
        result.pathCells[36, 17].SetValue(0.6460984f, 0.9946275f, 36, 17);
        result.pathCells[37, 17].SetValue(0.6460984f, 0.9946275f, 37, 17);
        result.pathCells[38, 17].SetValue(0.6460984f, 0.9946275f, 38, 17);
        result.pathCells[39, 17].SetValue(0.6460984f, 0.9946275f, 39, 17);
        result.pathCells[35, 18].SetValue(0.6795571f, 1.043938f, 35, 18);
        result.pathCells[36, 18].SetValue(0.6795571f, 1.043938f, 36, 18);
        result.pathCells[37, 18].SetValue(0.6795571f, 1.043938f, 37, 18);
        result.pathCells[38, 18].SetValue(0.6795571f, 1.043938f, 38, 18);
        result.pathCells[39, 18].SetValue(0.6795571f, 1.043938f, 39, 18);
        result.pathCells[35, 19].SetValue(0.7123661f, 1.076834f, 35, 19);
        result.pathCells[36, 19].SetValue(0.7123661f, 1.076834f, 36, 19);
        result.pathCells[37, 19].SetValue(0.7123661f, 1.076834f, 37, 19);
        result.pathCells[38, 19].SetValue(0.7123661f, 1.076834f, 38, 19);
        result.pathCells[39, 19].SetValue(0.7123661f, 1.076834f, 39, 19);
        result.pathCells[35, 20].SetValue(0.7454991f, 1.126556f, 35, 20);
        result.pathCells[36, 20].SetValue(0.7454991f, 1.126556f, 36, 20);
        result.pathCells[37, 20].SetValue(0.7454991f, 1.126556f, 37, 20);
        result.pathCells[38, 20].SetValue(0.7454991f, 1.126556f, 38, 20);
        result.pathCells[39, 20].SetValue(0.7454991f, 1.126556f, 39, 20);
        result.pathCells[35, 21].SetValue(0.7786325f, 1.159665f, 35, 21);
        result.pathCells[36, 21].SetValue(0.7786325f, 1.159665f, 36, 21);
        result.pathCells[37, 21].SetValue(0.7786325f, 1.159665f, 37, 21);
        result.pathCells[38, 21].SetValue(0.7786325f, 1.159665f, 38, 21);
        result.pathCells[39, 21].SetValue(0.7786325f, 1.159665f, 39, 21);
        result.pathCells[35, 22].SetValue(0.8117677f, 1.194057f, 35, 22);
        result.pathCells[36, 22].SetValue(0.8117677f, 1.194057f, 36, 22);
        result.pathCells[37, 22].SetValue(0.8117677f, 1.194057f, 37, 22);
        result.pathCells[38, 22].SetValue(0.8117677f, 1.194057f, 38, 22);
        result.pathCells[39, 22].SetValue(0.8117677f, 1.194057f, 39, 22);
        result.pathCells[35, 23].SetValue(0.8614793f, 1.242847f, 35, 23);
        result.pathCells[36, 23].SetValue(0.8614793f, 1.242847f, 36, 23);
        result.pathCells[37, 23].SetValue(0.8614793f, 1.242847f, 37, 23);
        result.pathCells[38, 23].SetValue(0.8614793f, 1.242847f, 38, 23);
        result.pathCells[39, 23].SetValue(0.8614793f, 1.242847f, 39, 23);
        result.pathCells[35, 24].SetValue(0.8945981f, 1.275906f, 35, 24);
        result.pathCells[36, 24].SetValue(0.8945981f, 1.275906f, 36, 24);
        result.pathCells[37, 24].SetValue(0.8945981f, 1.275906f, 37, 24);
        result.pathCells[38, 24].SetValue(0.8945981f, 1.275906f, 38, 24);
        result.pathCells[39, 24].SetValue(0.8945981f, 1.275906f, 39, 24);
        result.pathCells[35, 25].SetValue(0.9442981f, 1.292198f, 35, 25);
        result.pathCells[36, 25].SetValue(0.9442981f, 1.292198f, 36, 25);
        result.pathCells[37, 25].SetValue(0.9442981f, 1.292198f, 37, 25);
        result.pathCells[38, 25].SetValue(0.9442981f, 1.292198f, 38, 25);
        result.pathCells[39, 25].SetValue(0.9442981f, 1.292198f, 39, 25);
        result.pathCells[35, 26].SetValue(0.9774311f, 1.342161f, 35, 26);
        result.pathCells[36, 26].SetValue(0.9774311f, 1.342161f, 36, 26);
        result.pathCells[37, 26].SetValue(0.9774311f, 1.342161f, 37, 26);
        result.pathCells[38, 26].SetValue(0.9774311f, 1.342161f, 38, 26);
        result.pathCells[39, 26].SetValue(0.9774311f, 1.342161f, 39, 26);
        result.pathCells[35, 27].SetValue(1.02715f, 1.375032f, 35, 27);
        result.pathCells[36, 27].SetValue(1.02715f, 1.375032f, 36, 27);
        result.pathCells[37, 27].SetValue(1.02715f, 1.375032f, 37, 27);
        result.pathCells[38, 27].SetValue(1.02715f, 1.375032f, 38, 27);
        result.pathCells[39, 27].SetValue(1.02715f, 1.375032f, 39, 27);
        result.pathCells[35, 28].SetValue(1.060264f, 1.424733f, 35, 28);
        result.pathCells[36, 28].SetValue(1.060264f, 1.424733f, 36, 28);
        result.pathCells[37, 28].SetValue(1.060264f, 1.424733f, 37, 28);
        result.pathCells[38, 28].SetValue(1.060264f, 1.424733f, 38, 28);
        result.pathCells[39, 28].SetValue(1.060264f, 1.424733f, 39, 28);
        result.pathCells[35, 29].SetValue(1.076834f, 1.45794f, 35, 29);
        result.pathCells[36, 29].SetValue(1.076834f, 1.45794f, 36, 29);
        result.pathCells[37, 29].SetValue(1.076834f, 1.45794f, 37, 29);
        result.pathCells[38, 29].SetValue(1.076834f, 1.45794f, 38, 29);
        result.pathCells[39, 29].SetValue(1.076834f, 1.45794f, 39, 29);
        result.pathCells[35, 30].SetValue(1.126556f, 1.507774f, 35, 30);
        result.pathCells[36, 30].SetValue(1.126556f, 1.507774f, 36, 30);
        result.pathCells[37, 30].SetValue(1.126556f, 1.507774f, 37, 30);
        result.pathCells[38, 30].SetValue(1.126556f, 1.507774f, 38, 30);
        result.pathCells[39, 30].SetValue(1.126556f, 1.507774f, 39, 30);
        result.pathCells[35, 31].SetValue(1.159665f, 1.541105f, 35, 31);
        result.pathCells[36, 31].SetValue(1.159665f, 1.541105f, 36, 31);
        result.pathCells[37, 31].SetValue(1.159665f, 1.541105f, 37, 31);
        result.pathCells[38, 31].SetValue(1.159665f, 1.541105f, 38, 31);
        result.pathCells[39, 31].SetValue(1.159665f, 1.541105f, 39, 31);
        result.pathCells[35, 32].SetValue(1.194057f, 1.573841f, 35, 32);
        result.pathCells[36, 32].SetValue(1.194057f, 1.573841f, 36, 32);
        result.pathCells[37, 32].SetValue(1.194057f, 1.573841f, 37, 32);
        result.pathCells[38, 32].SetValue(1.194057f, 1.573841f, 38, 32);
        result.pathCells[39, 32].SetValue(1.194057f, 1.573841f, 39, 32);
        result.pathCells[35, 33].SetValue(1.242847f, 1.623533f, 35, 33);
        result.pathCells[36, 33].SetValue(1.242847f, 1.623533f, 36, 33);
        result.pathCells[37, 33].SetValue(1.242847f, 1.623533f, 37, 33);
        result.pathCells[38, 33].SetValue(1.242847f, 1.623533f, 38, 33);
        result.pathCells[39, 33].SetValue(1.242847f, 1.623533f, 39, 33);
        result.pathCells[35, 34].SetValue(1.275906f, 1.656666f, 35, 34);
        result.pathCells[36, 34].SetValue(1.275906f, 1.656666f, 36, 34);
        result.pathCells[37, 34].SetValue(1.275906f, 1.656666f, 37, 34);
        result.pathCells[38, 34].SetValue(1.275906f, 1.656666f, 38, 34);
        result.pathCells[39, 34].SetValue(1.275906f, 1.656666f, 39, 34);
        result.pathCells[35, 35].SetValue(1.325558f, 1.673231f, 35, 35);
        result.pathCells[36, 35].SetValue(1.325558f, 1.673231f, 36, 35);
        result.pathCells[37, 35].SetValue(1.325558f, 1.673231f, 37, 35);
        result.pathCells[38, 35].SetValue(1.325558f, 1.673231f, 38, 35);
        result.pathCells[39, 35].SetValue(1.325558f, 1.673231f, 39, 35);
        result.pathCells[35, 36].SetValue(1.358465f, 1.724092f, 35, 36);
        result.pathCells[36, 36].SetValue(1.358465f, 1.724092f, 36, 36);
        result.pathCells[37, 36].SetValue(1.358465f, 1.724092f, 37, 36);
        result.pathCells[38, 36].SetValue(1.358465f, 1.724092f, 38, 36);
        result.pathCells[39, 36].SetValue(1.358465f, 1.724092f, 39, 36);
        result.pathCells[35, 37].SetValue(1.391598f, 1.756073f, 35, 37);
        result.pathCells[36, 37].SetValue(1.391598f, 1.756073f, 36, 37);
        result.pathCells[37, 37].SetValue(1.391598f, 1.756073f, 37, 37);
        result.pathCells[38, 37].SetValue(1.391598f, 1.756073f, 38, 37);
        result.pathCells[39, 37].SetValue(1.391598f, 1.756073f, 39, 37);
        result.pathCells[35, 38].SetValue(1.424733f, 1.805765f, 35, 38);
        result.pathCells[36, 38].SetValue(1.424733f, 1.805765f, 36, 38);
        result.pathCells[37, 38].SetValue(1.424733f, 1.805765f, 37, 38);
        result.pathCells[38, 38].SetValue(1.424733f, 1.805765f, 38, 38);
        result.pathCells[39, 38].SetValue(1.424733f, 1.805765f, 39, 38);
        result.pathCells[35, 39].SetValue(1.45794f, 1.839061f, 35, 39);
        result.pathCells[36, 39].SetValue(1.45794f, 1.839061f, 36, 39);
        result.pathCells[37, 39].SetValue(1.45794f, 1.839061f, 37, 39);
        result.pathCells[38, 39].SetValue(1.45794f, 1.839061f, 38, 39);
        result.pathCells[39, 39].SetValue(1.45794f, 1.839061f, 39, 39);
        result.pathCells[35, 40].SetValue(1.507774f, 1.872032f, 35, 40);
        result.pathCells[36, 40].SetValue(1.507774f, 1.872032f, 36, 40);
        result.pathCells[37, 40].SetValue(1.507774f, 1.872032f, 37, 40);
        result.pathCells[38, 40].SetValue(1.507774f, 1.872032f, 38, 40);
        result.pathCells[39, 40].SetValue(1.507774f, 1.872032f, 39, 40);
        result.pathCells[35, 41].SetValue(1.541105f, 1.921732f, 35, 41);
        result.pathCells[36, 41].SetValue(1.541105f, 1.921732f, 36, 41);
        result.pathCells[37, 41].SetValue(1.541105f, 1.921732f, 37, 41);
        result.pathCells[38, 41].SetValue(1.541105f, 1.921732f, 38, 41);
        result.pathCells[39, 41].SetValue(1.541105f, 1.921732f, 39, 41);
        result.pathCells[35, 42].SetValue(1.573841f, 1.955055f, 35, 42);
        result.pathCells[36, 42].SetValue(1.573841f, 1.955055f, 36, 42);
        result.pathCells[37, 42].SetValue(1.573841f, 1.955055f, 37, 42);
        result.pathCells[38, 42].SetValue(1.573841f, 1.955055f, 38, 42);
        result.pathCells[39, 42].SetValue(1.573841f, 1.955055f, 39, 42);
        result.pathCells[35, 43].SetValue(1.623533f, 2.004845f, 35, 43);
        result.pathCells[36, 43].SetValue(1.623533f, 2.004845f, 36, 43);
        result.pathCells[37, 43].SetValue(1.623533f, 2.004845f, 37, 43);
        result.pathCells[38, 43].SetValue(1.623533f, 2.004845f, 38, 43);
        result.pathCells[39, 43].SetValue(1.623533f, 2.004845f, 39, 43);
        result.pathCells[35, 44].SetValue(1.656666f, 2.021132f, 35, 44);
        result.pathCells[36, 44].SetValue(1.656666f, 2.021132f, 36, 44);
        result.pathCells[37, 44].SetValue(1.656666f, 2.021132f, 37, 44);
        result.pathCells[38, 44].SetValue(1.656666f, 2.021132f, 38, 44);
        result.pathCells[39, 44].SetValue(1.656666f, 2.021132f, 39, 44);
        result.pathCells[35, 45].SetValue(1.706592f, 2.054265f, 35, 45);
        result.pathCells[36, 45].SetValue(1.706592f, 2.054265f, 36, 45);
        result.pathCells[37, 45].SetValue(1.706592f, 2.054265f, 37, 45);
        result.pathCells[38, 45].SetValue(1.706592f, 2.054265f, 38, 45);
        result.pathCells[39, 45].SetValue(1.706592f, 2.054265f, 39, 45);
        result.pathCells[35, 46].SetValue(1.739499f, 2.103965f, 35, 46);
        result.pathCells[36, 46].SetValue(1.739499f, 2.103965f, 36, 46);
        result.pathCells[37, 46].SetValue(1.739499f, 2.103965f, 37, 46);
        result.pathCells[38, 46].SetValue(1.739499f, 2.103965f, 38, 46);
        result.pathCells[39, 46].SetValue(1.739499f, 2.103965f, 39, 46);
        result.pathCells[35, 47].SetValue(1.772956f, 2.137261f, 35, 47);
        result.pathCells[36, 47].SetValue(1.772956f, 2.137261f, 36, 47);
        result.pathCells[37, 47].SetValue(1.772956f, 2.137261f, 37, 47);
        result.pathCells[38, 47].SetValue(1.772956f, 2.137261f, 38, 47);
        result.pathCells[39, 47].SetValue(1.772956f, 2.137261f, 39, 47);
        result.pathCells[35, 48].SetValue(1.805765f, 2.186798f, 35, 48);
        result.pathCells[36, 48].SetValue(1.805765f, 2.186798f, 36, 48);
        result.pathCells[37, 48].SetValue(1.805765f, 2.186798f, 37, 48);
        result.pathCells[38, 48].SetValue(1.805765f, 2.186798f, 38, 48);
        result.pathCells[39, 48].SetValue(1.805765f, 2.186798f, 39, 48);
        result.pathCells[35, 49].SetValue(1.839061f, 2.220083f, 35, 49);
        result.pathCells[36, 49].SetValue(1.839061f, 2.220083f, 36, 49);
        result.pathCells[37, 49].SetValue(1.839061f, 2.220083f, 37, 49);
        result.pathCells[38, 49].SetValue(1.839061f, 2.220083f, 38, 49);
        result.pathCells[39, 49].SetValue(1.839061f, 2.220083f, 39, 49);
        return result;
    }

    public static CarPath EToW()
    {
        CarPath resu = new CarPath();
        CarPath sToN = SToN();
        resu.iniCarPath();
        for (int i = 0; i < PathTesting.len; i++)
        {
            for (int j = 0; j < PathTesting.len; j++)
            {
                resu.pathCells[i, j] = sToN.pathCells[PathTesting.len - j-1, i];
            }
        }
        return resu;
    }

    public static CarPath WToE()
    {
        CarPath resu = new CarPath();
        CarPath sToN = EToW();
        resu.iniCarPath();
        for (int i = 0; i < PathTesting.len; i++)
        {
            for (int j = 0; j < PathTesting.len; j++)
            {
                resu.pathCells[i, j] = sToN.pathCells[PathTesting.len-1-i, PathTesting.len-1 - j];
            }
        }
        return resu;
    }

    public static CarPath NToS()
    {
        CarPath resu = new CarPath();
        CarPath sToN = SToN();
        resu.iniCarPath();
        for (int i = 0; i < PathTesting.len; i++)
        {
            for (int j = 0; j < PathTesting.len; j++)
            {
                resu.pathCells[i, j] = sToN.pathCells[PathTesting.len -1- i, PathTesting.len-1 - j];
            }
        }
        return resu;
    }
    #endregion

#region Turn path
    //南去西
    public static CarPath SToW()
    {
        CarPath result = new CarPath();
        result.iniCarPath();
        result.pathCells[27, 0].SetValue(0f, 0.3479055f, 27, 0);
        result.pathCells[28, 0].SetValue(0f, 0.3479055f, 28, 0);
        result.pathCells[29, 0].SetValue(0f, 0.3479055f, 29, 0);
        result.pathCells[30, 0].SetValue(0f, 0.3479055f, 30, 0);
        result.pathCells[31, 0].SetValue(0f, 0.3479055f, 31, 0);
        result.pathCells[27, 1].SetValue(0.03350361f, 0.3976003f, 27, 1);
        result.pathCells[28, 1].SetValue(0.03350361f, 0.3976003f, 28, 1);
        result.pathCells[29, 1].SetValue(0.03350361f, 0.3976003f, 29, 1);
        result.pathCells[30, 1].SetValue(0.03350361f, 0.3976003f, 30, 1);
        result.pathCells[31, 1].SetValue(0.03350361f, 0.3976003f, 31, 1);
        result.pathCells[27, 2].SetValue(0.04969964f, 0.4307337f, 27, 2);
        result.pathCells[28, 2].SetValue(0.04969964f, 0.4307337f, 28, 2);
        result.pathCells[29, 2].SetValue(0.04969964f, 0.4307337f, 29, 2);
        result.pathCells[30, 2].SetValue(0.04969964f, 0.4307337f, 30, 2);
        result.pathCells[31, 2].SetValue(0.04969964f, 0.4307337f, 31, 2);
        result.pathCells[27, 3].SetValue(0.09940018f, 0.4804502f, 27, 3);
        result.pathCells[28, 3].SetValue(0.09940018f, 0.4804502f, 28, 3);
        result.pathCells[29, 3].SetValue(0.09940018f, 0.4804502f, 29, 3);
        result.pathCells[30, 3].SetValue(0.09940018f, 0.4804502f, 30, 3);
        result.pathCells[31, 3].SetValue(0.09940018f, 0.4804502f, 31, 3);
        result.pathCells[27, 4].SetValue(0.1325331f, 0.5135729f, 27, 4);
        result.pathCells[28, 4].SetValue(0.1325331f, 0.5135729f, 28, 4);
        result.pathCells[29, 4].SetValue(0.1325331f, 0.5135729f, 29, 4);
        result.pathCells[30, 4].SetValue(0.1325331f, 0.5135729f, 30, 4);
        result.pathCells[31, 4].SetValue(0.1325331f, 0.5135729f, 31, 4);
        result.pathCells[31, 5].SetValue(0.1822328f, 0.5301334f, 31, 5);
        result.pathCells[31, 14].SetValue(0.5135729f, 0.5301334f, 31, 14);
        result.pathCells[27, 5].SetValue(0.1822328f, 0.5466992f, 27, 5);
        result.pathCells[28, 5].SetValue(0.1822328f, 0.5466992f, 28, 5);
        result.pathCells[29, 5].SetValue(0.1822328f, 0.5466992f, 29, 5);
        result.pathCells[30, 5].SetValue(0.1822328f, 0.5466992f, 30, 5);
        result.pathCells[31, 13].SetValue(0.4804502f, 0.579833f, 31, 13);
        result.pathCells[30, 6].SetValue(0.2154217f, 0.579833f, 30, 6);
        result.pathCells[31, 6].SetValue(0.2154217f, 0.579833f, 31, 6);
        result.pathCells[27, 6].SetValue(0.2154217f, 0.5963997f, 27, 6);
        result.pathCells[28, 6].SetValue(0.2154217f, 0.5963997f, 28, 6);
        result.pathCells[29, 6].SetValue(0.2154217f, 0.5963997f, 29, 6);
        result.pathCells[26, 10].SetValue(0.5301334f, 0.5963997f, 26, 10);
        result.pathCells[30, 7].SetValue(0.2486213f, 0.6129664f, 30, 7);
        result.pathCells[31, 7].SetValue(0.2486213f, 0.6129664f, 31, 7);
        result.pathCells[27, 7].SetValue(0.2486213f, 0.6300175f, 27, 7);
        result.pathCells[28, 7].SetValue(0.2486213f, 0.6300175f, 28, 7);
        result.pathCells[29, 7].SetValue(0.2486213f, 0.6300175f, 29, 7);
        result.pathCells[30, 8].SetValue(0.2982179f, 0.6626771f, 30, 8);
        result.pathCells[31, 8].SetValue(0.2982179f, 0.6626771f, 31, 8);
        result.pathCells[27, 8].SetValue(0.2982179f, 0.6797042f, 27, 8);
        result.pathCells[28, 8].SetValue(0.2982179f, 0.6797042f, 28, 8);
        result.pathCells[29, 8].SetValue(0.2982179f, 0.6797042f, 29, 8);
        result.pathCells[31, 9].SetValue(0.3313339f, 0.6797042f, 31, 9);
        result.pathCells[30, 17].SetValue(0.6129664f, 0.6797042f, 30, 17);
        result.pathCells[29, 9].SetValue(0.3313339f, 0.6957989f, 29, 9);
        result.pathCells[30, 9].SetValue(0.3313339f, 0.6957989f, 30, 9);
        result.pathCells[27, 9].SetValue(0.3313339f, 0.7123647f, 27, 9);
        result.pathCells[28, 9].SetValue(0.3313339f, 0.7123647f, 28, 9);
        result.pathCells[31, 10].SetValue(0.381034f, 0.7123647f, 31, 10);
        result.pathCells[26, 11].SetValue(0.5135729f, 0.7123647f, 26, 11);
        result.pathCells[30, 10].SetValue(0.381034f, 0.7289341f, 30, 10);
        result.pathCells[29, 10].SetValue(0.381034f, 0.7289341f, 29, 10);
        result.pathCells[27, 10].SetValue(0.381034f, 0.7620657f, 27, 10);
        result.pathCells[28, 10].SetValue(0.381034f, 0.7620657f, 28, 10);
        result.pathCells[31, 11].SetValue(0.3976003f, 0.7620657f, 31, 11);
        result.pathCells[30, 11].SetValue(0.3976003f, 0.7620657f, 30, 11);
        result.pathCells[29, 11].SetValue(0.3976003f, 0.7786324f, 29, 11);
        result.pathCells[31, 12].SetValue(0.4307337f, 0.7786324f, 31, 12);
        result.pathCells[27, 11].SetValue(0.3976003f, 0.7954267f, 27, 11);
        result.pathCells[28, 11].SetValue(0.3976003f, 0.7954267f, 28, 11);
        result.pathCells[30, 12].SetValue(0.4307337f, 0.7954267f, 30, 12);
        result.pathCells[26, 12].SetValue(0.5135729f, 0.7954267f, 26, 12);
        result.pathCells[29, 12].SetValue(0.4307337f, 0.8117649f, 29, 12);
        result.pathCells[31, 13].SetValue(0.6797042f, 0.8117649f, 31, 13);
        result.pathCells[27, 12].SetValue(0.4307337f, 0.8283316f, 27, 12);
        result.pathCells[28, 12].SetValue(0.4307337f, 0.8283316f, 28, 12);
        result.pathCells[30, 13].SetValue(0.4804502f, 0.8283316f, 30, 13);
        result.pathCells[31, 14].SetValue(0.7786324f, 0.8283316f, 31, 14);
        result.pathCells[29, 13].SetValue(0.4804502f, 0.8614655f, 29, 13);
        result.pathCells[30, 14].SetValue(0.5135729f, 0.8614655f, 30, 14);
        result.pathCells[28, 21].SetValue(0.7786324f, 0.8614655f, 28, 21);
        result.pathCells[28, 13].SetValue(0.4804502f, 0.8780348f, 28, 13);
        result.pathCells[27, 13].SetValue(0.4804502f, 0.8780348f, 27, 13);
        result.pathCells[29, 14].SetValue(0.5135729f, 0.8780348f, 29, 14);
        result.pathCells[26, 13].SetValue(0.4970004f, 0.8780348f, 26, 13);
        result.pathCells[28, 14].SetValue(0.5135729f, 0.8947771f, 28, 14);
        result.pathCells[30, 15].SetValue(0.5466992f, 0.8947771f, 30, 15);
        result.pathCells[25, 15].SetValue(0.6626771f, 0.8947771f, 25, 15);
        result.pathCells[27, 14].SetValue(0.5135729f, 0.9111655f, 27, 14);
        result.pathCells[29, 15].SetValue(0.5466992f, 0.9111655f, 29, 15);
        result.pathCells[26, 14].SetValue(0.5135729f, 0.9277344f, 26, 14);
        result.pathCells[28, 15].SetValue(0.5466992f, 0.9277344f, 28, 15);
        result.pathCells[30, 16].SetValue(0.579833f, 0.9277344f, 30, 16);
        result.pathCells[29, 16].SetValue(0.5963997f, 0.9277344f, 29, 16);
        result.pathCells[30, 17].SetValue(0.8614655f, 0.9612039f, 30, 17);
        result.pathCells[27, 15].SetValue(0.5466992f, 0.9612039f, 27, 15);
        result.pathCells[26, 24].SetValue(0.8947771f, 0.9612039f, 26, 24);
        result.pathCells[24, 17].SetValue(0.7786324f, 0.9612039f, 24, 17);
        result.pathCells[26, 15].SetValue(0.5466992f, 0.9774332f, 26, 15);
        result.pathCells[28, 16].SetValue(0.5963997f, 0.9774332f, 28, 16);
        result.pathCells[29, 17].SetValue(0.6129664f, 0.9774332f, 29, 17);
        result.pathCells[27, 16].SetValue(0.5963997f, 0.9940017f, 27, 16);
        result.pathCells[29, 18].SetValue(0.6626771f, 0.9940017f, 29, 18);
        result.pathCells[28, 17].SetValue(0.6300175f, 0.9940017f, 28, 17);
        result.pathCells[25, 16].SetValue(0.6300175f, 1.010567f, 25, 16);
        result.pathCells[26, 16].SetValue(0.5963997f, 1.010567f, 26, 16);
        result.pathCells[25, 25].SetValue(0.9277344f, 1.010567f, 25, 25);
        result.pathCells[27, 17].SetValue(0.6300175f, 1.010567f, 27, 17);
        result.pathCells[29, 19].SetValue(0.6957989f, 1.027143f, 29, 19);
        result.pathCells[28, 18].SetValue(0.6626771f, 1.027143f, 28, 18);
        result.pathCells[26, 17].SetValue(0.6300175f, 1.027143f, 26, 17);
        result.pathCells[25, 17].SetValue(0.6626771f, 1.060266f, 25, 17);
        result.pathCells[27, 18].SetValue(0.6797042f, 1.060266f, 27, 18);
        result.pathCells[28, 19].SetValue(0.6957989f, 1.060266f, 28, 19);
        result.pathCells[24, 26].SetValue(0.9940017f, 1.060266f, 24, 26);
        result.pathCells[28, 20].SetValue(0.7289341f, 1.076833f, 28, 20);
        result.pathCells[26, 18].SetValue(0.6797042f, 1.076833f, 26, 18);
        result.pathCells[27, 19].SetValue(0.7123647f, 1.076833f, 27, 19);
        result.pathCells[23, 27].SetValue(1.027143f, 1.076833f, 23, 27);
        result.pathCells[28, 21].SetValue(0.9612039f, 1.093401f, 28, 21);
        result.pathCells[27, 20].SetValue(0.7289341f, 1.093401f, 27, 20);
        result.pathCells[25, 18].SetValue(0.6957989f, 1.093401f, 25, 18);
        result.pathCells[26, 19].SetValue(0.7123647f, 1.093401f, 26, 19);
        result.pathCells[24, 18].SetValue(0.7289341f, 1.110152f, 24, 18);
        result.pathCells[23, 19].SetValue(0.8283316f, 1.110152f, 23, 19);
        result.pathCells[22, 20].SetValue(0.9612039f, 1.110152f, 22, 20);
        result.pathCells[21, 21].SetValue(1.060266f, 1.110152f, 21, 21);
        result.pathCells[26, 20].SetValue(0.7620657f, 1.143098f, 26, 20);
        result.pathCells[25, 19].SetValue(0.7289341f, 1.143098f, 25, 19);
        result.pathCells[27, 21].SetValue(0.7786324f, 1.143098f, 27, 21);
        result.pathCells[27, 23].SetValue(1.143098f, 1.159666f, 27, 23);
        result.pathCells[27, 22].SetValue(0.8117649f, 1.159666f, 27, 22);
        result.pathCells[24, 19].SetValue(0.7289341f, 1.159666f, 24, 19);
        result.pathCells[25, 20].SetValue(0.7786324f, 1.159666f, 25, 20);
        result.pathCells[26, 21].SetValue(0.7954267f, 1.159666f, 26, 21);
        result.pathCells[26, 22].SetValue(0.8117649f, 1.176248f, 26, 22);
        result.pathCells[25, 21].SetValue(0.7954267f, 1.176248f, 25, 21);
        result.pathCells[24, 20].SetValue(0.7786324f, 1.192799f, 24, 20);
        result.pathCells[26, 23].SetValue(0.8614655f, 1.192799f, 26, 23);
        result.pathCells[23, 20].SetValue(0.7954267f, 1.192799f, 23, 20);
        result.pathCells[20, 22].SetValue(1.093401f, 1.192799f, 20, 22);
        result.pathCells[26, 24].SetValue(1.143098f, 1.210379f, 26, 24);
        result.pathCells[25, 22].SetValue(0.8283316f, 1.210379f, 25, 22);
        result.pathCells[24, 21].SetValue(0.8117649f, 1.210379f, 24, 21);
        result.pathCells[24, 22].SetValue(0.8614655f, 1.242506f, 24, 22);
        result.pathCells[20, 29].SetValue(1.159666f, 1.242506f, 20, 29);
        result.pathCells[25, 23].SetValue(0.8780348f, 1.242506f, 25, 23);
        result.pathCells[25, 25].SetValue(1.159666f, 1.259113f, 25, 25);
        result.pathCells[25, 24].SetValue(0.8947771f, 1.259113f, 25, 24);
        result.pathCells[22, 21].SetValue(0.8780348f, 1.259113f, 22, 21);
        result.pathCells[23, 21].SetValue(0.8283316f, 1.259113f, 23, 21);
        result.pathCells[24, 23].SetValue(0.8947771f, 1.259113f, 24, 23);
        result.pathCells[23, 22].SetValue(0.8780348f, 1.275637f, 23, 22);
        result.pathCells[24, 24].SetValue(0.9111655f, 1.275637f, 24, 24);
        result.pathCells[24, 25].SetValue(0.9612039f, 1.292201f, 24, 25);
        result.pathCells[23, 23].SetValue(0.8947771f, 1.292201f, 23, 23);
        result.pathCells[24, 26].SetValue(1.210379f, 1.308908f, 24, 26);
        result.pathCells[21, 22].SetValue(0.9277344f, 1.308908f, 21, 22);
        result.pathCells[22, 22].SetValue(0.8947771f, 1.308908f, 22, 22);
        result.pathCells[23, 24].SetValue(0.9277344f, 1.308908f, 23, 24);
        result.pathCells[19, 23].SetValue(1.110152f, 1.308908f, 19, 23);
        result.pathCells[18, 30].SetValue(1.210379f, 1.341898f, 18, 30);
        result.pathCells[23, 25].SetValue(0.9774332f, 1.341898f, 23, 25);
        result.pathCells[16, 31].SetValue(1.308908f, 1.341898f, 16, 31);
        result.pathCells[22, 23].SetValue(0.9111655f, 1.341898f, 22, 23);
        result.pathCells[23, 27].SetValue(1.292201f, 1.358466f, 23, 27);
        result.pathCells[23, 26].SetValue(0.9940017f, 1.358466f, 23, 26);
        result.pathCells[22, 24].SetValue(0.9612039f, 1.358466f, 22, 24);
        result.pathCells[22, 25].SetValue(0.9940017f, 1.358466f, 22, 25);
        result.pathCells[21, 23].SetValue(0.9612039f, 1.358466f, 21, 23);
        result.pathCells[20, 23].SetValue(0.9940017f, 1.375031f, 20, 23);
        result.pathCells[21, 24].SetValue(0.9774332f, 1.375031f, 21, 24);
        result.pathCells[22, 26].SetValue(1.010567f, 1.375031f, 22, 26);
        result.pathCells[22, 28].SetValue(1.375031f, 1.391598f, 22, 28);
        result.pathCells[22, 27].SetValue(1.027143f, 1.391598f, 22, 27);
        result.pathCells[21, 25].SetValue(1.010567f, 1.391598f, 21, 25);
        result.pathCells[20, 24].SetValue(0.9940017f, 1.408172f, 20, 24);
        result.pathCells[21, 26].SetValue(1.027143f, 1.408172f, 21, 26);
        result.pathCells[18, 24].SetValue(1.110152f, 1.408172f, 18, 24);
        result.pathCells[21, 28].SetValue(1.093401f, 1.441415f, 21, 28);
        result.pathCells[21, 27].SetValue(1.076833f, 1.441415f, 21, 27);
        result.pathCells[19, 24].SetValue(1.027143f, 1.441415f, 19, 24);
        result.pathCells[20, 25].SetValue(1.027143f, 1.441415f, 20, 25);
        result.pathCells[20, 26].SetValue(1.060266f, 1.457865f, 20, 26);
        result.pathCells[20, 27].SetValue(1.093401f, 1.457865f, 20, 27);
        result.pathCells[20, 29].SetValue(1.391598f, 1.474457f, 20, 29);
        result.pathCells[20, 28].SetValue(1.110152f, 1.474457f, 20, 28);
        result.pathCells[16, 25].SetValue(1.242506f, 1.474457f, 16, 25);
        result.pathCells[19, 25].SetValue(1.060266f, 1.474457f, 19, 25);
        result.pathCells[19, 26].SetValue(1.093401f, 1.474457f, 19, 26);
        result.pathCells[13, 26].SetValue(1.474457f, 1.491f, 13, 26);
        result.pathCells[19, 28].SetValue(1.143098f, 1.491f, 19, 28);
        result.pathCells[12, 32].SetValue(1.441415f, 1.491f, 12, 32);
        result.pathCells[19, 27].SetValue(1.110152f, 1.491f, 19, 27);
        result.pathCells[19, 29].SetValue(1.176248f, 1.507569f, 19, 29);
        result.pathCells[17, 25].SetValue(1.143098f, 1.507569f, 17, 25);
        result.pathCells[18, 26].SetValue(1.110152f, 1.507569f, 18, 26);
        result.pathCells[18, 25].SetValue(1.093401f, 1.507569f, 18, 25);
        result.pathCells[18, 28].SetValue(1.176248f, 1.540702f, 18, 28);
        result.pathCells[18, 27].SetValue(1.159666f, 1.540702f, 18, 27);
        result.pathCells[18, 30].SetValue(1.457865f, 1.557266f, 18, 30);
        result.pathCells[18, 29].SetValue(1.192799f, 1.557266f, 18, 29);
        result.pathCells[11, 32].SetValue(1.457865f, 1.557266f, 11, 32);
        result.pathCells[17, 26].SetValue(1.159666f, 1.557266f, 17, 26);
        result.pathCells[17, 29].SetValue(1.210379f, 1.573845f, 17, 29);
        result.pathCells[17, 28].SetValue(1.192799f, 1.573845f, 17, 28);
        result.pathCells[17, 27].SetValue(1.176248f, 1.573845f, 17, 27);
        result.pathCells[17, 30].SetValue(1.242506f, 1.590401f, 17, 30);
        result.pathCells[16, 26].SetValue(1.192799f, 1.590401f, 16, 26);
        result.pathCells[14, 26].SetValue(1.292201f, 1.590401f, 14, 26);
        result.pathCells[15, 26].SetValue(1.242506f, 1.606966f, 15, 26);
        result.pathCells[16, 28].SetValue(1.242506f, 1.606966f, 16, 28);
        result.pathCells[16, 29].SetValue(1.259113f, 1.606966f, 16, 29);
        result.pathCells[16, 30].SetValue(1.275637f, 1.606966f, 16, 30);
        result.pathCells[16, 27].SetValue(1.210379f, 1.606966f, 16, 27);
        result.pathCells[16, 31].SetValue(1.573845f, 1.606966f, 16, 31);
        result.pathCells[15, 31].SetValue(1.308908f, 1.656666f, 15, 31);
        result.pathCells[15, 30].SetValue(1.292201f, 1.656666f, 15, 30);
        result.pathCells[15, 29].SetValue(1.275637f, 1.656666f, 15, 29);
        result.pathCells[15, 28].SetValue(1.259113f, 1.656666f, 15, 28);
        result.pathCells[15, 27].SetValue(1.242506f, 1.656666f, 15, 27);
        result.pathCells[10, 32].SetValue(1.491f, 1.656666f, 10, 32);
        result.pathCells[14, 31].SetValue(1.358466f, 1.689798f, 14, 31);
        result.pathCells[14, 30].SetValue(1.341898f, 1.689798f, 14, 30);
        result.pathCells[14, 29].SetValue(1.308908f, 1.689798f, 14, 29);
        result.pathCells[14, 28].SetValue(1.292201f, 1.689798f, 14, 28);
        result.pathCells[14, 27].SetValue(1.275637f, 1.689798f, 14, 27);
        result.pathCells[13, 32].SetValue(1.722934f, 1.7395f, 13, 32);
        result.pathCells[13, 31].SetValue(1.375031f, 1.7395f, 13, 31);
        result.pathCells[13, 30].SetValue(1.375031f, 1.7395f, 13, 30);
        result.pathCells[13, 29].SetValue(1.358466f, 1.7395f, 13, 29);
        result.pathCells[13, 28].SetValue(1.341898f, 1.7395f, 13, 28);
        result.pathCells[13, 27].SetValue(1.308908f, 1.7395f, 13, 27);
        result.pathCells[5, 32].SetValue(1.656666f, 1.7395f, 5, 32);
        result.pathCells[4, 32].SetValue(1.689798f, 1.7395f, 4, 32);
        result.pathCells[12, 32].SetValue(1.722934f, 1.756066f, 12, 32);
        result.pathCells[12, 31].SetValue(1.408172f, 1.756066f, 12, 31);
        result.pathCells[12, 30].SetValue(1.391598f, 1.772633f, 12, 30);
        result.pathCells[12, 29].SetValue(1.375031f, 1.772633f, 12, 29);
        result.pathCells[12, 28].SetValue(1.375031f, 1.772633f, 12, 28);
        result.pathCells[12, 27].SetValue(1.358466f, 1.772633f, 12, 27);
        result.pathCells[11, 32].SetValue(1.722934f, 1.790169f, 11, 32);
        result.pathCells[11, 31].SetValue(1.457865f, 1.790169f, 11, 31);
        result.pathCells[11, 30].SetValue(1.441415f, 1.790169f, 11, 30);
        result.pathCells[11, 29].SetValue(1.408172f, 1.790169f, 11, 29);
        result.pathCells[11, 28].SetValue(1.391598f, 1.822333f, 11, 28);
        result.pathCells[11, 27].SetValue(1.391598f, 1.822333f, 11, 27);
        result.pathCells[10, 28].SetValue(1.457865f, 1.8389f, 10, 28);
        result.pathCells[10, 31].SetValue(1.474457f, 1.8389f, 10, 31);
        result.pathCells[10, 32].SetValue(1.689798f, 1.8389f, 10, 32);
        result.pathCells[10, 30].SetValue(1.474457f, 1.8389f, 10, 30);
        result.pathCells[10, 27].SetValue(1.474457f, 1.8389f, 10, 27);
        result.pathCells[10, 29].SetValue(1.457865f, 1.8389f, 10, 29);
        result.pathCells[9, 32].SetValue(1.540702f, 1.872032f, 9, 32);
        result.pathCells[9, 31].SetValue(1.507569f, 1.872032f, 9, 31);
        result.pathCells[9, 30].SetValue(1.507569f, 1.872032f, 9, 30);
        result.pathCells[9, 29].SetValue(1.491f, 1.872032f, 9, 29);
        result.pathCells[9, 28].SetValue(1.491f, 1.872032f, 9, 28);
        result.pathCells[9, 27].SetValue(1.540702f, 1.872032f, 9, 27);
        result.pathCells[8, 32].SetValue(1.557266f, 1.921733f, 8, 32);
        result.pathCells[8, 31].SetValue(1.557266f, 1.921733f, 8, 31);
        result.pathCells[8, 30].SetValue(1.557266f, 1.921733f, 8, 30);
        result.pathCells[8, 29].SetValue(1.540702f, 1.921733f, 8, 29);
        result.pathCells[8, 28].SetValue(1.540702f, 1.921733f, 8, 28);
        result.pathCells[8, 27].SetValue(1.606966f, 1.921733f, 8, 27);
        result.pathCells[7, 32].SetValue(1.590401f, 1.955294f, 7, 32);
        result.pathCells[7, 31].SetValue(1.590401f, 1.955294f, 7, 31);
        result.pathCells[7, 30].SetValue(1.573845f, 1.955294f, 7, 30);
        result.pathCells[7, 29].SetValue(1.573845f, 1.955294f, 7, 29);
        result.pathCells[7, 28].SetValue(1.573845f, 1.955294f, 7, 28);
        result.pathCells[7, 27].SetValue(1.656666f, 1.955294f, 7, 27);
        result.pathCells[6, 32].SetValue(1.640136f, 1.971433f, 6, 32);
        result.pathCells[6, 31].SetValue(1.640136f, 1.988f, 6, 31);
        result.pathCells[6, 30].SetValue(1.606966f, 1.988f, 6, 30);
        result.pathCells[6, 29].SetValue(1.606966f, 1.988f, 6, 29);
        result.pathCells[6, 28].SetValue(1.606966f, 1.988f, 6, 28);
        result.pathCells[6, 27].SetValue(1.673233f, 1.988f, 6, 27);
        result.pathCells[5, 31].SetValue(1.656666f, 2.037711f, 5, 31);
        result.pathCells[5, 30].SetValue(1.656666f, 2.037711f, 5, 30);
        result.pathCells[5, 29].SetValue(1.656666f, 2.037711f, 5, 29);
        result.pathCells[5, 28].SetValue(1.656666f, 2.037711f, 5, 28);
        result.pathCells[5, 27].SetValue(1.689798f, 2.037711f, 5, 27);
        result.pathCells[4, 31].SetValue(1.689798f, 2.070999f, 4, 31);
        result.pathCells[4, 30].SetValue(1.689798f, 2.070999f, 4, 30);
        result.pathCells[4, 29].SetValue(1.689798f, 2.070999f, 4, 29);
        result.pathCells[4, 28].SetValue(1.689798f, 2.070999f, 4, 28);
        result.pathCells[4, 27].SetValue(1.722934f, 2.070999f, 4, 27);
        result.pathCells[3, 31].SetValue(1.7395f, 2.087401f, 3, 31);
        result.pathCells[3, 30].SetValue(1.7395f, 2.120768f, 3, 30);
        result.pathCells[3, 29].SetValue(1.7395f, 2.120768f, 3, 29);
        result.pathCells[3, 28].SetValue(1.7395f, 2.120768f, 3, 28);
        result.pathCells[3, 27].SetValue(1.7395f, 2.120768f, 3, 27);
        result.pathCells[2, 29].SetValue(1.772633f, 2.137196f, 2, 29);
        result.pathCells[2, 30].SetValue(1.772633f, 2.137196f, 2, 30);
        result.pathCells[2, 31].SetValue(1.772633f, 2.137196f, 2, 31);
        result.pathCells[2, 28].SetValue(1.772633f, 2.153721f, 2, 28);
        result.pathCells[2, 27].SetValue(1.772633f, 2.153721f, 2, 27);
        result.pathCells[1, 28].SetValue(1.822333f, 2.170621f, 1, 28);
        result.pathCells[1, 30].SetValue(1.822333f, 2.170621f, 1, 30);
        result.pathCells[1, 31].SetValue(1.822333f, 2.170621f, 1, 31);
        result.pathCells[1, 29].SetValue(1.822333f, 2.170621f, 1, 29);
        result.pathCells[1, 27].SetValue(1.822333f, 2.170621f, 1, 27);
        result.pathCells[0, 31].SetValue(1.855466f, 2.219934f, 0, 31);
        result.pathCells[0, 30].SetValue(1.855466f, 2.219934f, 0, 30);
        result.pathCells[0, 29].SetValue(1.855466f, 2.219934f, 0, 29);
        result.pathCells[0, 28].SetValue(1.855466f, 2.219934f, 0, 28);
        result.pathCells[0, 27].SetValue(1.855466f, 2.219934f, 0, 27);


        return result;
    }

    public static CarPath NToE()
    {
        CarPath resu = new CarPath();
        CarPath sToN = SToW();
        resu.iniCarPath();
        for (int i = 0; i < PathTesting.len; i++)
        {
            for (int j = 0; j < PathTesting.len; j++)
            {
                resu.pathCells[i, j] = sToN.pathCells[PathTesting.len-1 - i, PathTesting.len-1 - j];
            }
        }
        return resu;
    }

    public static CarPath EToS()
    {
        CarPath resu = new CarPath();
        CarPath sToN = SToW();
        resu.iniCarPath();
        for (int i = 0; i < PathTesting.len; i++)
        {
            for (int j = 0; j < PathTesting.len; j++)
            {
                resu.pathCells[i, j] = sToN.pathCells[PathTesting.len - j-1, i];
            }
        }
        return resu;
    }

    public static CarPath WToN()
    {
        CarPath resu = new CarPath();
        CarPath sToN = EToS();
        resu.iniCarPath();
        for (int i = 0; i < PathTesting.len; i++)
        {
            for (int j = 0; j < PathTesting.len; j++)
            {
                resu.pathCells[i, j] = sToN.pathCells[PathTesting.len-1 - i, PathTesting.len -1- j];
            }
        }
        return resu;
    }
#endregion
    // public static CarPath 

    public static CarPath CarPStartTime(CarPath carp, float startTime)
    {
        CarPath clone = new CarPath();
        clone.iniCarPath();
        
        for (int i = 0; i < PathTesting.len; i++)
        {
            for (int j = 0; j < PathTesting.len; j++)
            {
                clone.pathCells[i,j].startTime= carp.pathCells[i, j].startTime + startTime;
                clone.pathCells[i,j].endTime= carp.pathCells[i, j].endTime + startTime;
            }
        }
        return clone;
    }
}
