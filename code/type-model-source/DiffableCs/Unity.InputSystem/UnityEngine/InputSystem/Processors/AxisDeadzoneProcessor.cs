namespace UnityEngine.InputSystem.Processors;

[Token(Token = "0x20001EC")]
public class AxisDeadzoneProcessor : InputProcessor<Single>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000AFF")]
	public float min; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000B00")]
	public float max; //Field offset: 0x14

	[Token(Token = "0x17000541")]
	private float maxOrDefault
	{
		[Address(RVA = "0x2A010B0", Offset = "0x2A004B0", Length = "0x6E")]
		[Token(Token = "0x6001253")]
		private get { } //Length: 110
	}

	[Token(Token = "0x17000540")]
	private float minOrDefault
	{
		[Address(RVA = "0x2A01120", Offset = "0x2A00520", Length = "0x6E")]
		[Token(Token = "0x6001252")]
		private get { } //Length: 110
	}

	[Address(RVA = "0x2A01070", Offset = "0x2A00470", Length = "0x39")]
	[Token(Token = "0x6001256")]
	public AxisDeadzoneProcessor() { }

	[Address(RVA = "0x2A010B0", Offset = "0x2A004B0", Length = "0x6E")]
	[Token(Token = "0x6001253")]
	private float get_maxOrDefault() { }

	[Address(RVA = "0x2A01120", Offset = "0x2A00520", Length = "0x6E")]
	[Token(Token = "0x6001252")]
	private float get_minOrDefault() { }

	[Address(RVA = "0x2A00DF0", Offset = "0x2A001F0", Length = "0x141")]
	[Token(Token = "0x6001254")]
	public virtual float Process(float value, InputControl control = null) { }

	[Address(RVA = "0x2A00F40", Offset = "0x2A00340", Length = "0x12D")]
	[Token(Token = "0x6001255")]
	public virtual string ToString() { }

}

