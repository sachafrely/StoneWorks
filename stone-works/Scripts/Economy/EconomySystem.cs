// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Coordinates the game's economic rules and currency flow.
// Responsibilities: Manage money, validate purchases/sales, apply economic changes, and expose economic state to other systems.
// Rules: Economy owns economic rules; workers, machines, and UI must not directly change money or prices.
// Dependencies: ResourceManager, Market, SellingSystem, GameState, EventBus.
// Communication: Receives sell/purchase requests and publishes economic events such as MoneyChanged and ResourceSold.
// Must not depend on: WorkerMovement, rendering, or UI widgets.
// Planned functions: AddMoney(amount), TrySpendMoney(amount), CanAfford(amount), GetBalance(), ProcessSale(resource), ApplyEconomicEvent(event).
// Future considerations: Centralize validation here so every source of income and every purchase follows the same rules.
