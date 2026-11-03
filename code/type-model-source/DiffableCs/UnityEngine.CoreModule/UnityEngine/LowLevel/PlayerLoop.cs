namespace UnityEngine.LowLevel;

[MovedFrom("UnityEngine.Experimental.LowLevel")]
[Token(Token = "0x200026A")]
public class PlayerLoop
{

	[Address(RVA = "0x30810C0", Offset = "0x30804C0", Length = "0x80")]
	[Token(Token = "0x600188C")]
	public static PlayerLoopSystem GetCurrentPlayerLoop() { }

	[Address(RVA = "0x3081090", Offset = "0x3080490", Length = "0x2A")]
	[NativeMethod(IsFreeFunction = True)]
	[Token(Token = "0x6001890")]
	private static PlayerLoopSystemInternal[] GetCurrentPlayerLoopInternal() { }

	[Address(RVA = "0x3081140", Offset = "0x3080540", Length = "0x2E0")]
	[Token(Token = "0x600188F")]
	private static PlayerLoopSystem InternalToPlayerLoopSystem(PlayerLoopSystemInternal[] internalSys, ref int offset) { }

	[Address(RVA = "0x3081430", Offset = "0x3080830", Length = "0x2CD")]
	[Token(Token = "0x600188E")]
	private static int PlayerLoopSystemToInternal(PlayerLoopSystem sys, ref List<PlayerLoopSystemInternal>& internalSys) { }

	[Address(RVA = "0x3081740", Offset = "0x3080B40", Length = "0xE8")]
	[Token(Token = "0x600188D")]
	public static void SetPlayerLoop(PlayerLoopSystem loop) { }

	[Address(RVA = "0x3081700", Offset = "0x3080B00", Length = "0x33")]
	[NativeMethod(IsFreeFunction = True)]
	[Token(Token = "0x6001891")]
	private static void SetPlayerLoopInternal(PlayerLoopSystemInternal[] loop) { }

}

