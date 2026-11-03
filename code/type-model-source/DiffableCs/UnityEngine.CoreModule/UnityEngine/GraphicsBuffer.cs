namespace UnityEngine;

[NativeHeader("Runtime/Export/Graphics/GraphicsBuffer.bindings.h")]
[NativeHeader("Runtime/Shaders/GraphicsBuffer.h")]
[Token(Token = "0x20000F1")]
[UsedByNativeCode]
public sealed class GraphicsBuffer : IDisposable
{
	[Token(Token = "0x20000F5")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x2FF1920", Offset = "0x2FF0D20", Length = "0x54")]
		[Token(Token = "0x6000A21")]
		public static GraphicsBuffer ConvertToManaged(IntPtr ptr) { }

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6000A22")]
		public static IntPtr ConvertToNative(GraphicsBuffer graphicsBuffer) { }

	}

	[Token(Token = "0x20000F4")]
	internal struct IndirectDrawIndexedArgs
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400029A")]
		private uint <indexCountPerInstance>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400029B")]
		private uint <instanceCount>k__BackingField; //Field offset: 0x4
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400029C")]
		private uint <startIndex>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400029D")]
		private uint <baseVertexIndex>k__BackingField; //Field offset: 0xC
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400029E")]
		private uint <startInstance>k__BackingField; //Field offset: 0x10

