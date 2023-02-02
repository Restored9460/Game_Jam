using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{ 
private Transform target ;
public float step = 1.0f;
public void Update()
{   transform.Translate(Vector3.Normalize(target.position - transform.position) * step);
    
}
}
