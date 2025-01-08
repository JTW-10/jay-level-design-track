using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D myrb;
    private Transform mytransform;

    public LayerMask ground;

    [Header("Movement Settings")]
    public float speed = 1.0f;
    public float jumpForce = 1.0f;
    public float dashForce = 1.0f;
    public float canDash = 1.0f;
    public bool isGrounded = true;
    public bool isDodging = true;
    private void Awake()
    {
        myrb = GetComponent<Rigidbody2D>();
        UnityEngine.Cursor.visible = false;
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            
        }
    }
}
