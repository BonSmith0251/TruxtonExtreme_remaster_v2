namespace UnityEngine.Rendering;

[BurstCompile]
[Token(Token = "0x2000097")]
internal static class InstanceDataSystemBurst
{
	[Token(Token = "0x200009D")]
	public static class FreeInstances_000002A2$BurstDirectCall
	{
		[Token(Token = "0x40002E6")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x2CF2AE0", Offset = "0x2CF1EE0", Length = "0x17A")]
		[Token(Token = "0x60002E9")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x2CF2950", Offset = "0x2CF1D50", Length = "0x184")]
		[BurstDiscard]
		[Token(Token = "0x60002E8")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x2CF2C60", Offset = "0x2CF2060", Length = "0x244")]
		[Token(Token = "0x60002EA")]
		public static void Invoke(in ReadOnly<InstanceHandle> instances, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash) { }

	}

	[Token(Token = "0x200009C")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class FreeInstances_000002A2$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2CEFBC0", Offset = "0x2CEEFC0", Length = "0xB5")]
		[Token(Token = "0x60002E4")]
		public FreeInstances_000002A2$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x2CF2EB0", Offset = "0x2CF22B0", Length = "0x14D")]
		[Token(Token = "0x60002E6")]
		public override IAsyncResult BeginInvoke(in ReadOnly<InstanceHandle> instances, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash, AsyncCallback unnamed_param_6, object unnamed_param_7) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x60002E7")]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x1C17FD0", Offset = "0x1C173D0", Length = "0x14")]
		[Token(Token = "0x60002E5")]
		public override void Invoke(in ReadOnly<InstanceHandle> instances, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash) { }

	}

	[Token(Token = "0x200009B")]
	public static class FreeRendererGroupInstances_000002A1$BurstDirectCall
	{
		[Token(Token = "0x40002E5")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x2CF3880", Offset = "0x2CF2C80", Length = "0x17A")]
		[Token(Token = "0x60002E2")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x2CF36F0", Offset = "0x2CF2AF0", Length = "0x184")]
		[BurstDiscard]
		[Token(Token = "0x60002E1")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x2CF3A00", Offset = "0x2CF2E00", Length = "0x244")]
		[Token(Token = "0x60002E3")]
		public static void Invoke(in ReadOnly<EntityId> rendererGroupsID, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash) { }

	}

	[Token(Token = "0x200009A")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class FreeRendererGroupInstances_000002A1$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2CEFBC0", Offset = "0x2CEEFC0", Length = "0xB5")]
		[Token(Token = "0x60002DD")]
		public FreeRendererGroupInstances_000002A1$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x2CF3C50", Offset = "0x2CF3050", Length = "0x14D")]
		[Token(Token = "0x60002DF")]
		public override IAsyncResult BeginInvoke(in ReadOnly<EntityId> rendererGroupsID, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash, AsyncCallback unnamed_param_6, object unnamed_param_7) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x60002E0")]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x1C17FD0", Offset = "0x1C173D0", Length = "0x14")]
		[Token(Token = "0x60002DE")]
		public override void Invoke(in ReadOnly<EntityId> rendererGroupsID, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash) { }

	}

