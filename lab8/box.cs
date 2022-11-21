﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Box<T>
{
    private T element;

    public Box(T element)
    {
        this.element = element;
    }

    public override string ToString()
    {
        return $"{this.element.GetType().FullName}: {this.element}";
    }
}
