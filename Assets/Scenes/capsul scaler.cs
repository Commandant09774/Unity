using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class capsulscealer : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed = 0.2f;
    
    private void Update()
    {
        transform.localScale += transform.localScale * _scaleSpeed * Time.deltaTime;      
    }
}