		[Token(Token = "0x17000195")]
		public uint indexCountPerInstance
		{
			[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
			[CompilerGenerated]
			[Token(Token = "0x6000A1F")]
			 set { } //Length: 3
		}

		[Token(Token = "0x17000196")]
		public uint instanceCount
		{
			[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000A20")]
			 set { } //Length: 4
		}

		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x6000A1F")]
		public void set_indexCountPerInstance(uint value) { }

		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000A20")]
		public void set_instanceCount(uint value) { }

	}

	[Flags]
	[Token(Token = "0x20000F2")]
	internal enum Target : int
	{
		Vertex = 1,
		Index = 2,
		CopySource = 4,
		CopyDestination = 8,
		Structured = 16,
		Raw = 32,
		Append = 64,
		Counter = 128,
		IndirectArguments = 256,
		Constant = 512,
	}

	[Flags]
	[Token(Token = "0x20000F3")]
	internal enum UsageFlags : int
	{
		None = 0,
		LockBufferForWrite = 1,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400028B")]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Token(Token = "0x17000193")]
	public GraphicsBufferHandle bufferHandle
	{
		[Address(RVA = "0x2FF5430", Offset = "0x2FF4830", Length = "0x62")]
		[Token(Token = "0x6000A04")]
		 get { } //Length: 98
	}

	[Token(Token = "0x17000190")]
	public int count
	{
		[Address(RVA = "0x2FF54E0", Offset = "0x2FF48E0", Length = "0x51")]
		[Token(Token = "0x6000A00")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000194")]
	public string name
	{
		[Address(RVA = "0x2FF55E0", Offset = "0x2FF49E0", Length = "0x8")]
		[Token(Token = "0x6000A11")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000191")]
	public int stride
	{
		[Address(RVA = "0x2FF5580", Offset = "0x2FF4980", Length = "0x51")]
		[Token(Token = "0x6000A01")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000192")]
	public UsageFlags usageFlags
	{
		[Address(RVA = "0x2FF4420", Offset = "0x2FF3820", Length = "0x51")]
		[Token(Token = "0x6000A03")]
		 get { } //Length: 81
	}

	[Address(RVA = "0x2B7F420", Offset = "0x2B7E820", Length = "0x26")]
	[Token(Token = "0x60009F9")]
	private GraphicsBuffer(IntPtr ptr) { }

	[Address(RVA = "0x2FF5370", Offset = "0x2FF4770", Length = "0x63")]
	[Token(Token = "0x60009FA")]
	public GraphicsBuffer(Target target, int count, int stride) { }

	[Address(RVA = "0x2FF5310", Offset = "0x2FF4710", Length = "0x53")]
	[Token(Token = "0x60009FB")]
	public GraphicsBuffer(Target target, UsageFlags usageFlags, int count, int stride) { }

	[Address(RVA = "0x2FF3D60", Offset = "0x2FF3160", Length = "0x67")]
	[Token(Token = "0x6000A0D")]
	private Void* BeginBufferWrite(int offset = 0, int size = 0) { }

	[Address(RVA = "0x2FF3D10", Offset = "0x2FF3110", Length = "0x50")]
	[Token(Token = "0x6000A1C")]
	private static Void* BeginBufferWrite_Injected(IntPtr _unity_self, int offset, int size) { }

	[Address(RVA = "0x2FF3E10", Offset = "0x2FF3210", Length = "0x3D")]
	[FreeFunction("GraphicsBuffer_Bindings::DestroyBuffer")]
	[Token(Token = "0x60009F8")]
	private static void DestroyBuffer(GraphicsBuffer buf) { }

	[Address(RVA = "0x2FF3DD0", Offset = "0x2FF31D0", Length = "0x33")]
	[Token(Token = "0x6000A13")]
	private static void DestroyBuffer_Injected(IntPtr buf) { }

	[Address(RVA = "0x2FF3E50", Offset = "0x2FF3250", Length = "0xB3")]
	[Token(Token = "0x60009F3")]
	public override void Dispose() { }

	[Address(RVA = "0x2FF3F10", Offset = "0x2FF3310", Length = "0xBE")]
	[Token(Token = "0x60009F4")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x2FF4010", Offset = "0x2FF3410", Length = "0x58")]
	[Token(Token = "0x6000A0F")]
	private void EndBufferWrite(int bytesWritten = 0) { }

	[Address(RVA = "0x2FF3FD0", Offset = "0x2FF33D0", Length = "0x40")]
	[Token(Token = "0x6000A1D")]
	private static void EndBufferWrite_Injected(IntPtr _unity_self, int bytesWritten) { }

	[Address(RVA = "0x2FF4070", Offset = "0x2FF3470", Length = "0xAB")]
	[Token(Token = "0x60009F2")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2FF5430", Offset = "0x2FF4830", Length = "0x62")]
	[Token(Token = "0x6000A04")]
	public GraphicsBufferHandle get_bufferHandle() { }

	[Address(RVA = "0x2FF53E0", Offset = "0x2FF47E0", Length = "0x42")]
	[Token(Token = "0x6000A18")]
	private static void get_bufferHandle_Injected(IntPtr _unity_self, out GraphicsBufferHandle ret) { }

	[Address(RVA = "0x2FF54E0", Offset = "0x2FF48E0", Length = "0x51")]
	[Token(Token = "0x6000A00")]
	public int get_count() { }

	[Address(RVA = "0x2FF54A0", Offset = "0x2FF48A0", Length = "0x33")]
	[Token(Token = "0x6000A15")]
	private static int get_count_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FF5580", Offset = "0x2FF4980", Length = "0x51")]
	[Token(Token = "0x6000A01")]
	public int get_stride() { }

	[Address(RVA = "0x2FF5540", Offset = "0x2FF4940", Length = "0x33")]
	[Token(Token = "0x6000A16")]
	private static int get_stride_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FF4420", Offset = "0x2FF3820", Length = "0x51")]
	[Token(Token = "0x6000A03")]
	public UsageFlags get_usageFlags() { }

	[Address(RVA = "0x2FF4120", Offset = "0x2FF3520", Length = "0x2BE")]
	[Token(Token = "0x6000A0B")]
	public void GetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count) { }

	[Address(RVA = "0x2FF4420", Offset = "0x2FF3820", Length = "0x51")]
	[FreeFunction(Name = "GraphicsBuffer_Bindings::GetUsageFlags", HasExplicitThis = True)]
	[Token(Token = "0x6000A02")]
	private UsageFlags GetUsageFlags() { }

	[Address(RVA = "0x2FF43E0", Offset = "0x2FF37E0", Length = "0x33")]
	[Token(Token = "0x6000A17")]
	private static UsageFlags GetUsageFlags_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FF4480", Offset = "0x2FF3880", Length = "0x5E")]
	[FreeFunction("GraphicsBuffer_Bindings::InitBuffer")]
	[Token(Token = "0x60009F7")]
	private static IntPtr InitBuffer(Target target, UsageFlags usageFlags, int count, int stride) { }

	[Address(RVA = "0x2FF4550", Offset = "0x2FF3950", Length = "0x79")]
	[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalGetData", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000A0C")]
	private void InternalGetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	[Address(RVA = "0x2FF44E0", Offset = "0x2FF38E0", Length = "0x62")]
	[Token(Token = "0x6000A1B")]
	private static void InternalGetData_Injected(IntPtr _unity_self, Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	[Address(RVA = "0x2FF45D0", Offset = "0x2FF39D0", Length = "0x3EC")]
	[Token(Token = "0x60009FC")]
	private void InternalInitialization(Target target, UsageFlags usageFlags, int count, int stride) { }

	[Address(RVA = "0x2FF4A30", Offset = "0x2FF3E30", Length = "0x79")]
	[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetData", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000A0A")]
	private void InternalSetData(Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[Address(RVA = "0x2FF49C0", Offset = "0x2FF3DC0", Length = "0x62")]
	[Token(Token = "0x6000A1A")]
	private static void InternalSetData_Injected(IntPtr _unity_self, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[Address(RVA = "0x2FF4B20", Offset = "0x2FF3F20", Length = "0x79")]
	[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetNativeData", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000A09")]
	private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[Address(RVA = "0x2FF4AB0", Offset = "0x2FF3EB0", Length = "0x62")]
	[Token(Token = "0x6000A19")]
	private static void InternalSetNativeData_Injected(IntPtr _unity_self, IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[Address(RVA = "0x2FF4C20", Offset = "0x2FF4020", Length = "0x56")]
	[Token(Token = "0x60009FF")]
	public bool IsValid() { }

	[Address(RVA = "0x2FF4BE0", Offset = "0x2FF3FE0", Length = "0x3D")]
	[FreeFunction("GraphicsBuffer_Bindings::IsValidBuffer")]
	[Token(Token = "0x60009FE")]
	private static bool IsValidBuffer(GraphicsBuffer buf) { }

	[Address(RVA = "0x2FF4BA0", Offset = "0x2FF3FA0", Length = "0x33")]
	[Token(Token = "0x6000A14")]
	private static bool IsValidBuffer_Injected(IntPtr buf) { }

	[Address(RVA = "0x2FF4C80", Offset = "0x2FF4080", Length = "0xD")]
	[Token(Token = "0x60009F6")]
	private static bool IsVertexIndexOrCopyOnly(Target target) { }

	[Address(RVA = "0x813A90", Offset = "0x812E90", Length = "0x31A")]
	[Token(Token = "0x6000A0E")]
	public NativeArray<T> LockBufferForWrite(int bufferStartIndex, int count) { }

	[Address(RVA = "0x2FF3E50", Offset = "0x2FF3250", Length = "0xB3")]
	[Token(Token = "0x60009FD")]
	public void Release() { }

	[Address(RVA = "0x2FF4C90", Offset = "0x2FF4090", Length = "0xC")]
	[Token(Token = "0x60009F5")]
	private static bool RequiresCompute(Target target) { }

	[Address(RVA = "0x2FF55E0", Offset = "0x2FF49E0", Length = "0x8")]
	[Token(Token = "0x6000A11")]
	public void set_name(string value) { }

	[Address(RVA = "0x814350", Offset = "0x813750", Length = "0x169")]
	[Token(Token = "0x6000A08")]
	public void SetData(NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Address(RVA = "0x2FF4CA0", Offset = "0x2FF40A0", Length = "0x2BE")]
	[Token(Token = "0x6000A07")]
	public void SetData(Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Address(RVA = "0x8144C0", Offset = "0x8138C0", Length = "0x84")]
	[Token(Token = "0x6000A06")]
	public void SetData(NativeArray<T> data) { }

	[Address(RVA = "0x2FF4F60", Offset = "0x2FF4360", Length = "0x199")]
	[Token(Token = "0x6000A05")]
	public void SetData(Array data) { }

	[Address(RVA = "0x2FF5150", Offset = "0x2FF4550", Length = "0x1BB")]
	[FreeFunction(Name = "GraphicsBuffer_Bindings::SetName", HasExplicitThis = True)]
	[Token(Token = "0x6000A12")]
	private void SetName(string name) { }

	[Address(RVA = "0x2FF5100", Offset = "0x2FF4500", Length = "0x42")]
	[Token(Token = "0x6000A1E")]
	private static void SetName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x814A30", Offset = "0x813E30", Length = "0xAB")]
	[Token(Token = "0x6000A10")]
	public void UnlockBufferAfterWrite(int countWritten) { }

}

