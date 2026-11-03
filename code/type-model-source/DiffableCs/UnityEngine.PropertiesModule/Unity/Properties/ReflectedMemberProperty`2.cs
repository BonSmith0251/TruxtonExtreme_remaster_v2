namespace Unity.Properties;

[Token(Token = "0x2000020")]
public class ReflectedMemberProperty : Property<TContainer, TValue>
{
	[Token(Token = "0x2000023")]
	private sealed class GetClassValueAction : MulticastDelegate
	{

		[Address(RVA = "0x1C3F6A0", Offset = "0x1C3EAA0", Length = "0x111")]
		[Token(Token = "0x6000087")]
		public GetClassValueAction(object object, IntPtr method) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x6000088")]
		public override TValue Invoke(TContainer container) { }

	}

	[Token(Token = "0x2000021")]
	private sealed class GetStructValueAction : MulticastDelegate
	{

		[Address(RVA = "0xE42000", Offset = "0xE41400", Length = "0xB8")]
		[Token(Token = "0x6000083")]
		public GetStructValueAction(object object, IntPtr method) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x6000084")]
		public override TValue Invoke(ref TContainer container) { }

	}

	[Token(Token = "0x2000024")]
	private sealed class SetClassValueAction : MulticastDelegate
	{

		[Address(RVA = "0xF5C6C0", Offset = "0xF5BAC0", Length = "0x112")]
		[Token(Token = "0x6000089")]
		public SetClassValueAction(object object, IntPtr method) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x600008A")]
		public override void Invoke(TContainer container, TValue value) { }

	}

	[Token(Token = "0x2000022")]
	private sealed class SetStructValueAction : MulticastDelegate
	{

		[Address(RVA = "0xE420C0", Offset = "0xE414C0", Length = "0xB9")]
		[Token(Token = "0x6000085")]
		public SetStructValueAction(object object, IntPtr method) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x6000086")]
		public override void Invoke(ref TContainer container, TValue value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400003B")]
	private readonly IMemberInfo m_Info; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400003C")]
	private readonly bool m_IsStructContainerType; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400003D")]
	private GetStructValueAction<TContainer, TValue> m_GetStructValueAction; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400003E")]
	private SetStructValueAction<TContainer, TValue> m_SetStructValueAction; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400003F")]
	private GetClassValueAction<TContainer, TValue> m_GetClassValueAction; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000040")]
	private SetClassValueAction<TContainer, TValue> m_SetClassValueAction; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000041")]
	private readonly string <Name>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000042")]
	private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x1700001F")]
	public virtual bool IsReadOnly
	{
		[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600007F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700001E")]
	public virtual string Name
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600007E")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xF4EFC0", Offset = "0xF4E3C0", Length = "0x66E")]
	[Token(Token = "0x6000080")]
	internal ReflectedMemberProperty`2(IMemberInfo info, string name) { }

	[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600007F")]
	public virtual bool get_IsReadOnly() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600007E")]
	public virtual string get_Name() { }

	[Address(RVA = "0xF4E7F0", Offset = "0xF4DBF0", Length = "0x398")]
	[Token(Token = "0x6000081")]
	public virtual TValue GetValue(ref TContainer container) { }

	[Address(RVA = "0xF4EB90", Offset = "0xF4DF90", Length = "0x42D")]
	[Token(Token = "0x6000082")]
	public virtual void SetValue(ref TContainer container, TValue value) { }

}

