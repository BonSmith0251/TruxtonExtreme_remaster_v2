namespace UnityEngine.Rendering;

[BurstCompile]
[Token(Token = "0x2000062")]
internal static class InstanceCullingBatcherBurst
{
	[Token(Token = "0x2000066")]
	public static class CreateDrawBatches_0000018C$BurstDirectCall
	{
		[Token(Token = "0x40001B6")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x2CDEE10", Offset = "0x2CDE210", Length = "0x168")]
		[Token(Token = "0x60001BB")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x2CDEC90", Offset = "0x2CDE090", Length = "0x175")]
		[BurstDiscard]
		[Token(Token = "0x60001BA")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x2CDEF80", Offset = "0x2CDE380", Length = "0x37E")]
		[Token(Token = "0x60001BC")]
		public static void Invoke(bool implicitInstanceIndices, in NativeArray<InstanceHandle>& instances, in GPUDrivenRendererGroupData rendererData, in NativeParallelHashMap<EntityId, BatchMeshID>& batchMeshHash, in NativeParallelHashMap<EntityId, BatchMaterialID>& batchMaterialHash, in NativeParallelHashMap<EntityId, GPUDrivenPackedMaterialData>& packedMaterialDataHash, ref NativeParallelHashMap<RangeKey, Int32>& rangeHash, ref NativeList<DrawRange>& drawRanges, ref NativeParallelHashMap<DrawKey, Int32>& batchHash, ref NativeList<DrawBatch>& drawBatches, ref NativeList<DrawInstance>& drawInstances) { }

	}

	[Token(Token = "0x2000065")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class CreateDrawBatches_0000018C$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2CDF510", Offset = "0x2CDE910", Length = "0xA6")]
		[Token(Token = "0x60001B6")]
		public CreateDrawBatches_0000018C$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x2CDF300", Offset = "0x2CDE700", Length = "0x203")]
		[Token(Token = "0x60001B8")]
		public override IAsyncResult BeginInvoke(bool implicitInstanceIndices, in NativeArray<InstanceHandle>& instances, in GPUDrivenRendererGroupData rendererData, in NativeParallelHashMap<EntityId, BatchMeshID>& batchMeshHash, in NativeParallelHashMap<EntityId, BatchMaterialID>& batchMaterialHash, in NativeParallelHashMap<EntityId, GPUDrivenPackedMaterialData>& packedMaterialDataHash, ref NativeParallelHashMap<RangeKey, Int32>& rangeHash, ref NativeList<DrawRange>& drawRanges, ref NativeParallelHashMap<DrawKey, Int32>& batchHash, ref NativeList<DrawBatch>& drawBatches, ref NativeList<DrawInstance>& drawInstances, AsyncCallback unnamed_param_11, object unnamed_param_12) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x60001B9")]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x1C0F7F0", Offset = "0x1C0EBF0", Length = "0x7F")]
		[Token(Token = "0x60001B7")]
		public override void Invoke(bool implicitInstanceIndices, in NativeArray<InstanceHandle>& instances, in GPUDrivenRendererGroupData rendererData, in NativeParallelHashMap<EntityId, BatchMeshID>& batchMeshHash, in NativeParallelHashMap<EntityId, BatchMaterialID>& batchMaterialHash, in NativeParallelHashMap<EntityId, GPUDrivenPackedMaterialData>& packedMaterialDataHash, ref NativeParallelHashMap<RangeKey, Int32>& rangeHash, ref NativeList<DrawRange>& drawRanges, ref NativeParallelHashMap<DrawKey, Int32>& batchHash, ref NativeList<DrawBatch>& drawBatches, ref NativeList<DrawInstance>& drawInstances) { }

	}

