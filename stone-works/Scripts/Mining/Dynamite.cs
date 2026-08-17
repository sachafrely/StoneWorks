// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Represents the dynamite mining action/entity used to destroy terrain and trigger resource generation.
// Rules: Owns explosion/action parameters only; terrain mutation and resource creation remain MiningSystem responsibilities.
// Dependencies: Mine/WorldGrid/Terrain through MiningSystem; EventBus for resulting events where useful.
// Communication: MiningJob/MiningSystem invokes the action; MiningSystem resolves terrain and resource consequences.
// Must not depend on: Physics internals, Economy, UI, or worker AI.
