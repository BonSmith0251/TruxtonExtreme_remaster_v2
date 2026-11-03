namespace UnityEngine.Rendering;

[Token(Token = "0x2000071")]
public abstract class DebugDisplaySettingsPanel : DebugDisplaySettingsPanel
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400016F")]
	internal T m_Data; //Field offset: 0x0

	[Token(Token = "0x17000051")]
	public internal T data
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60005A4")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60005A5")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x17CDA00", Offset = "0x17CCE00", Length = "0x31")]
	[Token(Token = "0x60005A6")]
	protected DebugDisplaySettingsPanel`1(T data) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60005A4")]
	public T get_data() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60005A5")]
	internal void set_data(T value) { }

}

