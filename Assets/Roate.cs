using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Rotate : MonoBehaviour
{
    float rotSpeed = 0; // ����t��
    void Start()
    {
    }
    void Update()
    {
        // �Y�I���ƹ��N�n�]�w����t��
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = 10;
        }
        // ����t�סB�����L����
        transform.Rotate(0, 0, rotSpeed);
        // (�W�[�o�q)�����L��t
        rotSpeed *= 0.96f;
    }
}
