// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Represents a concrete mining task available to a worker.
// Rules: Contains task target/state/priority data; does not globally schedule workers or execute terrain destruction itself.
// Dependencies: Mine/WorldGrid target data and WorkerJob/job abstractions.
// Communication: JobSystem exposes it; WorkerAI selects it; MiningSystem executes the mining rules.
// Must not depend on: UI, Economy, physics implementation, or worker movement internals.
