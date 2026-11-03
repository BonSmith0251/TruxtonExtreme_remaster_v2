namespace UnityEngine;

[NativeHeader("Runtime/Transform/ScriptBindings/TransformScriptBindings.h")]
[NativeHeader("Runtime/Transform/Transform.h")]
[NativeHeader("Configuration/UnityConfigure.h")]
[RequiredByNativeCode]
[Token(Token = "0x20001FD")]
public class Transform : Component, IEnumerable
{
	[Token(Token = "0x20001FE")]
	private class Enumerator : IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000730")]
		private Transform outer; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000731")]
		private int currentIndex; //Field offset: 0x18

		[Token(Token = "0x1700036D")]
		public override object Current
		{
			[Address(RVA = "0x3078910", Offset = "0x3077D10", Length = "0xA0")]
			[Token(Token = "0x6001700")]
			 get { } //Length: 160
		}

		[Address(RVA = "0x2536CB0", Offset = "0x25360B0", Length = "0x38")]
		[Token(Token = "0x60016FF")]
		internal Enumerator(Transform outer) { }

		[Address(RVA = "0x3078910", Offset = "0x3077D10", Length = "0xA0")]
		[Token(Token = "0x6001700")]
		public override object get_Current() { }

		[Address(RVA = "0x3078870", Offset = "0x3077C70", Length = "0x91")]
		[Token(Token = "0x6001701")]
		public override bool MoveNext() { }

