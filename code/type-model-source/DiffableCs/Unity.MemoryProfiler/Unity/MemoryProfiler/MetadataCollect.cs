namespace Unity.MemoryProfiler;

[Token(Token = "0x2000005")]
public abstract class MetadataCollect : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000009")]
	private bool disposed; //Field offset: 0x10

	[Address(RVA = "0x2B32FB0", Offset = "0x2B323B0", Length = "0x126")]
	[Token(Token = "0x6000005")]
	protected MetadataCollect() { }

	[Token(Token = "0x6000006")]
	public abstract void CollectMetadata(MemorySnapshotMetadata data) { }

	[Address(RVA = "0x2B32E80", Offset = "0x2B32280", Length = "0x122")]
	[Token(Token = "0x6000007")]
	public override void Dispose() { }

}

