namespace UnityEngine.Rendering;

[BurstCompile]
[Token(Token = "0x2000020")]
internal static class GPUResidentDrawerBurst
{
	[Token(Token = "0x2000022")]
	public static class ClassifyMaterials_000000EA$BurstDirectCall
	{
		[Token(Token = "0x400006B")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x2CC13F0", Offset = "0x2CC07F0", Length = "0x17A")]
		[Token(Token = "0x60000F5")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x2CC1260", Offset = "0x2CC0660", Length = "0x184")]
		[BurstDiscard]
		[Token(Token = "0x60000F4")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x2CC1570", Offset = "0x2CC0970", Length = "0x224")]
		[Token(Token = "0x60000F6")]
		public static void Invoke(in NativeArray<EntityId>& materialIDs, in ReadOnly<EntityId, BatchMaterialID> batchMaterialHash, ref NativeList<EntityId>& supportedMaterialIDs, ref NativeList<EntityId>& unsupportedMaterialIDs, ref NativeList<GPUDrivenPackedMaterialData>& supportedPackedMaterialDatas) { }

	}

	[Token(Token = "0x2000021")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class ClassifyMaterials_000000EA$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2CC18C0", Offset = "0x2CC0CC0", Length = "0xB5")]
		[Token(Token = "0x60000F0")]
		public ClassifyMaterials_000000EA$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x2CC17A0", Offset = "0x2CC0BA0", Length = "0x112")]
		[Token(Token = "0x60000F2")]
		public override IAsyncResult BeginInvoke(in NativeArray<EntityId>& materialIDs, in ReadOnly<EntityId, BatchMaterialID> batchMaterialHash, ref NativeList<EntityId>& supportedMaterialIDs, ref NativeList<EntityId>& unsupportedMaterialIDs, ref NativeList<GPUDrivenPackedMaterialData>& supportedPackedMaterialDatas, AsyncCallback unnamed_param_5, object unnamed_param_6) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x60000F3")]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x1BB00C0", Offset = "0x1BAF4C0", Length = "0x14")]
		[Token(Token = "0x60000F1")]
		public override void Invoke(in NativeArray<EntityId>& materialIDs, in ReadOnly<EntityId, BatchMaterialID> batchMaterialHash, ref NativeList<EntityId>& supportedMaterialIDs, ref NativeList<EntityId>& unsupportedMaterialIDs, ref NativeList<GPUDrivenPackedMaterialData>& supportedPackedMaterialDatas) { }

	}

	[Token(Token = "0x2000024")]
	public static class FindUnsupportedRenderers_000000EB$BurstDirectCall
	{
		[Token(Token = "0x400006C")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x2CC6C90", Offset = "0x2CC6090", Length = "0x17A")]
		[Token(Token = "0x60000FC")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x2CC6B00", Offset = "0x2CC5F00", Length = "0x184")]
		[BurstDiscard]
		[Token(Token = "0x60000FB")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x2CC6E10", Offset = "0x2CC6210", Length = "0x398")]
		[Token(Token = "0x60000FD")]
		public static void Invoke(in NativeArray<EntityId>& unsupportedMaterials, in ReadOnly<SmallEntityIdArray> materialIDArrays, in ReadOnly<EntityId> rendererGroups, ref NativeList<EntityId>& unsupportedRenderers) { }

	}

	[Token(Token = "0x2000023")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class FindUnsupportedRenderers_000000EB$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2CC72B0", Offset = "0x2CC66B0", Length = "0xB5")]
		[Token(Token = "0x60000F7")]
		public FindUnsupportedRenderers_000000EB$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x2CC71B0", Offset = "0x2CC65B0", Length = "0xFB")]
		[Token(Token = "0x60000F9")]
		public override IAsyncResult BeginInvoke(in NativeArray<EntityId>& unsupportedMaterials, in ReadOnly<SmallEntityIdArray> materialIDArrays, in ReadOnly<EntityId> rendererGroups, ref NativeList<EntityId>& unsupportedRenderers, AsyncCallback unnamed_param_4, object unnamed_param_5) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x60000FA")]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x60D5C0", Offset = "0x60C9C0", Length = "0x14")]
		[Token(Token = "0x60000F8")]
		public override void Invoke(in NativeArray<EntityId>& unsupportedMaterials, in ReadOnly<SmallEntityIdArray> materialIDArrays, in ReadOnly<EntityId> rendererGroups, ref NativeList<EntityId>& unsupportedRenderers) { }

	}

