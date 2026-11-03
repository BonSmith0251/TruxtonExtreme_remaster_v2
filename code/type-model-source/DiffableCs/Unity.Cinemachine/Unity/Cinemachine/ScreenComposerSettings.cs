namespace Unity.Cinemachine;

[Token(Token = "0x20000DF")]
public struct ScreenComposerSettings
{
	[Token(Token = "0x20000E0")]
	internal struct DeadZoneSettings
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000364")]
		public bool Enabled; //Field offset: 0x0
		[DelayedVector]
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000365")]
		[Tooltip("The camera will not adjust if the target is within this range of the screen position.  Full screen size is 1.")]
		public Vector2 Size; //Field offset: 0x4

	}

	[Token(Token = "0x20000E1")]
	internal struct HardLimitSettings
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000366")]
		public bool Enabled; //Field offset: 0x0
		[DelayedVector]
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000367")]
		[Tooltip("The target will not be allowed to be outside this region. When the target is within this region, the camera will gradually adjust to re-align towards the desired position, depending on the damping speed.  Full screen size is 1")]
		public Vector2 Size; //Field offset: 0x4
		[DelayedVector]
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000368")]
		[Tooltip("A zero Offset means that the hard limits will be centered around the target screen position.  A nonzero Offset will uncenter the hard limits relative to the target screen position.")]
		public Vector2 Offset; //Field offset: 0xC

	}

	[DelayedVector]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000361")]
	[Tooltip("Screen position for target. The camera will adjust to position the tracked object here.  0 is screen center, and +0.5 or -0.5 is screen edge")]
	public Vector2 ScreenPosition; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[FoldoutWithEnabledButton("Enabled")]
	[Token(Token = "0x4000362")]
	[Tooltip("The camera will not adjust if the target is within this range of the screen position")]
	public DeadZoneSettings DeadZone; //Field offset: 0x8
	[FieldOffset(Offset = "0x14")]
	[FoldoutWithEnabledButton("Enabled")]
	[Token(Token = "0x4000363")]
	[Tooltip("The target will not be allowed to be outside this region. When the target is within this region, the camera will gradually adjust to re-align towards the desired position, depending on the damping speed")]
	public HardLimitSettings HardLimits; //Field offset: 0x14

	[Token(Token = "0x170000E3")]
	public Rect DeadZoneRect
	{
		[Address(RVA = "0x2849A10", Offset = "0x2848E10", Length = "0x9F")]
		[Token(Token = "0x6000423")]
		 get { } //Length: 159
		[Address(RVA = "0x2849DD0", Offset = "0x28491D0", Length = "0x1A9")]
		[Token(Token = "0x6000424")]
		 set { } //Length: 425
	}

	[Token(Token = "0x170000E5")]
	public static ScreenComposerSettings Default
	{
		[Address(RVA = "0x2849AB0", Offset = "0x2848EB0", Length = "0x5B")]
		[Token(Token = "0x6000429")]
		 get { } //Length: 91
	}

	[Token(Token = "0x170000E1")]
	public Vector2 EffectiveDeadZoneSize
	{
		[Address(RVA = "0x2849B10", Offset = "0x2848F10", Length = "0x61")]
		[Token(Token = "0x6000421")]
		 get { } //Length: 97
	}

	[Token(Token = "0x170000E2")]
	public Vector2 EffectiveHardLimitSize
	{
		[Address(RVA = "0x2849B80", Offset = "0x2848F80", Length = "0x2D")]
		[Token(Token = "0x6000422")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170000E4")]
	public Rect HardLimitsRect
	{
		[Address(RVA = "0x2849BB0", Offset = "0x2848FB0", Length = "0x219")]
		[Token(Token = "0x6000425")]
		 get { } //Length: 537
		[Address(RVA = "0x2849F80", Offset = "0x2849380", Length = "0xAD")]
		[Token(Token = "0x6000426")]
		 set { } //Length: 173
	}

	[Address(RVA = "0x2849310", Offset = "0x2848710", Length = "0x2B5")]
	[Token(Token = "0x6000428")]
	public static bool Approximately(in ScreenComposerSettings a, in ScreenComposerSettings b) { }

	[Address(RVA = "0x2849A10", Offset = "0x2848E10", Length = "0x9F")]
	[Token(Token = "0x6000423")]
	public Rect get_DeadZoneRect() { }

	[Address(RVA = "0x2849AB0", Offset = "0x2848EB0", Length = "0x5B")]
	[Token(Token = "0x6000429")]
	public static ScreenComposerSettings get_Default() { }

	[Address(RVA = "0x2849B10", Offset = "0x2848F10", Length = "0x61")]
	[Token(Token = "0x6000421")]
	public Vector2 get_EffectiveDeadZoneSize() { }

	[Address(RVA = "0x2849B80", Offset = "0x2848F80", Length = "0x2D")]
	[Token(Token = "0x6000422")]
	public Vector2 get_EffectiveHardLimitSize() { }

	[Address(RVA = "0x2849BB0", Offset = "0x2848FB0", Length = "0x219")]
	[Token(Token = "0x6000425")]
	public Rect get_HardLimitsRect() { }

	[Address(RVA = "0x28495D0", Offset = "0x28489D0", Length = "0x315")]
	[Token(Token = "0x6000427")]
	public static ScreenComposerSettings Lerp(in ScreenComposerSettings a, in ScreenComposerSettings b, float t) { }

	[Address(RVA = "0x2849DD0", Offset = "0x28491D0", Length = "0x1A9")]
	[Token(Token = "0x6000424")]
	public void set_DeadZoneRect(Rect value) { }

	[Address(RVA = "0x2849F80", Offset = "0x2849380", Length = "0xAD")]
	[Token(Token = "0x6000426")]
	public void set_HardLimitsRect(Rect value) { }

	[Address(RVA = "0x28498F0", Offset = "0x2848CF0", Length = "0x116")]
	[Token(Token = "0x6000420")]
	public void Validate() { }

}

