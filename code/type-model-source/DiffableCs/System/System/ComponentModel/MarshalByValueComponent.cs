namespace System.ComponentModel;

[DesignerCategory("Component")]
[Token(Token = "0x2000188")]
[TypeConverter(typeof(ComponentConverter))]
public class MarshalByValueComponent : IComponent, IDisposable, IServiceProvider
{
	[Token(Token = "0x4000646")]
	private static readonly object s_eventDisposed; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000647")]
	private ISite _site; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000648")]
	private EventHandlerList _events; //Field offset: 0x18

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[Token(Token = "0x170001CE")]
	public override ISite Site
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000971")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2664710", Offset = "0x2663B10", Length = "0x73")]
	[Token(Token = "0x6000976")]
	private static MarshalByValueComponent() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600096F")]
	public MarshalByValueComponent() { }

	[Address(RVA = "0x2664300", Offset = "0x2663700", Length = "0x61")]
	[Token(Token = "0x6000972")]
	public override void Dispose() { }

	[Address(RVA = "0x2664370", Offset = "0x2663770", Length = "0x1D1")]
	[Token(Token = "0x6000973")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x2664550", Offset = "0x2663950", Length = "0x65")]
	[Token(Token = "0x6000970")]
	protected virtual void Finalize() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000971")]
	public override ISite get_Site() { }

	[Address(RVA = "0x26645C0", Offset = "0x26639C0", Length = "0x5D")]
	[Token(Token = "0x6000974")]
	public override object GetService(Type service) { }

	[Address(RVA = "0x2664620", Offset = "0x2663A20", Length = "0xEB")]
	[Token(Token = "0x6000975")]
	public virtual string ToString() { }

}

