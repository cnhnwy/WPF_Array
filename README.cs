using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W数组
{
    class README
    {
        //有两个下标的数组称为二维数组

        //二维数组定义：


        //-----------------动态初始化:------------------------------

        //int [,]数组名 = new   类型[常量表达式1 ， 常量表达式2];
        //                          第一纬的长度    第二纬的长度
        //eg：
        //int[,] a = new int[5, 30];
        //Console.WriteLine(a[0,0]);

        //第一种动态初始化：
        //int[,] array = new int[2, 3] { { 1, 2, 3, }, { 4, 5, 6, } };
        //               2表示有两个对象，3表示每个对象里面有三个元素。    每个对象里面的元素数量必须一样。
        //第二种动态初始值：
        //int[,] map  = new int[ ,] { { 1, 2, 3, }, { 4, 5, 6, } };

        //
        //-----------------静态初始化：--------------------------------

        //类型[,]数组名={{具体数值1，具体数值2}，{具体数值3，具体数值4}……}
        //int[,] gameMap = { { 2, 3 }, { 4, 5 } };
        //eg:
        //int[,] b = { { 95, 80, 92 }, { 1, 2, 3 }, { 4, 5, 6 } };
        //int[,] c = { { 80, 92 }, { 2, 3 }, { 5, 6 } };

        //二维数组的元素也称为双下标变量。
        //---------------------行列-----------------------------
        //int[,] map  = new int[ ,] { { 1, 2, 3, }, { 4, 5, 6, } };
        //等同于：
        //int[,] map  = new int[ ,] { 
        //                             { 1, 2, 3, },
        //                             { 4, 5, 6, }
        //                           };


        //-----------------------练习---------------------------
        //1、将一个二维数组的行和列交换，存储到另外一个 数组中去。
        //int[,] a = new int[2, 3] { { 1, 3, 2, }, { 4, 3, 2 } };

        //Console.WriteLine(a.Length);      //6个元素
        //Console.WriteLine(a.GetLength(0));//2行
        //Console.WriteLine(a.GetLength(1));//3列

        //int[,] b = new int[3, 2];

        //for (int i = 0; i < a.GetLength(0); i++)
        //{
        //    for (int j = 0; j < a.GetLength(1); j++)
        //    {
        //        b[j, i] = a[i, j];
        //        Console.WriteLine("第" + i + "行" + "------" + "第" + j + "列" + "------" + a[i, j]);

        //    }
        //}


        //2、有一个3行4列的二维数组，要求编程找出最大元 素，并输出所在的行和列。
        //int[,] a = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

        //int max = int.MinValue;
        //int hang = 0;
        //int lie = 0;

        //for (int i = 0; i < a.GetLength(0); i++)
        //{
        //    for (int j = 0; j < a.GetLength(1); j++)
        //    {
        //        if (max < a[i, j])
        //        {
        //            max = a[i, j];
        //            hang = i;
        //            lie = j;
        //        }
        //    }
        //}
        //Console.WriteLine("最大值是： " + max + "         " + "第" + hang + "行" + "------" + "第" + lie + "列");

    }
}
