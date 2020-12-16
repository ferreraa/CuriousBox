using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class And : Component
{
    public And(int nbOfInputs) : base(nbOfInputs) { }


    public override bool Process()
    {
        bool res = true;
        foreach(Component input in inputs)
        {
            res &= input != null && input.IsActive();
        }
        return res;
    }

}
