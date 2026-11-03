namespace Unity.Collections;

[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
[Token(Token = "0x20000C8")]
public struct SortJobDefer
{
	[BurstCompile]
	[Token(Token = "0x20000C9")]
	internal struct SegmentSort : IJobParallelForDefer
	{
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x40003FC")]
		internal NativeList<T> DataRO; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40003FD")]
		internal UnsafeList<T>* Data; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003FE")]
		internal U Comp; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003FF")]
		internal int SegmentWidth; //Field offset: 0x0

		[Address(RVA = "0xF57B10", Offset = "0xF56F10", Length = "0x381")]
		[Token(Token = "0x600093B")]
		public override void Execute(int index) { }

	}

	[BurstCompile]
	[Token(Token = "0x20000CA")]
	internal struct SegmentSortMerge : IJob
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4000400")]
		internal NativeList<T> Data; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000401")]
		internal U Comp; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000402")]
		internal int SegmentWidth; //Field offset: 0x0

		[Address(RVA = "0xF56570", Offset = "0xF55970", Length = "0x6F3")]
		[Token(Token = "0x600093C")]
		public override void Execute() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003FA")]
	public NativeList<T> Data; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003FB")]
	public U Comp; //Field offset: 0x0

	[Address(RVA = "0xF64970", Offset = "0xF63D70", Length = "0x688")]
	[Token(Token = "0x600093A")]
	public JobHandle Schedule(JobHandle inputDeps = null) { }

}

