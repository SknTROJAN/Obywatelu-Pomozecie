using Godot;
using System;

public partial class Main : Control
{
    private string GameTitle = "Obywatelu, pomożecie?";
    private const string Version = "0.0.1";

    public override void _Ready()
    {
        GD.Print(GameTitle);
        GD.Print($"Wersja: {Version}");
    }


}