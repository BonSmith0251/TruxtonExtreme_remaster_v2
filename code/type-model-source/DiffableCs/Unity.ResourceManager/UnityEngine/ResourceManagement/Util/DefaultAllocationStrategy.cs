namespace UnityEngine.ResourceManagement.Util;

[Token(Token = "0x2000038")]
public class DefaultAllocationStrategy : IAllocationStrategy
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600014B")]
	public DefaultAllocationStrategy() { }

	[Address(RVA = "0x2E3D620", Offset = "0x2E3CA20", Length = "0xA")]
	[Token(Token = "0x6000149")]
	public override object New(Type type, int typeHash) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600014A")]
	public override void Release(int typeHash, object obj) { }

}

