//Type is in global namespace

[Token(Token = "0x2000005")]
internal class DeltaTimeScaleProcessor : InputProcessor<Vector2>
{

	[Address(RVA = "0x28161B0", Offset = "0x28155B0", Length = "0x39")]
	[Token(Token = "0x6000007")]
	public DeltaTimeScaleProcessor() { }

	[Address(RVA = "0x2816110", Offset = "0x2815510", Length = "0x53")]
	[RuntimeInitializeOnLoadMethod]
	[Token(Token = "0x6000006")]
	private static void Initialize() { }

	[Address(RVA = "0x2816170", Offset = "0x2815570", Length = "0x31")]
	[Token(Token = "0x6000005")]
	public virtual Vector2 Process(Vector2 value, InputControl control) { }

}