	[Token(Token = "0x2000064")]
	public static class RemoveDrawInstanceIndices_00000188$BurstDirectCall
	{
		[Token(Token = "0x40001B5")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x2CEF520", Offset = "0x2CEE920", Length = "0x17A")]
		[Token(Token = "0x60001B4")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x2CEF390", Offset = "0x2CEE790", Length = "0x184")]
		[BurstDiscard]
		[Token(Token = "0x60001B3")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x2CEF6A0", Offset = "0x2CEEAA0", Length = "0x3CA")]
		[Token(Token = "0x60001B5")]
		public static void Invoke(in NativeArray<Int32>& drawInstanceIndices, ref NativeList<DrawInstance>& drawInstances, ref NativeParallelHashMap<RangeKey, Int32>& rangeHash, ref NativeParallelHashMap<DrawKey, Int32>& batchHash, ref NativeList<DrawRange>& drawRanges, ref NativeList<DrawBatch>& drawBatches) { }

	}

	[Token(Token = "0x2000063")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class RemoveDrawInstanceIndices_00000188$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2CEFBC0", Offset = "0x2CEEFC0", Length = "0xB5")]
		[Token(Token = "0x60001AF")]
		public RemoveDrawInstanceIndices_00000188$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x2CEFA70", Offset = "0x2CEEE70", Length = "0x14D")]
		[Token(Token = "0x60001B1")]
		public override IAsyncResult BeginInvoke(in NativeArray<Int32>& drawInstanceIndices, ref NativeList<DrawInstance>& drawInstances, ref NativeParallelHashMap<RangeKey, Int32>& rangeHash, ref NativeParallelHashMap<DrawKey, Int32>& batchHash, ref NativeList<DrawRange>& drawRanges, ref NativeList<DrawBatch>& drawBatches, AsyncCallback unnamed_param_6, object unnamed_param_7) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x60001B2")]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x1C17FD0", Offset = "0x1C173D0", Length = "0x14")]
		[Token(Token = "0x60001B0")]
		public override void Invoke(in NativeArray<Int32>& drawInstanceIndices, ref NativeList<DrawInstance>& drawInstances, ref NativeParallelHashMap<RangeKey, Int32>& rangeHash, ref NativeParallelHashMap<DrawKey, Int32>& batchHash, ref NativeList<DrawRange>& drawRanges, ref NativeList<DrawBatch>& drawBatches) { }

	}


	[Address(RVA = "0x2CE3350", Offset = "0x2CE2750", Length = "0x6D")]
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[MonoPInvokeCallback(typeof(CreateDrawBatches_0000018C$PostfixBurstDelegate))]
	[Token(Token = "0x60001AC")]
	public static void CreateDrawBatches(bool implicitInstanceIndices, in NativeArray<InstanceHandle>& instances, in GPUDrivenRendererGroupData rendererData, in NativeParallelHashMap<EntityId, BatchMeshID>& batchMeshHash, in NativeParallelHashMap<EntityId, BatchMaterialID>& batchMaterialHash, in NativeParallelHashMap<EntityId, GPUDrivenPackedMaterialData>& packedMaterialDataHash, ref NativeParallelHashMap<RangeKey, Int32>& rangeHash, ref NativeList<DrawRange>& drawRanges, ref NativeParallelHashMap<DrawKey, Int32>& batchHash, ref NativeList<DrawBatch>& drawBatches, ref NativeList<DrawInstance>& drawInstances) { }

	[Address(RVA = "0x2CE31A0", Offset = "0x2CE25A0", Length = "0x1A2")]
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x60001AE")]
	internal static void CreateDrawBatches$BurstManaged(bool implicitInstanceIndices, in NativeArray<InstanceHandle>& instances, in GPUDrivenRendererGroupData rendererData, in NativeParallelHashMap<EntityId, BatchMeshID>& batchMeshHash, in NativeParallelHashMap<EntityId, BatchMaterialID>& batchMaterialHash, in NativeParallelHashMap<EntityId, GPUDrivenPackedMaterialData>& packedMaterialDataHash, ref NativeParallelHashMap<RangeKey, Int32>& rangeHash, ref NativeList<DrawRange>& drawRanges, ref NativeParallelHashMap<DrawKey, Int32>& batchHash, ref NativeList<DrawBatch>& drawBatches, ref NativeList<DrawInstance>& drawInstances) { }

