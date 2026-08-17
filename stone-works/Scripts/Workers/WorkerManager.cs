// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Owns the collection and lifecycle of workers.
// Rules: Registers/spawns/removes workers and exposes controlled access; does not decide individual jobs.
// Dependencies: Worker, GameState, EventBus; progression may request worker unlock/creation.
// Communication: WorkerAI and UI use manager-facing commands rather than mutating worker internals.
// Must not depend on: Mining/Economy implementation details or UI presentation.
