using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxRotate : MonoBehaviour
{
    [SerializeField] private float _skyBoxSpeed;

    private void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time*_skyBoxSpeed);
    }
}
