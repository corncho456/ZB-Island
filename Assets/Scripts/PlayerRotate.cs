using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public Transform target;
    
    void Rotation()
    {
        Vector3 dir = target.transform.position - transform.position;
        dir.y = 0f;
        // ������ ���ʹϾ� �� ���ϱ�
        // ���ʹϾ� �� = ���ʹϾ� ���� ��(���� ����)
        Quaternion rot = Quaternion.LookRotation(dir.normalized);
        // ���� ������
        transform.rotation = rot;
    }

    void Update()
    {
        Rotation();
    }
}
