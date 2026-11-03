namespace Newtonsoft.Json.Serialization;

[Token(Token = "0x2000109")]
public class DiagnosticsTraceWriter : ITraceWriter
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000506")]
	private TraceLevel <LevelFilter>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170000EF")]
	public override TraceLevel LevelFilter
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x60007AE")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007AF")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60007B2")]
	public DiagnosticsTraceWriter() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x60007AE")]
	public override TraceLevel get_LevelFilter() { }

	[Address(RVA = "0x213DB70", Offset = "0x213CF70", Length = "0x92")]
	[Token(Token = "0x60007B0")]
	private TraceEventType GetTraceEventType(TraceLevel level) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007AF")]
	public void set_LevelFilter(TraceLevel value) { }

	[Address(RVA = "0x213DC10", Offset = "0x213D010", Length = "0x415")]
	[NullableContext(1)]
	[Token(Token = "0x60007B1")]
	public override void Trace(TraceLevel level, string message, Exception ex) { }

}

