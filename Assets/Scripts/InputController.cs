
using UnityEngine;

public class InputController : MonoBehaviour
{
    Transform cam;
    public Joystick joystickMove;
    public Rigidbody rb;
    float rotateV;
    float rotateH;
    public float speed = 10f;
    private Animator animator;

    private void Start()
    {
        cam = Camera.main.transform;
        animator = GetComponent<Animator>();
    }
    void Move()
    {
        rb.velocity = new Vector3(joystickMove.Horizontal * speed + Input.GetAxis("Horizontal"), rb.velocity.y, joystickMove.Vertical * speed + Input.GetAxis("Vertical"));
    }
    
    private void Update()
    {
        Move();
        UpdateAnimation();

    }

    void UpdateAnimation()
    {
        animator.SetBool("IsWalking", true);
    }
}
