using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTop : MonoBehaviour
{
    [SerializeField] public float velocidadMovimiento;
    [SerializeField] private Vector2 direccion;
    private Rigidbody2D rbr2D;

    private void Start()
    {
        rbr2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        direccion = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

    }

    private void FixedUpdate()
    {
        rbr2D.MovePosition(rbr2D.position + direccion * velocidadMovimiento * Time.fixedDeltaTime);
    }
}
