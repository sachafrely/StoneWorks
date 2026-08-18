// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Coordinates scripted parallax background layers and their relationship to the active camera.
// Responsibilities: Register layers, track the camera's movement, and update all parallax layers consistently.
// Rules: Presentation only; never owns gameplay state or modifies world simulation. Each layer controls its own depth factor and optional wrapping.
// Dependencies: Godot Node2D/Camera2D and ParallaxLayerController.

using Godot;
using System.Collections.Generic;

public partial class ParallaxBackgroundController : Node2D
{
    [Export]
    public Camera2D Camera { get; set; }

    [Export]
    public bool UpdateInProcess { get; set; } = true;

    private readonly List<ParallaxLayerController> _layers = new();
    private Vector2 _initialCameraPosition;
    private bool _initialized;

    public override void _Ready()
    {
        RegisterChildLayers();
        InitializeCameraPosition();
    }

    public override void _Process(double delta)
    {
        if (!UpdateInProcess)
            return;

        UpdateParallax();
    }

    public void RegisterLayer(ParallaxLayerController layer)
    {
        if (layer == null || _layers.Contains(layer))
            return;

        _layers.Add(layer);
        layer.Initialize(_initialCameraPosition);
    }

    public void UnregisterLayer(ParallaxLayerController layer)
    {
        if (layer == null)
            return;

        _layers.Remove(layer);
    }

    private void RegisterChildLayers()
    {
        foreach (Node child in GetChildren())
        {
            if (child is ParallaxLayerController layer)
                RegisterLayer(layer);
        }
    }

    private void InitializeCameraPosition()
    {
        if (Camera == null)
            return;

        _initialCameraPosition = Camera.GlobalPosition;
        _initialized = true;

        foreach (ParallaxLayerController layer in _layers)
            layer.Initialize(_initialCameraPosition);
    }

    private void UpdateParallax()
    {
        if (!_initialized || Camera == null)
            return;

        Vector2 cameraDelta = Camera.GlobalPosition - _initialCameraPosition;

        foreach (ParallaxLayerController layer in _layers)
            layer.UpdateParallax(cameraDelta);
    }
}
