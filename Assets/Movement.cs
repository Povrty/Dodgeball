using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float jumpVelocity;
    private new Rigidbody2D rigidbody2D;
    private BoxCollider2D boxCollider2D;
    [SerializeField] public LayerMask platformsLayerMask;

    void Awake()
    {
        rigidbody2D = transform.GetComponent<Rigidbody2D>();
        boxCollider2D = transform.GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        Vector2 playerMovement = new Vector2(hor, 0f) * speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);

        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.velocity = Vector2.up * jumpVelocity;
        }
    }
        private bool IsGrounded()
        {
            RaycastHit2D raycastHit2D = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, .1f, platformsLayerMask);
            //Debug.Log(raycastHit2D.collider);
            return raycastHit2D.collider != null;
        }
}
