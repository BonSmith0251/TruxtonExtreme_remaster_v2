namespace InGame.Kernel;

[Token(Token = "0x2000005")]
public class InGameAnimationManager
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000018")]
	private List<Animator> _pools; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000019")]
	private float _timeRate; //Field offset: 0x18

	[Address(RVA = "0x1CC73E0", Offset = "0x1CC67E0", Length = "0x5D")]
	[Token(Token = "0x6000020")]
	private bool _isContain(Animator am) { }

	[Address(RVA = "0x1CC73D0", Offset = "0x1CC67D0", Length = "0xE")]
	[Token(Token = "0x6000021")]
	public InGameAnimationManager() { }

	[Address(RVA = "0x1CC6D00", Offset = "0x1CC6100", Length = "0x172")]
	[Token(Token = "0x600001E")]
	public void ChangeSpeed(float speed, bool isForce) { }

	[Address(RVA = "0x1CC6FF0", Offset = "0x1CC63F0", Length = "0x10D")]
	[Token(Token = "0x600001A")]
	public void Entry(Animator a) { }

	[Address(RVA = "0x1CC6E80", Offset = "0x1CC6280", Length = "0x16C")]
	[Token(Token = "0x600001B")]
	public void Entry(Animator[] animes) { }

	[Address(RVA = "0x1CC7100", Offset = "0x1CC6500", Length = "0x6D")]
	[Token(Token = "0x6000018")]
	public void Initialize() { }

	[Address(RVA = "0x1CC7170", Offset = "0x1CC6570", Length = "0x25")]
	[Token(Token = "0x600001F")]
	public void Pause(bool value) { }

	[Address(RVA = "0x1CC71A0", Offset = "0x1CC65A0", Length = "0xA6")]
	[Token(Token = "0x600001C")]
	public void Remove(Animator a) { }

	[Address(RVA = "0x1CC7250", Offset = "0x1CC6650", Length = "0x10E")]
	[Token(Token = "0x600001D")]
	public void Remove(Animator[] animes) { }

	[Address(RVA = "0x1CC7360", Offset = "0x1CC6760", Length = "0x6F")]
	[Token(Token = "0x6000019")]
	public void Terminate() { }

}

