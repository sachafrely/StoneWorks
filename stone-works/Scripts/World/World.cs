// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Represents and coordinates the overall game world/environment.
// Rules: Owns world composition and access to world entities; does not own mining, economy, worker AI, or physics rules.
// Dependencies: WorldGrid, Terrain, Mine; may expose world-level references to systems.
// Communication: Provides world context to systems; changes that matter to other systems should use explicit APIs/events.
// Must not depend on: UI or rendering logic.
