namespace UnityEngine;

[NativeClass("UI::RectTransform")]
[NativeHeader("Runtime/Transform/RectTransform.h")]
[Token(Token = "0x20001F8")]
public sealed class RectTransform : Transform
{
	[Token(Token = "0x20001FA")]
	internal enum Axis : int
	{
		Horizontal = 0,
		Vertical = 1,
	}

	[Token(Token = "0x20001F9")]
	internal enum Edge : int
	{
		Left = 0,
		Right = 1,
		Top = 2,
		Bottom = 3,
	}

	[Token(Token = "0x20001FB")]
	internal sealed class ReapplyDrivenProperties : MulticastDelegate
	{

		[Address(RVA = "0x1FCA570", Offset = "0x1FC9970", Length = "0xB4")]
		[Token(Token = "0x6001645")]
		public ReapplyDrivenProperties(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6001646")]
		public override void Invoke(RectTransform driven) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000720")]
	private static ReapplyDrivenProperties reapplyDrivenProperties; //Field offset: 0x0

	[Token(Token = "0x14000008")]
	public static event ReapplyDrivenProperties reapplyDrivenProperties
	{
		[Address(RVA = "0x3083870", Offset = "0x3082C70", Length = "0xB4")]
		[CompilerGenerated]
		[Token(Token = "0x6001611")]
		 add { } //Length: 180
		[Address(RVA = "0x3084560", Offset = "0x3083960", Length = "0xB4")]
		[CompilerGenerated]
		[Token(Token = "0x6001612")]
		 remove { } //Length: 180
	}

	[Token(Token = "0x1700034E")]
	public Vector2 anchoredPosition
	{
		[Address(RVA = "0x3083C70", Offset = "0x3083070", Length = "0x88")]
		[Token(Token = "0x6001618")]
		 get { } //Length: 136
		[Address(RVA = "0x30849C0", Offset = "0x3083DC0", Length = "0x81")]
		[Token(Token = "0x6001619")]
		 set { } //Length: 129
	}

	[Token(Token = "0x17000351")]
	public Vector3 anchoredPosition3D
	{
		[Address(RVA = "0x3083AF0", Offset = "0x3082EF0", Length = "0x123")]
		[Token(Token = "0x600161E")]
		 get { } //Length: 291
		[Address(RVA = "0x30847E0", Offset = "0x3083BE0", Length = "0x182")]
		[Token(Token = "0x600161F")]
		 set { } //Length: 386
	}

	[Token(Token = "0x1700034D")]
	public Vector2 anchorMax
	{
		[Address(RVA = "0x3083980", Offset = "0x3082D80", Length = "0x88")]
		[Token(Token = "0x6001616")]
		 get { } //Length: 136
		[Address(RVA = "0x3084670", Offset = "0x3083A70", Length = "0x81")]
		[Token(Token = "0x6001617")]
		 set { } //Length: 129
	}

	[Token(Token = "0x1700034C")]
	public Vector2 anchorMin
	{
		[Address(RVA = "0x3083A60", Offset = "0x3082E60", Length = "0x88")]
		[Token(Token = "0x6001614")]
		 get { } //Length: 136
		[Address(RVA = "0x3084750", Offset = "0x3083B50", Length = "0x81")]
		[Token(Token = "0x6001615")]
		 set { } //Length: 129
	}

	[Token(Token = "0x17000354")]
	public internal object drivenByObject
	{
		[Address(RVA = "0x3083D40", Offset = "0x3083140", Length = "0x91")]
		[Token(Token = "0x6001624")]
		 get { } //Length: 145
		[Address(RVA = "0x3084AA0", Offset = "0x3083EA0", Length = "0xB2")]
		[Token(Token = "0x6001625")]
		internal set { } //Length: 178
	}

	[Token(Token = "0x17000355")]
	internal DrivenTransformProperties drivenProperties
	{
		[Address(RVA = "0x3083E20", Offset = "0x3083220", Length = "0x77")]
		[Token(Token = "0x6001626")]
		internal get { } //Length: 119
		[Address(RVA = "0x3084BA0", Offset = "0x3083FA0", Length = "0x84")]
		[Token(Token = "0x6001627")]
		internal set { } //Length: 132
	}

	[Token(Token = "0x17000353")]
	public Vector2 offsetMax
	{
		[Address(RVA = "0x3083EA0", Offset = "0x30832A0", Length = "0x1C3")]
		[Token(Token = "0x6001622")]
		 get { } //Length: 451
		[Address(RVA = "0x3084C30", Offset = "0x3084030", Length = "0x3F6")]
		[Token(Token = "0x6001623")]
		 set { } //Length: 1014
	}

	[Token(Token = "0x17000352")]
	public Vector2 offsetMin
	{
		[Address(RVA = "0x3084070", Offset = "0x3083470", Length = "0x183")]
		[Token(Token = "0x6001620")]
		 get { } //Length: 387
		[Address(RVA = "0x3085030", Offset = "0x3084430", Length = "0x40E")]
		[Token(Token = "0x6001621")]
		 set { } //Length: 1038
	}

	[Token(Token = "0x17000350")]
	public Vector2 pivot
	{
		[Address(RVA = "0x3084250", Offset = "0x3083650", Length = "0x88")]
		[Token(Token = "0x600161C")]
		 get { } //Length: 136
		[Address(RVA = "0x3085490", Offset = "0x3084890", Length = "0x81")]
		[Token(Token = "0x600161D")]
		 set { } //Length: 129
	}

	[Token(Token = "0x1700034B")]
	public Rect rect
	{
		[Address(RVA = "0x3084330", Offset = "0x3083730", Length = "0x8F")]
		[Token(Token = "0x6001613")]
		 get { } //Length: 143
	}

	[Token(Token = "0x17000356")]
	public bool sendChildDimensionsChange
	{
		[Address(RVA = "0x3084400", Offset = "0x3083800", Length = "0x77")]
		[Token(Token = "0x6001628")]
		 get { } //Length: 119
		[Address(RVA = "0x3085570", Offset = "0x3084970", Length = "0x87")]
		[Token(Token = "0x6001629")]
		 set { } //Length: 135
	}

	[Token(Token = "0x1700034F")]
	public Vector2 sizeDelta
	{
		[Address(RVA = "0x30844D0", Offset = "0x30838D0", Length = "0x88")]
		[Token(Token = "0x600161A")]
		 get { } //Length: 136
		[Address(RVA = "0x3085650", Offset = "0x3084A50", Length = "0x81")]
		[Token(Token = "0x600161B")]
		 set { } //Length: 129
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6001632")]
	public RectTransform() { }

	[Address(RVA = "0x3083870", Offset = "0x3082C70", Length = "0xB4")]
	[CompilerGenerated]
	[Token(Token = "0x6001611")]
	public static void add_reapplyDrivenProperties(ReapplyDrivenProperties value) { }

	[Address(RVA = "0x3081E80", Offset = "0x3081280", Length = "0x77")]
	[NativeMethod("UpdateIfTransformDispatchIsDirty")]
	[Token(Token = "0x600162A")]
	public void ForceUpdateRectTransforms() { }

	[Address(RVA = "0x3081E40", Offset = "0x3081240", Length = "0x33")]
	[Token(Token = "0x6001644")]
	private static void ForceUpdateRectTransforms_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3083C70", Offset = "0x3083070", Length = "0x88")]
	[Token(Token = "0x6001618")]
	public Vector2 get_anchoredPosition() { }

	[Address(RVA = "0x3083C20", Offset = "0x3083020", Length = "0x42")]
	[Token(Token = "0x6001638")]
	private static void get_anchoredPosition_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x3083AF0", Offset = "0x3082EF0", Length = "0x123")]
	[Token(Token = "0x600161E")]
	public Vector3 get_anchoredPosition3D() { }

	[Address(RVA = "0x3083980", Offset = "0x3082D80", Length = "0x88")]
	[Token(Token = "0x6001616")]
	public Vector2 get_anchorMax() { }

	[Address(RVA = "0x3083930", Offset = "0x3082D30", Length = "0x42")]
	[Token(Token = "0x6001636")]
	private static void get_anchorMax_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x3083A60", Offset = "0x3082E60", Length = "0x88")]
	[Token(Token = "0x6001614")]
	public Vector2 get_anchorMin() { }

	[Address(RVA = "0x3083A10", Offset = "0x3082E10", Length = "0x42")]
	[Token(Token = "0x6001634")]
	private static void get_anchorMin_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x3083D40", Offset = "0x3083140", Length = "0x91")]
	[Token(Token = "0x6001624")]
	public object get_drivenByObject() { }

	[Address(RVA = "0x3083D00", Offset = "0x3083100", Length = "0x33")]
	[Token(Token = "0x600163E")]
	private static IntPtr get_drivenByObject_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3083E20", Offset = "0x3083220", Length = "0x77")]
	[Token(Token = "0x6001626")]
	internal DrivenTransformProperties get_drivenProperties() { }

	[Address(RVA = "0x3083DE0", Offset = "0x30831E0", Length = "0x33")]
	[Token(Token = "0x6001640")]
	private static DrivenTransformProperties get_drivenProperties_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3083EA0", Offset = "0x30832A0", Length = "0x1C3")]
	[Token(Token = "0x6001622")]
	public Vector2 get_offsetMax() { }

	[Address(RVA = "0x3084070", Offset = "0x3083470", Length = "0x183")]
	[Token(Token = "0x6001620")]
	public Vector2 get_offsetMin() { }

	[Address(RVA = "0x3084250", Offset = "0x3083650", Length = "0x88")]
	[Token(Token = "0x600161C")]
	public Vector2 get_pivot() { }

	[Address(RVA = "0x3084200", Offset = "0x3083600", Length = "0x42")]
	[Token(Token = "0x600163C")]
	private static void get_pivot_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x3084330", Offset = "0x3083730", Length = "0x8F")]
	[Token(Token = "0x6001613")]
	public Rect get_rect() { }

	[Address(RVA = "0x30842E0", Offset = "0x30836E0", Length = "0x42")]
	[Token(Token = "0x6001633")]
	private static void get_rect_Injected(IntPtr _unity_self, out Rect ret) { }

	[Address(RVA = "0x3084400", Offset = "0x3083800", Length = "0x77")]
	[Token(Token = "0x6001628")]
	public bool get_sendChildDimensionsChange() { }

	[Address(RVA = "0x30843C0", Offset = "0x30837C0", Length = "0x33")]
	[Token(Token = "0x6001642")]
	private static bool get_sendChildDimensionsChange_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30844D0", Offset = "0x30838D0", Length = "0x88")]
	[Token(Token = "0x600161A")]
	public Vector2 get_sizeDelta() { }

	[Address(RVA = "0x3084480", Offset = "0x3083880", Length = "0x42")]
	[Token(Token = "0x600163A")]
	private static void get_sizeDelta_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x3081F00", Offset = "0x3081300", Length = "0x1A8")]
	[Token(Token = "0x600162B")]
	public void GetLocalCorners(Vector3[] fourCornersArray) { }

	[Address(RVA = "0x30820B0", Offset = "0x30814B0", Length = "0x1EA")]
	[Token(Token = "0x6001631")]
	private Vector2 GetParentSize() { }

	[Address(RVA = "0x30822A0", Offset = "0x30816A0", Length = "0x5A3")]
	[Token(Token = "0x6001630")]
	internal Rect GetRectInParentSpace() { }

	[Address(RVA = "0x3082850", Offset = "0x3081C50", Length = "0x490")]
	[Token(Token = "0x600162C")]
	public void GetWorldCorners(Vector3[] fourCornersArray) { }

	[Address(RVA = "0x3084560", Offset = "0x3083960", Length = "0xB4")]
	[CompilerGenerated]
	[Token(Token = "0x6001612")]
	public static void remove_reapplyDrivenProperties(ReapplyDrivenProperties value) { }

	[Address(RVA = "0x3082CF0", Offset = "0x30820F0", Length = "0x58")]
	[RequiredByNativeCode]
	[Token(Token = "0x600162F")]
	internal static void SendReapplyDrivenProperties(RectTransform driven) { }

	[Address(RVA = "0x30849C0", Offset = "0x3083DC0", Length = "0x81")]
	[Token(Token = "0x6001619")]
	public void set_anchoredPosition(Vector2 value) { }

	[Address(RVA = "0x3084970", Offset = "0x3083D70", Length = "0x42")]
	[Token(Token = "0x6001639")]
	private static void set_anchoredPosition_Injected(IntPtr _unity_self, in Vector2 value) { }

	[Address(RVA = "0x30847E0", Offset = "0x3083BE0", Length = "0x182")]
	[Token(Token = "0x600161F")]
	public void set_anchoredPosition3D(Vector3 value) { }

	[Address(RVA = "0x3084670", Offset = "0x3083A70", Length = "0x81")]
	[Token(Token = "0x6001617")]
	public void set_anchorMax(Vector2 value) { }

	[Address(RVA = "0x3084620", Offset = "0x3083A20", Length = "0x42")]
	[Token(Token = "0x6001637")]
	private static void set_anchorMax_Injected(IntPtr _unity_self, in Vector2 value) { }

	[Address(RVA = "0x3084750", Offset = "0x3083B50", Length = "0x81")]
	[Token(Token = "0x6001615")]
	public void set_anchorMin(Vector2 value) { }

	[Address(RVA = "0x3084700", Offset = "0x3083B00", Length = "0x42")]
	[Token(Token = "0x6001635")]
	private static void set_anchorMin_Injected(IntPtr _unity_self, in Vector2 value) { }

	[Address(RVA = "0x3084AA0", Offset = "0x3083EA0", Length = "0xB2")]
	[Token(Token = "0x6001625")]
	internal void set_drivenByObject(object value) { }

	[Address(RVA = "0x3084A50", Offset = "0x3083E50", Length = "0x42")]
	[Token(Token = "0x600163F")]
	private static void set_drivenByObject_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x3084BA0", Offset = "0x3083FA0", Length = "0x84")]
	[Token(Token = "0x6001627")]
	internal void set_drivenProperties(DrivenTransformProperties value) { }

	[Address(RVA = "0x3084B60", Offset = "0x3083F60", Length = "0x40")]
	[Token(Token = "0x6001641")]
	private static void set_drivenProperties_Injected(IntPtr _unity_self, DrivenTransformProperties value) { }

	[Address(RVA = "0x3084C30", Offset = "0x3084030", Length = "0x3F6")]
	[Token(Token = "0x6001623")]
	public void set_offsetMax(Vector2 value) { }

	[Address(RVA = "0x3085030", Offset = "0x3084430", Length = "0x40E")]
	[Token(Token = "0x6001621")]
	public void set_offsetMin(Vector2 value) { }

	[Address(RVA = "0x3085490", Offset = "0x3084890", Length = "0x81")]
	[Token(Token = "0x600161D")]
	public void set_pivot(Vector2 value) { }

	[Address(RVA = "0x3085440", Offset = "0x3084840", Length = "0x42")]
	[Token(Token = "0x600163D")]
	private static void set_pivot_Injected(IntPtr _unity_self, in Vector2 value) { }

	[Address(RVA = "0x3085570", Offset = "0x3084970", Length = "0x87")]
	[Token(Token = "0x6001629")]
	public void set_sendChildDimensionsChange(bool value) { }

	[Address(RVA = "0x3085520", Offset = "0x3084920", Length = "0x42")]
	[Token(Token = "0x6001643")]
	private static void set_sendChildDimensionsChange_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x3085650", Offset = "0x3084A50", Length = "0x81")]
	[Token(Token = "0x600161B")]
	public void set_sizeDelta(Vector2 value) { }

	[Address(RVA = "0x3085600", Offset = "0x3084A00", Length = "0x42")]
	[Token(Token = "0x600163B")]
	private static void set_sizeDelta_Injected(IntPtr _unity_self, in Vector2 value) { }

	[Address(RVA = "0x3082D50", Offset = "0x3082150", Length = "0x72A")]
	[Token(Token = "0x600162D")]
	public void SetInsetAndSizeFromParentEdge(Edge edge, float inset, float size) { }

	[Address(RVA = "0x3083480", Offset = "0x3082880", Length = "0x3EB")]
	[Token(Token = "0x600162E")]
	public void SetSizeWithCurrentAnchors(Axis axis, float size) { }

}

