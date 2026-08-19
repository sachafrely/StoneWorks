// StoneWorks — EVENT BUS
// Role: Lightweight publish/subscribe infrastructure for domain events.
// Rules: Events communicate facts that happened; EventBus must not become a command router or hidden service locator.
// Dependencies: Event definitions and subscribers only.
using Godot;
using System;
using System.Collections.Generic;

public partial class EventBus : Node
{
    private readonly Dictionary<Type, List<Delegate>> subscribers = new();

    public void Subscribe<TEvent>(Action<TEvent> handler)
    {
        if (handler == null)
        {
            throw new ArgumentNullException(nameof(handler));
        }

        Type eventType = typeof(TEvent);

        if (!subscribers.TryGetValue(eventType, out List<Delegate> handlers))
        {
            handlers = new List<Delegate>();
            subscribers[eventType] = handlers;
        }

        if (!handlers.Contains(handler))
        {
            handlers.Add(handler);
        }
    }

    public void Unsubscribe<TEvent>(Action<TEvent> handler)
    {
        if (handler == null)
        {
            return;
        }

        Type eventType = typeof(TEvent);

        if (!subscribers.TryGetValue(eventType, out List<Delegate> handlers))
        {
            return;
        }

        handlers.Remove(handler);

        if (handlers.Count == 0)
        {
            subscribers.Remove(eventType);
        }
    }

    public void Publish<TEvent>(TEvent eventData)
    {
        Type eventType = typeof(TEvent);

        if (!subscribers.TryGetValue(eventType, out List<Delegate> handlers))
        {
            return;
        }

        Delegate[] snapshot = handlers.ToArray();

        foreach (Delegate handler in snapshot)
        {
            if (handler is Action<TEvent> typedHandler)
            {
                typedHandler(eventData);
            }
        }
    }

    public void Clear()
    {
        subscribers.Clear();
    }

    public override void _ExitTree()
    {
        Clear();
    }
}
