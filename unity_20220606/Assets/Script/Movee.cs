

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movee : MonoBehaviour
{
    Rigidbody2D playerRigidbody2D;

    [Header("�ثe�������t��")]
    public float speedX;

    [Header("�ثe��������V")]
    public float horizontalDirection;//�ƭȷ|�b -1~1����

    const string HORIZONTAL = "Horizontal";

    [Header("�������O")]
    [Range(0, 150)]
    public float xForce;

    //�ثe�����t��
    float speedY;

    [Header("�̤j�����t��")]
    public float maxSpeedX;

    [Header("�����V�W���O")]
    public float yForce;

    [Header("�P���a�O���Z��")]
    [Range(0, 0.5f)]
    public float distance;

    [Header("�����a�O���g�u�_�I")]
    public Transform groundCheck;

    [Header("�a���ϼh")]
    public LayerMask groundLayer;

    public bool grounded;

    public void ControlSpeed()
    {
        speedX = playerRigidbody2D.velocity.x;
        speedY = playerRigidbody2D.velocity.y;
        float newSpeedX = Mathf.Clamp(speedX, -maxSpeedX, maxSpeedX);
        playerRigidbody2D.velocity = new Vector2(newSpeedX, speedY);
    }

    public bool JumpKey
    {
        get
        {
            return Input.GetKeyDown(KeyCode.Space);
        }
    }

    void TryJump()
    {
        if (IsGround && JumpKey)
        {
            playerRigidbody2D.AddForce(Vector2.up * yForce);
        }
    }

    //�b���a�������g�@���ܵu���g�u �p�G�g�u������a�O�ϼh���� �N���b��ۦa�O
    bool IsGround
    {
        get
        {
            Vector2 start = groundCheck.position;
            Vector2 end = new Vector2(start.x, start.y - distance);

            Debug.DrawLine(start, end, Color.blue);
            grounded = Physics2D.Linecast(start, end, groundLayer);
            return grounded;
        }
    }

    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    /// <summary>��������</summary>
    void MovementX()
    {
        horizontalDirection = Input.GetAxis(HORIZONTAL);
        playerRigidbody2D.AddForce(new Vector2(xForce * horizontalDirection, 0));
    }

    void Update()
    {
        MovementX();
        ControlSpeed();
        TryJump();
        //speedX = playerRigidbody2D.velocity.x;
    }
}