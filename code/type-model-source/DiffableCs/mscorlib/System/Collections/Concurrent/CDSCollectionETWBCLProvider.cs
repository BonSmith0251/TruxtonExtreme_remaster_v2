namespace System.Collections.Concurrent;

[EventSource(Name = "System.Collections.Concurrent.ConcurrentCollectionsEventSource", Guid = "35167F8E-49B2-4b96-AB86-435B59336B5E")]
[Token(Token = "0x20005D6")]
internal sealed class CDSCollectionETWBCLProvider : EventSource
{
	[Token(Token = "0x400182C")]
	public static CDSCollectionETWBCLProvider Log; //Field offset: 0x0

	[Address(RVA = "0x1FBF970", Offset = "0x1FBED70", Length = "0xA2")]
	[Token(Token = "0x6002B2E")]
	private static CDSCollectionETWBCLProvider() { }

	[Address(RVA = "0x1FBFA20", Offset = "0x1FBEE20", Length = "0x50")]
	[Token(Token = "0x6002B2C")]
	private CDSCollectionETWBCLProvider() { }

	[Address(RVA = "0x945130", Offset = "0x944530", Length = "0x3")]
	[Event(3, Level = EventLevel::Warning (3))]
	[Token(Token = "0x6002B2D")]
	public void ConcurrentDictionary_AcquiringAllLocks(int numOfBuckets) { }

}

