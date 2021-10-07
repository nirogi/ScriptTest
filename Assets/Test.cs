using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() //void Start()に続く{}の中には、最初に一度だけ実行する処理
    {
        int num = 100;
        Debug.Log(num);
        if (num <= 500)
        {
            // 要素数5の配列を初期化する
            int[] points = new int[5];

            // 配列の各要素に値を代入する
            points[0] = 30;
            points[1] = 20;
            points[2] = 50;
            points[3] = 10;
            points[4] = 80;

            // 配列の要素をすべて表示する
            for (int i = 0; i < 5; i++)
            {
                Debug.Log(points[i]);
            }
        }
    }
    

    // Update is called once per frame
    void Update() //毎フレーム実行する処理
    {
        
    }
}
