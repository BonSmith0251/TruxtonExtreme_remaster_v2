namespace Unity.Cinemachine;

[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineBlending.html")]
[Token(Token = "0x200008A")]
public sealed class CinemachineBlenderSettings : ScriptableObject
{
	[Token(Token = "0x200008B")]
	internal struct CustomBlend
	{
		[FieldOffset(Offset = "0x0")]
		[FormerlySerializedAs("m_From")]
		[Token(Token = "0x4000255")]
		[Tooltip("When blending from a camera with this name")]
		public string From; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[FormerlySerializedAs("m_To")]
		[Token(Token = "0x4000256")]
		[Tooltip("When blending to a camera with this name")]
		public string To; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("m_Blend")]
		[Token(Token = "0x4000257")]
		[Tooltip("Blend curve definition")]
		public CinemachineBlendDefinition Blend; //Field offset: 0x10

	}

	[Token(Token = "0x4000254")]
	internal const string kBlendFromAnyCameraLabel = "**ANY CAMERA**"; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("m_CustomBlends")]
	[Token(Token = "0x4000253")]
	[Tooltip("The array containing explicitly defined blends between two Virtual Cameras")]
	public CustomBlend[] CustomBlends; //Field offset: 0x18

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x60002BD")]
	public CinemachineBlenderSettings() { }

	[Address(RVA = "0x283BAD0", Offset = "0x283AED0", Length = "0x268")]
	[Token(Token = "0x60002BB")]
	public CinemachineBlendDefinition GetBlendForVirtualCameras(string fromCameraName, string toCameraName, CinemachineBlendDefinition defaultBlend) { }

	[Address(RVA = "0x283BD40", Offset = "0x283B140", Length = "0x1D9")]
	[Token(Token = "0x60002BC")]
	public static CinemachineBlendDefinition LookupBlend(ICinemachineCamera outgoing, ICinemachineCamera incoming, CinemachineBlendDefinition defaultBlend, CinemachineBlenderSettings customBlends, object owner) { }

}

