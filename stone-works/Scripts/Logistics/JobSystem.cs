// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Creates, tracks, and prioritizes jobs for workers and logistics.
// Responsibilities: Register available jobs, select suitable jobs, reserve jobs, complete/cancel jobs, and prevent conflicting assignments.
// Rules: Jobs describe work to be done; the JobSystem does not move workers or perform the work itself.
// Dependencies: Worker roles, MiningJob/TransportJob, world/resource availability, EventBus.
// Communication: Workers request/accept jobs; gameplay systems publish conditions that create or invalidate jobs.
// Must not depend on: UI implementation or worker movement internals.
// Planned functions: RegisterJob(job), RemoveJob(job), FindBestJob(worker), ReserveJob(job, worker), CompleteJob(job), CancelJob(job), RefreshJobs().
// Future considerations: Job priority should support mining, transport, machine supply, warehouse sorting, and future job types.
