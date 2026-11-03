namespace UnityEngine.ResourceManagement.Util;

[Token(Token = "0x200002F")]
internal sealed class IdCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000089")]
	public string ID; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400008A")]
	public Type locationType; //Field offset: 0x18

	[Address(RVA = "0x2E40D00", Offset = "0x2E40100", Length = "0x68")]
	[Token(Token = "0x600012A")]
	public IdCacheKey(string id) { }

	[Address(RVA = "0x1EF8380", Offset = "0x1EF7780", Length = "0x4E")]
	[Token(Token = "0x600012B")]
	public IdCacheKey(Type locType, string id) { }

	[Address(RVA = "0x2E40B40", Offset = "0x2E3FF40", Length = "0x7D")]
	[Token(Token = "0x600012C")]
	private bool Equals(IdCacheKey other) { }

	[Address(RVA = "0x2E40BC0", Offset = "0x2E3FFC0", Length = "0xC2")]
	[Token(Token = "0x600012E")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2E40A70", Offset = "0x2E3FE70", Length = "0xC2")]
	[Token(Token = "0x600012F")]
	public override bool Equals(IOperationCacheKey other) { }

	[Address(RVA = "0x2E40C90", Offset = "0x2E40090", Length = "0x63")]
	[Token(Token = "0x600012D")]
	public virtual int GetHashCode() { }

}

