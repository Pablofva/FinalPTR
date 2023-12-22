using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuantumTek.QuantumDialogue; // Para usar el componente QD_DialogueHandler

public class waypActor : MonoBehaviour
{
    float speed = 4.0f;
    public QD_DialogueHandler dialogueHandler; // Referencia al componente QD_DialogueHandler
    public List<wayp> waypoints; // Lista de waypoints
    int currentWaypoint = 0; // Índice del waypoint actual
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       //transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
    }

    // Método para mover el personaje hacia el waypoint que corresponda según el ID de la tarjeta de conversación
    public void MoveToWaypoint(int mensajeID)
    {
        for (int i = 0; i < waypoints.Count; i++) // Busca el waypoint que tenga el mismo ID que la tarjeta de mensaje
        {
            if (waypoints[i].mensajeID== mensajeID) // Si lo encuentra
            {
                currentWaypoint = i; // Asigna el índice del waypoint actual
                transform.position = waypoints[i].position; // Mueve el personaje a la posición del waypoint
                break; // Termina el bucle
            }
        }
    }

    // Método para iniciar la conversación cuando el personaje llega a un waypoint
    public void StartConversation()
    {if (waypoints.Count !=0)
        {
            dialogueHandler.SetConversation(waypoints[currentWaypoint].mensajeID.ToString()); // Establece la conversación según el ID del waypoint actual
    }
    }
}