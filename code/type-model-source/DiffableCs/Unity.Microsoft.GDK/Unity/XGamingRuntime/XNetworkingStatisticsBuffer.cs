namespace Unity.XGamingRuntime;

[Token(Token = "0x2000241")]
public class XNetworkingStatisticsBuffer
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400063F")]
	internal XNetworkingStatisticsBuffer _interop; //Field offset: 0x10
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000640")]
	internal XNetworkingTcpQueuedReceivedBufferUsageStatistics _tcpQueuedReceivedBufferUsageStatistics; //Field offset: 0x38

	[Token(Token = "0x17000241")]
	internal XNetworkingStatisticsBuffer interop
	{
		[Address(RVA = "0x2B81C50", Offset = "0x2B81050", Length = "0x40")]
		[Token(Token = "0x6000BAA")]
		internal get { } //Length: 64
	}

	[Token(Token = "0x17000242")]
	public XNetworkingTcpQueuedReceivedBufferUsageStatistics TcpQueuedReceiveBufferUsage
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000BAB")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x6000BAC")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2B81B70", Offset = "0x2B80F70", Length = "0xA5")]
	[Token(Token = "0x6000BA8")]
	internal XNetworkingStatisticsBuffer(XNetworkingStatisticsBuffer interop) { }

	[Address(RVA = "0x2B81C20", Offset = "0x2B81020", Length = "0x27")]
	[Token(Token = "0x6000BA9")]
	public XNetworkingStatisticsBuffer() { }

	[Address(RVA = "0x2B81C50", Offset = "0x2B81050", Length = "0x40")]
	[Token(Token = "0x6000BAA")]
	internal XNetworkingStatisticsBuffer get_interop() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000BAB")]
	public XNetworkingTcpQueuedReceivedBufferUsageStatistics get_TcpQueuedReceiveBufferUsage() { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x6000BAC")]
	public void set_TcpQueuedReceiveBufferUsage(XNetworkingTcpQueuedReceivedBufferUsageStatistics value) { }

}

