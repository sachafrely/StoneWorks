// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Collects and exposes gameplay statistics without owning the gameplay systems that produce them.
// Responsibilities: Track totals, rates, play time, production, sales, resources processed, worker counts, and other useful metrics.
// Rules: Statistics are observers/recorders; they should not change gameplay state.
// Dependencies: EventBus and stable domain event payloads; GameTime for elapsed time.
// Communication: Subscribes to events such as ResourceCreated, GemProduced, GemSold, WorkerUnlocked, MachineFinished, and PrestigePerformed.
// Planned functions: RecordEvent(event), Update(delta), GetStatistic(id), GetRate(id), ResetRunStatistics(), SavePersistentStatistics(), GetHistory(id).
// Future considerations: Separate lifetime statistics from current-run statistics and avoid expensive per-frame sampling when an event is sufficient.
