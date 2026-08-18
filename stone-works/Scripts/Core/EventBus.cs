// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Decoupled event transport between gameplay systems, statistics, and UI.
// Responsibilities: Define event types/payloads, publish facts, and allow systems to subscribe/unsubscribe safely.
// Rules: Events describe facts that happened; subscribers react. Do not use the bus as hidden global state or as a direct command router.
// Dependencies: None on concrete gameplay systems; event payloads may reference stable domain data types.
// Communication: ResourceCreated, ResourcePickedUp, ResourceDelivered, MachineFinished, GemProduced, GemSold, WorkerUnlocked, PrestigePerformed, and similar domain events.
// Must not depend on: UI implementation, rendering, or concrete worker/machine implementations.
// Planned functions: Subscribe(eventType, handler), Unsubscribe(eventType, handler), Publish(event).
// Future considerations: Keep event payloads small, explicit, and stable so systems remain loosely coupled.
