namespace System.Diagnostics.Tracing;

[Token(Token = "0x2000594")]
public class EventSource : IDisposable
{
	[Token(Token = "0x2000595")]
	private struct EventData
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400178E")]
		private IntPtr <DataPointer>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400178F")]
		private int <Size>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4001790")]
		private int <Reserved>k__BackingField; //Field offset: 0xC

		[Token(Token = "0x17000609")]
		public IntPtr DataPointer
		{
			[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6002926")]
			 set { } //Length: 4
		}

		[Token(Token = "0x1700060B")]
		internal int Reserved
		{
			[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6002928")]
			internal set { } //Length: 4
		}

		[Token(Token = "0x1700060A")]
		public int Size
		{
			[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6002927")]
			 set { } //Length: 4
		}

		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002926")]
		public void set_DataPointer(IntPtr value) { }

		[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002928")]
		internal void set_Reserved(int value) { }

		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002927")]
		public void set_Size(int value) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400178D")]
	private string <Name>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000608")]
	private string Name
	{
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6002918")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x1FBFA20", Offset = "0x1FBEE20", Length = "0x50")]
	[Token(Token = "0x6002914")]
	protected EventSource() { }

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6002915")]
	public EventSource(string eventSourceName) { }

	[Address(RVA = "0x1FC2100", Offset = "0x1FC1500", Length = "0x31")]
	[Token(Token = "0x6002916")]
	internal EventSource(Guid eventSourceGuid, string eventSourceName) { }

	[Address(RVA = "0x1FC1980", Offset = "0x1FC0D80", Length = "0x61")]
	[Token(Token = "0x600291B")]
	public override void Dispose() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600291C")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1E56230", Offset = "0x1E55630", Length = "0x65")]
	[Token(Token = "0x6002917")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002919")]
	public bool IsEnabled() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600291A")]
	public bool IsEnabled(EventLevel level, EventKeywords keywords) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6002918")]
	private void set_Name(string value) { }

	[Address(RVA = "0x1FC1DE0", Offset = "0x1FC11E0", Length = "0x136")]
	[Token(Token = "0x6002924")]
	protected void WriteEvent(int eventId, string arg1, string arg2, string arg3) { }

	[Address(RVA = "0x1FC1D20", Offset = "0x1FC1120", Length = "0xB3")]
	[Token(Token = "0x600291D")]
	protected void WriteEvent(int eventId, int arg1) { }

	[Address(RVA = "0x1FC19F0", Offset = "0x1FC0DF0", Length = "0x96")]
	[Token(Token = "0x600291E")]
	protected void WriteEvent(int eventId, string arg1) { }

	[Address(RVA = "0x1FC1FE0", Offset = "0x1FC13E0", Length = "0x11F")]
	[Token(Token = "0x600291F")]
	protected void WriteEvent(int eventId, int arg1, int arg2) { }

	[Address(RVA = "0x1FC1A90", Offset = "0x1FC0E90", Length = "0x186")]
	[Token(Token = "0x6002920")]
	protected void WriteEvent(int eventId, int arg1, int arg2, int arg3) { }

	[Address(RVA = "0x1FC1F20", Offset = "0x1FC1320", Length = "0xB0")]
	[Token(Token = "0x6002921")]
	protected void WriteEvent(int eventId, long arg1) { }

	[Address(RVA = "0x1FC1C20", Offset = "0x1FC1020", Length = "0xFC")]
	[Token(Token = "0x6002922")]
	protected void WriteEvent(int eventId, long arg1, string arg2) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6002923")]
	protected void WriteEvent(int eventId, Object[] args) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[CLSCompliant(False)]
	[Token(Token = "0x6002925")]
	protected void WriteEventCore(int eventId, int eventDataCount, EventData* data) { }

}

