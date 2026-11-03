namespace UnityEngine.Rendering.RenderGraphModule;

[Token(Token = "0x200025E")]
internal class RenderGraphLogger
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000AD4")]
	private Dictionary<String, StringBuilder> m_LogMap; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000AD5")]
	private StringBuilder m_CurrentBuilder; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000AD6")]
	private int m_CurrentIndentation; //Field offset: 0x20

	[Address(RVA = "0x2C7BAF0", Offset = "0x2C7AEF0", Length = "0x77")]
	[Token(Token = "0x60010EE")]
	public RenderGraphLogger() { }

	[Address(RVA = "0x2C7B690", Offset = "0x2C7AA90", Length = "0x70")]
	[Token(Token = "0x60010EB")]
	public void DecrementIndentation(int value) { }

	[Address(RVA = "0x2C7B700", Offset = "0x2C7AB00", Length = "0x1F3")]
	[Token(Token = "0x60010ED")]
	public void FlushLogs() { }

	[Address(RVA = "0x2C7B900", Offset = "0x2C7AD00", Length = "0x64")]
	[Token(Token = "0x60010EA")]
	public void IncrementIndentation(int value) { }

	[Address(RVA = "0x2C7B970", Offset = "0x2C7AD70", Length = "0xEE")]
	[Token(Token = "0x60010E9")]
	public void Initialize(string logName) { }

	[Address(RVA = "0x2C7BA60", Offset = "0x2C7AE60", Length = "0x81")]
	[Token(Token = "0x60010EC")]
	public void LogLine(string format, Object[] args) { }

}

