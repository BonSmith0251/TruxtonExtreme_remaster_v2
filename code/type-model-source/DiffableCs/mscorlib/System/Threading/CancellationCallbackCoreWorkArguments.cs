namespace System.Threading;

[Token(Token = "0x200020E")]
internal struct CancellationCallbackCoreWorkArguments
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009BB")]
	internal SparselyPopulatedArrayFragment<CancellationCallbackInfo> _currArrayFragment; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009BC")]
	internal int _currArrayIndex; //Field offset: 0x8

	[Address(RVA = "0xAEE5F0", Offset = "0xAED9F0", Length = "0x26")]
	[Token(Token = "0x60011FA")]
	public CancellationCallbackCoreWorkArguments(SparselyPopulatedArrayFragment<CancellationCallbackInfo> currArrayFragment, int currArrayIndex) { }

}

