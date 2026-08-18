// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Coordinates the progression of simulation time and calls the major systems that need periodic updates.
// Responsibilities: Advance simulation ticks, apply simulation speed/pause, schedule systems at appropriate frequencies, and coordinate offline progression.
// Rules: SimulationSystem coordinates; it should not contain the internal rules of mining, workers, machines, economy, or physics.
// Dependencies: GameTime, Worker/Job systems, MiningSystem, MachineManager, Economy/Market, PhysicsWorld, StatisticsSystem, EventBus.
// Communication: Provides time steps to systems and reacts to pause/speed changes.
// Planned functions: Start(), Stop(), Update(delta), RunTick(delta), RunOfflineSimulation(duration), SetSimulationSpeed(multiplier), Pause(), Resume().
// Future considerations: Not every system needs a per-frame update. Physics/workers can tick frequently; markets/statistics can update less often; idle production can use larger analytical steps.
