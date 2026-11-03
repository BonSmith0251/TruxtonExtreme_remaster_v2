namespace Unity.Cinemachine;

[Extension]
[Token(Token = "0x200007F")]
public static class CameraStateExtensions
{

	[Address(RVA = "0x2834EC0", Offset = "0x28342C0", Length = "0x598")]
	[Extension]
	[Token(Token = "0x600028A")]
	public static int FindCustomBlendable(CameraState s, object custom) { }

	[Address(RVA = "0x2835460", Offset = "0x2834860", Length = "0x16D")]
	[Extension]
	[Token(Token = "0x6000285")]
	public static Quaternion GetCorrectedOrientation(CameraState s) { }

	[Address(RVA = "0x28355D0", Offset = "0x28349D0", Length = "0x4B")]
	[Extension]
	[Token(Token = "0x6000284")]
	public static Vector3 GetCorrectedPosition(CameraState s) { }

	[Address(RVA = "0x2835620", Offset = "0x2834A20", Length = "0x3E1")]
	[Extension]
	[Token(Token = "0x6000289")]
	public static Item GetCustomBlendable(CameraState s, int index) { }

	[Address(RVA = "0x2835A10", Offset = "0x2834E10", Length = "0x38B")]
	[Extension]
	[Token(Token = "0x6000287")]
	public static Quaternion GetFinalOrientation(CameraState s) { }

	[Address(RVA = "0x28355D0", Offset = "0x28349D0", Length = "0x4B")]
	[Extension]
	[Token(Token = "0x6000286")]
	public static Vector3 GetFinalPosition(CameraState s) { }

	[Address(RVA = "0x1E17330", Offset = "0x1E16730", Length = "0x7")]
	[Extension]
	[Token(Token = "0x6000288")]
	public static int GetNumCustomBlendables(CameraState s) { }

	[Address(RVA = "0x2835DA0", Offset = "0x28351A0", Length = "0x52")]
	[Extension]
	[Token(Token = "0x6000283")]
	public static bool HasLookAt(CameraState s) { }

	[Address(RVA = "0x2835E00", Offset = "0x2835200", Length = "0x7B5")]
	[Extension]
	[Token(Token = "0x600028B")]
	public static bool IsTargetOffscreen(CameraState state) { }

}

