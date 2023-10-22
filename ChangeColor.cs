using UnityEngine;
using System.Collections;

public class ChangeMaterialOnCollision : MonoBehaviour
{
    // Reference to the original and new materials
    private Material originalMaterial;
    public Material newMaterial;

    private void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        originalMaterial = renderer.material;
    }

    private void OnCollisionEnter(Collision collision)
    {
            // Change the material of the object to the new material
            Renderer renderer = GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material = newMaterial;

                // Start a coroutine to change the material back to the original material after 1.5 seconds
                StartCoroutine(ChangeMaterialBack());
            }
    }

    // Coroutine to change the material back to the original material after a delay
    private IEnumerator ChangeMaterialBack()
    {
        // Wait for 1.5 seconds
        yield return new WaitForSeconds(1.5f);

        // Change the material back to the original material
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material = originalMaterial;
        }
    }
}
