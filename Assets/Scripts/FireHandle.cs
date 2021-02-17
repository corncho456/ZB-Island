using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FireHandle : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Sprite idleHandle;
    public Sprite fireHandle;
    
    public Image image;

    public FireArea fireArea;


    public void FireState(){
        image.sprite = fireHandle;
    }

    public void IdleState(){
        image.sprite = idleHandle;
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        fireArea.gameObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {

        fireArea.gameObject.SetActive(false);
    }




    // Start is called before the first frame update
    void Start()
    {
        image = gameObject.GetComponent<Image>();
        fireArea.gameObject.SetActive(false);
    }
}
