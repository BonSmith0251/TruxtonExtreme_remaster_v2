namespace UnityEngine;

[NativeHeader("Runtime/Mono/Coroutine.h")]
[RequiredByNativeCode]
[Token(Token = "0x20001A2")]
public sealed class Coroutine : YieldInstruction
{
	[Token(Token = "0x20001A3")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6001300")]
		public static IntPtr ConvertToNative(Coroutine coroutine) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400065E")]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60012FD")]
	private Coroutine() { }

	[Address(RVA = "0x305E120", Offset = "0x305D520", Length = "0x7A")]
	[Token(Token = "0x60012FE")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x305E1A0", Offset = "0x305D5A0", Length = "0x33")]
	[FreeFunction("Coroutine::CleanupCoroutineGC", True)]
	[Token(Token = "0x60012FF")]
	private static void ReleaseCoroutine(IntPtr ptr) { }

}

