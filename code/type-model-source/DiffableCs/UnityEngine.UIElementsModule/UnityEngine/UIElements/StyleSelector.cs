namespace UnityEngine.UIElements;

[Token(Token = "0x2000484")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class StyleSelector
{
	[CompilerGenerated]
	[Token(Token = "0x2000485")]
	private sealed class <>c
	{
		[Token(Token = "0x4000EC6")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000EC7")]
		public static Func<StyleSelectorPart, String> <>9__11_0; //Field offset: 0x8

		[Address(RVA = "0x3293320", Offset = "0x3292720", Length = "0x67")]
		[Token(Token = "0x60021D3")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60021D4")]
		public <>c() { }

		[Address(RVA = "0x32932D0", Offset = "0x32926D0", Length = "0x13")]
		[Token(Token = "0x60021D5")]
		internal string <ToString>b__11_0(StyleSelectorPart p) { }

	}

	[Token(Token = "0x4000EC3")]
	public const int InvalidPseudoStateMask = -1; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000EC1")]
	private StyleSelectorPart[] m_Parts; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000EC2")]
	private StyleSelectorRelationship m_PreviousRelationship; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000EC4")]
	internal int pseudoStateMask; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000EC5")]
	internal int negatedPseudoStateMask; //Field offset: 0x20

	[Token(Token = "0x1700091A")]
	public internal StyleSelectorPart[] parts
	{
		[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
		[Token(Token = "0x60021CD")]
		 get { } //Length: 7
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x60021CE")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700091B")]
	public internal StyleSelectorRelationship previousRelationship
	{
		[Address(RVA = "0xE0D7C0", Offset = "0xE0CBC0", Length = "0x6")]
		[Token(Token = "0x60021CF")]
		 get { } //Length: 6
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x60021D0")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x328B840", Offset = "0x328AC40", Length = "0xF")]
	[Token(Token = "0x60021D2")]
	public StyleSelector() { }

	[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
	[Token(Token = "0x60021CD")]
	public StyleSelectorPart[] get_parts() { }

	[Address(RVA = "0xE0D7C0", Offset = "0xE0CBC0", Length = "0x6")]
	[Token(Token = "0x60021CF")]
	public StyleSelectorRelationship get_previousRelationship() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x60021CE")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_parts(StyleSelectorPart[] value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[Token(Token = "0x60021D0")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_previousRelationship(StyleSelectorRelationship value) { }

	[Address(RVA = "0x328B6E0", Offset = "0x328AAE0", Length = "0x157")]
	[Token(Token = "0x60021D1")]
	public virtual string ToString() { }

}

