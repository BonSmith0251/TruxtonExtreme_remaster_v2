namespace UnityEngine.UIElements;

[Token(Token = "0x20002A1")]
public abstract class Manipulator : IManipulator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A6C")]
	private VisualElement m_Target; //Field offset: 0x10

	[Token(Token = "0x17000382")]
	public override VisualElement target
	{
		[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
		[Token(Token = "0x600124E")]
		 get { } //Length: 7
		[Address(RVA = "0x3404CB0", Offset = "0x34040B0", Length = "0x62")]
		[Token(Token = "0x600124F")]
		 set { } //Length: 98
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001250")]
	protected Manipulator() { }

	[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
	[Token(Token = "0x600124E")]
	public override VisualElement get_target() { }

	[Token(Token = "0x600124C")]
	protected abstract void RegisterCallbacksOnTarget() { }

	[Address(RVA = "0x3404CB0", Offset = "0x34040B0", Length = "0x62")]
	[Token(Token = "0x600124F")]
	public override void set_target(VisualElement value) { }

	[Token(Token = "0x600124D")]
	protected abstract void UnregisterCallbacksFromTarget() { }

}

