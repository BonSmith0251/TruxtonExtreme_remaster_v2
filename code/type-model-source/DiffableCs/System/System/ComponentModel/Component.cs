namespace System.ComponentModel;

[ClassInterface(ClassInterfaceType::AutoDispatch (1))]
[ComVisible(True)]
[DesignerCategory("Component")]
[Token(Token = "0x20001AA")]
public class Component : MarshalByRefObject, IComponent, IDisposable
{
	[Token(Token = "0x4000676")]
	private static readonly object EventDisposed; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000677")]
	private ISite site; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000678")]
	private EventHandlerList events; //Field offset: 0x20

	[Token(Token = "0x170001F5")]
	protected override bool CanRaiseEvents
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000A3E")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170001F6")]
	internal bool CanRaiseEventsInternal
	{
		[Address(RVA = "0x2051FA0", Offset = "0x20513A0", Length = "0x14")]
		[Token(Token = "0x6000A3F")]
		internal get { } //Length: 20
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[Token(Token = "0x170001F8")]
	protected bool DesignMode
	{
		[Address(RVA = "0x265C8D0", Offset = "0x265BCD0", Length = "0x4C")]
		[Token(Token = "0x6000A44")]
		 get { } //Length: 76
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[Token(Token = "0x170001F7")]
	public override ISite Site
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000A40")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x265C850", Offset = "0x265BC50", Length = "0x73")]
	[Token(Token = "0x6000A47")]
	private static Component() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000A46")]
	public Component() { }

	[Address(RVA = "0x265C490", Offset = "0x265B890", Length = "0x61")]
	[Token(Token = "0x6000A41")]
	public override void Dispose() { }

	[Address(RVA = "0x265C500", Offset = "0x265B900", Length = "0x1EF")]
	[Token(Token = "0x6000A42")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1E89C80", Offset = "0x1E89080", Length = "0x65")]
	[Token(Token = "0x6000A3D")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000A3E")]
	protected override bool get_CanRaiseEvents() { }

	[Address(RVA = "0x2051FA0", Offset = "0x20513A0", Length = "0x14")]
	[Token(Token = "0x6000A3F")]
	internal bool get_CanRaiseEventsInternal() { }

	[Address(RVA = "0x265C8D0", Offset = "0x265BCD0", Length = "0x4C")]
	[Token(Token = "0x6000A44")]
	protected bool get_DesignMode() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000A40")]
	public override ISite get_Site() { }

	[Address(RVA = "0x265C700", Offset = "0x265BB00", Length = "0x5D")]
	[Token(Token = "0x6000A43")]
	protected override object GetService(Type service) { }

	[Address(RVA = "0x265C760", Offset = "0x265BB60", Length = "0xEB")]
	[Token(Token = "0x6000A45")]
	public virtual string ToString() { }

}

