using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() //void Start()�ɑ���{}�̒��ɂ́A�ŏ��Ɉ�x�������s���鏈��
    {
        int num = 100;
        Debug.Log(num);
        if (num <= 500)
        {
            // �v�f��5�̔z�������������
            int[] points = new int[5];

            // �z��̊e�v�f�ɒl��������
            points[0] = 30;
            points[1] = 20;
            points[2] = 50;
            points[3] = 10;
            points[4] = 80;

            // �z��̗v�f�����ׂĕ\������
            for (int i = 0; i < 5; i++)
            {
                Debug.Log(points[i]);
            }
        }
    }
    

    // Update is called once per frame
    void Update() //���t���[�����s���鏈��
    {
        
    }
}
