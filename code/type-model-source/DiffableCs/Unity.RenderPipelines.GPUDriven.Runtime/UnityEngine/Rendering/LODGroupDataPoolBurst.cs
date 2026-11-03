namespace UnityEngine.Rendering;

[BurstCompile]
[Token(Token = "0x20000C1")]
internal static class LODGroupDataPoolBurst
{
	[Token(Token = "0x20000C5")]
	public static class AllocateOrGetLODGroupDataInstances_000002F3$BurstDirectCall
	{
		[Token(Token = "0x40003A1")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x2CF2180", Offset = "0x2CF1580", Length = "0x17A")]
		[Token(Token = "0x600034A")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x2CF1FF0", Offset = "0x2CF13F0", Length = "0x184")]
		[BurstDiscard]
		[Token(Token = "0x6000349")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x2CF2300", Offset = "0x2CF1700", Length = "0x244")]
		[Token(Token = "0x600034B")]
		public static int Invoke(in NativeArray<EntityId>& lodGroupsID, ref NativeList<LODGroupData>& lodGroupsData, ref NativeList<LODGroupCullingData>& lodGroupCullingData, ref NativeParallelHashMap<Int32, GPUInstanceIndex>& lodGroupDataHash, ref NativeList<GPUInstanceIndex>& freeLODGroupDataHandles, ref NativeArray<GPUInstanceIndex>& lodGroupInstances) { }

	}

	[Token(Token = "0x20000C4")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class AllocateOrGetLODGroupDataInstances_000002F3$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2CF26A0", Offset = "0x2CF1AA0", Length = "0xB5")]
		[Token(Token = "0x6000345")]
		public AllocateOrGetLODGroupDataInstances_000002F3$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x2CF2550", Offset = "0x2CF1950", Length = "0x14D")]
		[Token(Token = "0x6000347")]
		public override IAsyncResult BeginInvoke(in NativeArray<EntityId>& lodGroupsID, ref NativeList<LODGroupData>& lodGroupsData, ref NativeList<LODGroupCullingData>& lodGroupCullingData, ref NativeParallelHashMap<Int32, GPUInstanceIndex>& lodGroupDataHash, ref NativeList<GPUInstanceIndex>& freeLODGroupDataHandles, ref NativeArray<GPUInstanceIndex>& lodGroupInstances, AsyncCallback unnamed_param_6, object unnamed_param_7) { }

		[Address(RVA = "0xF64600", Offset = "0xF63A00", Length = "0x27")]
		[Token(Token = "0x6000348")]
		public override int EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x1C17FD0", Offset = "0x1C173D0", Length = "0x14")]
		[Token(Token = "0x6000346")]
		public override int Invoke(in NativeArray<EntityId>& lodGroupsID, ref NativeList<LODGroupData>& lodGroupsData, ref NativeList<LODGroupCullingData>& lodGroupCullingData, ref NativeParallelHashMap<Int32, GPUInstanceIndex>& lodGroupDataHash, ref NativeList<GPUInstanceIndex>& freeLODGroupDataHandles, ref NativeArray<GPUInstanceIndex>& lodGroupInstances) { }

	}

	[Token(Token = "0x20000C3")]
	public static class FreeLODGroupData_000002F2$BurstDirectCall
	{
		[Token(Token = "0x40003A0")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x2CF3190", Offset = "0x2CF2590", Length = "0x17A")]
		[Token(Token = "0x6000343")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x2CF3000", Offset = "0x2CF2400", Length = "0x184")]
		[BurstDiscard]
		[Token(Token = "0x6000342")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x2CF3310", Offset = "0x2CF2710", Length = "0x210")]
		[Token(Token = "0x6000344")]
		public static int Invoke(in NativeArray<EntityId>& destroyedLODGroupsID, ref NativeList<LODGroupData>& lodGroupsData, ref NativeParallelHashMap<Int32, GPUInstanceIndex>& lodGroupDataHash, ref NativeList<GPUInstanceIndex>& freeLODGroupDataHandles) { }

	}

	[Token(Token = "0x20000C2")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class FreeLODGroupData_000002F2$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2CF3630", Offset = "0x2CF2A30", Length = "0xB5")]
		[Token(Token = "0x600033E")]
		public FreeLODGroupData_000002F2$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x2CF3530", Offset = "0x2CF2930", Length = "0xFB")]
		[Token(Token = "0x6000340")]
		public override IAsyncResult BeginInvoke(in NativeArray<EntityId>& destroyedLODGroupsID, ref NativeList<LODGroupData>& lodGroupsData, ref NativeParallelHashMap<Int32, GPUInstanceIndex>& lodGroupDataHash, ref NativeList<GPUInstanceIndex>& freeLODGroupDataHandles, AsyncCallback unnamed_param_4, object unnamed_param_5) { }

		[Address(RVA = "0xF64600", Offset = "0xF63A00", Length = "0x27")]
		[Token(Token = "0x6000341")]
		public override int EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x60D5C0", Offset = "0x60C9C0", Length = "0x14")]
		[Token(Token = "0x600033F")]
		public override int Invoke(in NativeArray<EntityId>& destroyedLODGroupsID, ref NativeList<LODGroupData>& lodGroupsData, ref NativeParallelHashMap<Int32, GPUInstanceIndex>& lodGroupDataHash, ref NativeList<GPUInstanceIndex>& freeLODGroupDataHandles) { }

	}


	[Address(RVA = "0x2CF6D50", Offset = "0x2CF6150", Length = "0xE")]
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[MonoPInvokeCallback(typeof(AllocateOrGetLODGroupDataInstances_000002F3$PostfixBurstDelegate))]
	[Token(Token = "0x600033B")]
	public static int AllocateOrGetLODGroupDataInstances(in NativeArray<EntityId>& lodGroupsID, ref NativeList<LODGroupData>& lodGroupsData, ref NativeList<LODGroupCullingData>& lodGroupCullingData, ref NativeParallelHashMap<Int32, GPUInstanceIndex>& lodGroupDataHash, ref NativeList<GPUInstanceIndex>& freeLODGroupDataHandles, ref NativeArray<GPUInstanceIndex>& lodGroupInstances) { }

	[Address(RVA = "0x2CF6B00", Offset = "0x2CF5F00", Length = "0x24C")]
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x600033D")]
	internal static int AllocateOrGetLODGroupDataInstances$BurstManaged(in NativeArray<EntityId>& lodGroupsID, ref NativeList<LODGroupData>& lodGroupsData, ref NativeList<LODGroupCullingData>& lodGroupCullingData, ref NativeParallelHashMap<Int32, GPUInstanceIndex>& lodGroupDataHash, ref NativeList<GPUInstanceIndex>& freeLODGroupDataHandles, ref NativeArray<GPUInstanceIndex>& lodGroupInstances) { }

	[Address(RVA = "0x2CF6F80", Offset = "0x2CF6380", Length = "0xE")]
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[MonoPInvokeCallback(typeof(FreeLODGroupData_000002F2$PostfixBurstDelegate))]
	[Token(Token = "0x600033A")]
	public static int FreeLODGroupData(in NativeArray<EntityId>& destroyedLODGroupsID, ref NativeList<LODGroupData>& lodGroupsData, ref NativeParallelHashMap<Int32, GPUInstanceIndex>& lodGroupDataHash, ref NativeList<GPUInstanceIndex>& freeLODGroupDataHandles) { }

	[Address(RVA = "0x2CF6D60", Offset = "0x2CF6160", Length = "0x212")]
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x600033C")]
	internal static int FreeLODGroupData$BurstManaged(in NativeArray<EntityId>& destroyedLODGroupsID, ref NativeList<LODGroupData>& lodGroupsData, ref NativeParallelHashMap<Int32, GPUInstanceIndex>& lodGroupDataHash, ref NativeList<GPUInstanceIndex>& freeLODGroupDataHandles) { }

}

