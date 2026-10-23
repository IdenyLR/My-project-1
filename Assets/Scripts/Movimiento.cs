using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad = 5f;
    private CambioColor cambioColor;

    void Start()
    {
        cambioColor = GetComponent<CambioColor>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * velocidad * Time.deltaTime);
            cambioColor.CambiarColor(Color.green);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * velocidad * Time.deltaTime);
            cambioColor.CambiarColor(Color.yellow);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
            cambioColor.CambiarColor(Color.red);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
            cambioColor.CambiarColor(Color.blue);
        }
    }
}
