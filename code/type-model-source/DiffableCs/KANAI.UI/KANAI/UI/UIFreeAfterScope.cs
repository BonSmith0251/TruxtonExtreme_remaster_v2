namespace KANAI.UI;

[Token(Token = "0x2000033")]
public class UIFreeAfterScope : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400015E")]
	private UIInputLocker _handler; //Field offset: 0x10

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000148")]
	public UIFreeAfterScope(UIInputLocker locker) { }

	[Address(RVA = "0x1E1AB70", Offset = "0x1E19F70", Length = "0x75")]
	[Token(Token = "0x6000149")]
	public override void Dispose() { }

}

