using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    RaycastHit hit;
    public float maxDistance;
    public Transform target;
    public float range;
    public bool isFire;
    public Camera cam;
    public Unit atarget;

    private void OnDrawGizmos()
    {
        Vector3 dir = (target.position - transform.position).normalized;
        Gizmos.DrawRay(transform.position, dir * hit.distance);
        Gizmos.DrawWireSphere(transform.position + dir * hit.distance, transform.lossyScale.x / 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (isFire)
        {
            Shoot();
        }
    }

    public void Shoot()
    {


        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            if (atarget != null)
            {
                Debug.Log(hit.transform.name);
                atarget.OnDamaged(10f);
            }
        }
    }
}
