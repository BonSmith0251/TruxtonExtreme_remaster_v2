namespace UnityEngine.Bindings;

[NativeHeader("Runtime/Scripting/Marshalling/BindingsAllocator.h")]
[StaticAccessor("Marshalling::BindingsAllocator", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000250")]
[VisibleToOtherModules]
internal static class BindingsAllocator
{
	[Token(Token = "0x2000251")]
	private struct NativeOwnedMemory
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007B6")]
		public Void* data; //Field offset: 0x0

	}


	[Address(RVA = "0x3078270", Offset = "0x3077670", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x6001837")]
	public static void Free(Void* ptr) { }

	[Address(RVA = "0x3078230", Offset = "0x3077630", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x6001838")]
	public static void FreeNativeOwnedMemory(Void* ptr) { }

	[Address(RVA = "0x88FEE0", Offset = "0x88F2E0", Length = "0x16")]
	[Token(Token = "0x6001839")]
	public static Void* GetNativeOwnedDataPointer(Void* ptr) { }

}

