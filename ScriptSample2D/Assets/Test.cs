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


    }

    // Update is called once per frame
    void Update() // エンターフレームと同じ、60fpsだが、実際はTime.deltaTime毎に実行
    {
        
    }
}