	[Token(Token = "0x2000099")]
	public static class ReallocateInstances_000002A0$BurstDirectCall
	{
		[Token(Token = "0x40002E4")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x2CFF7C0", Offset = "0x2CFEBC0", Length = "0x168")]
		[Token(Token = "0x60002DB")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x2CFF640", Offset = "0x2CFEA40", Length = "0x175")]
		[BurstDiscard]
		[Token(Token = "0x60002DA")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x2CFF930", Offset = "0x2CFED30", Length = "0x2CC")]
		[Token(Token = "0x60002DC")]
		public static void Invoke(bool implicitInstanceIndices, in NativeArray<EntityId>& rendererGroupIDs, in NativeArray<GPUDrivenPackedRendererData>& packedRendererData, in NativeArray<Int32>& instanceOffsets, in NativeArray<Int32>& instanceCounts, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeArray<InstanceHandle>& instances, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash) { }

	}

	[Token(Token = "0x2000098")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class ReallocateInstances_000002A0$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2CDF510", Offset = "0x2CDE910", Length = "0xA6")]
		[Token(Token = "0x60002D6")]
		public ReallocateInstances_000002A0$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x2CFFC00", Offset = "0x2CFF000", Length = "0x1F7")]
		[Token(Token = "0x60002D8")]
		public override IAsyncResult BeginInvoke(bool implicitInstanceIndices, in NativeArray<EntityId>& rendererGroupIDs, in NativeArray<GPUDrivenPackedRendererData>& packedRendererData, in NativeArray<Int32>& instanceOffsets, in NativeArray<Int32>& instanceCounts, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeArray<InstanceHandle>& instances, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash, AsyncCallback unnamed_param_11, object unnamed_param_12) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x60002D9")]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x1C0F7F0", Offset = "0x1C0EBF0", Length = "0x7F")]
		[Token(Token = "0x60002D7")]
		public override void Invoke(bool implicitInstanceIndices, in NativeArray<EntityId>& rendererGroupIDs, in NativeArray<GPUDrivenPackedRendererData>& packedRendererData, in NativeArray<Int32>& instanceOffsets, in NativeArray<Int32>& instanceCounts, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeArray<InstanceHandle>& instances, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash) { }

	}


	[Address(RVA = "0x2CF5560", Offset = "0x2CF4960", Length = "0xE")]
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[MonoPInvokeCallback(typeof(FreeInstances_000002A2$PostfixBurstDelegate))]
	[Token(Token = "0x60002D2")]
	public static void FreeInstances(in ReadOnly<InstanceHandle> instances, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash) { }

	[Address(RVA = "0x2CF5230", Offset = "0x2CF4630", Length = "0x323")]
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x60002D5")]
	internal static void FreeInstances$BurstManaged(in ReadOnly<InstanceHandle> instances, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash) { }

	[Address(RVA = "0x2CF5830", Offset = "0x2CF4C30", Length = "0xE")]
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[MonoPInvokeCallback(typeof(FreeRendererGroupInstances_000002A1$PostfixBurstDelegate))]
	[Token(Token = "0x60002D1")]
	public static void FreeRendererGroupInstances(in ReadOnly<EntityId> rendererGroupsID, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash) { }

	[Address(RVA = "0x2CF5570", Offset = "0x2CF4970", Length = "0x2B5")]
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x60002D4")]
	internal static void FreeRendererGroupInstances$BurstManaged(in ReadOnly<EntityId> rendererGroupsID, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash) { }

	[Address(RVA = "0x2CF5D40", Offset = "0x2CF5140", Length = "0x6D")]
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[MonoPInvokeCallback(typeof(ReallocateInstances_000002A0$PostfixBurstDelegate))]
	[Token(Token = "0x60002D0")]
	public static void ReallocateInstances(bool implicitInstanceIndices, in NativeArray<EntityId>& rendererGroupIDs, in NativeArray<GPUDrivenPackedRendererData>& packedRendererData, in NativeArray<Int32>& instanceOffsets, in NativeArray<Int32>& instanceCounts, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeArray<InstanceHandle>& instances, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash) { }

	[Address(RVA = "0x2CF5840", Offset = "0x2CF4C40", Length = "0x4F1")]
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x60002D3")]
	internal static void ReallocateInstances$BurstManaged(bool implicitInstanceIndices, in NativeArray<EntityId>& rendererGroupIDs, in NativeArray<GPUDrivenPackedRendererData>& packedRendererData, in NativeArray<Int32>& instanceOffsets, in NativeArray<Int32>& instanceCounts, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeArray<InstanceHandle>& instances, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash) { }

}

