using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Rigidbody rigid;
    public Animator anim;
    public PlayerInput playerInput;
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        playerInput = gameObject.GetComponent<PlayerInput>();
        rigid = gameObject.GetComponent<Rigidbody>();
        anim = gameObject.GetComponentInChildren<Animator>();
    }

    public float MoveConst = 100;
    public void CharacterMove()
    {
        Vector3 moveDistance = new Vector3(playerInput.xAxis, 0f, playerInput.zAxis) * MoveConst * Time.deltaTime;
        rigid.MovePosition(rigid.position + moveDistance);
    }

    public void CharacterAnimation()
    {
        anim.SetBool("Run",playerInput.isPressedMoveStick);
    }
    public void CharacterRotation()
    {
        Vector3 dir = new Vector3(playerInput.xAxis, 0f, playerInput.zAxis);
        rigid.rotation = Quaternion.Lerp(rigid.rotation, Quaternion.LookRotation(dir), Time.deltaTime*rotateSpeed);
    }
    // Update is called once per frame
    void Update()
    {
        if (playerInput.isPressedMoveStick)
        {
            CharacterMove();
            CharacterRotation();
        }
        CharacterAnimation();

    }
}
