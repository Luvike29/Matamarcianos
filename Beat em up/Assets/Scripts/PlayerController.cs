using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour

{
    private PlayerInput playerInput;

    protected Vector3 move;
    [SerializeField] 
    protected float speed;

    [SerializeField]
    //Variables global de rigibody
    protected Rigidbody2D rb;
    [SerializeField]
    protected Animator anim;
    // Start is called before the first frame update
    void Awake()
    {
        
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = move*speed;
    }
    private void OnMove(InputValue inputValue)
    {
      move = inputValue.Get<Vector2>();
    }
}
