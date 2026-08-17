// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Gem-specific market pricing and fluctuation rules.
// Rules: Supports the six defined gem colors and maintains base/current/min/max price and trend concepts. Do not invent a seventh gem here.
// Dependencies: Market, ResourceType, GameTime/SimulationSystem, market data.
// Communication: SellingSystem/EconomySystem query it for current gem prices; price changes can emit events for UI/statistics.
// Must not depend on: Worker systems, physics, mining, or UI implementation.
