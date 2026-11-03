namespace UnityEngine.InputSystem.LowLevel;

[Extension]
[Token(Token = "0x20001CF")]
internal static class InputRuntimeExtensions
{

	[Address(RVA = "0x8483D0", Offset = "0x8477D0", Length = "0xAD")]
	[Extension]
	[Token(Token = "0x6001151")]
	public static long DeviceCommand(IInputRuntime runtime, int deviceId, ref TCommand command) { }

}

