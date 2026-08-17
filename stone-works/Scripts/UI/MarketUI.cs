// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Displays current market prices, trends, and selling controls.
// Rules: Read market state and send selling commands; never calculate authoritative prices or mutate money directly.
// Dependencies: Market/GemMarket read-only state, SellingSystem/EconomySystem command API, EventBus.
// Communication: Market events refresh display; sell actions are sent to SellingSystem.
// Must not depend on: workers, mining, physics, or direct Economy/GameState field mutation.
