namespace KANAI.UI;

[Token(Token = "0x2000010")]
public class UIButton : ButtonBase
{
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000035")]
	private float scaleTime; //Field offset: 0x160
	[FieldOffset(Offset = "0x164")]
	[SerializeField]
	[Token(Token = "0x4000036")]
	private readonly float scaleTimeMax; //Field offset: 0x164
	[FieldOffset(Offset = "0x168")]
	[SerializeField]
	[Token(Token = "0x4000037")]
	private readonly Vector3 onPressScale; //Field offset: 0x168

	[Address(RVA = "0x1E189E0", Offset = "0x1E17DE0", Length = "0x43")]
	[Token(Token = "0x6000063")]
	protected virtual void _OnClicked() { }

	[Address(RVA = "0x1E18A30", Offset = "0x1E17E30", Length = "0x37")]
	[Token(Token = "0x6000066")]
	public UIButton() { }

	[Address(RVA = "0x1E18730", Offset = "0x1E17B30", Length = "0x55")]
	[Token(Token = "0x6000064")]
	protected virtual float GetDeltaTime() { }

	[Address(RVA = "0x1E18790", Offset = "0x1E17B90", Length = "0x12")]
	[Token(Token = "0x6000062")]
	public virtual bool IsAnimation() { }

	[Address(RVA = "0x1E187B0", Offset = "0x1E17BB0", Length = "0x18A")]
	[Token(Token = "0x6000065")]
	private void LateUpdate() { }

	[Address(RVA = "0x1E18940", Offset = "0x1E17D40", Length = "0x92")]
	[Token(Token = "0x6000061")]
	public void SetText(string iText) { }

}

