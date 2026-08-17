// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Coordinates money/economy state and economy-wide rules.
// Rules: Economy knows resources/market values, not how workers mine or transport them. Money changes must be authoritative and auditable.
// Dependencies: Market/GemMarket, GameState, ResourceType, EventBus.
// Communication: SellingSystem requests transactions; economy updates money and emits sale/economy events.
// Must not depend on: WorkerAI, MiningSystem internals, physics, or UI.
