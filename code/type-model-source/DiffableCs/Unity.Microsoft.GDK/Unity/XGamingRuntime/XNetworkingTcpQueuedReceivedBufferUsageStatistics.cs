namespace Unity.XGamingRuntime;

[Token(Token = "0x2000240")]
public class XNetworkingTcpQueuedReceivedBufferUsageStatistics
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400063E")]
	internal XNetworkingTcpQueuedReceivedBufferUsageStatistics interop; //Field offset: 0x10

	[Token(Token = "0x1700023C")]
	public ulong NumBytesCurrentlyQueued
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000B9E")]
		 get { } //Length: 5
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[Token(Token = "0x6000B9F")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000240")]
	public ulong NumBytesDroppedDueToAnyFailure
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000BA6")]
		 get { } //Length: 5
		[Address(RVA = "0x2162050", Offset = "0x2161450", Length = "0x5")]
		[Token(Token = "0x6000BA7")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700023F")]
	public ulong NumBytesDroppedForExceedingConfiguredMax
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000BA4")]
		 get { } //Length: 5
		[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
		[Token(Token = "0x6000BA5")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700023D")]
	public ulong PeakNumBytesEverQueued
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000BA0")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[Token(Token = "0x6000BA1")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700023E")]
	public ulong TotalNumBytesQueued
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000BA2")]
		 get { } //Length: 5
		[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
		[Token(Token = "0x6000BA3")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x2B81CA0", Offset = "0x2B810A0", Length = "0x3B")]
	[Token(Token = "0x6000B9C")]
	internal XNetworkingTcpQueuedReceivedBufferUsageStatistics(XNetworkingTcpQueuedReceivedBufferUsageStatistics interop) { }

	[Address(RVA = "0x2B81C20", Offset = "0x2B81020", Length = "0x27")]
	[Token(Token = "0x6000B9D")]
	public XNetworkingTcpQueuedReceivedBufferUsageStatistics() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000B9E")]
	public ulong get_NumBytesCurrentlyQueued() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000BA6")]
	public ulong get_NumBytesDroppedDueToAnyFailure() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000BA4")]
	public ulong get_NumBytesDroppedForExceedingConfiguredMax() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000BA0")]
	public ulong get_PeakNumBytesEverQueued() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000BA2")]
	public ulong get_TotalNumBytesQueued() { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[Token(Token = "0x6000B9F")]
	public void set_NumBytesCurrentlyQueued(ulong value) { }

	[Address(RVA = "0x2162050", Offset = "0x2161450", Length = "0x5")]
	[Token(Token = "0x6000BA7")]
	public void set_NumBytesDroppedDueToAnyFailure(ulong value) { }

	[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
	[Token(Token = "0x6000BA5")]
	public void set_NumBytesDroppedForExceedingConfiguredMax(ulong value) { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[Token(Token = "0x6000BA1")]
	public void set_PeakNumBytesEverQueued(ulong value) { }

	[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
	[Token(Token = "0x6000BA3")]
	public void set_TotalNumBytesQueued(ulong value) { }

}

