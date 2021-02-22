using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoComponent : MonoBehaviour
{
    [Header("Attribution")]
    public string bulletName;
    public int atk;
    public int increaseAtkPerUP;
    public int atkUP;
    //제작시간
    public float progressTime;
    //걸린시간
    private float progressValue;
    public int price;
    public int dPrice;
    public int possession;


    [Header("UIField")]
    public Text tName;
    public Text tAtk;
    public Text tPrice;
    public Text tPossession;
    public Image progressCircle;


    private void Start()
    {
        progressCircle.fillAmount = 0;
    }

    void Update()
    {
        progressValue += Time.deltaTime;
        progressCircle.fillAmount = progressValue / progressTime;
        if(progressCircle.fillAmount >= 1)
        {
            progressCircle.fillAmount = 0;
            progressValue = 0;
            AddBullet();
            UpdateDisplayer();
        }
    }

    public void Upgrade()
    {

    }

    public void AddBullet()
    {
        possession += 1;

    }

    public void UpdateDisplayer()
    {
        tAtk.text = atk.ToString();
        tPossession.text = "+ " + possession.ToString();
    }
}
