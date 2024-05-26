using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{    
    [SerializeField] private float _speed = 1f;
    
    private void Update()
    {       
        transform.position += transform.forward * _speed * Time.deltaTime; 
    }
}
