namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Math/Matrix4x4.h")]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[RequiredByNativeCode]
[Token(Token = "0x20003AE")]
public class BatchRendererGroup : IDisposable
{
	[Token(Token = "0x20003B1")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6001D0D")]
		public static IntPtr ConvertToNative(BatchRendererGroup batchRendererGroup) { }

	}

	[Token(Token = "0x20003B0")]
	internal sealed class OnFinishedCulling : MulticastDelegate
	{

		[Address(RVA = "0x60D6F0", Offset = "0x60CAF0", Length = "0xA6")]
		[Token(Token = "0x6001D0B")]
		public OnFinishedCulling(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6001D0C")]
		public override void Invoke(IntPtr customCullingResult) { }

	}

	[Token(Token = "0x20003AF")]
	internal sealed class OnPerformCulling : MulticastDelegate
	{

		[Address(RVA = "0x30B60E0", Offset = "0x30B54E0", Length = "0x125")]
		[Token(Token = "0x6001D09")]
		public OnPerformCulling(object object, IntPtr method) { }

		[Address(RVA = "0x30B5FE0", Offset = "0x30B53E0", Length = "0xFD")]
		[Token(Token = "0x6001D0A")]
		public override JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, BatchCullingOutput cullingOutput, IntPtr userContext) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B7D")]
	private IntPtr m_GroupHandle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B7E")]
	private OnPerformCulling m_PerformCulling; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B7F")]
	private OnFinishedCulling m_FinishedCulling; //Field offset: 0x20

	[Token(Token = "0x170003F4")]
	public static BatchBufferTarget BufferTarget
	{
		[Address(RVA = "0x3098B50", Offset = "0x3097F50", Length = "0x2A")]
		[Token(Token = "0x6001CFC")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x30995D0", Offset = "0x30989D0", Length = "0x8D")]
	[Token(Token = "0x6001CF1")]
	public BatchRendererGroup(BatchRendererGroupCreateInfo info) { }

	[Address(RVA = "0x3098870", Offset = "0x3097C70", Length = "0xE4")]
	[Token(Token = "0x6001CF4")]
	public BatchID AddBatch(NativeArray<MetadataValue> batchMetadata, GraphicsBufferHandle buffer) { }

	[Address(RVA = "0x30989D0", Offset = "0x3097DD0", Length = "0x99")]
	[Token(Token = "0x6001CF3")]
	private BatchID AddDrawCommandBatch(IntPtr values, int count, GraphicsBufferHandle buffer, uint bufferOffset, uint windowSize) { }

	[Address(RVA = "0x3098960", Offset = "0x3097D60", Length = "0x62")]
	[Token(Token = "0x6001D02")]
	private static void AddDrawCommandBatch_Injected(IntPtr _unity_self, IntPtr values, int count, in GraphicsBufferHandle buffer, uint bufferOffset, uint windowSize, out BatchID ret) { }

	[Address(RVA = "0x3098A70", Offset = "0x3097E70", Length = "0x42")]
	[Token(Token = "0x6001CFD")]
	private static IntPtr Create(BatchRendererGroup group, Void* userContext) { }

	[Address(RVA = "0x3098AC0", Offset = "0x3097EC0", Length = "0x33")]
	[Token(Token = "0x6001CFE")]
	private static void Destroy(IntPtr groupHandle) { }

	[Address(RVA = "0x3098B00", Offset = "0x3097F00", Length = "0x48")]
	[Token(Token = "0x6001CF2")]
	public override void Dispose() { }

	[Address(RVA = "0x3098B50", Offset = "0x3097F50", Length = "0x2A")]
	[Token(Token = "0x6001CFC")]
	public static BatchBufferTarget get_BufferTarget() { }

	[Address(RVA = "0x3098B50", Offset = "0x3097F50", Length = "0x2A")]
	[Token(Token = "0x6001CFB")]
	private static BatchBufferTarget GetBufferTarget() { }

	[Address(RVA = "0x3098B80", Offset = "0x3097F80", Length = "0x5D")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001D00")]
	private static void InvokeOnFinishedCulling(BatchRendererGroup group, IntPtr customCullingResult) { }

	[Address(RVA = "0x3098BE0", Offset = "0x3097FE0", Length = "0x398")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001CFF")]
	private static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters, IntPtr userContext) { }

	[Address(RVA = "0x3098FD0", Offset = "0x30983D0", Length = "0x42")]
	[FreeFunction("BatchRendererGroup::OcclusionTestAABB", IsThreadSafe = True)]
	[Token(Token = "0x6001D01")]
	internal static bool OcclusionTestAABB(IntPtr occlusionBuffer, Bounds aabb) { }

	[Address(RVA = "0x3098F80", Offset = "0x3098380", Length = "0x42")]
	[Token(Token = "0x6001D08")]
	private static bool OcclusionTestAABB_Injected(IntPtr occlusionBuffer, in Bounds aabb) { }

	[Address(RVA = "0x3099080", Offset = "0x3098480", Length = "0x13B")]
	[Token(Token = "0x6001CF7")]
	internal void RegisterMaterials(ReadOnlySpan<EntityId> materialID, Span<BatchMaterialID> batchMaterialID) { }

	[Address(RVA = "0x3099020", Offset = "0x3098420", Length = "0x52")]
	[Token(Token = "0x6001D04")]
	private static void RegisterMaterials_Injected(IntPtr _unity_self, ref ManagedSpanWrapper materialID, ref ManagedSpanWrapper batchMaterialID) { }

	[Address(RVA = "0x3099220", Offset = "0x3098620", Length = "0x13B")]
	[Token(Token = "0x6001CF9")]
	internal void RegisterMeshes(ReadOnlySpan<EntityId> meshID, Span<BatchMeshID> batchMeshID) { }

	[Address(RVA = "0x30991C0", Offset = "0x30985C0", Length = "0x52")]
	[Token(Token = "0x6001D06")]
	private static void RegisterMeshes_Injected(IntPtr _unity_self, ref ManagedSpanWrapper meshID, ref ManagedSpanWrapper batchMeshID) { }

	[Address(RVA = "0x3099360", Offset = "0x3098760", Length = "0x5A")]
	[Token(Token = "0x6001CF6")]
	public void RemoveBatch(BatchID batchID) { }

	[Address(RVA = "0x3099410", Offset = "0x3098810", Length = "0x5A")]
	[Token(Token = "0x6001CF5")]
	private void RemoveDrawCommandBatch(BatchID batchID) { }

	[Address(RVA = "0x30993C0", Offset = "0x30987C0", Length = "0x42")]
	[Token(Token = "0x6001D03")]
	private static void RemoveDrawCommandBatch_Injected(IntPtr _unity_self, in BatchID batchID) { }

	[Address(RVA = "0x30994C0", Offset = "0x30988C0", Length = "0x5A")]
	[Token(Token = "0x6001CF8")]
	public void UnregisterMaterial(BatchMaterialID material) { }

	[Address(RVA = "0x3099470", Offset = "0x3098870", Length = "0x42")]
	[Token(Token = "0x6001D05")]
	private static void UnregisterMaterial_Injected(IntPtr _unity_self, in BatchMaterialID material) { }

	[Address(RVA = "0x3099570", Offset = "0x3098970", Length = "0x5A")]
	[Token(Token = "0x6001CFA")]
	public void UnregisterMesh(BatchMeshID mesh) { }

	[Address(RVA = "0x3099520", Offset = "0x3098920", Length = "0x42")]
	[Token(Token = "0x6001D07")]
	private static void UnregisterMesh_Injected(IntPtr _unity_self, in BatchMeshID mesh) { }

}

