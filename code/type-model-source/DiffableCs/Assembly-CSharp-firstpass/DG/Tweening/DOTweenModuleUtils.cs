namespace DG.Tweening;

[Token(Token = "0x200005D")]
public static class DOTweenModuleUtils
{
	[Token(Token = "0x200005E")]
	internal static class Physics
	{

		[Address(RVA = "0x5CF3E0", Offset = "0x5CE7E0", Length = "0x76D")]
		[Preserve]
		[Token(Token = "0x6000150")]
		public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode) { }

		[Address(RVA = "0x5CFBD0", Offset = "0x5CEFD0", Length = "0x74")]
		[Preserve]
		[Token(Token = "0x600014F")]
		public static bool HasRigidbody(Component target) { }

		[Address(RVA = "0x5CFB50", Offset = "0x5CEF50", Length = "0x74")]
		[Token(Token = "0x600014E")]
		public static bool HasRigidbody2D(Component target) { }

		[Address(RVA = "0x5CFC50", Offset = "0x5CF050", Length = "0x10F")]
		[Token(Token = "0x600014D")]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans) { }

	}

	[Token(Token = "0x400008C")]
	private static bool _initialized; //Field offset: 0x0

	[Address(RVA = "0x5CF2A0", Offset = "0x5CE6A0", Length = "0x93")]
	[Preserve]
	[Token(Token = "0x600014B")]
	public static void Init() { }

	[Address(RVA = "0x5CF340", Offset = "0x5CE740", Length = "0x92")]
	[Preserve]
	[Token(Token = "0x600014C")]
	private static void Preserver() { }

}

