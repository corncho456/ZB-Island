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

    public int defConst;
    public int defBase;

    public int atkConst;
    public int atkBase;

    public float Atk { get { return atkBase + atkConst * level; } }
    public float Def { get { return defBase + defConst * level; } }
    public float HP { get { return hpBase + hpConst * level; } }


    private float atk;
    private float def;
    private float hp;
    public bool isDead = false;

    public void Dead()
    {
        isDead = true;
    }

    public void OnDamaged(float damage)
    {
        hp -= damage;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hp < 0f)
        {
            Dead();
        }
    }
}