	[Token(Token = "0x2000026")]
	public static class GetMaterialsWithChangedPackedMaterial_000000EC$BurstDirectCall
	{
		[Token(Token = "0x400006D")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x2CCE6B0", Offset = "0x2CCDAB0", Length = "0x17A")]
		[Token(Token = "0x6000103")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x2CCE520", Offset = "0x2CCD920", Length = "0x184")]
		[BurstDiscard]
		[Token(Token = "0x6000102")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x2CCE830", Offset = "0x2CCDC30", Length = "0x28D")]
		[Token(Token = "0x6000104")]
		public static void Invoke(in NativeArray<EntityId>& materialIDs, in NativeArray<GPUDrivenPackedMaterialData>& packedMaterialDatas, in ReadOnly<EntityId, GPUDrivenPackedMaterialData> packedMaterialHash, ref NativeHashSet<EntityId>& filteredMaterials) { }

	}

	[Token(Token = "0x2000025")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class GetMaterialsWithChangedPackedMaterial_000000EC$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2CC72B0", Offset = "0x2CC66B0", Length = "0xB5")]
		[Token(Token = "0x60000FE")]
		public GetMaterialsWithChangedPackedMaterial_000000EC$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x2CCEAC0", Offset = "0x2CCDEC0", Length = "0xFB")]
		[Token(Token = "0x6000100")]
		public override IAsyncResult BeginInvoke(in NativeArray<EntityId>& materialIDs, in NativeArray<GPUDrivenPackedMaterialData>& packedMaterialDatas, in ReadOnly<EntityId, GPUDrivenPackedMaterialData> packedMaterialHash, ref NativeHashSet<EntityId>& filteredMaterials, AsyncCallback unnamed_param_4, object unnamed_param_5) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000101")]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x60D5C0", Offset = "0x60C9C0", Length = "0x14")]
		[Token(Token = "0x60000FF")]
		public override void Invoke(in NativeArray<EntityId>& materialIDs, in NativeArray<GPUDrivenPackedMaterialData>& packedMaterialDatas, in ReadOnly<EntityId, GPUDrivenPackedMaterialData> packedMaterialHash, ref NativeHashSet<EntityId>& filteredMaterials) { }

	}


	[Address(RVA = "0x2CC96A0", Offset = "0x2CC8AA0", Length = "0xE")]
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[MonoPInvokeCallback(typeof(ClassifyMaterials_000000EA$PostfixBurstDelegate))]
	[Token(Token = "0x60000EA")]
	public static void ClassifyMaterials(in NativeArray<EntityId>& materialIDs, in ReadOnly<EntityId, BatchMaterialID> batchMaterialHash, ref NativeList<EntityId>& supportedMaterialIDs, ref NativeList<EntityId>& unsupportedMaterialIDs, ref NativeList<GPUDrivenPackedMaterialData>& supportedPackedMaterialDatas) { }

	[Address(RVA = "0x2CC91F0", Offset = "0x2CC85F0", Length = "0x4AF")]
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x60000ED")]
	internal static void ClassifyMaterials$BurstManaged(in NativeArray<EntityId>& materialIDs, in ReadOnly<EntityId, BatchMaterialID> batchMaterialHash, ref NativeList<EntityId>& supportedMaterialIDs, ref NativeList<EntityId>& unsupportedMaterialIDs, ref NativeList<GPUDrivenPackedMaterialData>& supportedPackedMaterialDatas) { }

	[Address(RVA = "0x2CC98A0", Offset = "0x2CC8CA0", Length = "0xE")]
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[MonoPInvokeCallback(typeof(FindUnsupportedRenderers_000000EB$PostfixBurstDelegate))]
	[Token(Token = "0x60000EB")]
	public static void FindUnsupportedRenderers(in NativeArray<EntityId>& unsupportedMaterials, in ReadOnly<SmallEntityIdArray> materialIDArrays, in ReadOnly<EntityId> rendererGroups, ref NativeList<EntityId>& unsupportedRenderers) { }

	[Address(RVA = "0x2CC96B0", Offset = "0x2CC8AB0", Length = "0x1E9")]
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x60000EE")]
	internal static void FindUnsupportedRenderers$BurstManaged(in NativeArray<EntityId>& unsupportedMaterials, in ReadOnly<SmallEntityIdArray> materialIDArrays, in ReadOnly<EntityId> rendererGroups, ref NativeList<EntityId>& unsupportedRenderers) { }

	[Address(RVA = "0x2CC9990", Offset = "0x2CC8D90", Length = "0xE")]
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[MonoPInvokeCallback(typeof(GetMaterialsWithChangedPackedMaterial_000000EC$PostfixBurstDelegate))]
	[Token(Token = "0x60000EC")]
	public static void GetMaterialsWithChangedPackedMaterial(in NativeArray<EntityId>& materialIDs, in NativeArray<GPUDrivenPackedMaterialData>& packedMaterialDatas, in ReadOnly<EntityId, GPUDrivenPackedMaterialData> packedMaterialHash, ref NativeHashSet<EntityId>& filteredMaterials) { }

	[Address(RVA = "0x2CC98B0", Offset = "0x2CC8CB0", Length = "0xD5")]
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x60000EF")]
	internal static void GetMaterialsWithChangedPackedMaterial$BurstManaged(in NativeArray<EntityId>& materialIDs, in NativeArray<GPUDrivenPackedMaterialData>& packedMaterialDatas, in ReadOnly<EntityId, GPUDrivenPackedMaterialData> packedMaterialHash, ref NativeHashSet<EntityId>& filteredMaterials) { }

}

