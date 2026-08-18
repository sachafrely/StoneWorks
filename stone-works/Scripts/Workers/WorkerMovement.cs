// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Handles physical traversal of workers through the mine and factory area.
// Responsibilities: Move toward targets, follow terrain/grid traversal rules, climb, fall/drop, and report arrival or movement failure.
// Rules: WorkerMovement handles how a worker moves; WorkerAI decides where/why the worker should move.
// Dependencies: Worker, WorldGrid/Terrain, WorkerJob target data, GameTime.
// Communication: WorkerAI sends movement targets; World supplies traversability; WorkerMovement reports Arrived/Blocked/Fell events.
// Planned functions: SetTarget(position), MoveTowardTarget(delta), CanTraverse(from, to), Climb(direction), Fall(), Stop(), HasArrived(), IsPathValid().
// Future considerations: Workers must be able to traverse the mining field, including climbing up/down terrain, without walking through solid terrain. A grid-based solution may be preferable to a navigation mesh.
