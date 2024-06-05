using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Reflection;
using System;
using System.Collections.Generic;
using Avalonia;
using System.ComponentModel;

namespace GetStartedApp;

[Decorator("MainWindow", 10)]
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void btnCalculate_Click(object sender, RoutedEventArgs e)
    {
        Debug.WriteLine($"Clicked! Celsius={tbCelsius.Text}");
        TypeInfo typeInfo = typeof(MainWindow).GetTypeInfo();
        Console.WriteLine($"The assembley qualified name of MainWindow is {typeInfo.AssemblyQualifiedName}");

        TestAttribute(typeInfo);

        TranlateCelsiusToFahrenheit();
    }

    private static void TestAttribute(TypeInfo typeInfo)
    {
        IEnumerable<Attribute> attrs = typeInfo.GetCustomAttributes();
        foreach (Attribute attr in attrs)
        {
            Console.WriteLine($"Attribute on MainWindow: {attr.GetType().Name}");
        }
    }

    public void tbCelsius_PropertyChanged(object? sender, AvaloniaPropertyChangedEventArgs args)
    {
        if (args.Property == TextBox.TextProperty)
        {
            TranlateCelsiusToFahrenheit();
        }
    }

    private void TranlateCelsiusToFahrenheit()
    {
        if (!Double.TryParse(tbCelsius.Text, out double C))
        {
            tbCelsius.Text = "0";
        }
        tbFahrenheit.Text = TranlateCelsiusToFahrenheit(C).ToString("0.0");
    }

    private static double TranlateCelsiusToFahrenheit(double C)
    {
        var F = C * (9d / 5d) + 32;
        return F;
    }
}