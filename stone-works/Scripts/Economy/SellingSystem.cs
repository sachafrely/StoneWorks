// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Handles selling resources through the market and converts valid sales into money.
// Rules: Selling validates ownership/availability and price, then delegates money mutation to EconomySystem. It does not contain market fluctuation logic.
// Dependencies: EconomySystem, Market/GemMarket, ResourceManager/Storage, EventBus.
// Communication: Player/AutoSell invokes SellingSystem; successful sales emit GemSold/ResourceSold-style events for statistics/UI.
// Must not depend on: Worker movement, mining, physics, or direct UI manipulation.
