namespace InGame.Kernel;

[Token(Token = "0x2000019")]
public class InGameBulletReway : InGameBullet
{
	[Token(Token = "0x40000C1")]
	private static readonly float RewayAngle; //Field offset: 0x0
	[Token(Token = "0x40000C2")]
	private static readonly Matrix4x4 RewayL; //Field offset: 0x4
	[Token(Token = "0x40000C3")]
	private static readonly Matrix4x4 RewayR; //Field offset: 0x44
	[Token(Token = "0x40000C4")]
	private static readonly float RewaySeconds; //Field offset: 0x84
	[Token(Token = "0x40000C5")]
	private static readonly float RewayLength; //Field offset: 0x88

	[Address(RVA = "0x1CCD130", Offset = "0x1CCC530", Length = "0x188")]
	[Token(Token = "0x6000100")]
	private static InGameBulletReway() { }

	[Address(RVA = "0x1CCD2C0", Offset = "0x1CCC6C0", Length = "0x49")]
	[Token(Token = "0x60000FF")]
	public InGameBulletReway() { }

	[Address(RVA = "0x1CCCC50", Offset = "0x1CCC050", Length = "0x4DA")]
	[Token(Token = "0x60000FE")]
	public virtual void ProgressBullet(float dt) { }

}

