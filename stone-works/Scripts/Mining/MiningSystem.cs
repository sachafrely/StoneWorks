// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Coordinates the mining gameplay loop from job execution to terrain destruction and resource creation.
// Responsibilities: Validate mining targets, execute MiningJob/Dynamite actions, destroy terrain, create logical resources, and publish mining events.
// Rules: Mining owns mining rules only. It does not simulate resource physics, move workers, or sell resources.
// Dependencies: Mine, Terrain/WorldGrid, MiningJob, Dynamite, ResourceManager, EventBus.
// Communication: Receives mining jobs from JobSystem and reports terrain/resource results to resource, physics, statistics, and UI systems through interfaces/events.
// Planned functions: CanMine(target), ExecuteJob(job), TriggerExplosion(target), DestroyAffectedTerrain(cells), SpawnResources(result), CompleteJob(job).
// Future considerations: Define infinite/deep mine strategy, explosion balance, resource yield, and how floating/unsupported terrain is removed.
