using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;
    public float speed;
    private Vector2 movement;
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        
    }

    void FixedUpdate()
    {
        Rigidbody2D.MovePosition(Rigidbody2D.position + movement * speed * Time.fixedDeltaTime);
    }
    
}
