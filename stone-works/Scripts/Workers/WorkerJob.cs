// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Represents the worker's current assigned job/state.
// Rules: Describes assignment and progress; does not create or globally prioritize jobs.
// Dependencies: Job domain data and the worker/entity performing the job.
// Communication: JobSystem creates/assigns jobs; WorkerAI selects them; execution is handled by the relevant gameplay system.
// Must not depend on: UI, Economy, or concrete mining/machine implementations.
