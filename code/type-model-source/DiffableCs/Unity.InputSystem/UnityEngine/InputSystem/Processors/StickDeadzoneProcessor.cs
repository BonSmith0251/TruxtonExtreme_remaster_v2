namespace UnityEngine.InputSystem.Processors;

[Token(Token = "0x20001F9")]
public class StickDeadzoneProcessor : InputProcessor<Vector2>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B11")]
	public float min; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000B12")]
	public float max; //Field offset: 0x14

	[Token(Token = "0x17000545")]
	private float maxOrDefault
	{
		[Address(RVA = "0x2A16ED0", Offset = "0x2A162D0", Length = "0x6E")]
		[Token(Token = "0x6001280")]
		private get { } //Length: 110
	}

	[Token(Token = "0x17000544")]
	private float minOrDefault
	{
		[Address(RVA = "0x2A16F40", Offset = "0x2A16340", Length = "0x6E")]
		[Token(Token = "0x600127F")]
		private get { } //Length: 110
	}

	[Address(RVA = "0x2A16E90", Offset = "0x2A16290", Length = "0x39")]
	[Token(Token = "0x6001284")]
	public StickDeadzoneProcessor() { }

	[Address(RVA = "0x2A16ED0", Offset = "0x2A162D0", Length = "0x6E")]
	[Token(Token = "0x6001280")]
	private float get_maxOrDefault() { }

	[Address(RVA = "0x2A16F40", Offset = "0x2A16340", Length = "0x6E")]
	[Token(Token = "0x600127F")]
	private float get_minOrDefault() { }

	[Address(RVA = "0x2A169E0", Offset = "0x2A15DE0", Length = "0x141")]
	[Token(Token = "0x6001282")]
	private float GetDeadZoneAdjustedValue(float value) { }

	[Address(RVA = "0x2A16B30", Offset = "0x2A15F30", Length = "0x22E")]
	[Token(Token = "0x6001281")]
	public virtual Vector2 Process(Vector2 value, InputControl control = null) { }

	[Address(RVA = "0x2A16D60", Offset = "0x2A16160", Length = "0x12D")]
	[Token(Token = "0x6001283")]
	public virtual string ToString() { }

}

