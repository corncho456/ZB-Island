using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AimSlider : MonoBehaviour
{
    public Transform Target;
    public Transform leftLimit;
    public Transform rightLimit;
    public Slider slider;
    public void AimingCam(){
        Target.position = leftLimit.position + slider.value*(rightLimit.position - leftLimit.position);
    }    
    // Start is called before the first frame update
    void Start()
    {
        slider = gameObject.GetComponent<Slider>();
        slider.value = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        AimingCam();
    }
}
