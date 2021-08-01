using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private LayerMask ground;

    RaycastHit2D groundHit;
    private float groundRaycastLength = .25f;

    void Awake()
    {
        GameEvents.event1Name.AddListener(event1Callback);
    }

    void Start()
    {

    }
    void Update()
    {
        groundHit = Physics2D.Raycast(transform.position, Vector2.down, groundRaycastLength, ground);
        Debug.DrawRay(transform.position, Vector2.down * groundRaycastLength, Color.green);
        if (groundHit == true)
        {
            //Debug.Log(groundHit.collider.name);
            //GameEvents.hello.Invoke(new OneEventData(gameObject, gameObject, gameObject));

            GameEvents.event1Name.Invoke(new Event1Data(1f));
        }
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * speed, rb.velocity.y, 0);
    }
    
    void event1Callback(Event1Data data) 
    {
        Debug.Log(data.data);
    }
    
}
