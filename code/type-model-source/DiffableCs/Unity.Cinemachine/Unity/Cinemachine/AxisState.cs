namespace Unity.Cinemachine;

[Obsolete("AxisState is deprecated.  Use InputAxis instead")]
[Token(Token = "0x20000FD")]
public struct AxisState
{
	[Obsolete("IInputAxisProvider is deprecated.  Use InputAxis and InputAxisController instead")]
	[Token(Token = "0x20000FF")]
	internal interface IInputAxisProvider
	{

		[Token(Token = "0x60004B6")]
		public float GetAxisValue(int axis) { }

	}

	[Obsolete("IRequiresInput is deprecated.  Use InputAxis and InputAxisController instead")]
	[Token(Token = "0x2000100")]
	internal interface IRequiresInput
	{

		[Token(Token = "0x60004B7")]
		public bool RequiresInput() { }

	}

	[Obsolete("AxisState.Recentering is deprecated.  Use InputAxis and InputAxisController instead")]
	[Token(Token = "0x2000101")]
	internal struct Recentering
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003C0")]
		[Tooltip("If checked, will enable automatic recentering of the axis. If unchecked, recenting is disabled.")]
		public bool m_enabled; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40003C1")]
		[Tooltip("If no user input has been detected on the axis, the axis will wait this long in seconds before recentering.")]
		public float m_WaitTime; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40003C2")]
		[Tooltip("How long it takes to reach destination once recentering has started.")]
		public float m_RecenteringTime; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40003C3")]
		private float m_LastUpdateTime; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003C4")]
		private float mLastAxisInputTime; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40003C5")]
		private float mRecenteringVelocity; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("m_HeadingDefinition")]
		[HideInInspector]
		[SerializeField]
		[Token(Token = "0x40003C6")]
		private int m_LegacyHeadingDefinition; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[FormerlySerializedAs("m_VelocityFilterStrength")]
		[HideInInspector]
		[SerializeField]
		[Token(Token = "0x40003C7")]
		private int m_LegacyVelocityFilterStrength; //Field offset: 0x1C

		[Address(RVA = "0x2864720", Offset = "0x2863B20", Length = "0x1E")]
		[Token(Token = "0x60004B8")]
		public Recentering(bool enabled, float waitTime, float recenteringTime) { }

		[Address(RVA = "0x2864430", Offset = "0x2863830", Length = "0x22")]
		[Token(Token = "0x60004BB")]
		public void CancelRecentering() { }

		[Address(RVA = "0x2864460", Offset = "0x2863860", Length = "0x1B")]
		[Token(Token = "0x60004BA")]
		public void CopyStateFrom(ref Recentering other) { }

		[Address(RVA = "0x2864480", Offset = "0x2863880", Length = "0x255")]
		[Token(Token = "0x60004BD")]
		public void DoRecentering(ref AxisState axis, float deltaTime, float recenterTarget) { }

		[Address(RVA = "0x28646E0", Offset = "0x2863AE0", Length = "0x25")]
		[Token(Token = "0x60004BE")]
		internal bool LegacyUpgrade(ref int heading, ref int velocityFilter) { }

		[Address(RVA = "0x2864710", Offset = "0x2863B10", Length = "0x8")]
		[Token(Token = "0x60004BC")]
		public void RecenterNow() { }

		[Address(RVA = "0x2844950", Offset = "0x2843D50", Length = "0x1D")]
		[Token(Token = "0x60004B9")]
		public void Validate() { }

	}

	[Token(Token = "0x20000FE")]
	internal enum SpeedMode : int
	{
		MaxSpeed = 0,
		InputValueGain = 1,
	}

	[Token(Token = "0x40003B8")]
	private const float Epsilon = 0.0001; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[NoSaveDuringPlay]
	[Token(Token = "0x40003A9")]
	[Tooltip("The current value of the axis.")]
	public float Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40003AA")]
	[Tooltip("How to interpret the Max Speed setting: in units/second, or as a direct input value multiplier")]
	public SpeedMode m_SpeedMode; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40003AB")]
	[Tooltip("The maximum speed of this axis in units/second, or the input value multiplier, depending on the Speed Mode")]
	public float m_MaxSpeed; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40003AC")]
	[Tooltip("The amount of time in seconds it takes to accelerate to MaxSpeed with the supplied Axis at its maximum value")]
	public float m_AccelTime; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003AD")]
	[Tooltip("The amount of time in seconds it takes to decelerate the axis to zero if the supplied axis is in a neutral position")]
	public float m_DecelTime; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("m_AxisName")]
	[InputAxisNameProperty]
	[Token(Token = "0x40003AE")]
	[Tooltip("The name of this axis as specified in Unity Input manager. Setting to an empty string will disable the automatic updating of this axis")]
	public string m_InputAxisName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[NoSaveDuringPlay]
	[Token(Token = "0x40003AF")]
	[Tooltip("The value of the input axis.  A value of 0 means no input.  You can drive this directly from a custom input system, or you can set the Axis Name and have the value driven by the internal Input Manager")]
	public float m_InputAxisValue; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[FormerlySerializedAs("m_InvertAxis")]
	[Token(Token = "0x40003B0")]
	[Tooltip("If checked, then the raw value of the input axis will be inverted before it is used")]
	public bool m_InvertInput; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003B1")]
	[Tooltip("The minimum value for the axis")]
	public float m_MinValue; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40003B2")]
	[Tooltip("The maximum value for the axis")]
	public float m_MaxValue; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003B3")]
	[Tooltip("If checked, then the axis will wrap around at the min/max values, forming a loop")]
	public bool m_Wrap; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40003B4")]
	[Tooltip("Automatic recentering to at-rest position")]
	public Recentering m_Recentering; //Field offset: 0x34
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40003B5")]
	private float m_CurrentSpeed; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40003B6")]
	private float m_LastUpdateTime; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40003B7")]
	private int m_LastUpdateFrame; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40003B9")]
	private IInputAxisProvider m_InputAxisProvider; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40003BA")]
	private int m_InputAxisIndex; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40003BB")]
	private bool <ValueRangeLocked>k__BackingField; //Field offset: 0x6C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x6D")]
	[Token(Token = "0x40003BC")]
	private bool <HasRecentering>k__BackingField; //Field offset: 0x6D

	[Token(Token = "0x170000FC")]
	public bool HasInputProvider
	{
		[Address(RVA = "0x1F0D390", Offset = "0x1F0C790", Length = "0x9")]
		[Token(Token = "0x60004AD")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170000FE")]
	public bool HasRecentering
	{
		[Address(RVA = "0x284E7B0", Offset = "0x284DBB0", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60004B4")]
		 get { } //Length: 5
		[Address(RVA = "0x284E7D0", Offset = "0x284DBD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60004B5")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000FD")]
	public bool ValueRangeLocked
	{
		[Address(RVA = "0x284E7C0", Offset = "0x284DBC0", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60004B2")]
		 get { } //Length: 5
		[Address(RVA = "0x284E7E0", Offset = "0x284DBE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60004B3")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x284E6C0", Offset = "0x284DAC0", Length = "0xED")]
	[Token(Token = "0x60004A9")]
	public AxisState(float minValue, float maxValue, bool wrap, bool rangeLocked, float maxSpeed, float accelTime, float decelTime, string name, bool invert) { }

	[Address(RVA = "0x284DDE0", Offset = "0x284D1E0", Length = "0x6D")]
	[Token(Token = "0x60004AF")]
	private float ClampValue(float v) { }

	[Address(RVA = "0x1F0D390", Offset = "0x1F0C790", Length = "0x9")]
	[Token(Token = "0x60004AD")]
	public bool get_HasInputProvider() { }

	[Address(RVA = "0x284E7B0", Offset = "0x284DBB0", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60004B4")]
	public bool get_HasRecentering() { }

	[Address(RVA = "0x284E7C0", Offset = "0x284DBC0", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60004B2")]
	public bool get_ValueRangeLocked() { }

	[Address(RVA = "0x284DE50", Offset = "0x284D250", Length = "0xAF")]
	[Token(Token = "0x60004B1")]
	private float GetMaxSpeed() { }

	[Address(RVA = "0x284DF00", Offset = "0x284D300", Length = "0x232")]
	[Token(Token = "0x60004B0")]
	private bool MaxSpeedUpdate(float input, float deltaTime) { }

	[Address(RVA = "0x284E140", Offset = "0x284D540", Length = "0xD")]
	[Token(Token = "0x60004AB")]
	public void Reset() { }

	[Address(RVA = "0x284E7D0", Offset = "0x284DBD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60004B5")]
	public void set_HasRecentering(bool value) { }

	[Address(RVA = "0x284E7E0", Offset = "0x284DBE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60004B3")]
	public void set_ValueRangeLocked(bool value) { }

	[Address(RVA = "0x284E150", Offset = "0x284D550", Length = "0x13")]
	[Token(Token = "0x60004AC")]
	public void SetInputAxisProvider(int axis, IInputAxisProvider provider) { }

	[Address(RVA = "0x284E170", Offset = "0x284D570", Length = "0x4EF")]
	[Token(Token = "0x60004AE")]
	public bool Update(float deltaTime) { }

	[Address(RVA = "0x284E660", Offset = "0x284DA60", Length = "0x53")]
	[Token(Token = "0x60004AA")]
	public void Validate() { }

}

