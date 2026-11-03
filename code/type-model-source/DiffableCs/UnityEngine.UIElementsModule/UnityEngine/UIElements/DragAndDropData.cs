namespace UnityEngine.UIElements;

[Token(Token = "0x2000192")]
public abstract class DragAndDropData
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400078D")]
	private String[] <paths>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000216")]
	public override String[] paths
	{
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000BDF")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000215")]
	public abstract object source
	{
		[Token(Token = "0x6000BDE")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000BE0")]
	protected DragAndDropData() { }

	[Token(Token = "0x6000BDE")]
	public abstract object get_source() { }

	[Token(Token = "0x6000BDD")]
	public abstract object GetGenericData(string key) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000BDF")]
	public override void set_paths(String[] value) { }

}

