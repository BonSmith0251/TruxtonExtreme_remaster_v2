namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Graphics/AsyncGPUReadbackManaged.h")]
[Token(Token = "0x2000338")]
[UsedByNativeCode]
internal struct AsyncRequestNativeArrayData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000874")]
	public Void* nativeArrayBuffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000875")]
	public long lengthInBytes; //Field offset: 0x8

	[Address(RVA = "0x7358F0", Offset = "0x734CF0", Length = "0xE4")]
	[Token(Token = "0x60019F9")]
	public static AsyncRequestNativeArrayData CreateAndCheckAccess(NativeArray<T> array) { }

}

