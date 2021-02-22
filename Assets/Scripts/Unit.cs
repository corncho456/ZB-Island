using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour,IDamageable
{
    [Header("Unit Information")]
    public string id;
    public string unitName;
    public int level;

    [Header("Unit Attribution")]
    public int hpConst;
    public int hpBase;


    public float HP { get { return hpBase + hpConst * level; } }

    private float hp;
    public bool isDead = false;

    public void Dead()
    {
        isDead = true;
    }

    public void OnDamaged(float damage)
    {
        hp -= damage;
        if (hp < 0)
        {
            Dead();
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

}
