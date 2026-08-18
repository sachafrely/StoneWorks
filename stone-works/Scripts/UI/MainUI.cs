// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Coordinates the visible gameplay UI and connects UI controls to high-level game commands.
// Responsibilities: Display core resources/progress, manage main panels, route player actions, and refresh visible state.
// Rules: UI displays state and sends commands; it must not contain economy, mining, worker, machine, or physics rules.
// Dependencies: GameState/read models, EventBus, Window/UI components, progression/economy systems through clear interfaces.
// Communication: Subscribes to relevant events and sends commands to systems rather than modifying their internals.
// Planned functions: Initialize(), Refresh(), OpenWindow(id), CloseWindow(id), HandleCommand(command), UpdateResourceDisplay(), UpdateProgressDisplay().
// Future considerations: Define window ownership/conflicts centrally so settings, statistics, upgrades, market, and prestige panels cannot fight over visibility.
