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
        // 방향의 쿼터니언 값 구하기
        // 쿼터니언 값 = 쿼터니언 방향 값(방향 백터)
        Quaternion rot = Quaternion.LookRotation(dir.normalized);
        // 방향 돌리기
        transform.rotation = rot;
    }

    void Update()
    {
        Rotation();
    }
}
