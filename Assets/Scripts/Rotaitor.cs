using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotaitor : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 90f;

    private void Update()
    {
        transform.Rotate(Vector3.up, _rotationSpeed * Time.deltaTime);
    }
}
