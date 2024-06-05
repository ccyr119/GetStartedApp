//********************************************************************
// FILE: DecoratorAttribute.cs
// AUTH: chency2
// MAIL: chency2@g-bits.com
// DATE: 2024-06-04 14:47:27
// VER: 1.0
// DESC: 修饰注解
//*********************************************************************


using System;

public class DecoratorAttribute : Attribute
{
    public string Name { get; set; }
    public int Level { get; set; } = 0;
    public DecoratorAttribute(string name, int level)
    {
        this.Name = name;
        this.Level = level;
    }
}