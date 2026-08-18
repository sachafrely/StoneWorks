// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Top-level representation of the physical game world.
// Responsibilities: Own world-level systems such as terrain, mine, machines, workers, and world bounds; provide controlled access to them.
// Rules: World coordinates major world entities but does not own their gameplay rules.
// Dependencies: WorldGrid, Terrain, Mine, MachineManager, WorkerManager, PhysicsWorld.
// Communication: Game initializes World; simulation systems query world state; entities/systems communicate through their dedicated interfaces.
// Planned functions: Initialize(), LoadWorldState(), GetMine(), GetTerrain(), GetGrid(), GetWorldBounds(), RegisterEntity(), RemoveEntity().
// Future considerations: Define how the mine can extend/reset while keeping travel time and world performance under control.
