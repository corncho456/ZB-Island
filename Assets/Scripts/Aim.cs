using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    RaycastHit hit;
    public float maxDistance;
    public Transform target;
    public float range;

    private void OnDrawGizmos()
    {
        Vector3 dir = (target.position - transform.position).normalized;
        Gizmos.DrawRay(transform.position, dir * hit.distance);
        Gizmos.DrawWireSphere(transform.position + dir * hit.distance, transform.lossyScale.x / 2);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = (target.position - transform.position).normalized;


        if (Physics.SphereCast(transform.position, range, dir, out hit, maxDistance))
        {
            if(hit.collider.GetComponent<IDamageable>() != null)
            {
                hit.collider.GetComponent<IDamageable>().OnDamaged(10);
                print("damaged!");
            }
            
        }
    }
}
