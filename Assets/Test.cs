using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start() //void Start()に続く{}の中には、最初に一度だけ実行する処理
    
    {
        int[] array = new int[5];//配列arrayを5で初期化

        for (int i = 0; i < array.Length; i++)//逆順
        {
            Debug.Log(5 - i);
        }
        for (int i = 0; i < array.Length; i++)//順番
        {

            Debug.Log(i);
        }
        int mp = 53;

        //10回繰り返す
        for (int i = 0; i < 10; i++)
        {
            Magic();
        }

        void Magic()//Magic関数宣言
        {

            if (mp >= 5)
            {
                int num = 5;
                //mpが5以上の時5減らす
                Debug.Log(mp - num);
                Debug.Log("魔法攻撃をした残りmpは"+mp);
                num = num + 5;
            }
            else
            {
                Debug.Log("mpが足りないため、魔法が使えない");
            }

        }
        
            
    }
    

    // Update is called once per frame
    void Update() //毎フレーム実行する処理
    {
        
    }
}
