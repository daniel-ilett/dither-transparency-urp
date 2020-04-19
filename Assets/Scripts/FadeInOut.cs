using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInOut : MonoBehaviour
{
    [SerializeField] private Renderer[] renderers;

    private void Update()
    {
        var time = Time.time * Mathf.PI * 0.25f;
        var opacity = (Mathf.Sin(time) + 1.0f) / 2.0f;

        foreach(var renderer in renderers)
        {
            renderer.material.SetFloat("_Opacity", opacity);
        }
    }
}
