using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Or : Component
{
    public Or(int nbOfInputs) : base(nbOfInputs) { }


    public override bool Process()
    {
        bool res = false;
        foreach (Component input in inputs)
        {
            res |= (input != null && input.IsActive());
        }
        return res;
    }

}
