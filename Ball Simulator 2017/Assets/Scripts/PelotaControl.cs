using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PelotaControl : MonoBehaviour {

    public float velocidad;
    public Text textoCont;
    public Text textoVict;

    private Rigidbody rb;
    private int contador;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        contador = 0;
        UpdContador();
        textoVict.text = "";
    }

    void FixedUpdate()
    {
        float movHor = Input.GetAxis("Horizontal");
        float movVer = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movHor, 0.0f, movVer);

        rb.AddForce(movimiento * velocidad);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coleccionable"))
        {
            other.gameObject.SetActive(false);
            contador = contador + 1;
            UpdContador();
        }
    }

    void UpdContador()
    {
        textoCont.text = "Coleccionables: " + contador.ToString();
        if(contador>= 12)
        {
            textoVict.text = "HAS GANADO!";
        }
    }
}
