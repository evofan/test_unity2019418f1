using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{

    //
    float rotSpeed = 0;// 回転速度

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // マウス押下で回転速度を設定する
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }

        // GetMouseButtonDown ... 押した瞬間一度
        // GetMouseButon ... 押している間
        // GetMouseBUttonUp ... 押して離した瞬間一度

        // 回転速度分、ルーレットを廻す
        transform.Rotate(0, 0, this.rotSpeed);

        // ルーレットを減速させる
        this.rotSpeed *= 0.96f;
        // ★少しずつ減速していくだけだと、一定の速さ（線形）で減速するので不自然になってしまう
        // ★減衰係数を掛けることで自然な感じに減速する＝線形でなく指数関数的になる

    }
}
