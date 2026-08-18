// StoneWorks — WORKER MANAGER
// Role: Owns the worker collection and worker lifecycle, including registration, removal, roles, and availability lookup.
// Rules: Does not own WorkerAI, movement, inventory simulation, or job-selection rules; those remain with their dedicated responsibilities.
// Dependencies: Worker entities/state and explicit worker-domain interfaces.
// Skeleton only; gameplay implementation is not added yet.
using Godot;

public partial class WorkerManager : Node
{
}
