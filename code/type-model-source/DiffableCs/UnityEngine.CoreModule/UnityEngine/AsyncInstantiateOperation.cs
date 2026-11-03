namespace UnityEngine;

[NativeHeader("Runtime/GameCode/AsyncInstantiate/AsyncInstantiateOperation.h")]
[RequiredByNativeCode]
[Token(Token = "0x200017E")]
public class AsyncInstantiateOperation : AsyncOperation
{
	[Token(Token = "0x400061A")]
	internal static CancellationTokenSource s_GlobalCancellation; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400061B")]
	internal Object[] m_Result; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400061C")]
	private CancellationToken m_CancellationToken; //Field offset: 0x28

	[Address(RVA = "0x3054870", Offset = "0x3053C70", Length = "0x73")]
	[Token(Token = "0x600125B")]
	private static AsyncInstantiateOperation() { }

	[Address(RVA = "0x30548F0", Offset = "0x3053CF0", Length = "0x107")]
	[Token(Token = "0x6001258")]
	protected AsyncInstantiateOperation(IntPtr ptr, CancellationToken cancellationToken) { }

	[Address(RVA = "0x30547C0", Offset = "0x3053BC0", Length = "0x58")]
	[Token(Token = "0x600125A")]
	internal override Object[] CreateResultArray(int size) { }

	[Address(RVA = "0x3054820", Offset = "0x3053C20", Length = "0x4A")]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6001259")]
	private bool IsCancellationRequested() { }

}

