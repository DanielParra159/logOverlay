using System;
using UnityEngine;

public class Consumer : MonoBehaviour
{
    private void Start(){
        Debug.Log("hola");
        Debug.LogError("error");
        Debug.LogWarning("warning");
        throw new Exception("ex");
    }
}