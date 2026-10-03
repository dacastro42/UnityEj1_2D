using UnityEngine;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour
{

    float speed ;
    private Rigidbody2D rigiBodyPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigiBodyPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        speed=Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rigiBodyPlayer.linearVelocity = new Vector2(speed , rigiBodyPlayer.linearVelocity.y);
    }
}
