using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

public class MovedorEnGrilla : MonoBehaviour
{
    public Tilemap obstaculosTilemap;

    public void Mover(Vector2 direccion, float velocidad)
    {
        var nuevaPosicion = new Vector3(
            transform.position.x + Mathf.RoundToInt(direccion.x),
            transform.position.y + Mathf.RoundToInt(direccion.y),
            0
        );

        if (EstaVacio(nuevaPosicion))
        {
            transform.position = nuevaPosicion;
        }
    }

    private bool EstaVacio(Vector3 posicionEnMundo)
    {
        Vector3Int posicionEnGrilla = obstaculosTilemap.WorldToCell(posicionEnMundo);

        return !obstaculosTilemap.HasTile(posicionEnGrilla);
    }
}