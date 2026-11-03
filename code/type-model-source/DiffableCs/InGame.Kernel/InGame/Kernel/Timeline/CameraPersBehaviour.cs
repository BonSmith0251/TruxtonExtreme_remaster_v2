namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000D9")]
public class CameraPersBehaviour : PlayableBehaviour
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40005F5")]
	private float _camPers; //Field offset: 0x10

	[Token(Token = "0x17000156")]
	public float CameraPers
	{
		[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
		[Token(Token = "0x6000740")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000742")]
	public CameraPersBehaviour() { }

	[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
	[Token(Token = "0x6000740")]
	public float get_CameraPers() { }

	[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
	[Token(Token = "0x6000741")]
	public void Set(float p) { }

}

