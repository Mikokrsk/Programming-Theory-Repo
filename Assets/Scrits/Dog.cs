using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Dog : Animal
{
    protected override void Talk()
    {
        Debug.Log("The Dog says " + Name);
    }
}
}
