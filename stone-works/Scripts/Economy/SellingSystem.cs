// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Converts sell requests into validated economic transactions.
// Responsibilities: Determine what can be sold, query market prices, remove the sold resources, add money, and publish the result.
// Rules: Never bypass storage/inventory validation and never modify UI directly.
// Dependencies: EconomySystem, Market/GemMarket, ResourceManager/Storage, EventBus.
// Communication: Receives sell commands from player/auto-sell systems and publishes ResourceSold/MoneyChanged events.
// Must not depend on: WorkerMovement or rendering.
// Planned functions: CanSell(resource), CalculateSaleValue(resource), Sell(resource, amount), SellFromWarehouse(resourceType, amount), SellAll().
// Future considerations: AutoSell should call the same transaction path as manual selling to avoid duplicate economy logic.
