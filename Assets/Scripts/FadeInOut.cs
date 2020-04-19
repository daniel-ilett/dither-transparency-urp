using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInOut : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;

    [SerializeField] private Renderer[] renderers;

    private void Update()
    {
        var opacity = (Mathf.Sin(Time.time * speed) + 1.0f) / 2.0f;

        foreach(var renderer in renderers)
        {
            renderer.material.SetFloat("_Opacity", opacity);
        }
    }
}
