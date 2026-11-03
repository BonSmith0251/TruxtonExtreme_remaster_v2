namespace Unity.Cinemachine;

[Token(Token = "0x200007B")]
public struct CameraState
{
	[Token(Token = "0x200007C")]
	internal enum BlendHints : int
	{
		Nothing = 0,
		SphericalPositionBlend = 1,
		CylindricalPositionBlend = 2,
		ScreenSpaceAimWhenTargetsDiffer = 4,
		InheritPosition = 8,
		IgnoreLookAtTarget = 16,
		FreezeWhenBlendingOut = 32,
		NoPosition = 65536,
		NoOrientation = 131072,
		NoTransform = 196608,
		NoLens = 262144,
	}

	[Token(Token = "0x200007D")]
	internal struct CustomBlendableItems
	{
		[Token(Token = "0x200007E")]
		internal struct Item
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000227")]
			public object Custom; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000228")]
			public float Weight; //Field offset: 0x8

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000221")]
		internal Item m_Item0; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000222")]
		internal Item m_Item1; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000223")]
		internal Item m_Item2; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000224")]
		internal Item m_Item3; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000225")]
		internal List<Item> m_Overflow; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000226")]
		internal int NumItems; //Field offset: 0x48

	}

	[Token(Token = "0x400020C")]
	public static Vector3 kNoPoint; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000209")]
	public LensSettings Lens; //Field offset: 0x0
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400020A")]
	public Vector3 ReferenceUp; //Field offset: 0x58
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400020B")]
	public Vector3 ReferenceLookAt; //Field offset: 0x64
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400020D")]
	public Vector3 RawPosition; //Field offset: 0x70
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x400020E")]
	public Quaternion RawOrientation; //Field offset: 0x7C
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x400020F")]
	public Quaternion RotationDampingBypass; //Field offset: 0x8C
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000210")]
	public float ShotQuality; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000211")]
	public Vector3 PositionCorrection; //Field offset: 0xA0
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000212")]
	public Quaternion OrientationCorrection; //Field offset: 0xAC
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4000213")]
	public BlendHints BlendHint; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000214")]
	internal CustomBlendableItems CustomBlendables; //Field offset: 0xC0

	[Token(Token = "0x17000084")]
	public static CameraState Default
	{
		[Address(RVA = "0x2839280", Offset = "0x2838680", Length = "0x220")]
		[Token(Token = "0x600027B")]
		 get { } //Length: 544
	}

	[Address(RVA = "0x2839230", Offset = "0x2838630", Length = "0x4A")]
	[Token(Token = "0x6000282")]
	private static CameraState() { }

	[Address(RVA = "0x28365C0", Offset = "0x28359C0", Length = "0x2FF")]
	[Token(Token = "0x600027C")]
	public void AddCustomBlendable(Item b) { }

	[Address(RVA = "0x28368C0", Offset = "0x2835CC0", Length = "0x78")]
	[Token(Token = "0x600027F")]
	private static Vector3 ApplyPosBlendHint(Vector3 posA, BlendHints hintA, Vector3 posB, BlendHints hintB, Vector3 original, Vector3 blended) { }

	[Address(RVA = "0x2836940", Offset = "0x2835D40", Length = "0x54")]
	[Token(Token = "0x6000280")]
	private static Quaternion ApplyRotBlendHint(Quaternion rotA, BlendHints hintA, Quaternion rotB, BlendHints hintB, Quaternion original, Quaternion blended) { }

	[Address(RVA = "0x2839280", Offset = "0x2838680", Length = "0x220")]
	[Token(Token = "0x600027B")]
	public static CameraState get_Default() { }

	[Address(RVA = "0x28369A0", Offset = "0x2835DA0", Length = "0x13D")]
	[Token(Token = "0x600027E")]
	private static float InterpolateFOV(float fovA, float fovB, float dA, float dB, float t) { }

	[Address(RVA = "0x2836AE0", Offset = "0x2835EE0", Length = "0x5D6")]
	[Token(Token = "0x6000281")]
	private static Vector3 InterpolatePosition(Vector3 posA, Vector3 pivotA, Vector3 posB, Vector3 pivotB, float t, BlendHints blendHint, Vector3 up) { }

	[Address(RVA = "0x28370C0", Offset = "0x28364C0", Length = "0x2163")]
	[Token(Token = "0x600027D")]
	public static CameraState Lerp(in CameraState stateA, in CameraState stateB, float t) { }

}

