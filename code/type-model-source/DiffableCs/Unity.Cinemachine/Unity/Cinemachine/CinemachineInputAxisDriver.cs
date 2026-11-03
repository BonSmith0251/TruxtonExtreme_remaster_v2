namespace Unity.Cinemachine;

[Obsolete("CinemachineInputAxisDriver has been deprecated. Use DefaultInputAxisDriver instead.")]
[Token(Token = "0x200011C")]
public struct CinemachineInputAxisDriver
{
	[Token(Token = "0x40004A7")]
	private const float Epsilon = 0.0001; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004A1")]
	[Tooltip("Multiply the input by this amount prior to processing.  Controls the input power.")]
	public float multiplier; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40004A2")]
	[Tooltip("The amount of time in seconds it takes to accelerate to a higher speed")]
	public float accelTime; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40004A3")]
	[Tooltip("The amount of time in seconds it takes to decelerate to a lower speed")]
	public float decelTime; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004A4")]
	[Tooltip("The name of this axis as specified in Unity Input manager. Setting to an empty string will disable the automatic updating of this axis")]
	public string name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NoSaveDuringPlay]
	[Token(Token = "0x40004A5")]
	[Tooltip("The value of the input axis.  A value of 0 means no input.  You can drive this directly from a custom input system, or you can set the Axis Name and have the value driven by the internal Input Manager")]
	public float inputValue; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40004A6")]
	private float mCurrentSpeed; //Field offset: 0x1C

	[Address(RVA = "0x286ED70", Offset = "0x286E170", Length = "0x70")]
	[Token(Token = "0x600057A")]
	private float ClampValue(ref AxisBase axis, float v) { }

	[Address(RVA = "0x286EDE0", Offset = "0x286E1E0", Length = "0x337")]
	[Token(Token = "0x6000578")]
	public bool Update(float deltaTime, ref AxisBase axis) { }

	[Address(RVA = "0x286F120", Offset = "0x286E520", Length = "0x70")]
	[Token(Token = "0x6000579")]
	public bool Update(float deltaTime, ref AxisState axis) { }

	[Address(RVA = "0x2844950", Offset = "0x2843D50", Length = "0x1D")]
	[Token(Token = "0x6000577")]
	public void Validate() { }

}

