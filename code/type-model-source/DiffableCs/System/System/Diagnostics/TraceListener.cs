namespace System.Diagnostics;

[Token(Token = "0x2000102")]
public abstract class TraceListener : MarshalByRefObject, IDisposable
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000479")]
	private int indentLevel; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400047A")]
	private int indentSize; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400047B")]
	private TraceOptions traceOptions; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400047C")]
	private bool needIndent; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400047D")]
	private string listenerName; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400047E")]
	private TraceFilter filter; //Field offset: 0x30

	[ComVisible(False)]
	[Token(Token = "0x170000F8")]
	public TraceFilter Filter
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600063C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000F6")]
	public int IndentLevel
	{
		[Address(RVA = "0x2640180", Offset = "0x263F580", Length = "0x1D")]
		[Token(Token = "0x600063A")]
		 set { } //Length: 29
	}

	[Token(Token = "0x170000F7")]
	public int IndentSize
	{
		[Address(RVA = "0x26401A0", Offset = "0x263F5A0", Length = "0xB3")]
		[Token(Token = "0x600063B")]
		 set { } //Length: 179
	}

	[Token(Token = "0x170000F5")]
	public override bool IsThreadSafe
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000636")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000F9")]
	protected bool NeedIndent
	{
		[Address(RVA = "0x1DFC7D0", Offset = "0x1DFBBD0", Length = "0x5")]
		[Token(Token = "0x600063D")]
		 get { } //Length: 5
		[Address(RVA = "0x1CC8060", Offset = "0x1CC7460", Length = "0x4")]
		[Token(Token = "0x600063E")]
		 set { } //Length: 4
	}

	[ComVisible(False)]
	[Token(Token = "0x170000FA")]
	public TraceOptions TraceOutputOptions
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x600063F")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2640140", Offset = "0x263F540", Length = "0x3C")]
	[Token(Token = "0x6000635")]
	protected TraceListener(string name) { }

	[Address(RVA = "0x263F5E0", Offset = "0x263E9E0", Length = "0x61")]
	[Token(Token = "0x6000637")]
	public override void Dispose() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000638")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000639")]
	public override void Flush() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600063C")]
	public TraceFilter get_Filter() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000636")]
	public override bool get_IsThreadSafe() { }

	[Address(RVA = "0x1DFC7D0", Offset = "0x1DFBBD0", Length = "0x5")]
	[Token(Token = "0x600063D")]
	protected bool get_NeedIndent() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x600063F")]
	public TraceOptions get_TraceOutputOptions() { }

	[Address(RVA = "0x263F650", Offset = "0x263EA50", Length = "0x7")]
	[Token(Token = "0x6000646")]
	internal bool IsEnabled(TraceOptions opts) { }

	[Address(RVA = "0x2640180", Offset = "0x263F580", Length = "0x1D")]
	[Token(Token = "0x600063A")]
	public void set_IndentLevel(int value) { }

	[Address(RVA = "0x26401A0", Offset = "0x263F5A0", Length = "0xB3")]
	[Token(Token = "0x600063B")]
	public void set_IndentSize(int value) { }

	[Address(RVA = "0x1CC8060", Offset = "0x1CC7460", Length = "0x4")]
	[Token(Token = "0x600063E")]
	protected void set_NeedIndent(bool value) { }

	[Address(RVA = "0x263F660", Offset = "0x263EA60", Length = "0x19A")]
	[ComVisible(False)]
	[Token(Token = "0x6000643")]
	public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message) { }

	[Token(Token = "0x6000640")]
	public abstract void Write(string message) { }

	[Address(RVA = "0x263F800", Offset = "0x263EC00", Length = "0x778")]
	[Token(Token = "0x6000645")]
	private void WriteFooter(TraceEventCache eventCache) { }

	[Address(RVA = "0x263FF80", Offset = "0x263F380", Length = "0x106")]
	[Token(Token = "0x6000644")]
	private void WriteHeader(string source, TraceEventType eventType, int id) { }

	[Address(RVA = "0x2640090", Offset = "0x263F490", Length = "0xAC")]
	[Token(Token = "0x6000641")]
	protected override void WriteIndent() { }

	[Token(Token = "0x6000642")]
	public abstract void WriteLine(string message) { }

}

