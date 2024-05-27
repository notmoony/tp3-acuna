using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public float velocidadDisparo;

    void Start()
    {
    }

    void Update()
    {
        transform.Translate(Vector2.up * velocidadDisparo * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "JueraBicho")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if(collision.gameObject.tag == "Paredes")
        {
            Destroy(gameObject);
        }
    }

}