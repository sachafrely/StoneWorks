// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Gem-specific market rules layered on top of the generic market model.
// Responsibilities: Define the six gem markets, their base values, sale response, stabilization behavior, and any future market rotation rules.
// Rules: GemMarket owns gem pricing rules; SellingSystem handles the act of selling and EconomySystem handles money.
// Dependencies: Market, ResourceType, GameTime, EventBus.
// Communication: Provides prices to SellingSystem and market information to UI/statistics systems.
// Must not depend on: Workers, physics, machine visuals, or UI controls.
// Planned functions: InitializeGemMarkets(), GetGemPrice(gemType), Update(delta), ApplyGemSale(gemType, quantity), GetMarketTrend(gemType), RotateBaseValuesIfNeeded().
// Future considerations: The exact six-gem price-rotation design is still open and should remain data-driven.
