using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Component
{

    private protected Component [] inputs;
    private protected List<Component> outputs;
    private bool isActive;
    /**
     * Creates a component using @nbOfInputs inputs
     */
    public Component(int nbOfInputs)
    {
        isActive = false;

        inputs = new Component[nbOfInputs];
        for (int i = 0; i < nbOfInputs; i++)
            inputs[i] = null;

        outputs = new List<Component>();
    }

    public void Plug(Component c)
    {
        outputs.Add(c);
    }

    public void UnPlugOutput(Component output)
    {
        outputs.Remove(output);
    }

    public void UnPlugInput(int i)
    {
        inputs[i] = null;
    }

    public bool IsActive()
    {
        return isActive;
    }

    public void Fire()
    {
        this.isActive = this.Process();
        outputs.ForEach(delegate (Component c) {
            c.isActive = false;
        });
    }


    public abstract bool Process();

}
