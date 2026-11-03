namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Helpers/Cinemachine External Impulse Listener")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineExternalImpulseListener.html")]
[SaveDuringPlay]
[Token(Token = "0x2000161")]
public class CinemachineExternalImpulseListener : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005EB")]
	private Vector3 m_ImpulsePosLastFrame; //Field offset: 0x20
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40005EC")]
	private Quaternion m_ImpulseRotLastFrame; //Field offset: 0x2C
	[CinemachineImpulseChannelProperty]
	[FieldOffset(Offset = "0x3C")]
	[FormerlySerializedAs("m_ChannelMask")]
	[Token(Token = "0x40005ED")]
	[Tooltip("Impulse events on channels not included in the mask will be ignored.")]
	public int ChannelMask; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("m_Gain")]
	[Token(Token = "0x40005EE")]
	[Tooltip("Gain to apply to the Impulse signal.  1 is normal strength.  Setting this to 0 completely mutes the signal.")]
	public float Gain; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[FormerlySerializedAs("m_Use2DDistance")]
	[Token(Token = "0x40005EF")]
	[Tooltip("Enable this to perform distance calculation in 2D (ignore Z)")]
	public bool Use2DDistance; //Field offset: 0x44
	[FieldOffset(Offset = "0x45")]
	[FormerlySerializedAs("m_UseLocalSpace")]
	[Token(Token = "0x40005F0")]
	[Tooltip("Enable this to process all impulse signals in camera space")]
	public bool UseLocalSpace; //Field offset: 0x45
	[FieldOffset(Offset = "0x48")]
	[FormerlySerializedAs("m_ReactionSettings")]
	[Token(Token = "0x40005F1")]
	[Tooltip("This controls the secondary reaction of the listener to the incoming impulse.  The impulse might be for example a sharp shock, and the secondary reaction could be a vibration whose amplitude and duration is controlled by the size of the original impulse.  This allows different listeners to respond in different ways to the same impulse signal.")]
	public ImpulseReaction ReactionSettings; //Field offset: 0x48

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60006CB")]
	public CinemachineExternalImpulseListener() { }

	[Address(RVA = "0x2881970", Offset = "0x2880D70", Length = "0x56E")]
	[Token(Token = "0x60006CA")]
	private void LateUpdate() { }

	[Address(RVA = "0x2881EE0", Offset = "0x28812E0", Length = "0x79")]
	[Token(Token = "0x60006C8")]
	private void OnEnable() { }

	[Address(RVA = "0x2881F60", Offset = "0x2881360", Length = "0x73")]
	[Token(Token = "0x60006C7")]
	private void Reset() { }

	[Address(RVA = "0x2881FE0", Offset = "0x28813E0", Length = "0x257")]
	[Token(Token = "0x60006C9")]
	private void Update() { }

}

