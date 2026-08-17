// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Displays worker state and exposes worker-related commands.
// Rules: UI presents worker information and sends commands; it never mutates Worker fields directly.
// Dependencies: WorkerManager/Worker read-only state, WorkerAI/job state, EventBus.
// Communication: Commands go through manager/system APIs; WorkerUnlocked/job events trigger refreshes.
// Must not depend on: Mining/Economy internals, physics, or worker private state.
