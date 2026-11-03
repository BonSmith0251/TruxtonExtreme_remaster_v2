namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000133")]
public class MemoryTraceWriter : ITraceWriter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005B6")]
	private readonly Queue<String> _traceMessages; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005B7")]
	private readonly object _lock; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005B8")]
	private TraceLevel <LevelFilter>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700016F")]
	public override TraceLevel LevelFilter
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000975")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000976")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x216CC40", Offset = "0x216C040", Length = "0xB3")]
	[Token(Token = "0x6000977")]
	public MemoryTraceWriter() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000975")]
	public override TraceLevel get_LevelFilter() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000979")]
	public IEnumerable<String> GetTraceMessages() { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000976")]
	public void set_LevelFilter(TraceLevel value) { }

	[Address(RVA = "0x216C730", Offset = "0x216BB30", Length = "0x26A")]
	[Token(Token = "0x600097A")]
	public virtual string ToString() { }

	[Address(RVA = "0x216C9A0", Offset = "0x216BDA0", Length = "0x29F")]
	[Token(Token = "0x6000978")]
	public override void Trace(TraceLevel level, string message, Exception ex) { }

}

