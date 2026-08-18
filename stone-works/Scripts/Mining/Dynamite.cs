// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Represents a dynamite/explosion action used by the mining system.
// Responsibilities: Define explosion position, radius/type, randomized shape parameters, affected grid cells, and resource-generation results.
// Rules: Dynamite changes terrain through MiningSystem; it does not directly manage worker AI, storage, or economy.
// Dependencies: WorldGrid/Terrain, resource definitions, EventBus.
// Communication: MiningSystem triggers the explosion; Terrain reports destroyed cells; ResourceManager/Physics receives generated resources.
// Planned functions: Configure(target, parameters), CalculateAffectedCells(), ApplyExplosion(), DestroyTerrain(), GenerateResources(), GetExplosionResult().
// Future considerations: Keep explosion generation deterministic when needed for testing and save/load, while allowing controlled randomness.
