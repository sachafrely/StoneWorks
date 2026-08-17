// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Authoritative runtime state for persistent/current game data.
// Rules: Stores state; does not execute gameplay rules. Resettable vs permanent progression must remain explicit for prestige/save logic.
// Dependencies: ResourceManager data, WorkerManager data, progression/economy/world state as required by SaveData.
// Communication: Read/written by systems and SaveSystem; changes should be exposed through controlled APIs/events.
// Must not depend on: UI or rendering.
