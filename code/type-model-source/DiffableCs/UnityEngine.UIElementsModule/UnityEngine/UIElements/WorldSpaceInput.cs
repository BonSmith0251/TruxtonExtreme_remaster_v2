namespace UnityEngine.UIElements;

[Token(Token = "0x200028A")]
internal static class WorldSpaceInput
{
	[Token(Token = "0x200028B")]
	internal struct PickResult
	{
		[Token(Token = "0x4000A22")]
		public static readonly PickResult Empty; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A23")]
		public Collider collider; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000A24")]
		public UIDocument document; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A25")]
		public VisualElement pickedElement; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A26")]
		public float distance; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000A27")]
		public Vector3 normal; //Field offset: 0x1C
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000A28")]
		public Vector3 point; //Field offset: 0x28
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000A29")]
		public Vector3 localPoint; //Field offset: 0x34

		[Address(RVA = "0x340A1C0", Offset = "0x34095C0", Length = "0x6B")]
		[Token(Token = "0x60011ED")]
		private static PickResult() { }

		[Address(RVA = "0x3409EF0", Offset = "0x34092F0", Length = "0x2C1")]
		[Token(Token = "0x60011EC")]
		internal void ComputeCollisionData(Ray ray) { }

	}


	[Address(RVA = "0x34110B0", Offset = "0x34104B0", Length = "0x12B")]
	[Token(Token = "0x60011EB")]
	internal static Bounds GetPicking3DLocalBounds(VisualElement ve) { }

	[Address(RVA = "0x34111E0", Offset = "0x34105E0", Length = "0x105")]
	[Token(Token = "0x60011EA")]
	internal static Bounds GetPicking3DWorldBounds(VisualElement ve) { }

	[Address(RVA = "0x34119C0", Offset = "0x3410DC0", Length = "0xB3")]
	[Token(Token = "0x60011E6")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"Assembly-CSharp-testable"})]
	internal static VisualElement PerformPick(VisualElement root, Ray ray, List<VisualElement> outResults) { }

	[Address(RVA = "0x3411660", Offset = "0x3410A60", Length = "0x72")]
	[Token(Token = "0x60011E7")]
	private static VisualElement PerformPick2D(VisualElement root, Ray ray, List<VisualElement> outResults) { }

	[Address(RVA = "0x34112F0", Offset = "0x34106F0", Length = "0x36F")]
	[Token(Token = "0x60011E9")]
	private static VisualElement PerformPick2D_LocalPoint(VisualElement root, Vector3 localPoint, List<VisualElement> picked = null) { }

	[Address(RVA = "0x34116E0", Offset = "0x3410AE0", Length = "0x2D6")]
	[Token(Token = "0x60011E8")]
	private static VisualElement PerformPick3D(VisualElement root, Ray ray, List<VisualElement> outResults) { }

	[Address(RVA = "0x34126D0", Offset = "0x3411AD0", Length = "0x11F")]
	[Token(Token = "0x60011E5")]
	internal static VisualElement Pick_Internal(UIDocument document, Ray documentRay, List<VisualElement> outResults = null) { }

	[Address(RVA = "0x3411A80", Offset = "0x3410E80", Length = "0x339")]
	[Token(Token = "0x60011E3")]
	public static VisualElement Pick3D(UIDocument document, Ray worldRay, out float distance) { }

	[Address(RVA = "0x3411DC0", Offset = "0x34111C0", Length = "0x90B")]
	[Token(Token = "0x60011E4")]
	public static PickResult PickDocument3D(Ray worldRay, float maxDistance = ∞, int layerMask = -5) { }

}

