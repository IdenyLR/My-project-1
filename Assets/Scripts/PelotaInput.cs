using UnityEngine;
using UnityEngine.InputSystem;

public class PelotaInput : MonoBehaviour
{
    public float fuerzaImpulso = 4f;
    // Se conserva la velocidad inicial de la nave de equilibrio de la Clase 05.
    public float velocidadHorizontal = 3f;

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rb.linearVelocity = new Vector2(velocidadHorizontal, 0f);
    }

    public void OnJump(InputValue value)
    {
        if (!value.isPressed)
        {
            return;
        }

        rb.AddForce(
            Vector2.up * fuerzaImpulso,
            ForceMode2D.Impulse
        );
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Suelo")
        {
            Debug.Log("La pelota cayó al suelo.");
        }
    }
}
