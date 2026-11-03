namespace Unity.Cinemachine;

[Token(Token = "0x2000191")]
internal sealed class CinemachineShotPlayable : PlayableBehaviour
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006AA")]
	public CinemachineVirtualCameraBase VirtualCamera; //Field offset: 0x10

	[Token(Token = "0x1700015F")]
	public bool IsValid
	{
		[Address(RVA = "0x289E810", Offset = "0x289DC10", Length = "0x50")]
		[Token(Token = "0x600085E")]
		 get { } //Length: 80
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x600085F")]
	public CinemachineShotPlayable() { }

	[Address(RVA = "0x289E810", Offset = "0x289DC10", Length = "0x50")]
	[Token(Token = "0x600085E")]
	public bool get_IsValid() { }

}

