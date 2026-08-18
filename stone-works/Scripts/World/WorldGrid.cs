// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Represents the mine's discrete grid structure and provides fast coordinate/cell operations.
// Responsibilities: Convert world positions to grid coordinates, store cell data, validate bounds, and support region queries.
// Rules: WorldGrid owns grid representation only; mining rules and resource generation remain in their systems.
// Dependencies: Grid dimensions/cell data and basic math types.
// Communication: Terrain and Mine use WorldGrid; MiningSystem/Dynamite use its query and mutation interface; WorkerMovement uses traversability queries.
// Planned functions: WorldToGrid(position), GridToWorld(cell), IsInside(cell), GetCell(cell), SetCell(cell, value), ClearCell(cell), GetNeighbors(cell), GetRegion(bounds).
// Future considerations: Use compact storage and efficient region operations because explosions may modify many cells at once and the mine may become large.
