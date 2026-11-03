namespace UnityEngine;

[NativeHeader("Runtime/Input/InputBindings.h")]
[Token(Token = "0x2000005")]
public struct Touch
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000F")]
	private int m_FingerId; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000010")]
	private Vector2 m_Position; //Field offset: 0x4
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000011")]
	private Vector2 m_RawPosition; //Field offset: 0xC
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000012")]
	private Vector2 m_PositionDelta; //Field offset: 0x14
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000013")]
	private float m_TimeDelta; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000014")]
	private int m_TapCount; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000015")]
	private TouchPhase m_Phase; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000016")]
	private TouchType m_Type; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000017")]
	private float m_Pressure; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000018")]
	private float m_maximumPossiblePressure; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000019")]
	private float m_Radius; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400001A")]
	private float m_RadiusVariance; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400001B")]
	private float m_AltitudeAngle; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400001C")]
	private float m_AzimuthAngle; //Field offset: 0x40

	[Token(Token = "0x1700000B")]
	public float altitudeAngle
	{
		[Address(RVA = "0x31132A0", Offset = "0x31126A0", Length = "0x8")]
		[Token(Token = "0x600000E")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700000C")]
	public float azimuthAngle
	{
		[Address(RVA = "0x31132B0", Offset = "0x31126B0", Length = "0x8")]
		[Token(Token = "0x600000F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000004")]
	public Vector2 deltaPosition
	{
		[Address(RVA = "0x1964100", Offset = "0x1963500", Length = "0x13")]
		[Token(Token = "0x6000006")]
		 get { } //Length: 19
		[Address(RVA = "0x3110120", Offset = "0x310F520", Length = "0x5")]
		[Token(Token = "0x6000007")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000005")]
	public float deltaTime
	{
		[Address(RVA = "0x2F92DC0", Offset = "0x2F921C0", Length = "0x8")]
		[Token(Token = "0x6000008")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000001")]
	public int fingerId
	{
		[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
		[Token(Token = "0x6000001")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000009")]
	public float maximumPossiblePressure
	{
		[Address(RVA = "0x2F92DA0", Offset = "0x2F921A0", Length = "0x8")]
		[Token(Token = "0x600000C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000007")]
	public TouchPhase phase
	{
		[Address(RVA = "0x2F92DD0", Offset = "0x2F921D0", Length = "0x6")]
		[Token(Token = "0x600000A")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000002")]
	public Vector2 position
	{
		[Address(RVA = "0x31132C0", Offset = "0x31126C0", Length = "0x13")]
		[Token(Token = "0x6000002")]
		 get { } //Length: 19
		[Address(RVA = "0x20939D0", Offset = "0x2092DD0", Length = "0x5")]
		[Token(Token = "0x6000003")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000008")]
	public float pressure
	{
		[Address(RVA = "0x2F92DB0", Offset = "0x2F921B0", Length = "0x8")]
		[Token(Token = "0x600000B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700000D")]
	public float radius
	{
		[Address(RVA = "0x31132F0", Offset = "0x31126F0", Length = "0x8")]
		[Token(Token = "0x6000010")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700000E")]
	public float radiusVariance
	{
		[Address(RVA = "0x31132E0", Offset = "0x31126E0", Length = "0x8")]
		[Token(Token = "0x6000011")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000003")]
	public Vector2 rawPosition
	{
		[Address(RVA = "0x3113300", Offset = "0x3112700", Length = "0x13")]
		[Token(Token = "0x6000004")]
		 get { } //Length: 19
		[Address(RVA = "0x3113320", Offset = "0x3112720", Length = "0x5")]
		[Token(Token = "0x6000005")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000006")]
	public int tapCount
	{
		[Address(RVA = "0x1073710", Offset = "0x1072B10", Length = "0x6")]
		[Token(Token = "0x6000009")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700000A")]
	public TouchType type
	{
		[Address(RVA = "0x1073730", Offset = "0x1072B30", Length = "0x6")]
		[Token(Token = "0x600000D")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x31132A0", Offset = "0x31126A0", Length = "0x8")]
	[Token(Token = "0x600000E")]
	public float get_altitudeAngle() { }

	[Address(RVA = "0x31132B0", Offset = "0x31126B0", Length = "0x8")]
	[Token(Token = "0x600000F")]
	public float get_azimuthAngle() { }

	[Address(RVA = "0x1964100", Offset = "0x1963500", Length = "0x13")]
	[Token(Token = "0x6000006")]
	public Vector2 get_deltaPosition() { }

	[Address(RVA = "0x2F92DC0", Offset = "0x2F921C0", Length = "0x8")]
	[Token(Token = "0x6000008")]
	public float get_deltaTime() { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x6000001")]
	public int get_fingerId() { }

	[Address(RVA = "0x2F92DA0", Offset = "0x2F921A0", Length = "0x8")]
	[Token(Token = "0x600000C")]
	public float get_maximumPossiblePressure() { }

	[Address(RVA = "0x2F92DD0", Offset = "0x2F921D0", Length = "0x6")]
	[Token(Token = "0x600000A")]
	public TouchPhase get_phase() { }

	[Address(RVA = "0x31132C0", Offset = "0x31126C0", Length = "0x13")]
	[Token(Token = "0x6000002")]
	public Vector2 get_position() { }

	[Address(RVA = "0x2F92DB0", Offset = "0x2F921B0", Length = "0x8")]
	[Token(Token = "0x600000B")]
	public float get_pressure() { }

	[Address(RVA = "0x31132F0", Offset = "0x31126F0", Length = "0x8")]
	[Token(Token = "0x6000010")]
	public float get_radius() { }

	[Address(RVA = "0x31132E0", Offset = "0x31126E0", Length = "0x8")]
	[Token(Token = "0x6000011")]
	public float get_radiusVariance() { }

	[Address(RVA = "0x3113300", Offset = "0x3112700", Length = "0x13")]
	[Token(Token = "0x6000004")]
	public Vector2 get_rawPosition() { }

	[Address(RVA = "0x1073710", Offset = "0x1072B10", Length = "0x6")]
	[Token(Token = "0x6000009")]
	public int get_tapCount() { }

	[Address(RVA = "0x1073730", Offset = "0x1072B30", Length = "0x6")]
	[Token(Token = "0x600000D")]
	public TouchType get_type() { }

	[Address(RVA = "0x3110120", Offset = "0x310F520", Length = "0x5")]
	[Token(Token = "0x6000007")]
	public void set_deltaPosition(Vector2 value) { }

	[Address(RVA = "0x20939D0", Offset = "0x2092DD0", Length = "0x5")]
	[Token(Token = "0x6000003")]
	public void set_position(Vector2 value) { }

	[Address(RVA = "0x3113320", Offset = "0x3112720", Length = "0x5")]
	[Token(Token = "0x6000005")]
	public void set_rawPosition(Vector2 value) { }

}

