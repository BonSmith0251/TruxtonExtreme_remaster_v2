namespace Unity.Cinemachine;

[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineImpulseFixedSignals.html")]
[Token(Token = "0x2000150")]
public class CinemachineFixedSignal : SignalSourceAsset
{
	[FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("m_XCurve")]
	[Token(Token = "0x4000590")]
	[Tooltip("The raw signal shape along the X axis")]
	public AnimationCurve XCurve; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("m_YCurve")]
	[Token(Token = "0x4000591")]
	[Tooltip("The raw signal shape along the Y axis")]
	public AnimationCurve YCurve; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_ZCurve")]
	[Token(Token = "0x4000592")]
	[Tooltip("The raw signal shape along the Z axis")]
	public AnimationCurve ZCurve; //Field offset: 0x28

	[Token(Token = "0x1700013F")]
	public virtual float SignalDuration
	{
		[Address(RVA = "0x286B580", Offset = "0x286A980", Length = "0x5E")]
		[Token(Token = "0x600068E")]
		 get { } //Length: 94
	}

	[Address(RVA = "0x1D308B0", Offset = "0x1D2FCB0", Length = "0x7")]
	[Token(Token = "0x6000692")]
	public CinemachineFixedSignal() { }

	[Address(RVA = "0x286B330", Offset = "0x286A730", Length = "0xD5")]
	[Token(Token = "0x600068F")]
	private float AxisDuration(AnimationCurve axis) { }

	[Address(RVA = "0x286B410", Offset = "0x286A810", Length = "0x4A")]
	[Token(Token = "0x6000691")]
	private float AxisValue(AnimationCurve axis, float time) { }

	[Address(RVA = "0x286B580", Offset = "0x286A980", Length = "0x5E")]
	[Token(Token = "0x600068E")]
	public virtual float get_SignalDuration() { }

	[Address(RVA = "0x286B460", Offset = "0x286A860", Length = "0x11E")]
	[Token(Token = "0x6000690")]
	public virtual void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) { }

}

