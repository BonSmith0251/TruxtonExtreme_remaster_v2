namespace UnityEngine.ResourceManagement.Util;

[Token(Token = "0x2000032")]
internal sealed class AsyncOpHandlesCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400008F")]
	private readonly HashSet<AsyncOperationHandle> m_Handles; //Field offset: 0x10

	[Address(RVA = "0x2E3AAF0", Offset = "0x2E39EF0", Length = "0x87")]
	[Token(Token = "0x600013A")]
	public AsyncOpHandlesCacheKey(IList<AsyncOperationHandle> handles) { }

	[Address(RVA = "0x2E3A970", Offset = "0x2E39D70", Length = "0xBD")]
	[Token(Token = "0x600013C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2E3AA30", Offset = "0x2E39E30", Length = "0xBD")]
	[Token(Token = "0x600013D")]
	public override bool Equals(IOperationCacheKey other) { }

	[Address(RVA = "0x2E3A8F0", Offset = "0x2E39CF0", Length = "0x78")]
	[Token(Token = "0x600013E")]
	private bool Equals(AsyncOpHandlesCacheKey other) { }

	[Address(RVA = "0x1E3ED90", Offset = "0x1E3E190", Length = "0x2A")]
	[Token(Token = "0x600013B")]
	public virtual int GetHashCode() { }

}

