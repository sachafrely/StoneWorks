// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Coordinates passage of game time and schedules system updates without becoming a giant gameplay system.
// Rules: Not everything updates every frame. Physics/movement may use physics ticks; machines/markets/statistics use appropriate timers/events; idle calculations use larger intervals.
// Dependencies: GameTime, SimulationTick, major gameplay systems, EventBus.
// Communication: Drives Worker, Mining, Machine, Economy, Physics, and Statistics updates through clear interfaces.
// Must not depend on: UI presentation or detailed rules owned by individual systems.
