namespace UnityEngine.UIElements;

[Token(Token = "0x2000543")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class PropertyChangedEvent : EventBase<PropertyChangedEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x2000544")]
	private sealed class <>c
	{
		[Token(Token = "0x4001174")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x32BB370", Offset = "0x32BA770", Length = "0x67")]
		[Token(Token = "0x60026C2")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60026C3")]
		public <>c() { }

		[Address(RVA = "0x32BADA0", Offset = "0x32BA1A0", Length = "0xA0")]
		[Token(Token = "0x60026C4")]
		internal PropertyChangedEvent <.cctor>b__0_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001173")]
	private BindingId <property>k__BackingField; //Field offset: 0x68

	[Token(Token = "0x17000A12")]
	public BindingId property
	{
		[Address(RVA = "0x32BA0E0", Offset = "0x32B94E0", Length = "0x73")]
		[CompilerGenerated]
		[Token(Token = "0x60026BE")]
		 get { } //Length: 115
		[Address(RVA = "0x32BA160", Offset = "0x32B9560", Length = "0x7A")]
		[CompilerGenerated]
		[Token(Token = "0x60026BF")]
		 set { } //Length: 122
	}

	[Address(RVA = "0x32B9F80", Offset = "0x32B9380", Length = "0xD1")]
	[Token(Token = "0x60026BD")]
	private static PropertyChangedEvent() { }

	[Address(RVA = "0x32BA060", Offset = "0x32B9460", Length = "0x74")]
	[Token(Token = "0x60026C0")]
	public PropertyChangedEvent() { }

	[Address(RVA = "0x32BA0E0", Offset = "0x32B94E0", Length = "0x73")]
	[CompilerGenerated]
	[Token(Token = "0x60026BE")]
	public BindingId get_property() { }

	[Address(RVA = "0x32B9E60", Offset = "0x32B9260", Length = "0x11F")]
	[Token(Token = "0x60026C1")]
	public static PropertyChangedEvent GetPooled(in BindingId property) { }

	[Address(RVA = "0x32BA160", Offset = "0x32B9560", Length = "0x7A")]
	[CompilerGenerated]
	[Token(Token = "0x60026BF")]
	public void set_property(BindingId value) { }

}

