using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public Camera mainCamera; // Reference to the Main Camera
    public DialogueSpeaker dialogueSpeaker; // Reference to the Dialogue Speaker
    public Canvas canvas; // Reference to the Canvas

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Interactable") && collision.collider.CompareTag("Player"))
        {
            // Enable Main Camera
            if (mainCamera != null)
            {
                mainCamera.enabled = true;
            }

            // Enable Dialogue Speaker
            if (dialogueSpeaker != null)
            {
                dialogueSpeaker.enabled = true;
            }

            // Enable Canvas
            if (canvas != null)
            {
                canvas.enabled = true;
            }

            // Disable anything else
            MonoBehaviour[] components = FindObjectsOfType<MonoBehaviour>();
            foreach (MonoBehaviour component in components)
            {
                if (component != this && component != dialogueSpeaker && component != canvas)
                {
                    component.enabled = false;
                }
            }
        }
    }
}
