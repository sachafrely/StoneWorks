// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Decoupled event transport between gameplay systems, statistics, and UI.
// Rules: Events describe facts that happened; subscribers react. Do not use the bus as a hidden global state store or direct command router.
// Dependencies: None on gameplay systems; event payloads may reference stable domain data types.
// Communication: Examples include ResourceCreated, ResourcePickedUp, ResourceDelivered, MachineFinished, GemProduced, GemSold, WorkerUnlocked, PrestigePerformed.
// Must not depend on: UI, rendering, or concrete worker/machine implementations.