	[Address(RVA = "0x2CE33C0", Offset = "0x2CE27C0", Length = "0x203")]
	[Token(Token = "0x60001AA")]
	private static DrawBatch EditDrawBatch(in DrawKey key, in SubMeshDescriptor subMeshDescriptor, NativeParallelHashMap<DrawKey, Int32> batchHash, NativeList<DrawBatch> drawBatches) { }

	[Address(RVA = "0x2CE35D0", Offset = "0x2CE29D0", Length = "0x172")]
	[Token(Token = "0x60001A9")]
	private static DrawRange EditDrawRange(in RangeKey key, NativeParallelHashMap<RangeKey, Int32> rangeHash, NativeList<DrawRange> drawRanges) { }

	[Address(RVA = "0x2CE3750", Offset = "0x2CE2B50", Length = "0xB3B")]
	[Token(Token = "0x60001AB")]
	private static void ProcessRenderer(int i, bool implicitInstanceIndices, in GPUDrivenRendererGroupData rendererData, NativeParallelHashMap<EntityId, BatchMeshID> batchMeshHash, NativeParallelHashMap<EntityId, GPUDrivenPackedMaterialData> packedMaterialDataHash, NativeParallelHashMap<EntityId, BatchMaterialID> batchMaterialHash, NativeArray<InstanceHandle> instances, NativeList<DrawInstance> drawInstances, NativeParallelHashMap<RangeKey, Int32> rangeHash, NativeList<DrawRange> drawRanges, NativeParallelHashMap<DrawKey, Int32> batchHash, NativeList<DrawBatch> drawBatches) { }

	[Address(RVA = "0x2CE4290", Offset = "0x2CE3690", Length = "0x329")]
	[Token(Token = "0x60001A7")]
	private static void RemoveDrawBatch(in DrawKey key, ref NativeList<DrawRange>& drawRanges, ref NativeParallelHashMap<RangeKey, Int32>& rangeHash, ref NativeParallelHashMap<DrawKey, Int32>& batchHash, ref NativeList<DrawBatch>& drawBatches) { }

	[Address(RVA = "0x2CE4780", Offset = "0x2CE3B80", Length = "0xE")]
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[MonoPInvokeCallback(typeof(RemoveDrawInstanceIndices_00000188$PostfixBurstDelegate))]
	[Token(Token = "0x60001A8")]
	public static void RemoveDrawInstanceIndices(in NativeArray<Int32>& drawInstanceIndices, ref NativeList<DrawInstance>& drawInstances, ref NativeParallelHashMap<RangeKey, Int32>& rangeHash, ref NativeParallelHashMap<DrawKey, Int32>& batchHash, ref NativeList<DrawRange>& drawRanges, ref NativeList<DrawBatch>& drawBatches) { }

	[Address(RVA = "0x2CE45C0", Offset = "0x2CE39C0", Length = "0x1BF")]
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x60001AD")]
	internal static void RemoveDrawInstanceIndices$BurstManaged(in NativeArray<Int32>& drawInstanceIndices, ref NativeList<DrawInstance>& drawInstances, ref NativeParallelHashMap<RangeKey, Int32>& rangeHash, ref NativeParallelHashMap<DrawKey, Int32>& batchHash, ref NativeList<DrawRange>& drawRanges, ref NativeList<DrawBatch>& drawBatches) { }

	[Address(RVA = "0x2CE4790", Offset = "0x2CE3B90", Length = "0x166")]
	[Token(Token = "0x60001A6")]
	private static void RemoveDrawRange(in RangeKey key, ref NativeParallelHashMap<RangeKey, Int32>& rangeHash, ref NativeList<DrawRange>& drawRanges) { }

}

