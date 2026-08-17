// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: General market model for current prices and market behavior.
// Rules: Owns pricing behavior, not selling UI or worker logistics. Price changes must follow defined bounds/trends from design data.
// Dependencies: ResourceType/ResourceData, GameTime/SimulationSystem for scheduled fluctuations.
// Communication: GemMarket specializes this for gems; SellingSystem queries current prices.
// Must not depend on: Workers, mining, physics, UI, or rendering.
