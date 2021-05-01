using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;
    Vector2 endPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetMouseButtonDown(0))
        {
            this.speed = 0.2f;
        }

        transform.Translate(this.speed, 0, 0); // 相対的に現在の位置から指定した位置に移動
        this.speed *= 0.98f; // 減衰
        */

        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition; // マウスをクリックした座標
        }

        else if (Input.GetMouseButtonUp(0)) {

            this.endPos = Input.mousePosition; // マウスを話した座標
            float swipeLength = this.endPos.x - this.startPos.x;

            // スワイプの長さを車の初速度に変換する
            this.speed = swipeLength / 500.0f; // この値で移動距離を調整する

        }

        transform.Translate(this.speed, 0, 0); // 相対的に現在の位置から指定した位置に移動
        this.speed *= 0.98f; // 減衰

    }
}
