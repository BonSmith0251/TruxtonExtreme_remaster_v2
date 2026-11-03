namespace UnityEngine.ResourceManagement.Util;

[Token(Token = "0x2000031")]
internal sealed class DependenciesCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400008D")]
	private readonly IList<IResourceLocation> m_Dependencies; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400008E")]
	private readonly int m_DependenciesHash; //Field offset: 0x18

	[Address(RVA = "0xF63E90", Offset = "0xF63290", Length = "0x42")]
	[Token(Token = "0x6000135")]
	public DependenciesCacheKey(IList<IResourceLocation> dependencies, int dependenciesHash) { }

	[Address(RVA = "0x2E3E9F0", Offset = "0x2E3DDF0", Length = "0x7F")]
	[Token(Token = "0x6000137")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2E3EA90", Offset = "0x2E3DE90", Length = "0x7F")]
	[Token(Token = "0x6000138")]
	public override bool Equals(IOperationCacheKey other) { }

	[Address(RVA = "0x2E3EA70", Offset = "0x2E3DE70", Length = "0x20")]
	[Token(Token = "0x6000139")]
	private bool Equals(DependenciesCacheKey other) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000136")]
	public virtual int GetHashCode() { }

}

