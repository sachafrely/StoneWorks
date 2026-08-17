// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Creates, tracks, prioritizes, and exposes available jobs to workers.
// Rules: Jobs describe work; JobSystem does not perform the work and does not own worker movement.
// Dependencies: WorkerJob plus MiningJob/TransportJob and other future job types; EventBus and world/resource state as needed for availability.
// Communication: WorkerAI queries/selects jobs; MiningSystem/LogisticsSystem publish work into the job system.
// Must not depend on: UI, Economy implementation, or direct worker internals.
