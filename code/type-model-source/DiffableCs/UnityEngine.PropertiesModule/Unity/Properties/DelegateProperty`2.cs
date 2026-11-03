namespace Unity.Properties;

[Token(Token = "0x2000012")]
public class DelegateProperty : Property<TContainer, TValue>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000020")]
	private readonly PropertyGetter<TContainer, TValue> m_Getter; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000021")]
	private readonly PropertySetter<TContainer, TValue> m_Setter; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000022")]
	private readonly string <Name>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000004")]
	public virtual bool IsReadOnly
	{
		[Address(RVA = "0x17D6B30", Offset = "0x17D5F30", Length = "0x9")]
		[Token(Token = "0x6000028")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000003")]
	public virtual string Name
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000027")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x17D6A60", Offset = "0x17D5E60", Length = "0xCA")]
	[Token(Token = "0x6000029")]
	public DelegateProperty`2(string name, PropertyGetter<TContainer, TValue> getter, PropertySetter<TContainer, TValue> setter = null) { }

	[Address(RVA = "0x17D6B30", Offset = "0x17D5F30", Length = "0x9")]
	[Token(Token = "0x6000028")]
	public virtual bool get_IsReadOnly() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000027")]
	public virtual string get_Name() { }

	[Address(RVA = "0x17D67F0", Offset = "0x17D5BF0", Length = "0x10C")]
	[Token(Token = "0x600002A")]
	public virtual TValue GetValue(ref TContainer container) { }

	[Address(RVA = "0x17D6900", Offset = "0x17D5D00", Length = "0x156")]
	[Token(Token = "0x600002B")]
	public virtual void SetValue(ref TContainer container, TValue value) { }

}

