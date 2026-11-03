namespace Unity.Cinemachine;

[Token(Token = "0x20000C6")]
public struct InputAxis
{
	[Token(Token = "0x20000C7")]
	internal struct RecenteringSettings
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002F5")]
		[Tooltip("If set, will enable automatic re-centering of the axis")]
		public bool Enabled; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40002F6")]
		[Tooltip("If no user input has been detected on the axis for this many seconds, re-centering will begin.")]
		public float Wait; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40002F7")]
		[Tooltip("How long it takes to reach center once re-centering has started.")]
		public float Time; //Field offset: 0x8

		[Token(Token = "0x170000D3")]
		public static RecenteringSettings Default
		{
			[Address(RVA = "0x2847B00", Offset = "0x2846F00", Length = "0x18")]
			[Token(Token = "0x60003CA")]
			 get { } //Length: 24
		}

		[Address(RVA = "0x2847B00", Offset = "0x2846F00", Length = "0x18")]
		[Token(Token = "0x60003CA")]
		public static RecenteringSettings get_Default() { }

		[Address(RVA = "0x2844950", Offset = "0x2843D50", Length = "0x1D")]
		[Token(Token = "0x60003CB")]
		public void Validate() { }

	}

	[Token(Token = "0x20000C9")]
	private struct RecenteringState
	{
		[Token(Token = "0x40002FD")]
		public const float k_Epsilon = 0.0001; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002FE")]
		public float m_RecenteringVelocity; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40002FF")]
		public bool m_ForceRecenter; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000300")]
		public float m_LastValueChangeTime; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000301")]
		public float m_LastValue; //Field offset: 0xC

		[Token(Token = "0x170000D4")]
		public static float CurrentTime
		{
			[Address(RVA = "0x2847B20", Offset = "0x2846F20", Length = "0xB7")]
			[Token(Token = "0x60003CC")]
			 get { } //Length: 183
		}

		[Address(RVA = "0x2847B20", Offset = "0x2846F20", Length = "0xB7")]
		[Token(Token = "0x60003CC")]
		public static float get_CurrentTime() { }

	}

	[Flags]
	[Token(Token = "0x20000C8")]
	internal enum RestrictionFlags : int
	{
		None = 0,
		RangeIsDriven = 1,
		NoRecentering = 2,
		Momentary = 4,
	}

	[FieldOffset(Offset = "0x0")]
	[NoSaveDuringPlay]
	[Token(Token = "0x40002EE")]
	[Tooltip("The current value of the axis.  You can drive this directly from a script.")]
	public float Value; //Field offset: 0x0
	[Delayed]
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40002EF")]
	[Tooltip("The centered, or at-rest value of this axis.")]
	public float Center; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002F0")]
	[Tooltip("The valid range for the axis value.  Value will be clamped to this range.")]
	[Vector2AsRange]
	public Vector2 Range; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002F1")]
	[Tooltip("If set, then the axis will wrap around at the min/max values, forming a loop")]
	public bool Wrap; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[FoldoutWithEnabledButton("Enabled")]
	[Token(Token = "0x40002F2")]
	public RecenteringSettings Recentering; //Field offset: 0x14
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[Token(Token = "0x40002F3")]
	public RestrictionFlags Restrictions; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40002F4")]
	private RecenteringState m_RecenteringState; //Field offset: 0x24

	[Token(Token = "0x170000D2")]
	public static InputAxis DefaultMomentary
	{
		[Address(RVA = "0x2845D30", Offset = "0x2845130", Length = "0x2E")]
		[Token(Token = "0x60003C3")]
		 get { } //Length: 46
	}

	[Address(RVA = "0x28458B0", Offset = "0x2844CB0", Length = "0x3A")]
	[Token(Token = "0x60003C9")]
	public void CancelRecentering() { }

	[Address(RVA = "0x28458F0", Offset = "0x2844CF0", Length = "0x82")]
	[Token(Token = "0x60003BE")]
	public float ClampValue(float v) { }

	[Address(RVA = "0x2845D30", Offset = "0x2845130", Length = "0x2E")]
	[Token(Token = "0x60003C3")]
	public static InputAxis get_DefaultMomentary() { }

	[Address(RVA = "0x2845980", Offset = "0x2844D80", Length = "0xC")]
	[Token(Token = "0x60003C0")]
	public float GetClampedValue() { }

	[Address(RVA = "0x2845990", Offset = "0x2844D90", Length = "0x49")]
	[Token(Token = "0x60003BF")]
	public float GetNormalizedValue() { }

	[Address(RVA = "0x28459E0", Offset = "0x2844DE0", Length = "0x5A")]
	[Token(Token = "0x60003C2")]
	public void Reset() { }

	[Address(RVA = "0x2845A40", Offset = "0x2844E40", Length = "0xA")]
	[Token(Token = "0x60003C5")]
	internal void SetValueAndLastValue(float value) { }

	[Address(RVA = "0x2845A50", Offset = "0x2844E50", Length = "0x50")]
	[Token(Token = "0x60003C4")]
	public bool TrackValueChange() { }

	[Address(RVA = "0x2845AA0", Offset = "0x2844EA0", Length = "0x5")]
	[Token(Token = "0x60003C8")]
	public void TriggerRecentering() { }

	[Address(RVA = "0x2845CB0", Offset = "0x28450B0", Length = "0x1C")]
	[Token(Token = "0x60003C6")]
	public void UpdateRecentering(float deltaTime, bool forceCancel) { }

	[Address(RVA = "0x2845AB0", Offset = "0x2844EB0", Length = "0x1F9")]
	[Token(Token = "0x60003C7")]
	public void UpdateRecentering(float deltaTime, bool forceCancel, float center) { }

	[Address(RVA = "0x2845CD0", Offset = "0x28450D0", Length = "0x5D")]
	[Token(Token = "0x60003C1")]
	public void Validate() { }

}

