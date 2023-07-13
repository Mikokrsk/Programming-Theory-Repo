using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Cat : Animal
{
    //Polymorphism
    protected override void Talk()
    {
        Debug.Log("The Cat says " + Name);
    }
}
