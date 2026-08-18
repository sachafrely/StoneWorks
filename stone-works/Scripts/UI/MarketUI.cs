// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Displays the gem market, current prices, trends, and selling-related information.
// Responsibilities: Read market state, refresh price displays, show sellable quantities, and send sell commands.
// Rules: MarketUI never calculates authoritative prices and never changes money/inventory directly.
// Dependencies: GemMarket/Market read interface, SellingSystem command interface, EventBus, MainUI.
// Communication: Reacts to price/resource/sale events and requests sales through SellingSystem.
// Planned functions: RefreshPrices(), RefreshInventory(), ShowMarketTrend(), HandleSell(gemType, amount), UpdateAfterSale(event).
// Future considerations: Clearly distinguish current price, base price, and price trend so market behavior is understandable to the player.
