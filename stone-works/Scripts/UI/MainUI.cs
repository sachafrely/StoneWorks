// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Main presentation/controller layer for the game UI.
// Rules: Displays state and sends player commands. It must never directly modify gameplay internals.
// Dependencies: Read-only views/interfaces from GameState and major systems; EventBus for updates.
// Communication: UI command -> system API; system event/state -> UI refresh.
// Must not depend on: private fields of workers, machines, resources, physics, or direct scene manipulation of gameplay rules.
