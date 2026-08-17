// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Executes worker movement through the terrain/grid, including walking, climbing, and falling/drop behavior.
// Rules: Movement should be grid/terrain based rather than starting with navigation meshes. It does not choose jobs.
// Dependencies: Worker, WorldGrid/Terrain, GameTime/SimulationSystem.
// Communication: Receives movement targets from WorkerAI/job execution and reports movement completion/failure.
// Must not depend on: Market, Economy, UI, or rendering-only data.
