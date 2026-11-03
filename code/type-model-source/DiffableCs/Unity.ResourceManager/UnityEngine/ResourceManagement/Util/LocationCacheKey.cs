namespace UnityEngine.ResourceManagement.Util;

[Token(Token = "0x2000030")]
internal sealed class LocationCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400008B")]
	private readonly IResourceLocation m_Location; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400008C")]
	private readonly Type m_DesiredType; //Field offset: 0x18

	[Address(RVA = "0x2E454D0", Offset = "0x2E448D0", Length = "0x10A")]
	[Token(Token = "0x6000130")]
	public LocationCacheKey(IResourceLocation location, Type desiredType) { }

	[Address(RVA = "0x2E452E0", Offset = "0x2E446E0", Length = "0x56")]
	[Token(Token = "0x6000132")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2E45420", Offset = "0x2E44820", Length = "0x56")]
	[Token(Token = "0x6000133")]
	public override bool Equals(IOperationCacheKey other) { }

	[Address(RVA = "0x2E45340", Offset = "0x2E44740", Length = "0xD0")]
	[Token(Token = "0x6000134")]
	private bool Equals(LocationCacheKey other) { }

	[Address(RVA = "0x2E45480", Offset = "0x2E44880", Length = "0x4D")]
	[Token(Token = "0x6000131")]
	public virtual int GetHashCode() { }

}

