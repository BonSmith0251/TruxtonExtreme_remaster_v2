namespace Unity.Collections;

[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
[Token(Token = "0x20000C5")]
public struct SortJob
{
	[BurstCompile]
	[Token(Token = "0x20000C6")]
	internal struct SegmentSort : IJobParallelFor
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40003F2")]
		internal T* Data; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003F3")]
		internal U Comp; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003F4")]
		internal int Length; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003F5")]
		internal int SegmentWidth; //Field offset: 0x0

		[Address(RVA = "0xF577C0", Offset = "0xF56BC0", Length = "0x7D")]
		[Token(Token = "0x6000938")]
		public override void Execute(int index) { }

	}

	[BurstCompile]
	[Token(Token = "0x20000C7")]
	internal struct SegmentSortMerge : IJob
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40003F6")]
		internal T* Data; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003F7")]
		internal U Comp; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003F8")]
		internal int Length; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003F9")]
		internal int SegmentWidth; //Field offset: 0x0

		[Address(RVA = "0xF575E0", Offset = "0xF569E0", Length = "0x1DC")]
		[Token(Token = "0x6000939")]
		public override void Execute() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003EF")]
	public T* Data; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003F0")]
	public U Comp; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003F1")]
	public int Length; //Field offset: 0x0

	[Address(RVA = "0xF651F0", Offset = "0xF645F0", Length = "0x1E6")]
	[Token(Token = "0x6000937")]
	public JobHandle Schedule(JobHandle inputDeps = null) { }

}

