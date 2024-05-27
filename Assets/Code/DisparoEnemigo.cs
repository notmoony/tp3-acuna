using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DisparoEnemigo : MonoBehaviour
{
    public float velocidadDisparoEnemigo;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.down * velocidadDisparoEnemigo * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
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
