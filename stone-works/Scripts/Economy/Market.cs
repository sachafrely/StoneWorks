// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Generic market model that owns prices and market-state rules.
// Responsibilities: Store base/current prices, apply price changes, calculate trends, and restore prices toward their defined targets.
// Rules: The market determines prices only; it does not sell resources or own inventories.
// Dependencies: ResourceType/resource data and GameTime; EventBus may notify interested systems of price changes.
// Communication: SellingSystem queries current prices; UI observes price changes; GemMarket may specialize this model for gems.
// Must not depend on: WorkerAI, storage implementation, or UI controls.
// Planned functions: GetPrice(resourceType), SetPrice(resourceType, price), Update(delta), ApplySaleImpact(resourceType, amount), StabilizePrices().
// Future considerations: Keep price behavior deterministic enough to save/load safely while allowing controlled fluctuation.
