using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start() //void Start()�ɑ���{}�̒��ɂ́A�ŏ��Ɉ�x�������s���鏈��
    
    {
        int[] array = new int[5];//�z��array��5�ŏ�����

        for (int i = 0; i < array.Length; i++)//�t��
        {
            Debug.Log(5 - i);
        }
        for (int i = 0; i < array.Length; i++)//����
        {

            Debug.Log(i);
        }
        int mp = 53;

        //10��J��Ԃ�
        for (int i = 0; i < 10; i++)
        {
            Magic();
        }

        void Magic()//Magic�֐��錾
        {

            if (mp >= 5)
            {
                int num = 5;
                //mp��5�ȏ�̎�5���炷
                Debug.Log(mp - num);
                Debug.Log("���@�U���������c��mp��"+mp);
                num = num + 5;
            }
            else
            {
                Debug.Log("mp������Ȃ����߁A���@���g���Ȃ�");
            }

        }
        
            
    }
    

    // Update is called once per frame
    void Update() //���t���[�����s���鏈��
    {
        
    }
}
