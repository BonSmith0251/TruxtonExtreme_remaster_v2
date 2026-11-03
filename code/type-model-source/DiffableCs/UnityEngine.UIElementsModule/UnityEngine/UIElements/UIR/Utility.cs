namespace UnityEngine.UIElements.UIR;

[NativeHeader("Modules/UIElements/Core/Native/Renderer/UIRendererUtility.h")]
[Token(Token = "0x2000570")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"Unity.UIElements"})]
internal class Utility
{
	[Token(Token = "0x2000572")]
	internal class GPUBuffer : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001214")]
		private IntPtr buffer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001215")]
		private int elemCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001216")]
		private int elemStride; //Field offset: 0x0

		[Token(Token = "0x17000A2E")]
		internal IntPtr BufferPointer
		{
			[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
			[Token(Token = "0x60027B6")]
			internal get { } //Length: 7
		}

		[Token(Token = "0x17000A2D")]
		public int ElementStride
		{
			[Address(RVA = "0x1C18DC0", Offset = "0x1C181C0", Length = "0x6")]
			[Token(Token = "0x60027B5")]
			 get { } //Length: 6
		}

		[Address(RVA = "0x1C18D20", Offset = "0x1C18120", Length = "0x85")]
		[Token(Token = "0x60027B2")]
		public GPUBuffer`1(int elementCount, GPUBufferType type) { }

		[Address(RVA = "0x1C188F0", Offset = "0x1C17CF0", Length = "0x4D")]
		[Token(Token = "0x60027B3")]
		public override void Dispose() { }

		[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
		[Token(Token = "0x60027B6")]
		internal IntPtr get_BufferPointer() { }

		[Address(RVA = "0x1C18DC0", Offset = "0x1C181C0", Length = "0x6")]
		[Token(Token = "0x60027B5")]
		public int get_ElementStride() { }

		[Address(RVA = "0x1C18B00", Offset = "0x1C17F00", Length = "0xD9")]
		[Token(Token = "0x60027B4")]
		public void UpdateRanges(NativeSlice<GfxUpdateBufferRange> ranges, int rangesMin, int rangesMax) { }

	}

	[Token(Token = "0x2000571")]
	public enum GPUBufferType : int
	{
		Vertex = 0,
		Index = 1,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400120D")]
	private static Action<Boolean> GraphicsResourcesRecreate; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400120E")]
	private static Action EngineUpdate; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400120F")]
	private static Action FlushPendingResources; //Field offset: 0x10
	[Token(Token = "0x4001210")]
	private static ProfilerMarker s_MarkerRaiseEngineUpdate; //Field offset: 0x18

	[Token(Token = "0x14000030")]
	public static event Action EngineUpdate
	{
		[Address(RVA = "0x32E6C70", Offset = "0x32E6070", Length = "0xF2")]
		[CompilerGenerated]
		[Token(Token = "0x600278A")]
		 add { } //Length: 242
		[Address(RVA = "0x32E6F80", Offset = "0x32E6380", Length = "0xF2")]
		[CompilerGenerated]
		[Token(Token = "0x600278B")]
		 remove { } //Length: 242
	}

	[Token(Token = "0x14000031")]
	public static event Action FlushPendingResources
	{
		[Address(RVA = "0x32E6D70", Offset = "0x32E6170", Length = "0xF2")]
		[CompilerGenerated]
		[Token(Token = "0x600278C")]
		 add { } //Length: 242
		[Address(RVA = "0x32E7080", Offset = "0x32E6480", Length = "0xF2")]
		[CompilerGenerated]
		[Token(Token = "0x600278D")]
		 remove { } //Length: 242
	}

	[Token(Token = "0x1400002F")]
	public static event Action<Boolean> GraphicsResourcesRecreate
	{
		[Address(RVA = "0x32E6E70", Offset = "0x32E6270", Length = "0x101")]
		[CompilerGenerated]
		[Token(Token = "0x6002788")]
		 add { } //Length: 257
		[Address(RVA = "0x32E7180", Offset = "0x32E6580", Length = "0x101")]
		[CompilerGenerated]
		[Token(Token = "0x6002789")]
		 remove { } //Length: 257
	}

	[Address(RVA = "0x32E6C10", Offset = "0x32E6010", Length = "0x5F")]
	[Token(Token = "0x60027AA")]
	private static Utility() { }

	[Address(RVA = "0x32E6C70", Offset = "0x32E6070", Length = "0xF2")]
	[CompilerGenerated]
	[Token(Token = "0x600278A")]
	public static void add_EngineUpdate(Action value) { }

	[Address(RVA = "0x32E6D70", Offset = "0x32E6170", Length = "0xF2")]
	[CompilerGenerated]
	[Token(Token = "0x600278C")]
	public static void add_FlushPendingResources(Action value) { }

	[Address(RVA = "0x32E6E70", Offset = "0x32E6270", Length = "0x101")]
	[CompilerGenerated]
	[Token(Token = "0x6002788")]
	public static void add_GraphicsResourcesRecreate(Action<Boolean> value) { }

	[Address(RVA = "0x32E5EA0", Offset = "0x32E52A0", Length = "0x50")]
	[ThreadSafe]
	[Token(Token = "0x6002791")]
	private static IntPtr AllocateBuffer(int elementCount, int elementStride, bool vertexBuffer) { }

	[Address(RVA = "0x32E5EF0", Offset = "0x32E52F0", Length = "0x2A")]
	[ThreadSafe]
	[Token(Token = "0x6002797")]
	public static IntPtr AllocateShaderPropertySheet() { }

	[Address(RVA = "0x32E5F20", Offset = "0x32E5320", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x600279A")]
	public static void ApplyShaderPropertySheet(IntPtr shaderPropertySheet) { }

	[Address(RVA = "0x32E5F60", Offset = "0x32E5360", Length = "0x31")]
	[ThreadSafe]
	[Token(Token = "0x60027A2")]
	public static bool CPUFencePassed(uint fence) { }

	[Address(RVA = "0x32E5FE0", Offset = "0x32E53E0", Length = "0x64")]
	[ThreadSafe]
	[Token(Token = "0x600279E")]
	public static IntPtr CreateStencilState(StencilState stencilState) { }

	[Address(RVA = "0x32E5FA0", Offset = "0x32E53A0", Length = "0x33")]
	[Token(Token = "0x60027AF")]
	private static IntPtr CreateStencilState_Injected(in StencilState stencilState) { }

	[Address(RVA = "0x32E6050", Offset = "0x32E5450", Length = "0x2A")]
	[ThreadSafe]
	[Token(Token = "0x600279D")]
	public static void DisableScissor() { }

	[Address(RVA = "0x32E6080", Offset = "0x32E5480", Length = "0x62")]
	[ThreadSafe]
	[Token(Token = "0x6002796")]
	public static void DrawRanges(IntPtr ib, IntPtr* vertexStreams, int streamCount, IntPtr ranges, int rangeCount, IntPtr vertexDecl) { }

	[Address(RVA = "0x32E60F0", Offset = "0x32E54F0", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x6002792")]
	private static void FreeBuffer(IntPtr buffer) { }

	[Address(RVA = "0x32E6170", Offset = "0x32E5570", Length = "0x6D")]
	[ThreadSafe]
	[Token(Token = "0x60027A5")]
	public static RectInt GetActiveViewport() { }

	[Address(RVA = "0x32E6130", Offset = "0x32E5530", Length = "0x33")]
	[Token(Token = "0x60027B0")]
	private static void GetActiveViewport_Injected(out RectInt ret) { }

	[Address(RVA = "0x32E6220", Offset = "0x32E5620", Length = "0x79")]
	[ThreadSafe]
	[Token(Token = "0x60027A9")]
	public static Matrix4x4 GetUnityProjectionMatrix() { }

	[Address(RVA = "0x32E61E0", Offset = "0x32E55E0", Length = "0x33")]
	[Token(Token = "0x60027B1")]
	private static void GetUnityProjectionMatrix_Injected(out Matrix4x4 ret) { }

	[Address(RVA = "0x32E62E0", Offset = "0x32E56E0", Length = "0xDD")]
	[ThreadSafe]
	[Token(Token = "0x6002795")]
	public static IntPtr GetVertexDeclaration(VertexAttributeDescriptor[] vertexAttributes) { }

	[Address(RVA = "0x32E62A0", Offset = "0x32E56A0", Length = "0x33")]
	[Token(Token = "0x60027AC")]
	private static IntPtr GetVertexDeclaration_Injected(ref ManagedSpanWrapper vertexAttributes) { }

	[Address(RVA = "0x32E63C0", Offset = "0x32E57C0", Length = "0x2A")]
	[ThreadSafe]
	[Token(Token = "0x60027A0")]
	public static bool HasMappedBufferRange() { }

	[Address(RVA = "0x32E63F0", Offset = "0x32E57F0", Length = "0x2A")]
	[ThreadSafe]
	[Token(Token = "0x60027A1")]
	public static uint InsertCPUFence() { }

	[Address(RVA = "0x32E6420", Offset = "0x32E5820", Length = "0x33")]
	[Token(Token = "0x60027A8")]
	public static void NotifyOfUIREvents(bool subscribe) { }

	[Address(RVA = "0x32E6460", Offset = "0x32E5860", Length = "0x2A")]
	[ThreadSafe]
	[Token(Token = "0x60027A6")]
	public static void ProfileDrawChainBegin() { }

	[Address(RVA = "0x32E6490", Offset = "0x32E5890", Length = "0x2A")]
	[ThreadSafe]
	[Token(Token = "0x60027A7")]
	public static void ProfileDrawChainEnd() { }

	[Address(RVA = "0x32E64C0", Offset = "0x32E58C0", Length = "0x8C")]
	[RequiredByNativeCode]
	[Token(Token = "0x600278F")]
	internal static void RaiseEngineUpdate() { }

	[Address(RVA = "0x32E6550", Offset = "0x32E5950", Length = "0x67")]
	[RequiredByNativeCode]
	[Token(Token = "0x6002790")]
	internal static void RaiseFlushPendingResources() { }

	[Address(RVA = "0x32E65C0", Offset = "0x32E59C0", Length = "0x70")]
	[RequiredByNativeCode]
	[Token(Token = "0x600278E")]
	internal static void RaiseGraphicsResourcesRecreate(bool recreate) { }

	[Address(RVA = "0x32E6630", Offset = "0x32E5A30", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x600279B")]
	public static void ReleasePropertySheet(IntPtr shaderPropertySheet) { }

	[Address(RVA = "0x32E6F80", Offset = "0x32E6380", Length = "0xF2")]
	[CompilerGenerated]
	[Token(Token = "0x600278B")]
	public static void remove_EngineUpdate(Action value) { }

	[Address(RVA = "0x32E7080", Offset = "0x32E6480", Length = "0xF2")]
	[CompilerGenerated]
	[Token(Token = "0x600278D")]
	public static void remove_FlushPendingResources(Action value) { }

	[Address(RVA = "0x32E7180", Offset = "0x32E6580", Length = "0x101")]
	[CompilerGenerated]
	[Token(Token = "0x6002789")]
	public static void remove_GraphicsResourcesRecreate(Action<Boolean> value) { }

	[Address(RVA = "0x32E6670", Offset = "0x32E5A70", Length = "0x62")]
	[ThreadSafe]
	[Token(Token = "0x6002798")]
	public static void SetAllTextures(IntPtr shaderPropertySheet, IntPtr textureNames, IntPtr texturePtrs, int count) { }

	[Address(RVA = "0x32E6720", Offset = "0x32E5B20", Length = "0x6F")]
	[ThreadSafe]
	[Token(Token = "0x6002799")]
	public static void SetPropertyBlock(MaterialPropertyBlock props) { }

	[Address(RVA = "0x32E66E0", Offset = "0x32E5AE0", Length = "0x33")]
	[Token(Token = "0x60027AD")]
	private static void SetPropertyBlock_Injected(IntPtr props) { }

	[Address(RVA = "0x32E67D0", Offset = "0x32E5BD0", Length = "0x64")]
	[ThreadSafe]
	[Token(Token = "0x600279C")]
	public static void SetScissorRect(RectInt scissorRect) { }

	[Address(RVA = "0x32E6790", Offset = "0x32E5B90", Length = "0x33")]
	[Token(Token = "0x60027AE")]
	private static void SetScissorRect_Injected(in RectInt scissorRect) { }

	[Address(RVA = "0x32E6840", Offset = "0x32E5C40", Length = "0x40")]
	[ThreadSafe]
	[Token(Token = "0x600279F")]
	public static void SetStencilState(IntPtr stencilState, int stencilRef) { }

	[Address(RVA = "0x32E6A20", Offset = "0x32E5E20", Length = "0x10A")]
	[ThreadSafe]
	[Token(Token = "0x6002794")]
	private static void SetVectorArray(IntPtr shaderPropertySheet, int name, Vector4[] values, int count) { }

	[Address(RVA = "0x32E68E0", Offset = "0x32E5CE0", Length = "0x13C")]
	[Token(Token = "0x6002787")]
	public static void SetVectorArray(IntPtr shaderPropertySheet, int nameID, Vector4[] vector4s) { }

	[Address(RVA = "0x32E6880", Offset = "0x32E5C80", Length = "0x60")]
	[Token(Token = "0x60027AB")]
	private static void SetVectorArray_Injected(IntPtr shaderPropertySheet, int name, ref ManagedSpanWrapper values, int count) { }

	[Address(RVA = "0x32E6B30", Offset = "0x32E5F30", Length = "0x2A")]
	[ThreadSafe]
	[Token(Token = "0x60027A4")]
	public static void SyncRenderThread() { }

	[Address(RVA = "0x32E6B60", Offset = "0x32E5F60", Length = "0x62")]
	[ThreadSafe]
	[Token(Token = "0x6002793")]
	private static void UpdateBufferRanges(IntPtr buffer, IntPtr ranges, int rangeCount, int writeRangeStart, int writeRangeEnd) { }

	[Address(RVA = "0x32E6BD0", Offset = "0x32E5FD0", Length = "0x31")]
	[ThreadSafe]
	[Token(Token = "0x60027A3")]
	public static void WaitForCPUFencePassed(uint fence) { }

}

