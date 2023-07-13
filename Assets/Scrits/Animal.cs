using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] protected string Name ;
    
    protected virtual void Talk()
    {
        Debug.Log("The Animal says the Name");
    }
}
