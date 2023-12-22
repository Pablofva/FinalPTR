using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wayp : MonoBehaviour
{
    [SerializeField] public int mensajeID; // El ID de la tarjeta de mensaje que se activa al llegar al waypoint
    [SerializeField] public Vector3 position; // La posición del waypoint
    public Transform nexPoint;
}
