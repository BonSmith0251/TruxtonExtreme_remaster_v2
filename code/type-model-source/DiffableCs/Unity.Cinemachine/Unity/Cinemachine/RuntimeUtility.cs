namespace Unity.Cinemachine;

[Token(Token = "0x20000DE")]
public static class RuntimeUtility
{
	[Token(Token = "0x400035C")]
	private static RaycastHit[] s_HitBuffer; //Field offset: 0x0
	[Token(Token = "0x400035D")]
	private static Int32[] s_PenetrationIndexBuffer; //Field offset: 0x8
	[Token(Token = "0x400035E")]
	private static SphereCollider s_ScratchCollider; //Field offset: 0x10
	[Token(Token = "0x400035F")]
	private static GameObject s_ScratchColliderGameObject; //Field offset: 0x18
	[Token(Token = "0x4000360")]
	private static int s_ScratchColliderRefCount; //Field offset: 0x20

	[Address(RVA = "0x2849250", Offset = "0x2848650", Length = "0xB1")]
	[Token(Token = "0x600041F")]
	private static RuntimeUtility() { }

	[Address(RVA = "0x2847BE0", Offset = "0x2846FE0", Length = "0x75")]
	[Token(Token = "0x6000418")]
	public static void DestroyObject(object obj) { }

	[Address(RVA = "0x2847C60", Offset = "0x2847060", Length = "0x16D")]
	[Token(Token = "0x600041D")]
	public static void DestroyScratchCollider() { }

	[Address(RVA = "0x2847DD0", Offset = "0x28471D0", Length = "0x2E5")]
	[Token(Token = "0x600041C")]
	public static SphereCollider GetScratchCollider() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000419")]
	public static bool IsPrefab(GameObject gameObject) { }

	[Address(RVA = "0x28480C0", Offset = "0x28474C0", Length = "0x2C5")]
	[Token(Token = "0x600041E")]
	public static AnimationCurve NormalizeCurve(AnimationCurve curve, bool normalizeX, bool normalizeY) { }

	[Address(RVA = "0x2848390", Offset = "0x2847790", Length = "0x39D")]
	[Token(Token = "0x600041A")]
	public static bool RaycastIgnoreTag(Ray ray, out RaycastHit hitInfo, float rayLength, int layerMask, in string ignoreTag) { }

	[Address(RVA = "0x2848730", Offset = "0x2847B30", Length = "0xB1B")]
	[Token(Token = "0x600041B")]
	public static bool SphereCastIgnoreTag(Ray ray, float radius, out RaycastHit hitInfo, float rayLength, int layerMask, in string ignoreTag) { }

}

