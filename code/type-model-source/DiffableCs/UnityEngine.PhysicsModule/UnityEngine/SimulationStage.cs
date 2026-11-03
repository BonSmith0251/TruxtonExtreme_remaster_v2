namespace UnityEngine;

[Token(Token = "0x2000012")]
public enum SimulationStage : ushort
{
	None = 0,
	PrepareSimulation = 1,
	RunSimulation = 2,
	PublishSimulationResults = 4,
	All = 7,
}

