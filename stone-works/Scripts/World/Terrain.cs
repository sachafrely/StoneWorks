// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Owns the logical terrain/grid contents of the mine and world.
// Responsibilities: Store cell states, answer occupancy/material queries, destroy/change cells, and provide traversability/collision information.
// Rules: Terrain data is gameplay state. Visual tiles are a representation and must not become the authoritative terrain source.
// Dependencies: Grid/material definitions only.
// Communication: Mining/Dynamite modifies cells; WorkerMovement queries traversability; PhysicsWorld queries collision; rendering reads the resulting terrain state.
// Planned functions: GetCell(position), SetCell(position, type), IsSolid(position), IsTraversable(position), DestroyCell(position), DestroyRegion(cells), GetNeighbors(position), FindUnsupportedRegions().
// Future considerations: Support explosion destruction and removal of floating/illogical terrain efficiently; keep grid operations fast enough for repeated mining.