		[Address(RVA = "0x195A120", Offset = "0x1959520", Length = "0x8")]
		[Token(Token = "0x6001702")]
		public override void Reset() { }

	}


	[Token(Token = "0x17000367")]
	public int childCount
	{
		[Address(RVA = "0x3093100", Offset = "0x3092500", Length = "0x77")]
		[NativeMethod("GetChildrenCount")]
		[Token(Token = "0x60016A3")]
		 get { } //Length: 119
	}

	[NativeConditional("UNITY_EDITOR")]
	[Token(Token = "0x1700036C")]
	internal bool constrainProportionsScale
	{
		[Address(RVA = "0x308F740", Offset = "0x308EB40", Length = "0x77")]
		[Token(Token = "0x60016BE")]
		internal get { } //Length: 119
		[Address(RVA = "0x30910F0", Offset = "0x30904F0", Length = "0x87")]
		[Token(Token = "0x60016BF")]
		internal set { } //Length: 135
	}

	[Token(Token = "0x17000359")]
	public Vector3 eulerAngles
	{
		[Address(RVA = "0x3093180", Offset = "0x3092580", Length = "0x122")]
		[Token(Token = "0x600164F")]
		 get { } //Length: 290
		[Address(RVA = "0x3094180", Offset = "0x3093580", Length = "0xD2")]
		[Token(Token = "0x6001650")]
		 set { } //Length: 210
	}

	[Token(Token = "0x1700035D")]
	public Vector3 forward
	{
		[Address(RVA = "0x30932B0", Offset = "0x30926B0", Length = "0x10E")]
		[Token(Token = "0x6001657")]
		 get { } //Length: 270
		[Address(RVA = "0x3094260", Offset = "0x3093660", Length = "0xF2")]
		[Token(Token = "0x6001658")]
		 set { } //Length: 242
	}

	[NativeProperty("HasChangedDeprecated")]
	[Token(Token = "0x17000369")]
	public bool hasChanged
	{
		[Address(RVA = "0x3093400", Offset = "0x3092800", Length = "0x77")]
		[Token(Token = "0x60016AF")]
		 get { } //Length: 119
		[Address(RVA = "0x30943B0", Offset = "0x30937B0", Length = "0x87")]
		[Token(Token = "0x60016B0")]
		 set { } //Length: 135
	}

	[Token(Token = "0x1700036A")]
	public int hierarchyCapacity
	{
		[Address(RVA = "0x3093480", Offset = "0x3092880", Length = "0x77")]
		[Token(Token = "0x60016B7")]
		 get { } //Length: 119
		[Address(RVA = "0x30940F0", Offset = "0x30934F0", Length = "0x84")]
		[Token(Token = "0x60016B8")]
		 set { } //Length: 132
	}

	[Token(Token = "0x1700036B")]
	public int hierarchyCount
	{
		[Address(RVA = "0x3093500", Offset = "0x3092900", Length = "0x77")]
		[Token(Token = "0x60016BB")]
		 get { } //Length: 119
	}

	[Token(Token = "0x1700035A")]
	public Vector3 localEulerAngles
	{
		[Address(RVA = "0x3093580", Offset = "0x3092980", Length = "0x122")]
		[Token(Token = "0x6001651")]
		 get { } //Length: 290
		[Address(RVA = "0x3094440", Offset = "0x3093840", Length = "0xD2")]
		[Token(Token = "0x6001652")]
		 set { } //Length: 210
	}

	[Token(Token = "0x17000358")]
	public Vector3 localPosition
	{
		[Address(RVA = "0x3093700", Offset = "0x3092B00", Length = "0x91")]
		[Token(Token = "0x600164A")]
		 get { } //Length: 145
		[Address(RVA = "0x3094570", Offset = "0x3093970", Length = "0x86")]
		[Token(Token = "0x600164B")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700035F")]
	public Quaternion localRotation
	{
		[Address(RVA = "0x30937F0", Offset = "0x3092BF0", Length = "0x8F")]
		[Token(Token = "0x600165B")]
		 get { } //Length: 143
		[Address(RVA = "0x3094650", Offset = "0x3093A50", Length = "0x86")]
		[Token(Token = "0x600165C")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000361")]
	public Vector3 localScale
	{
		[Address(RVA = "0x30938D0", Offset = "0x3092CD0", Length = "0x91")]
		[Token(Token = "0x6001661")]
		 get { } //Length: 145
		[Address(RVA = "0x3094730", Offset = "0x3093B30", Length = "0x86")]
		[Token(Token = "0x6001662")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000365")]
	public Matrix4x4 localToWorldMatrix
	{
		[Address(RVA = "0x30939C0", Offset = "0x3092DC0", Length = "0x9B")]
		[Token(Token = "0x600166B")]
		 get { } //Length: 155
	}

	[Token(Token = "0x17000368")]
	public Vector3 lossyScale
	{
		[Address(RVA = "0x3093AB0", Offset = "0x3092EB0", Length = "0x91")]
		[NativeMethod("GetWorldScaleLossy")]
		[Token(Token = "0x60016AD")]
		 get { } //Length: 145
	}

	[Token(Token = "0x17000362")]
	public Transform parent
	{
		[Address(RVA = "0x308DE10", Offset = "0x308D210", Length = "0x91")]
		[Token(Token = "0x6001663")]
		 get { } //Length: 145
		[Address(RVA = "0x30947C0", Offset = "0x3093BC0", Length = "0x130")]
		[Token(Token = "0x6001664")]
		 set { } //Length: 304
	}

	[Token(Token = "0x17000363")]
	internal Transform parentInternal
	{
		[Address(RVA = "0x308DE10", Offset = "0x308D210", Length = "0x91")]
		[Token(Token = "0x6001665")]
		internal get { } //Length: 145
		[Address(RVA = "0x30914C0", Offset = "0x30908C0", Length = "0xB5")]
		[Token(Token = "0x6001666")]
		internal set { } //Length: 181
	}

	[Token(Token = "0x17000357")]
	public Vector3 position
	{
		[Address(RVA = "0x3093BA0", Offset = "0x3092FA0", Length = "0x91")]
		[Token(Token = "0x6001648")]
		 get { } //Length: 145
		[Address(RVA = "0x3094950", Offset = "0x3093D50", Length = "0x86")]
		[Token(Token = "0x6001649")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700035B")]
	public Vector3 right
	{
		[Address(RVA = "0x3093C40", Offset = "0x3093040", Length = "0x10E")]
		[Token(Token = "0x6001653")]
		 get { } //Length: 270
		[Address(RVA = "0x30949E0", Offset = "0x3093DE0", Length = "0xEA")]
		[Token(Token = "0x6001654")]
		 set { } //Length: 234
	}

	[Token(Token = "0x17000366")]
	public Transform root
	{
		[Address(RVA = "0x308DFF0", Offset = "0x308D3F0", Length = "0x91")]
		[Token(Token = "0x60016A1")]
		 get { } //Length: 145
	}

	[Token(Token = "0x1700035E")]
	public Quaternion rotation
	{
		[Address(RVA = "0x3093DA0", Offset = "0x30931A0", Length = "0x8F")]
		[Token(Token = "0x6001659")]
		 get { } //Length: 143
		[Address(RVA = "0x3094B20", Offset = "0x3093F20", Length = "0x86")]
		[Token(Token = "0x600165A")]
		 set { } //Length: 134
	}

	[NativeConditional("UNITY_EDITOR")]
	[Token(Token = "0x17000360")]
	internal RotationOrder rotationOrder
	{
		[Address(RVA = "0x308E0D0", Offset = "0x308D4D0", Length = "0x77")]
		[Token(Token = "0x600165D")]
		internal get { } //Length: 119
		[Address(RVA = "0x3091790", Offset = "0x3090B90", Length = "0x84")]
		[Token(Token = "0x600165E")]
		internal set { } //Length: 132
	}

	[Token(Token = "0x1700035C")]
	public Vector3 up
	{
		[Address(RVA = "0x3093E30", Offset = "0x3093230", Length = "0x10E")]
		[Token(Token = "0x6001655")]
		 get { } //Length: 270
		[Address(RVA = "0x3094BB0", Offset = "0x3093FB0", Length = "0xEA")]
		[Token(Token = "0x6001656")]
		 set { } //Length: 234
	}

	[Token(Token = "0x17000364")]
	public Matrix4x4 worldToLocalMatrix
	{
		[Address(RVA = "0x3093F90", Offset = "0x3093390", Length = "0x9B")]
		[Token(Token = "0x600166A")]
		 get { } //Length: 155
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6001647")]
	protected Transform() { }

	[Address(RVA = "0x308D660", Offset = "0x308CA60", Length = "0x77")]
	[FreeFunction("DetachChildren", HasExplicitThis = True)]
	[Token(Token = "0x60016A4")]
	public void DetachChildren() { }

	[Address(RVA = "0x308D620", Offset = "0x308CA20", Length = "0x33")]
	[Token(Token = "0x60016E9")]
	private static void DetachChildren_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x308D6E0", Offset = "0x308CAE0", Length = "0x6A")]
	[Token(Token = "0x60016AB")]
	public Transform Find(string n) { }

	[Address(RVA = "0x308D6E0", Offset = "0x308CAE0", Length = "0x6A")]
	[Obsolete("FindChild has been deprecated. Use Find instead (UnityUpgradable) -> Find([mscorlib] System.String)", False)]
	[Token(Token = "0x60016B1")]
	public Transform FindChild(string n) { }

	[Address(RVA = "0x308D7B0", Offset = "0x308CBB0", Length = "0x200")]
	[FreeFunction(HasExplicitThis = True)]
	[Token(Token = "0x60016AA")]
	private Transform FindRelativeTransformWithPath(string path, bool isActiveOnly) { }

	[Address(RVA = "0x308D750", Offset = "0x308CB50", Length = "0x54")]
	[Token(Token = "0x60016EF")]
	private static IntPtr FindRelativeTransformWithPath_Injected(IntPtr _unity_self, ref ManagedSpanWrapper path, bool isActiveOnly) { }

	[Address(RVA = "0x3093100", Offset = "0x3092500", Length = "0x77")]
	[NativeMethod("GetChildrenCount")]
	[Token(Token = "0x60016A3")]
	public int get_childCount() { }

	[Address(RVA = "0x30930C0", Offset = "0x30924C0", Length = "0x33")]
	[Token(Token = "0x60016E8")]
	private static int get_childCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x308F740", Offset = "0x308EB40", Length = "0x77")]
	[Token(Token = "0x60016BE")]
	internal bool get_constrainProportionsScale() { }

	[Address(RVA = "0x3093180", Offset = "0x3092580", Length = "0x122")]
	[Token(Token = "0x600164F")]
	public Vector3 get_eulerAngles() { }

	[Address(RVA = "0x30932B0", Offset = "0x30926B0", Length = "0x10E")]
	[Token(Token = "0x6001657")]
	public Vector3 get_forward() { }

	[Address(RVA = "0x3093400", Offset = "0x3092800", Length = "0x77")]
	[Token(Token = "0x60016AF")]
	public bool get_hasChanged() { }

	[Address(RVA = "0x30933C0", Offset = "0x30927C0", Length = "0x33")]
	[Token(Token = "0x60016F3")]
	private static bool get_hasChanged_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3093480", Offset = "0x3092880", Length = "0x77")]
	[Token(Token = "0x60016B7")]
	public int get_hierarchyCapacity() { }

	[Address(RVA = "0x3093500", Offset = "0x3092900", Length = "0x77")]
	[Token(Token = "0x60016BB")]
	public int get_hierarchyCount() { }

	[Address(RVA = "0x3093580", Offset = "0x3092980", Length = "0x122")]
	[Token(Token = "0x6001651")]
	public Vector3 get_localEulerAngles() { }

	[Address(RVA = "0x3093700", Offset = "0x3092B00", Length = "0x91")]
	[Token(Token = "0x600164A")]
	public Vector3 get_localPosition() { }

	[Address(RVA = "0x30936B0", Offset = "0x3092AB0", Length = "0x42")]
	[Token(Token = "0x60016C4")]
	private static void get_localPosition_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x30937F0", Offset = "0x3092BF0", Length = "0x8F")]
	[Token(Token = "0x600165B")]
	public Quaternion get_localRotation() { }

	[Address(RVA = "0x30937A0", Offset = "0x3092BA0", Length = "0x42")]
	[Token(Token = "0x60016CB")]
	private static void get_localRotation_Injected(IntPtr _unity_self, out Quaternion ret) { }

	[Address(RVA = "0x30938D0", Offset = "0x3092CD0", Length = "0x91")]
	[Token(Token = "0x6001661")]
	public Vector3 get_localScale() { }

	[Address(RVA = "0x3093880", Offset = "0x3092C80", Length = "0x42")]
	[Token(Token = "0x60016CF")]
	private static void get_localScale_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x30939C0", Offset = "0x3092DC0", Length = "0x9B")]
	[Token(Token = "0x600166B")]
	public Matrix4x4 get_localToWorldMatrix() { }

	[Address(RVA = "0x3093970", Offset = "0x3092D70", Length = "0x42")]
	[Token(Token = "0x60016D4")]
	private static void get_localToWorldMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	[Address(RVA = "0x3093AB0", Offset = "0x3092EB0", Length = "0x91")]
	[NativeMethod("GetWorldScaleLossy")]
	[Token(Token = "0x60016AD")]
	public Vector3 get_lossyScale() { }

	[Address(RVA = "0x3093A60", Offset = "0x3092E60", Length = "0x42")]
	[Token(Token = "0x60016F1")]
	private static void get_lossyScale_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x308DE10", Offset = "0x308D210", Length = "0x91")]
	[Token(Token = "0x6001663")]
	public Transform get_parent() { }

	[Address(RVA = "0x308DE10", Offset = "0x308D210", Length = "0x91")]
	[Token(Token = "0x6001665")]
	internal Transform get_parentInternal() { }

	[Address(RVA = "0x3093BA0", Offset = "0x3092FA0", Length = "0x91")]
	[Token(Token = "0x6001648")]
	public Vector3 get_position() { }

	[Address(RVA = "0x3093B50", Offset = "0x3092F50", Length = "0x42")]
	[Token(Token = "0x60016C2")]
	private static void get_position_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x3093C40", Offset = "0x3093040", Length = "0x10E")]
	[Token(Token = "0x6001653")]
	public Vector3 get_right() { }

	[Address(RVA = "0x308DFF0", Offset = "0x308D3F0", Length = "0x91")]
	[Token(Token = "0x60016A1")]
	public Transform get_root() { }

	[Address(RVA = "0x3093DA0", Offset = "0x30931A0", Length = "0x8F")]
	[Token(Token = "0x6001659")]
	public Quaternion get_rotation() { }

	[Address(RVA = "0x3093D50", Offset = "0x3093150", Length = "0x42")]
	[Token(Token = "0x60016C9")]
	private static void get_rotation_Injected(IntPtr _unity_self, out Quaternion ret) { }

	[Address(RVA = "0x308E0D0", Offset = "0x308D4D0", Length = "0x77")]
	[Token(Token = "0x600165D")]
	internal RotationOrder get_rotationOrder() { }

	[Address(RVA = "0x3093E30", Offset = "0x3093230", Length = "0x10E")]
	[Token(Token = "0x6001655")]
	public Vector3 get_up() { }

	[Address(RVA = "0x3093F90", Offset = "0x3093390", Length = "0x9B")]
	[Token(Token = "0x600166A")]
	public Matrix4x4 get_worldToLocalMatrix() { }

	[Address(RVA = "0x3093F40", Offset = "0x3093340", Length = "0x42")]
	[Token(Token = "0x60016D3")]
	private static void get_worldToLocalMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	[Address(RVA = "0x308DAC0", Offset = "0x308CEC0", Length = "0x9E")]
	[FreeFunction("GetChild", HasExplicitThis = True)]
	[NativeThrows]
	[Token(Token = "0x60016B5")]
	public Transform GetChild(int index) { }

	[Address(RVA = "0x308DA80", Offset = "0x308CE80", Length = "0x40")]
	[Token(Token = "0x60016F7")]
	private static IntPtr GetChild_Injected(IntPtr _unity_self, int index) { }

	[Address(RVA = "0x308DA00", Offset = "0x308CE00", Length = "0x77")]
	[NativeMethod("GetChildrenCount")]
	[Obsolete("warning use Transform.childCount instead (UnityUpgradable) -> Transform.childCount", False)]
	[Token(Token = "0x60016B6")]
	public int GetChildCount() { }

	[Address(RVA = "0x308D9C0", Offset = "0x308CDC0", Length = "0x33")]
	[Token(Token = "0x60016F8")]
	private static int GetChildCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x308DB60", Offset = "0x308CF60", Length = "0x67")]
	[Token(Token = "0x60016B2")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x308DC20", Offset = "0x308D020", Length = "0xA0")]
	[Token(Token = "0x600164C")]
	internal Vector3 GetLocalEulerAngles(RotationOrder order) { }

	[Address(RVA = "0x308DBD0", Offset = "0x308CFD0", Length = "0x50")]
	[Token(Token = "0x60016C6")]
	private static void GetLocalEulerAngles_Injected(IntPtr _unity_self, RotationOrder order, out Vector3 ret) { }

	[Address(RVA = "0x308DD30", Offset = "0x308D130", Length = "0x96")]
	[Token(Token = "0x600166F")]
	public void GetLocalPositionAndRotation(out Vector3 localPosition, out Quaternion localRotation) { }

	[Address(RVA = "0x308DCD0", Offset = "0x308D0D0", Length = "0x52")]
	[Token(Token = "0x60016D8")]
	private static void GetLocalPositionAndRotation_Injected(IntPtr _unity_self, out Vector3 localPosition, out Quaternion localRotation) { }

	[Address(RVA = "0x308DE10", Offset = "0x308D210", Length = "0x91")]
	[Token(Token = "0x6001667")]
	private Transform GetParent() { }

	[Address(RVA = "0x308DDD0", Offset = "0x308D1D0", Length = "0x33")]
	[Token(Token = "0x60016D1")]
	private static IntPtr GetParent_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x308DF10", Offset = "0x308D310", Length = "0x96")]
	[Token(Token = "0x600166E")]
	public void GetPositionAndRotation(out Vector3 position, out Quaternion rotation) { }

	[Address(RVA = "0x308DEB0", Offset = "0x308D2B0", Length = "0x52")]
	[Token(Token = "0x60016D7")]
	private static void GetPositionAndRotation_Injected(IntPtr _unity_self, out Vector3 position, out Quaternion rotation) { }

	[Address(RVA = "0x308DFF0", Offset = "0x308D3F0", Length = "0x91")]
	[Token(Token = "0x60016A2")]
	private Transform GetRoot() { }

	[Address(RVA = "0x308DFB0", Offset = "0x308D3B0", Length = "0x33")]
	[Token(Token = "0x60016E7")]
	private static IntPtr GetRoot_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x308E0D0", Offset = "0x308D4D0", Length = "0x77")]
	[NativeConditional("UNITY_EDITOR")]
	[NativeMethod("GetRotationOrder")]
	[Token(Token = "0x600165F")]
	internal int GetRotationOrderInternal() { }

	[Address(RVA = "0x308E090", Offset = "0x308D490", Length = "0x33")]
	[Token(Token = "0x60016CD")]
	private static int GetRotationOrderInternal_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x308E190", Offset = "0x308D590", Length = "0x77")]
	[Token(Token = "0x60016A9")]
	public int GetSiblingIndex() { }

	[Address(RVA = "0x308E150", Offset = "0x308D550", Length = "0x33")]
	[Token(Token = "0x60016EE")]
	private static int GetSiblingIndex_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3093480", Offset = "0x3092880", Length = "0x77")]
	[FreeFunction("GetHierarchyCapacity", HasExplicitThis = True)]
	[Token(Token = "0x60016B9")]
	private int internal_getHierarchyCapacity() { }

	[Address(RVA = "0x3094030", Offset = "0x3093430", Length = "0x33")]
	[Token(Token = "0x60016F9")]
	private static int internal_getHierarchyCapacity_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3093500", Offset = "0x3092900", Length = "0x77")]
	[FreeFunction("GetHierarchyCount", HasExplicitThis = True)]
	[Token(Token = "0x60016BC")]
	private int internal_getHierarchyCount() { }

	[Address(RVA = "0x3094070", Offset = "0x3093470", Length = "0x33")]
	[Token(Token = "0x60016FB")]
	private static int internal_getHierarchyCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x308E270", Offset = "0x308D670", Length = "0x96")]
	[FreeFunction("Internal_LookAt", HasExplicitThis = True)]
	[Token(Token = "0x6001682")]
	private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	[Address(RVA = "0x308E210", Offset = "0x308D610", Length = "0x52")]
	[Token(Token = "0x60016DA")]
	private static void Internal_LookAt_Injected(IntPtr _unity_self, in Vector3 worldPosition, in Vector3 worldUp) { }

	[Address(RVA = "0x30940F0", Offset = "0x30934F0", Length = "0x84")]
	[FreeFunction("SetHierarchyCapacity", HasExplicitThis = True)]
	[Token(Token = "0x60016BA")]
	private void internal_setHierarchyCapacity(int value) { }

	[Address(RVA = "0x30940B0", Offset = "0x30934B0", Length = "0x40")]
	[Token(Token = "0x60016FA")]
	private static void internal_setHierarchyCapacity_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x308E370", Offset = "0x308D770", Length = "0xA1")]
	[Token(Token = "0x6001688")]
	public Vector3 InverseTransformDirection(Vector3 direction) { }

	[Address(RVA = "0x308E420", Offset = "0x308D820", Length = "0xC8")]
	[Token(Token = "0x6001689")]
	public Vector3 InverseTransformDirection(float x, float y, float z) { }

	[Address(RVA = "0x308E310", Offset = "0x308D710", Length = "0x52")]
	[Token(Token = "0x60016DD")]
	private static void InverseTransformDirection_Injected(IntPtr _unity_self, in Vector3 direction, out Vector3 ret) { }

	[Address(RVA = "0x308E690", Offset = "0x308DA90", Length = "0x7D")]
	[Token(Token = "0x600168C")]
	public void InverseTransformDirections(Span<Vector3> directions) { }

	[Address(RVA = "0x308E710", Offset = "0x308DB10", Length = "0x1B9")]
	[Token(Token = "0x600168B")]
	public void InverseTransformDirections(ReadOnlySpan<Vector3> directions, Span<Vector3> transformedDirections) { }

	[Address(RVA = "0x308E550", Offset = "0x308D950", Length = "0x13C")]
	[NativeMethod(Name = "InverseTransformDirections")]
	[Token(Token = "0x600168A")]
	internal void InverseTransformDirectionsInternal(ReadOnlySpan<Vector3> directions, Span<Vector3> transformedDirections) { }

	[Address(RVA = "0x308E4F0", Offset = "0x308D8F0", Length = "0x52")]
	[Token(Token = "0x60016DE")]
	private static void InverseTransformDirectionsInternal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper directions, ref ManagedSpanWrapper transformedDirections) { }

	[Address(RVA = "0x308E930", Offset = "0x308DD30", Length = "0xC8")]
	[Token(Token = "0x600169D")]
	public Vector3 InverseTransformPoint(float x, float y, float z) { }

	[Address(RVA = "0x308EA00", Offset = "0x308DE00", Length = "0xA1")]
	[Token(Token = "0x600169C")]
	public Vector3 InverseTransformPoint(Vector3 position) { }

	[Address(RVA = "0x308E8D0", Offset = "0x308DCD0", Length = "0x52")]
	[Token(Token = "0x60016E5")]
	private static void InverseTransformPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	[Address(RVA = "0x308EE10", Offset = "0x308E210", Length = "0x204")]
	[Token(Token = "0x60016A0")]
	public void InverseTransformPoints(Span<Vector3> positions) { }

	[Address(RVA = "0x308EC50", Offset = "0x308E050", Length = "0x1B9")]
	[Token(Token = "0x600169F")]
	public void InverseTransformPoints(ReadOnlySpan<Vector3> positions, Span<Vector3> transformedPositions) { }

	[Address(RVA = "0x308EB10", Offset = "0x308DF10", Length = "0x13C")]
	[NativeMethod(Name = "InverseTransformPoints")]
	[Token(Token = "0x600169E")]
	internal void InverseTransformPointsInternal(ReadOnlySpan<Vector3> positions, Span<Vector3> transformedPositions) { }

	[Address(RVA = "0x308EAB0", Offset = "0x308DEB0", Length = "0x52")]
	[Token(Token = "0x60016E6")]
	private static void InverseTransformPointsInternal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper positions, ref ManagedSpanWrapper transformedPositions) { }

	[Address(RVA = "0x308F150", Offset = "0x308E550", Length = "0xA1")]
	[Token(Token = "0x6001692")]
	public Vector3 InverseTransformVector(Vector3 vector) { }

	[Address(RVA = "0x308F080", Offset = "0x308E480", Length = "0xC8")]
	[Token(Token = "0x6001693")]
	public Vector3 InverseTransformVector(float x, float y, float z) { }

	[Address(RVA = "0x308F020", Offset = "0x308E420", Length = "0x52")]
	[Token(Token = "0x60016E1")]
	private static void InverseTransformVector_Injected(IntPtr _unity_self, in Vector3 vector, out Vector3 ret) { }

	[Address(RVA = "0x308F3A0", Offset = "0x308E7A0", Length = "0x7D")]
	[Token(Token = "0x6001696")]
	public void InverseTransformVectors(Span<Vector3> vectors) { }

	[Address(RVA = "0x308F420", Offset = "0x308E820", Length = "0x1B9")]
	[Token(Token = "0x6001695")]
	public void InverseTransformVectors(ReadOnlySpan<Vector3> vectors, Span<Vector3> transformedVectors) { }

	[Address(RVA = "0x308F260", Offset = "0x308E660", Length = "0x13C")]
	[NativeMethod(Name = "InverseTransformVectors")]
	[Token(Token = "0x6001694")]
	internal void InverseTransformVectorsInternal(ReadOnlySpan<Vector3> vectors, Span<Vector3> transformedVectors) { }

	[Address(RVA = "0x308F200", Offset = "0x308E600", Length = "0x52")]
	[Token(Token = "0x60016E2")]
	private static void InverseTransformVectorsInternal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper vectors, ref ManagedSpanWrapper transformedVectors) { }

	[Address(RVA = "0x308F630", Offset = "0x308EA30", Length = "0xC5")]
	[FreeFunction("Internal_IsChildOrSameAsOtherTransform", HasExplicitThis = True)]
	[Token(Token = "0x60016AE")]
	public bool IsChildOf(Transform parent) { }

	[Address(RVA = "0x308F5E0", Offset = "0x308E9E0", Length = "0x42")]
	[Token(Token = "0x60016F2")]
	private static bool IsChildOf_Injected(IntPtr _unity_self, IntPtr parent) { }

	[Address(RVA = "0x308F740", Offset = "0x308EB40", Length = "0x77")]
	[NativeConditional("UNITY_EDITOR")]
	[Token(Token = "0x60016C1")]
	private bool IsConstrainProportionsScale() { }

	[Address(RVA = "0x308F700", Offset = "0x308EB00", Length = "0x33")]
	[Token(Token = "0x60016FE")]
	private static bool IsConstrainProportionsScale_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x308F800", Offset = "0x308EC00", Length = "0x77")]
	[FreeFunction("IsNonUniformScaleTransform", HasExplicitThis = True)]
	[NativeConditional("UNITY_EDITOR")]
	[Token(Token = "0x60016BD")]
	internal bool IsNonUniformScaleTransform() { }

	[Address(RVA = "0x308F7C0", Offset = "0x308EBC0", Length = "0x33")]
	[Token(Token = "0x60016FC")]
	private static bool IsNonUniformScaleTransform_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x308FAD0", Offset = "0x308EED0", Length = "0x17A")]
	[Token(Token = "0x600167E")]
	public void LookAt(Transform target, Vector3 worldUp) { }

	[Address(RVA = "0x308F880", Offset = "0x308EC80", Length = "0x197")]
	[Token(Token = "0x600167F")]
	public void LookAt(Transform target) { }

	[Address(RVA = "0x308FA20", Offset = "0x308EE20", Length = "0xA5")]
	[Token(Token = "0x6001680")]
	public void LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	[Address(RVA = "0x308FC50", Offset = "0x308F050", Length = "0xD0")]
	[Token(Token = "0x6001681")]
	public void LookAt(Vector3 worldPosition) { }

	[Address(RVA = "0x308FD90", Offset = "0x308F190", Length = "0xC4")]
	[NativeMethod("MoveAfterSiblingInternal")]
	[Token(Token = "0x60016A8")]
	internal void MoveAfterSibling(Transform transform, bool notifyEditorAndMarkDirty) { }

	[Address(RVA = "0x308FD30", Offset = "0x308F130", Length = "0x54")]
	[Token(Token = "0x60016ED")]
	private static void MoveAfterSibling_Injected(IntPtr _unity_self, IntPtr transform, bool notifyEditorAndMarkDirty) { }

	[Address(RVA = "0x3090710", Offset = "0x308FB10", Length = "0x2B")]
	[Token(Token = "0x6001679")]
	public void Rotate(float xAngle, float yAngle, float zAngle) { }

	[Address(RVA = "0x3090530", Offset = "0x308F930", Length = "0x1DD")]
	[Token(Token = "0x600167B")]
	public void Rotate(Vector3 axis, float angle, Space relativeTo) { }

	[Address(RVA = "0x30903E0", Offset = "0x308F7E0", Length = "0x14B")]
	[Token(Token = "0x600167C")]
	public void Rotate(Vector3 axis, float angle) { }

	[Address(RVA = "0x3090E30", Offset = "0x3090230", Length = "0x2A")]
	[Token(Token = "0x6001678")]
	public void Rotate(float xAngle, float yAngle, float zAngle, Space relativeTo) { }

	[Address(RVA = "0x30903B0", Offset = "0x308F7B0", Length = "0x2D")]
	[Token(Token = "0x6001677")]
	public void Rotate(Vector3 eulers) { }

	[Address(RVA = "0x3090740", Offset = "0x308FB40", Length = "0x6E2")]
	[Token(Token = "0x6001676")]
	public void Rotate(Vector3 eulers, Space relativeTo) { }

	[Address(RVA = "0x30900C0", Offset = "0x308F4C0", Length = "0x245")]
	[Token(Token = "0x600167D")]
	public void RotateAround(Vector3 point, Vector3 axis, float angle) { }

	[Address(RVA = "0x3090310", Offset = "0x308F710", Length = "0x96")]
	[Obsolete("warning use Transform.Rotate instead.")]
	[Token(Token = "0x60016B3")]
	public void RotateAround(Vector3 axis, float angle) { }

	[Address(RVA = "0x3090060", Offset = "0x308F460", Length = "0x52")]
	[Token(Token = "0x60016F5")]
	private static void RotateAround_Injected(IntPtr _unity_self, in Vector3 axis, float angle) { }

	[Address(RVA = "0x308FEC0", Offset = "0x308F2C0", Length = "0x96")]
	[NativeMethod("RotateAround")]
	[Token(Token = "0x600167A")]
	internal void RotateAroundInternal(Vector3 axis, float angle) { }

	[Address(RVA = "0x308FE60", Offset = "0x308F260", Length = "0x52")]
	[Token(Token = "0x60016D9")]
	private static void RotateAroundInternal_Injected(IntPtr _unity_self, in Vector3 axis, float angle) { }

	[Address(RVA = "0x308FFC0", Offset = "0x308F3C0", Length = "0x96")]
	[Obsolete("warning use Transform.Rotate instead.")]
	[Token(Token = "0x60016B4")]
	public void RotateAroundLocal(Vector3 axis, float angle) { }

	[Address(RVA = "0x308FF60", Offset = "0x308F360", Length = "0x52")]
	[Token(Token = "0x60016F6")]
	private static void RotateAroundLocal_Injected(IntPtr _unity_self, in Vector3 axis, float angle) { }

	[Address(RVA = "0x3090EA0", Offset = "0x30902A0", Length = "0x77")]
	[NativeConditional("UNITY_EDITOR")]
	[Token(Token = "0x60016AC")]
	internal void SendTransformChangedScale() { }

	[Address(RVA = "0x3090E60", Offset = "0x3090260", Length = "0x33")]
	[Token(Token = "0x60016F0")]
	private static void SendTransformChangedScale_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30910F0", Offset = "0x30904F0", Length = "0x87")]
	[Token(Token = "0x60016BF")]
	internal void set_constrainProportionsScale(bool value) { }

	[Address(RVA = "0x3094180", Offset = "0x3093580", Length = "0xD2")]
	[Token(Token = "0x6001650")]
	public void set_eulerAngles(Vector3 value) { }

	[Address(RVA = "0x3094260", Offset = "0x3093660", Length = "0xF2")]
	[Token(Token = "0x6001658")]
	public void set_forward(Vector3 value) { }

	[Address(RVA = "0x30943B0", Offset = "0x30937B0", Length = "0x87")]
	[Token(Token = "0x60016B0")]
	public void set_hasChanged(bool value) { }

	[Address(RVA = "0x3094360", Offset = "0x3093760", Length = "0x42")]
	[Token(Token = "0x60016F4")]
	private static void set_hasChanged_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x30940F0", Offset = "0x30934F0", Length = "0x84")]
	[Token(Token = "0x60016B8")]
	public void set_hierarchyCapacity(int value) { }

	[Address(RVA = "0x3094440", Offset = "0x3093840", Length = "0xD2")]
	[Token(Token = "0x6001652")]
	public void set_localEulerAngles(Vector3 value) { }

	[Address(RVA = "0x3094570", Offset = "0x3093970", Length = "0x86")]
	[Token(Token = "0x600164B")]
	public void set_localPosition(Vector3 value) { }

	[Address(RVA = "0x3094520", Offset = "0x3093920", Length = "0x42")]
	[Token(Token = "0x60016C5")]
	private static void set_localPosition_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x3094650", Offset = "0x3093A50", Length = "0x86")]
	[Token(Token = "0x600165C")]
	public void set_localRotation(Quaternion value) { }

	[Address(RVA = "0x3094600", Offset = "0x3093A00", Length = "0x42")]
	[Token(Token = "0x60016CC")]
	private static void set_localRotation_Injected(IntPtr _unity_self, in Quaternion value) { }

	[Address(RVA = "0x3094730", Offset = "0x3093B30", Length = "0x86")]
	[Token(Token = "0x6001662")]
	public void set_localScale(Vector3 value) { }

	[Address(RVA = "0x30946E0", Offset = "0x3093AE0", Length = "0x42")]
	[Token(Token = "0x60016D0")]
	private static void set_localScale_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x30947C0", Offset = "0x3093BC0", Length = "0x130")]
	[Token(Token = "0x6001664")]
	public void set_parent(Transform value) { }

	[Address(RVA = "0x30914C0", Offset = "0x30908C0", Length = "0xB5")]
	[Token(Token = "0x6001666")]
	internal void set_parentInternal(Transform value) { }

	[Address(RVA = "0x3094950", Offset = "0x3093D50", Length = "0x86")]
	[Token(Token = "0x6001649")]
	public void set_position(Vector3 value) { }

	[Address(RVA = "0x3094900", Offset = "0x3093D00", Length = "0x42")]
	[Token(Token = "0x60016C3")]
	private static void set_position_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x30949E0", Offset = "0x3093DE0", Length = "0xEA")]
	[Token(Token = "0x6001654")]
	public void set_right(Vector3 value) { }

	[Address(RVA = "0x3094B20", Offset = "0x3093F20", Length = "0x86")]
	[Token(Token = "0x600165A")]
	public void set_rotation(Quaternion value) { }

	[Address(RVA = "0x3094AD0", Offset = "0x3093ED0", Length = "0x42")]
	[Token(Token = "0x60016CA")]
	private static void set_rotation_Injected(IntPtr _unity_self, in Quaternion value) { }

	[Address(RVA = "0x3091790", Offset = "0x3090B90", Length = "0x84")]
	[Token(Token = "0x600165E")]
	internal void set_rotationOrder(RotationOrder value) { }

	[Address(RVA = "0x3094BB0", Offset = "0x3093FB0", Length = "0xEA")]
	[Token(Token = "0x6001656")]
	public void set_up(Vector3 value) { }

	[Address(RVA = "0x3090F60", Offset = "0x3090360", Length = "0x77")]
	[Token(Token = "0x60016A5")]
	public void SetAsFirstSibling() { }

	[Address(RVA = "0x3090F20", Offset = "0x3090320", Length = "0x33")]
	[Token(Token = "0x60016EA")]
	private static void SetAsFirstSibling_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3091020", Offset = "0x3090420", Length = "0x77")]
	[Token(Token = "0x60016A6")]
	public void SetAsLastSibling() { }

	[Address(RVA = "0x3090FE0", Offset = "0x30903E0", Length = "0x33")]
	[Token(Token = "0x60016EB")]
	private static void SetAsLastSibling_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30910F0", Offset = "0x30904F0", Length = "0x87")]
	[NativeConditional("UNITY_EDITOR")]
	[Token(Token = "0x60016C0")]
	private void SetConstrainProportionsScale(bool isLinked) { }

	[Address(RVA = "0x30910A0", Offset = "0x30904A0", Length = "0x42")]
	[Token(Token = "0x60016FD")]
	private static void SetConstrainProportionsScale_Injected(IntPtr _unity_self, bool isLinked) { }

	[Address(RVA = "0x30911E0", Offset = "0x30905E0", Length = "0x96")]
	[Token(Token = "0x600164D")]
	internal void SetLocalEulerAngles(Vector3 euler, RotationOrder order) { }

	[Address(RVA = "0x3091180", Offset = "0x3090580", Length = "0x52")]
	[Token(Token = "0x60016C7")]
	private static void SetLocalEulerAngles_Injected(IntPtr _unity_self, in Vector3 euler, RotationOrder order) { }

	[Address(RVA = "0x30912D0", Offset = "0x30906D0", Length = "0x86")]
	[NativeConditional("UNITY_EDITOR")]
	[Token(Token = "0x600164E")]
	internal void SetLocalEulerHint(Vector3 euler) { }

	[Address(RVA = "0x3091280", Offset = "0x3090680", Length = "0x42")]
	[Token(Token = "0x60016C8")]
	private static void SetLocalEulerHint_Injected(IntPtr _unity_self, in Vector3 euler) { }

	[Address(RVA = "0x30913C0", Offset = "0x30907C0", Length = "0x96")]
	[Token(Token = "0x600166D")]
	public void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation) { }

	[Address(RVA = "0x3091360", Offset = "0x3090760", Length = "0x52")]
	[Token(Token = "0x60016D6")]
	private static void SetLocalPositionAndRotation_Injected(IntPtr _unity_self, in Vector3 localPosition, in Quaternion localRotation) { }

	[Address(RVA = "0x3091580", Offset = "0x3090980", Length = "0xC4")]
	[FreeFunction("SetParent", HasExplicitThis = True)]
	[Token(Token = "0x6001669")]
	public void SetParent(Transform parent, bool worldPositionStays) { }

	[Address(RVA = "0x30914C0", Offset = "0x30908C0", Length = "0xB5")]
	[Token(Token = "0x6001668")]
	public void SetParent(Transform p) { }

	[Address(RVA = "0x3091460", Offset = "0x3090860", Length = "0x54")]
	[Token(Token = "0x60016D2")]
	private static void SetParent_Injected(IntPtr _unity_self, IntPtr parent, bool worldPositionStays) { }

	[Address(RVA = "0x30916B0", Offset = "0x3090AB0", Length = "0x96")]
	[Token(Token = "0x600166C")]
	public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	[Address(RVA = "0x3091650", Offset = "0x3090A50", Length = "0x52")]
	[Token(Token = "0x60016D5")]
	private static void SetPositionAndRotation_Injected(IntPtr _unity_self, in Vector3 position, in Quaternion rotation) { }

	[Address(RVA = "0x3091790", Offset = "0x3090B90", Length = "0x84")]
	[NativeConditional("UNITY_EDITOR")]
	[NativeMethod("SetRotationOrder")]
	[Token(Token = "0x6001660")]
	internal void SetRotationOrderInternal(RotationOrder rotationOrder) { }

	[Address(RVA = "0x3091750", Offset = "0x3090B50", Length = "0x40")]
	[Token(Token = "0x60016CE")]
	private static void SetRotationOrderInternal_Injected(IntPtr _unity_self, RotationOrder rotationOrder) { }

	[Address(RVA = "0x3091860", Offset = "0x3090C60", Length = "0x84")]
	[Token(Token = "0x60016A7")]
	public void SetSiblingIndex(int index) { }

	[Address(RVA = "0x3091820", Offset = "0x3090C20", Length = "0x40")]
	[Token(Token = "0x60016EC")]
	private static void SetSiblingIndex_Injected(IntPtr _unity_self, int index) { }

	[Address(RVA = "0x3091950", Offset = "0x3090D50", Length = "0xA1")]
	[Token(Token = "0x6001683")]
	public Vector3 TransformDirection(Vector3 direction) { }

	[Address(RVA = "0x3091A00", Offset = "0x3090E00", Length = "0xC8")]
	[Token(Token = "0x6001684")]
	public Vector3 TransformDirection(float x, float y, float z) { }

	[Address(RVA = "0x30918F0", Offset = "0x3090CF0", Length = "0x52")]
	[Token(Token = "0x60016DB")]
	private static void TransformDirection_Injected(IntPtr _unity_self, in Vector3 direction, out Vector3 ret) { }

	[Address(RVA = "0x3091C70", Offset = "0x3091070", Length = "0x7D")]
	[Token(Token = "0x6001687")]
	public void TransformDirections(Span<Vector3> directions) { }

	[Address(RVA = "0x3091CF0", Offset = "0x30910F0", Length = "0x1B9")]
	[Token(Token = "0x6001686")]
	public void TransformDirections(ReadOnlySpan<Vector3> directions, Span<Vector3> transformedDirections) { }

	[Address(RVA = "0x3091B30", Offset = "0x3090F30", Length = "0x13C")]
	[NativeMethod(Name = "TransformDirections")]
	[Token(Token = "0x6001685")]
	internal void TransformDirectionsInternal(ReadOnlySpan<Vector3> directions, Span<Vector3> transformedDirections) { }

	[Address(RVA = "0x3091AD0", Offset = "0x3090ED0", Length = "0x52")]
	[Token(Token = "0x60016DC")]
	private static void TransformDirectionsInternal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper directions, ref ManagedSpanWrapper transformedDirections) { }

	[Address(RVA = "0x3091FC0", Offset = "0x30913C0", Length = "0xC8")]
	[Token(Token = "0x6001698")]
	public Vector3 TransformPoint(float x, float y, float z) { }

	[Address(RVA = "0x3091F10", Offset = "0x3091310", Length = "0xA1")]
	[Token(Token = "0x6001697")]
	public Vector3 TransformPoint(Vector3 position) { }

	[Address(RVA = "0x3091EB0", Offset = "0x30912B0", Length = "0x52")]
	[Token(Token = "0x60016E3")]
	private static void TransformPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	[Address(RVA = "0x3092230", Offset = "0x3091630", Length = "0x7D")]
	[Token(Token = "0x600169B")]
	public void TransformPoints(Span<Vector3> positions) { }

	[Address(RVA = "0x30922B0", Offset = "0x30916B0", Length = "0x1B9")]
	[Token(Token = "0x600169A")]
	public void TransformPoints(ReadOnlySpan<Vector3> positions, Span<Vector3> transformedPositions) { }

	[Address(RVA = "0x30920F0", Offset = "0x30914F0", Length = "0x13C")]
	[NativeMethod(Name = "TransformPoints")]
	[Token(Token = "0x6001699")]
	internal void TransformPointsInternal(ReadOnlySpan<Vector3> positions, Span<Vector3> transformedPositions) { }

	[Address(RVA = "0x3092090", Offset = "0x3091490", Length = "0x52")]
	[Token(Token = "0x60016E4")]
	private static void TransformPointsInternal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper positions, ref ManagedSpanWrapper transformedPositions) { }

	[Address(RVA = "0x30924D0", Offset = "0x30918D0", Length = "0xC8")]
	[Token(Token = "0x600168E")]
	public Vector3 TransformVector(float x, float y, float z) { }

	[Address(RVA = "0x30925A0", Offset = "0x30919A0", Length = "0xA1")]
	[Token(Token = "0x600168D")]
	public Vector3 TransformVector(Vector3 vector) { }

	[Address(RVA = "0x3092470", Offset = "0x3091870", Length = "0x52")]
	[Token(Token = "0x60016DF")]
	private static void TransformVector_Injected(IntPtr _unity_self, in Vector3 vector, out Vector3 ret) { }

	[Address(RVA = "0x30927F0", Offset = "0x3091BF0", Length = "0x1B9")]
	[Token(Token = "0x6001690")]
	public void TransformVectors(ReadOnlySpan<Vector3> vectors, Span<Vector3> transformedVectors) { }

	[Address(RVA = "0x30929B0", Offset = "0x3091DB0", Length = "0x7D")]
	[Token(Token = "0x6001691")]
	public void TransformVectors(Span<Vector3> vectors) { }

	[Address(RVA = "0x30926B0", Offset = "0x3091AB0", Length = "0x13C")]
	[NativeMethod(Name = "TransformVectors")]
	[Token(Token = "0x600168F")]
	internal void TransformVectorsInternal(ReadOnlySpan<Vector3> vectors, Span<Vector3> transformedVectors) { }

	[Address(RVA = "0x3092650", Offset = "0x3091A50", Length = "0x52")]
	[Token(Token = "0x60016E0")]
	private static void TransformVectorsInternal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper vectors, ref ManagedSpanWrapper transformedVectors) { }

	[Address(RVA = "0x3093060", Offset = "0x3092460", Length = "0x2A")]
	[Token(Token = "0x6001672")]
	public void Translate(float x, float y, float z, Space relativeTo) { }

	[Address(RVA = "0x3093090", Offset = "0x3092490", Length = "0x2B")]
	[Token(Token = "0x6001673")]
	public void Translate(float x, float y, float z) { }

	[Address(RVA = "0x3092A60", Offset = "0x3091E60", Length = "0x30B")]
	[Token(Token = "0x6001674")]
	public void Translate(Vector3 translation, Transform relativeTo) { }

	[Address(RVA = "0x3092DA0", Offset = "0x30921A0", Length = "0x2B2")]
	[Token(Token = "0x6001670")]
	public void Translate(Vector3 translation, Space relativeTo) { }

	[Address(RVA = "0x3092A30", Offset = "0x3091E30", Length = "0x2D")]
	[Token(Token = "0x6001671")]
	public void Translate(Vector3 translation) { }

	[Address(RVA = "0x3092D70", Offset = "0x3092170", Length = "0x2A")]
	[Token(Token = "0x6001675")]
	public void Translate(float x, float y, float z, Transform relativeTo) { }

}

