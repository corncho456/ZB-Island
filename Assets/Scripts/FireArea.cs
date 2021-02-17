using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FireArea : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public FireHandle fireHandle;
    public void OnPointerExit(PointerEventData eventData)
    {
        fireHandle.IdleState();
        print("end");
    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        fireHandle.FireState();
        print("fire");
    }


}
