using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorEnemigos : MonoBehaviour
{
    public TMPro.TMP_Text TextoContadorEnemigos;
    public GameObject canva;
    private int Sobrevivientes;

    void Start()
    {
        canva.SetActive(false);
    }

    void FixedUpdate()
    {
        Sobrevivientes = GameObject.FindGameObjectsWithTag("JueraBicho").Length;
        TextoContadorEnemigos.text = "Restantes: " + Sobrevivientes;
    }

    public void Morido()
    {
        Sobrevivientes--;
        TextoContadorEnemigos.text = "Restantes: " + Sobrevivientes;
        
        if (Sobrevivientes == 0)
        {
            canva.SetActive(true);  
        }
    }

}
