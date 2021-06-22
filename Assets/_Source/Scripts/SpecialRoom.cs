using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialRoom : MonoBehaviour
{

    public Material material02;

    Dictionary<CharacterControl, Material[]> materialBank = new Dictionary<CharacterControl, Material[]>();


    public void OnTriggerEnter(Collider col)
    {
        var character = col.GetComponent<CharacterControl>();
        if (character != null)
        {
            var renderers = character.GetComponentsInChildren<Renderer>();
            var materials = new Material[renderers.Length];
            for (int i = 0; i < renderers.Length; i++)
            {
                materials[i] = renderers[i].material;
                renderers[i].material = material02;
            }
            materialBank.Add(character, materials);
        }
    }

    public void OnTriggerExit(Collider col)
    {
        var character = col.GetComponent<CharacterControl>();
        if (character != null)
        {
            var renderers = character.GetComponentsInChildren<Renderer>();
            var materials = materialBank[character];
            for (int i = 0; i < materials.Length; i++)
                renderers[i].material = materials[i];
            materialBank.Remove(character);
        }
    }
}
