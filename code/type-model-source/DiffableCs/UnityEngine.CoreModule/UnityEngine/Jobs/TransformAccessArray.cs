namespace UnityEngine.Jobs;

[DefaultMember("Item")]
[NativeType(Header = "Runtime/Transform/ScriptBindings/TransformAccess.bindings.h", CodegenOptions = CodegenOptions::Custom (1))]
[Token(Token = "0x200020C")]
public struct TransformAccessArray : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000740")]
	private IntPtr m_TransformArray; //Field offset: 0x0

	[Token(Token = "0x1700037C")]
	public bool isCreated
	{
		[Address(RVA = "0x308CDF0", Offset = "0x308C1F0", Length = "0xA")]
		[Token(Token = "0x600173F")]
		 get { } //Length: 10
	}

	[Token(Token = "0x1700037D")]
	public Transform Item
	{
		[Address(RVA = "0x308CD80", Offset = "0x308C180", Length = "0x6A")]
		[Token(Token = "0x6001742")]
		 get { } //Length: 106
		[Address(RVA = "0x308CE40", Offset = "0x308C240", Length = "0x88")]
		[Token(Token = "0x6001743")]
		 set { } //Length: 136
	}

	[Token(Token = "0x1700037E")]
	public int length
	{
		[Address(RVA = "0x308CE00", Offset = "0x308C200", Length = "0x33")]
		[Token(Token = "0x6001744")]
		 get { } //Length: 51
	}

	[Address(RVA = "0x308CD10", Offset = "0x308C110", Length = "0x61")]
	[Token(Token = "0x600173D")]
	public TransformAccessArray(int capacity, int desiredJobCount = -1) { }

	[Address(RVA = "0x308C800", Offset = "0x308BC00", Length = "0x7A")]
	[NativeMethod(Name = "TransformAccessArrayBindings::AddTransform", IsFreeFunction = True)]
	[Token(Token = "0x6001749")]
	private static void Add(IntPtr transformArrayIntPtr, Transform transform) { }

	[Address(RVA = "0x308C880", Offset = "0x308BC80", Length = "0x7A")]
	[Token(Token = "0x6001745")]
	public void Add(Transform transform) { }

	[Address(RVA = "0x308C7B0", Offset = "0x308BBB0", Length = "0x42")]
	[Token(Token = "0x6001750")]
	private static void Add_Injected(IntPtr transformArrayIntPtr, IntPtr transform) { }

	[Address(RVA = "0x308C900", Offset = "0x308BD00", Length = "0x60")]
	[Token(Token = "0x600173E")]
	public static void Allocate(int capacity, int desiredJobCount, out TransformAccessArray array) { }

	[Address(RVA = "0x308C960", Offset = "0x308BD60", Length = "0x3E")]
	[NativeMethod(Name = "TransformAccessArrayBindings::Create", IsFreeFunction = True)]
	[Token(Token = "0x6001747")]
	private static IntPtr Create(int capacity, int desiredJobCount) { }

	[Address(RVA = "0x308C9A0", Offset = "0x308BDA0", Length = "0x33")]
	[NativeMethod(Name = "DestroyTransformAccessArray", IsFreeFunction = True)]
	[Token(Token = "0x6001748")]
	private static void DestroyTransformAccessArray(IntPtr transformArray) { }

	[Address(RVA = "0x308C9E0", Offset = "0x308BDE0", Length = "0x56")]
	[Token(Token = "0x6001740")]
	public override void Dispose() { }

	[Address(RVA = "0x308CDF0", Offset = "0x308C1F0", Length = "0xA")]
	[Token(Token = "0x600173F")]
	public bool get_isCreated() { }

	[Address(RVA = "0x308CD80", Offset = "0x308C180", Length = "0x6A")]
	[Token(Token = "0x6001742")]
	public Transform get_Item(int index) { }

	[Address(RVA = "0x308CE00", Offset = "0x308C200", Length = "0x33")]
	[Token(Token = "0x6001744")]
	public int get_length() { }

	[Address(RVA = "0x308CA40", Offset = "0x308BE40", Length = "0x33")]
	[NativeMethod(Name = "TransformAccessArrayBindings::GetLength", IsFreeFunction = True)]
	[Token(Token = "0x600174D")]
	internal static int GetLength(IntPtr transformArrayIntPtr) { }

	[Address(RVA = "0x308CA80", Offset = "0x308BE80", Length = "0x33")]
	[NativeMethod(Name = "TransformAccessArrayBindings::GetSortedToUserIndex", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x600174C")]
	internal static IntPtr GetSortedToUserIndex(IntPtr transformArrayIntPtr) { }

	[Address(RVA = "0x308CAC0", Offset = "0x308BEC0", Length = "0x33")]
	[NativeMethod(Name = "TransformAccessArrayBindings::GetSortedTransformAccess", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x600174B")]
	internal static IntPtr GetSortedTransformAccess(IntPtr transformArrayIntPtr) { }

	[Address(RVA = "0x308CB40", Offset = "0x308BF40", Length = "0x6A")]
	[NativeMethod(Name = "TransformAccessArrayBindings::GetTransform", IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x600174E")]
	internal static Transform GetTransform(IntPtr transformArrayIntPtr, int index) { }

	[Address(RVA = "0x308CB00", Offset = "0x308BF00", Length = "0x40")]
	[Token(Token = "0x6001751")]
	private static IntPtr GetTransform_Injected(IntPtr transformArrayIntPtr, int index) { }

	[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
	[Token(Token = "0x6001741")]
	internal IntPtr GetTransformAccessArrayForSchedule() { }

	[Address(RVA = "0x308CBB0", Offset = "0x308BFB0", Length = "0x40")]
	[Token(Token = "0x6001746")]
	public void RemoveAtSwapBack(int index) { }

	[Address(RVA = "0x308CBF0", Offset = "0x308BFF0", Length = "0x40")]
	[NativeMethod(Name = "TransformAccessArrayBindings::RemoveAtSwapBack", IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x600174A")]
	private static void RemoveAtSwapBack(IntPtr transformArrayIntPtr, int index) { }

	[Address(RVA = "0x308CE40", Offset = "0x308C240", Length = "0x88")]
	[Token(Token = "0x6001743")]
	public void set_Item(int index, Transform value) { }

	[Address(RVA = "0x308CC80", Offset = "0x308C080", Length = "0x88")]
	[NativeMethod(Name = "TransformAccessArrayBindings::SetTransform", IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x600174F")]
	internal static void SetTransform(IntPtr transformArrayIntPtr, int index, Transform transform) { }

	[Address(RVA = "0x308CC30", Offset = "0x308C030", Length = "0x50")]
	[Token(Token = "0x6001752")]
	private static void SetTransform_Injected(IntPtr transformArrayIntPtr, int index, IntPtr transform) { }

}

