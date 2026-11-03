namespace Unity.MemoryProfiler;

[Token(Token = "0x2000006")]
internal class DefaultMetadataCollect : MetadataCollect
{

	[Address(RVA = "0x2B32D20", Offset = "0x2B32120", Length = "0x154")]
	[Token(Token = "0x6000008")]
	public DefaultMetadataCollect() { }

	[Address(RVA = "0x2B32800", Offset = "0x2B31C00", Length = "0x276")]
	[Token(Token = "0x6000009")]
	public virtual void CollectMetadata(MemorySnapshotMetadata data) { }

	[Address(RVA = "0x2B32A80", Offset = "0x2B31E80", Length = "0x291")]
	[Token(Token = "0x600000A")]
	private string FormatSecondsToTime(double timeInSeconds) { }

}

