using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() // 最初に一回だけ実行
    {
        // ここにクラスの処理を書く

        // Hello, Worldを表示する
        Debug.Log("Hello, World.");

        // p65
        // 変数
        // ■int, 整数型, -2,147,483,648 ～ 2,147,483,647
        // ■float, 浮動小数点型, -3.402823E+38 ～ 3.402823E+38
        // ■double, 倍精度浮動小数点型, -1.79769313486232E+308 ～ 1.79769313486232E+308
        // ■bool, ブール型, true or false
        // ■char, 文字型, ★テキストで使用されるUnicode記号
        // ■string, 文字列型, テキスト

        int age; // 型名 変数名
        age = 30;
        Debug.Log(age);

        // p66 変数の初期化と代入
        float hight1 = 160.5f; // fを付けてfloat指定。つけないとdouble指定になるので注意
        float hight2;
        hight2 = hight1;
        Debug.Log(hight2);

        // 文字列
        string name;
        name = "Kitamura";
        Debug.Log(name);

        // 四則演算
        int answer;
        answer = 1 + 2;
        Debug.Log(answer);

        answer = 3 - 4;
        Debug.Log(answer);

        answer = 5 * 6;
        Debug.Log(answer);

        answer = 8 / 4;
        Debug.Log(answer);

        // 変数同士の演算
        int n1 = 8;
        int n2 = 9;
        answer = n1 + n2;
        Debug.Log(answer);

        // 便利な書き方1
        int answer2 = 10;
        answer2 += 5;
        Debug.Log(answer2);

        // 便利な書き方2
        int answer3 = 10;
        answer3++;
        Debug.Log(answer3);

        // 文字列の連結
        string str1 = "happy";
        string str2 = "birthday";
        string message;

        message = str1 + str2;
        Debug.Log(message);

        str1 += str2;
        Debug.Log(str1);

        // 文字列と数値の連結
        string str3 = "happy ";
        int num3 = 123;
        string message3 = str3 + num3;
        Debug.Log(message3);

        // 制御文
        int hurbnum = 1;
        if (hurbnum == 1)
        {
            Debug.Log("HPが50回復");
        }

        // if else
        int hp2 = 200;
        if (hp2 >= 100)
        {
            Debug.Log("攻撃！");
        }
        else
        {
            Debug.Log("防御！");
        }

        // else if
        int hp3 = 180;
        if (hp3 <= 50)
        {
            Debug.Log("逃走2！");
        }
        else if (hp3 >= 200)
        {
            Debug.Log("攻撃2！");
        }
        else
        {
            Debug.Log("防御2！");
        }

        //  変数のスコープ
        int x83 = 1;
        if (x83 == 1)
        {
            int y83 = 2;
            Debug.Log(x83);
            Debug.Log(y83);
        }
        // Debug.Log(y83);//Assets\Test.cs(127,19): error CS0103: The name 'y83' does not exist in the current context

        // for文、p84
        for(int i = 0; i< 5; i++)
        {
            Debug.Log(i);
        }

        // 配列,p89
        int[] points = new int[5];// 書き方

        int[] num_ary = new int[5];
        num_ary[0] = 74;
        num_ary[1] = 86;
        num_ary[2] = 12;
        num_ary[3] = 90;
        num_ary[4] = 53;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(num_ary[i]);
        }

        Debug.Log("\n\n");

        // 配列内の条件を満たす要素だけを抽出
        int[] num_ary2 = { 83, 99, 52, 93, 25 };
        for (int i = 0; i < num_ary2.Length; i++)
        {
            if (num_ary2[i] >= 90)
            {
                Debug.Log(num_ary2[i]);
            }
        }

        // 平均値を求めるサンプル
        int[] num_ary3 = { 83, 99, 52, 93, 15 };
        int sum = 0;
        for (int i = 0; i < num_ary3.Length; i++)
        {
            sum += num_ary3[i];
        }
        int average = sum / num_ary3.Length;
        Debug.Log(average);//68
        
        // 小数点以下も正確に求める場合
        float average2 = 1.0f * sum / num_ary3.Length;
        Debug.Log(average2);//68.4



    }

    // Update is called once per frame
    void Update() // エンターフレームと同じ、60fpsだが、実際はTime.deltaTime毎に実行
    {
        
    }
}
