namespace UnityEngine;

[NativeHeader("Runtime/Misc/ObjectDispatcher.h")]
[RequiredByNativeCode]
[StaticAccessor("GetObjectDispatcher()", StaticAccessorType::Dot (0))]
[Token(Token = "0x200015F")]
internal sealed class ObjectDispatcher : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000162")]
	private sealed class <>c
	{
		[Token(Token = "0x40005FB")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x3073D00", Offset = "0x3073100", Length = "0x67")]
		[Token(Token = "0x60011BC")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60011BD")]
		public <>c() { }

		[Address(RVA = "0x3073750", Offset = "0x3072B50", Length = "0x131")]
		[Token(Token = "0x60011BE")]
		internal void <.cctor>b__64_0(Object[] changed, IntPtr changedID, IntPtr destroyedID, int changedCount, int destroyedCount, Action<TypeDispatchData> callback) { }

		[Address(RVA = "0x3073890", Offset = "0x3072C90", Length = "0x1E9")]
		[Token(Token = "0x60011BF")]
		internal void <.cctor>b__64_1(IntPtr transformed, IntPtr parents, IntPtr localToWorldMatrices, IntPtr positions, IntPtr rotations, IntPtr scales, int count, Action<TransformDispatchData> callback) { }

	}

	[Token(Token = "0x2000160")]
	internal enum TransformTrackingType : int
	{
		GlobalTRS = 0,
		LocalTRS = 1,
		Hierarchy = 2,
	}

	[Flags]
	[Token(Token = "0x2000161")]
	internal enum TypeTrackingFlags : int
	{
		SceneObjects = 1,
		Assets = 2,
		EditorOnlyObjects = 4,
		Default = 3,
		All = 7,
	}

	[Token(Token = "0x40005EF")]
	private static Action<Object[], IntPtr, IntPtr, Int32, Int32, Action`1<TypeDispatchData>> s_TypeDispatch; //Field offset: 0x0
	[Token(Token = "0x40005F0")]
	private static Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, Int32, Action`1<TransformDispatchData>> s_TransformDispatch; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005E7")]
	private IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005E8")]
	private Allocator m_DispatchAllocator; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005E9")]
	private TypeDispatchData m_TypeDispatchData; //Field offset: 0x20
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005EA")]
	private TransformDispatchData m_TransformDispatchData; //Field offset: 0x48
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40005EB")]
	private Component[] m_TransformedComponents; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40005EC")]
	private Action<TypeDispatchData> m_TypeDataCallback; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40005ED")]
	private Action<TransformDispatchData> m_TransformDataCallback; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40005EE")]
	private Action<Component[]> m_TransformComponentCallback; //Field offset: 0xC0

	[Token(Token = "0x170002BD")]
	public bool valid
	{
		[Address(RVA = "0x3069AF0", Offset = "0x3068EF0", Length = "0xB")]
		[Token(Token = "0x60011A0")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x3069820", Offset = "0x3068C20", Length = "0x141")]
	[Token(Token = "0x60011BB")]
	private static ObjectDispatcher() { }

	[Address(RVA = "0x3069970", Offset = "0x3068D70", Length = "0x175")]
	[Token(Token = "0x60011A1")]
	public ObjectDispatcher() { }

	[Address(RVA = "0x30686C0", Offset = "0x3067AC0", Length = "0x2A")]
	[Token(Token = "0x60011B5")]
	private static IntPtr CreateDispatchSystemHandle() { }

	[Address(RVA = "0x30686F0", Offset = "0x3067AF0", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x60011B6")]
	private static void DestroyDispatchSystemHandle(IntPtr ptr) { }

	[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
	[Token(Token = "0x60011AA")]
	private void DispatchCallback(Component[] components) { }

	[Address(RVA = "0x3068730", Offset = "0x3067B30", Length = "0x10D")]
	[Token(Token = "0x60011A8")]
	private void DispatchCallback(TypeDispatchData data) { }

	[Address(RVA = "0x3068840", Offset = "0x3067C40", Length = "0x1B2")]
	[Token(Token = "0x60011A9")]
	private void DispatchCallback(TransformDispatchData data) { }

	[Address(RVA = "0x3068A00", Offset = "0x3067E00", Length = "0x11E")]
	[Token(Token = "0x60011AC")]
	public void DispatchTransformChangesAndClear(Type type, TransformTrackingType trackingType, Action<TransformDispatchData> callback) { }

	[Address(RVA = "0x3068B20", Offset = "0x3067F20", Length = "0x62")]
	[Token(Token = "0x60011BA")]
	private static void DispatchTransformDataChangesAndClear(IntPtr ptr, Type type, TransformTrackingType trackingType, Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, Int32, Action`1<TransformDispatchData>> callback, Action<TransformDispatchData> param) { }

	[Address(RVA = "0x3068B90", Offset = "0x3067F90", Length = "0x6D")]
	[Token(Token = "0x60011B9")]
	private static void DispatchTypeChangesAndClear(IntPtr ptr, Type type, Action<Object[], IntPtr, IntPtr, Int32, Int32, Action`1<TypeDispatchData>> callback, bool sortByInstanceID, bool noScriptingArray, Action<TypeDispatchData> param) { }

	[Address(RVA = "0x3068C00", Offset = "0x3068000", Length = "0x128")]
	[Token(Token = "0x60011AB")]
	public void DispatchTypeChangesAndClear(Type type, Action<TypeDispatchData> callback, bool sortByInstanceID = false, bool noScriptingArray = false) { }

	[Address(RVA = "0x3068D30", Offset = "0x3068130", Length = "0x81")]
	[Token(Token = "0x60011A4")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x3068DC0", Offset = "0x30681C0", Length = "0x56")]
	[Token(Token = "0x60011A3")]
	public override void Dispose() { }

	[Address(RVA = "0x89A530", Offset = "0x899930", Length = "0xEE")]
	[Token(Token = "0x60011B4")]
	public void EnableTransformTracking(TransformTrackingType trackingType) { }

	[Address(RVA = "0x3068E20", Offset = "0x3068220", Length = "0x1E9")]
	[Token(Token = "0x60011B0")]
	public void EnableTransformTracking(TransformTrackingType trackingType, Type[] types) { }

	[Address(RVA = "0x3069010", Offset = "0x3068410", Length = "0x52")]
	[Token(Token = "0x60011B8")]
	private static void EnableTransformTracking(IntPtr ptr, Type type, TransformTrackingType trackingType) { }

	[Address(RVA = "0x3069260", Offset = "0x3068660", Length = "0x52")]
	[Token(Token = "0x60011B7")]
	private static void EnableTypeTracking(IntPtr ptr, Type type, TypeTrackingFlags typeTrackingMask) { }

	[Address(RVA = "0x3069070", Offset = "0x3068470", Length = "0x1E9")]
	[Token(Token = "0x60011AF")]
	public void EnableTypeTracking(TypeTrackingFlags typeTrackingMask, Type[] types) { }

	[Address(RVA = "0x89A620", Offset = "0x899A20", Length = "0xEE")]
	[Token(Token = "0x60011B3")]
	public void EnableTypeTracking(TypeTrackingFlags typeTrackingMask = 3) { }

	[Address(RVA = "0x30692C0", Offset = "0x30686C0", Length = "0x5A")]
	[Token(Token = "0x60011A2")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x3069AF0", Offset = "0x3068EF0", Length = "0xB")]
	[Token(Token = "0x60011A0")]
	public bool get_valid() { }

	[Address(RVA = "0x3069320", Offset = "0x3068720", Length = "0x184")]
	[Token(Token = "0x60011AE")]
	public TransformDispatchData GetTransformChangesAndClear(Type type, TransformTrackingType trackingType, Allocator allocator) { }

	[Address(RVA = "0x89A710", Offset = "0x899B10", Length = "0xEF")]
	[Token(Token = "0x60011B2")]
	public TransformDispatchData GetTransformChangesAndClear(TransformTrackingType trackingType, Allocator allocator) { }

	[Address(RVA = "0x89A800", Offset = "0x899C00", Length = "0xD6")]
	[Token(Token = "0x60011B1")]
	public TypeDispatchData GetTypeChangesAndClear(Allocator allocator, bool sortByInstanceID = false, bool noScriptingArray = false) { }

	[Address(RVA = "0x30694B0", Offset = "0x30688B0", Length = "0x156")]
	[Token(Token = "0x60011AD")]
	public TypeDispatchData GetTypeChangesAndClear(Type type, Allocator allocator, bool sortByInstanceID = false, bool noScriptingArray = false) { }

	[Address(RVA = "0x3069610", Offset = "0x3068A10", Length = "0xCB")]
	[Token(Token = "0x60011A7")]
	private void ValidateComponentTypeAndThrow(Type type) { }

	[Address(RVA = "0x30696E0", Offset = "0x3068AE0", Length = "0x62")]
	[Token(Token = "0x60011A5")]
	private void ValidateSystemHandleAndThrow() { }

	[Address(RVA = "0x3069750", Offset = "0x3068B50", Length = "0xCB")]
	[Token(Token = "0x60011A6")]
	private void ValidateTypeAndThrow(Type type) { }

}

