using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField]protected string Name ;
    //Polymorphism
    protected virtual void Talk()
    {
        Debug.Log("The Animal says " + Name);
    }

    //Encapsulation
    public void SetName(string name)
    {
        if (name != null && name.Length <=5)
        {
            Name = name;
        }
    }
}
