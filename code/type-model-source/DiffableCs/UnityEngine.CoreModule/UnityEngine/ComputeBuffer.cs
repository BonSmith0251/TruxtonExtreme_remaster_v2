namespace UnityEngine;

[NativeClass("GraphicsBuffer")]
[NativeHeader("Runtime/Export/Graphics/GraphicsBuffer.bindings.h")]
[NativeHeader("Runtime/Shaders/GraphicsBuffer.h")]
[Token(Token = "0x20001E0")]
[UsedByNativeCode]
public sealed class ComputeBuffer : IDisposable
{
	[Token(Token = "0x20001E1")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x60014E6")]
		public static IntPtr ConvertToNative(ComputeBuffer computeBuffer) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006C4")]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Token(Token = "0x170002FF")]
	public int count
	{
		[Address(RVA = "0x3059BE0", Offset = "0x3058FE0", Length = "0x51")]
		[Token(Token = "0x60014DA")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000300")]
	public int stride
	{
		[Address(RVA = "0x3059C80", Offset = "0x3059080", Length = "0x51")]
		[Token(Token = "0x60014DB")]
		 get { } //Length: 81
	}

	[Address(RVA = "0x3059B70", Offset = "0x3058F70", Length = "0x24")]
	[Token(Token = "0x60014D6")]
	public ComputeBuffer(int count, int stride) { }

	[Address(RVA = "0x3059960", Offset = "0x3058D60", Length = "0x21")]
	[Token(Token = "0x60014D7")]
	public ComputeBuffer(int count, int stride, ComputeBufferType type) { }

	[Address(RVA = "0x3059990", Offset = "0x3058D90", Length = "0x1DD")]
	[Token(Token = "0x60014D8")]
	private ComputeBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth) { }

	[Address(RVA = "0x3059310", Offset = "0x3058710", Length = "0x3D")]
	[FreeFunction("GraphicsBuffer_Bindings::DestroyComputeBuffer")]
	[Token(Token = "0x60014D5")]
	private static void DestroyBuffer(ComputeBuffer buf) { }

	[Address(RVA = "0x30592D0", Offset = "0x30586D0", Length = "0x33")]
	[Token(Token = "0x60014E1")]
	private static void DestroyBuffer_Injected(IntPtr buf) { }

	[Address(RVA = "0x3059350", Offset = "0x3058750", Length = "0xB3")]
	[Token(Token = "0x60014D2")]
	public override void Dispose() { }

	[Address(RVA = "0x3059410", Offset = "0x3058810", Length = "0xBE")]
	[Token(Token = "0x60014D3")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x30594D0", Offset = "0x30588D0", Length = "0xAB")]
	[Token(Token = "0x60014D1")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x3059BE0", Offset = "0x3058FE0", Length = "0x51")]
	[Token(Token = "0x60014DA")]
	public int get_count() { }

	[Address(RVA = "0x3059BA0", Offset = "0x3058FA0", Length = "0x33")]
	[Token(Token = "0x60014E2")]
	private static int get_count_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3059C80", Offset = "0x3059080", Length = "0x51")]
	[Token(Token = "0x60014DB")]
	public int get_stride() { }

	[Address(RVA = "0x3059C40", Offset = "0x3059040", Length = "0x33")]
	[Token(Token = "0x60014E3")]
	private static int get_stride_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3059580", Offset = "0x3058980", Length = "0x5E")]
	[FreeFunction("GraphicsBuffer_Bindings::InitComputeBuffer")]
	[Token(Token = "0x60014D4")]
	private static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage) { }

	[Address(RVA = "0x3059650", Offset = "0x3058A50", Length = "0x79")]
	[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetData", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x60014E0")]
	private void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	[Address(RVA = "0x30595E0", Offset = "0x30589E0", Length = "0x62")]
	[Token(Token = "0x60014E5")]
	private static void InternalSetData_Injected(IntPtr _unity_self, Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	[Address(RVA = "0x3059740", Offset = "0x3058B40", Length = "0x79")]
	[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetNativeData", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x60014DF")]
	private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	[Address(RVA = "0x30596D0", Offset = "0x3058AD0", Length = "0x62")]
	[Token(Token = "0x60014E4")]
	private static void InternalSetNativeData_Injected(IntPtr _unity_self, IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	[Address(RVA = "0x3059350", Offset = "0x3058750", Length = "0xB3")]
	[Token(Token = "0x60014D9")]
	public void Release() { }

	[Address(RVA = "0x30597C0", Offset = "0x3058BC0", Length = "0x199")]
	[Token(Token = "0x60014DC")]
	public void SetData(Array data) { }

	[Address(RVA = "0x7A6D10", Offset = "0x7A6110", Length = "0x84")]
	[Token(Token = "0x60014DD")]
	public void SetData(NativeArray<T> data) { }

	[Address(RVA = "0x7A6E30", Offset = "0x7A6230", Length = "0x169")]
	[Token(Token = "0x60014DE")]
	public void SetData(NativeArray<T> data, int nativeBufferStartIndex, int computeBufferStartIndex, int count) { }

}

