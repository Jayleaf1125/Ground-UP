using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float movementSpeed;
    public bool isMovingRight = true;

    Rigidbody2D _rb;
    Animator _animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + new Vector2(movementSpeed, 0) * Time.fixedDeltaTime);
        // _animator.SetBool("isWalking", true);
        
    }

}
    

