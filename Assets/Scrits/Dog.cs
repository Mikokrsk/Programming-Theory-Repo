using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    //Polymorphism
    protected override void Talk()
    {
        Debug.Log("The Dog says " + Name);
    }
}
