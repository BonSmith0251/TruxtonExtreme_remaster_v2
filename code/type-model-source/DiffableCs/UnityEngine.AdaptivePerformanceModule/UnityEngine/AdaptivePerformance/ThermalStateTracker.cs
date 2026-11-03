namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000018")]
internal class ThermalStateTracker
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000069")]
	private float warningTemp; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400006A")]
	private float throttlingTemp; //Field offset: 0x14

	[Address(RVA = "0x2F99AB0", Offset = "0x2F98EB0", Length = "0x15")]
	[Token(Token = "0x60000AD")]
	public ThermalStateTracker() { }

	[Address(RVA = "0x2F99730", Offset = "0x2F98B30", Length = "0x371")]
	[Token(Token = "0x60000AE")]
	public StateAction Update() { }

}

