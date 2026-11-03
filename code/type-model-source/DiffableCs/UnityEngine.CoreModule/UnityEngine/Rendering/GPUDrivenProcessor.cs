namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/GPUDrivenProcessor.h")]
[RequiredByNativeCode]
[Token(Token = "0x20003B7")]
internal class GPUDrivenProcessor
{
	[CompilerGenerated]
	[Token(Token = "0x20003B9")]
	private sealed class <>c
	{
		[Token(Token = "0x4000B85")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x30B9140", Offset = "0x30B8540", Length = "0x67")]
		[Token(Token = "0x6001D33")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001D34")]
		public <>c() { }

		[Address(RVA = "0x30B85A0", Offset = "0x30B79A0", Length = "0x818")]
		[Token(Token = "0x6001D35")]
		internal void <.cctor>b__34_0(in GPUDrivenRendererGroupDataNative nativeData, List<Mesh> meshes, List<Material> materials, GPUDrivenRendererDataCallback callback) { }

		[Address(RVA = "0x30B8DC0", Offset = "0x30B81C0", Length = "0x37F")]
		[Token(Token = "0x6001D36")]
		internal void <.cctor>b__34_1(in GPUDrivenLODGroupDataNative nativeData, GPUDrivenLODGroupDataCallback callback) { }

	}

	[Token(Token = "0x20003B8")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6001D32")]
		public static IntPtr ConvertToNative(GPUDrivenProcessor obj) { }

	}

	[Token(Token = "0x4000B83")]
	private static GPUDrivenRendererDataNativeCallback s_NativeRendererCallback; //Field offset: 0x0
	[Token(Token = "0x4000B84")]
	private static GPUDrivenLODGroupDataNativeCallback s_NativeLODGroupCallback; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B80")]
	internal IntPtr m_Ptr; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B81")]
	private List<Mesh> <scratchMeshes>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B82")]
	private List<Material> <scratchMaterials>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x170003F7")]
	public bool enablePartialRendering
	{
		[Address(RVA = "0x30B4D30", Offset = "0x30B4130", Length = "0x9B")]
		[Token(Token = "0x6001D27")]
		 set { } //Length: 155
	}

	[Token(Token = "0x170003F6")]
	internal List<Material> scratchMaterials
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001D1A")]
		internal get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6001D1B")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170003F5")]
	internal List<Mesh> scratchMeshes
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001D18")]
		internal get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6001D19")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x30B4970", Offset = "0x30B3D70", Length = "0x250")]
	[Token(Token = "0x6001D2B")]
	private static GPUDrivenProcessor() { }

	[Address(RVA = "0x30B4BD0", Offset = "0x30B3FD0", Length = "0x103")]
	[Token(Token = "0x6001D1C")]
	public GPUDrivenProcessor() { }

	[Address(RVA = "0x30B3D30", Offset = "0x30B3130", Length = "0x129")]
	[Token(Token = "0x6001D2A")]
	public static int ClassifyMaterials(NativeArray<EntityId> materialIDs, NativeArray<EntityId> unsupportedMaterialIDs, NativeArray<EntityId> supportedMaterialIDs, NativeArray<GPUDrivenPackedMaterialData> supportedPackedMaterialDatas) { }

	[Address(RVA = "0x30B3B70", Offset = "0x30B2F70", Length = "0x1BF")]
	[FreeFunction("GPUDrivenProcessor::ClassifyMaterials", IsThreadSafe = True)]
	[Token(Token = "0x6001D29")]
	private static int ClassifyMaterialsImpl(ReadOnlySpan<EntityId> materialIDs, Span<EntityId> unsupportedMaterialIDs, Span<EntityId> supportedMaterialIDs, Span<GPUDrivenPackedMaterialData> supportedPackedMaterialDatas) { }

	[Address(RVA = "0x30B3B00", Offset = "0x30B2F00", Length = "0x62")]
	[Token(Token = "0x6001D31")]
	private static int ClassifyMaterialsImpl_Injected(ref ManagedSpanWrapper materialIDs, ref ManagedSpanWrapper unsupportedMaterialIDs, ref ManagedSpanWrapper supportedMaterialIDs, ref ManagedSpanWrapper supportedPackedMaterialDatas) { }

	[Address(RVA = "0x30B3EA0", Offset = "0x30B32A0", Length = "0x8B")]
	[Token(Token = "0x6001D28")]
	public void ClearMaterialFilters() { }

	[Address(RVA = "0x30B3E60", Offset = "0x30B3260", Length = "0x33")]
	[Token(Token = "0x6001D30")]
	private static void ClearMaterialFilters_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30B3F30", Offset = "0x30B3330", Length = "0x81")]
	[Token(Token = "0x6001D1F")]
	private void Destroy() { }

	[Address(RVA = "0x30B4010", Offset = "0x30B3410", Length = "0xF6")]
	[Token(Token = "0x6001D24")]
	public void DisableGPUDrivenRendering(ReadOnlySpan<EntityId> renderersID) { }

	[Address(RVA = "0x30B3FC0", Offset = "0x30B33C0", Length = "0x42")]
	[Token(Token = "0x6001D2D")]
	private static void DisableGPUDrivenRendering_Injected(IntPtr _unity_self, ref ManagedSpanWrapper renderersID) { }

	[Address(RVA = "0x30B4180", Offset = "0x30B3580", Length = "0x119")]
	[Token(Token = "0x6001D25")]
	private void DispatchLODGroupData(ReadOnlySpan<EntityId> lodGroupID, GPUDrivenLODGroupDataNativeCallback callback, GPUDrivenLODGroupDataCallback param) { }

	[Address(RVA = "0x30B42A0", Offset = "0x30B36A0", Length = "0x1A6")]
	[Token(Token = "0x6001D26")]
	public void DispatchLODGroupData(ReadOnlySpan<EntityId> lodGroupID, GPUDrivenLODGroupDataCallback callback) { }

	[Address(RVA = "0x30B4110", Offset = "0x30B3510", Length = "0x62")]
	[Token(Token = "0x6001D2E")]
	private static void DispatchLODGroupData_Injected(IntPtr _unity_self, ref ManagedSpanWrapper lodGroupID, GPUDrivenLODGroupDataNativeCallback callback, GPUDrivenLODGroupDataCallback param) { }

	[Address(RVA = "0x30B4450", Offset = "0x30B3850", Length = "0x79")]
	[Token(Token = "0x6001D1E")]
	public void Dispose() { }

	[Address(RVA = "0x30B4750", Offset = "0x30B3B50", Length = "0x140")]
	[Token(Token = "0x6001D22")]
	private void EnableGPUDrivenRenderingAndDispatchRendererData(ReadOnlySpan<EntityId> renderersID, GPUDrivenRendererDataNativeCallback callback, List<Mesh> meshes, List<Material> materials, GPUDrivenRendererDataCallback param, bool materialUpdateOnly) { }

	[Address(RVA = "0x30B4550", Offset = "0x30B3950", Length = "0x1FF")]
	[Token(Token = "0x6001D23")]
	public void EnableGPUDrivenRenderingAndDispatchRendererData(ReadOnlySpan<EntityId> renderersID, GPUDrivenRendererDataCallback callback, bool materialUpdateOnly = false) { }

	[Address(RVA = "0x30B44D0", Offset = "0x30B38D0", Length = "0x73")]
	[Token(Token = "0x6001D2C")]
	private static void EnableGPUDrivenRenderingAndDispatchRendererData_Injected(IntPtr _unity_self, ref ManagedSpanWrapper renderersID, GPUDrivenRendererDataNativeCallback callback, List<Mesh> meshes, List<Material> materials, GPUDrivenRendererDataCallback param, bool materialUpdateOnly) { }

	[Address(RVA = "0x30B48A0", Offset = "0x30B3CA0", Length = "0x57")]
	[Token(Token = "0x6001D1D")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001D1A")]
	internal List<Material> get_scratchMaterials() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001D18")]
	internal List<Mesh> get_scratchMeshes() { }

	[Address(RVA = "0x30B4900", Offset = "0x30B3D00", Length = "0x2A")]
	[Token(Token = "0x6001D20")]
	private static IntPtr Internal_Create() { }

	[Address(RVA = "0x30B4930", Offset = "0x30B3D30", Length = "0x33")]
	[Token(Token = "0x6001D21")]
	private static void Internal_Destroy(IntPtr ptr) { }

	[Address(RVA = "0x30B4D30", Offset = "0x30B4130", Length = "0x9B")]
	[Token(Token = "0x6001D27")]
	public void set_enablePartialRendering(bool value) { }

	[Address(RVA = "0x30B4CE0", Offset = "0x30B40E0", Length = "0x42")]
	[Token(Token = "0x6001D2F")]
	private static void set_enablePartialRendering_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6001D1B")]
	private void set_scratchMaterials(List<Material> value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6001D19")]
	private void set_scratchMeshes(List<Mesh> value) { }

}

