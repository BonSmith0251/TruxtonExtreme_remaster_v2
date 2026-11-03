namespace UnityEngine.UIElements;

[Token(Token = "0x200001C")]
public class BindableElement : VisualElement, IBindable
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200001D")]
	internal class UxmlFactory : UxmlFactory<BindableElement, UxmlTraits>
	{

		[Address(RVA = "0x3210EA0", Offset = "0x32102A0", Length = "0x39")]
		[Token(Token = "0x600008E")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200001E")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000041")]
		private UxmlStringAttributeDescription m_PropertyPath; //Field offset: 0x88

		[Address(RVA = "0x3211070", Offset = "0x3210470", Length = "0x96")]
		[Token(Token = "0x600008F")]
		public UxmlTraits() { }

		[Address(RVA = "0x3210EE0", Offset = "0x32102E0", Length = "0x183")]
		[Token(Token = "0x6000090")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x400003E")]
	internal const string k_BindingPathTooltip = "Default method to define a path to a serialized property. Most often used for Editor extensions and inspectors."; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x400003F")]
	private IBinding <binding>k__BackingField; //Field offset: 0x2C8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x4000040")]
	private string <bindingPath>k__BackingField; //Field offset: 0x2D0

	[Token(Token = "0x17000020")]
	public override IBinding binding
	{
		[Address(RVA = "0x102C7D0", Offset = "0x102BBD0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600008B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000021")]
	public override string bindingPath
	{
		[Address(RVA = "0x31EE840", Offset = "0x31EDC40", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600008C")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x31EE7F0", Offset = "0x31EDBF0", Length = "0x49")]
	[Token(Token = "0x600008D")]
	public BindableElement() { }

	[Address(RVA = "0x102C7D0", Offset = "0x102BBD0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600008B")]
	public override IBinding get_binding() { }

	[Address(RVA = "0x31EE840", Offset = "0x31EDC40", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600008C")]
	public override void set_bindingPath(string value) { }

}

