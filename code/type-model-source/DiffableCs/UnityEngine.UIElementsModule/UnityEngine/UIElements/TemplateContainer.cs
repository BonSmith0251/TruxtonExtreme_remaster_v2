namespace UnityEngine.UIElements;

[HideInInspector]
[Token(Token = "0x200049C")]
[UxmlElement("Instance")]
public class TemplateContainer : BindableElement
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200049D")]
	internal class UxmlFactory : UxmlFactory<TemplateContainer, UxmlTraits>
	{

		[Token(Token = "0x1700092F")]
		public virtual string uxmlName
		{
			[Address(RVA = "0x3296C10", Offset = "0x3296010", Length = "0x2C")]
			[Token(Token = "0x6002285")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000930")]
		public virtual string uxmlQualifiedName
		{
			[Address(RVA = "0x3296C40", Offset = "0x3296040", Length = "0x78")]
			[Token(Token = "0x6002286")]
			 get { } //Length: 120
		}

		[Address(RVA = "0x3296BD0", Offset = "0x3295FD0", Length = "0x39")]
		[Token(Token = "0x6002287")]
		public UxmlFactory() { }

		[Address(RVA = "0x3296C10", Offset = "0x3296010", Length = "0x2C")]
		[Token(Token = "0x6002285")]
		public virtual string get_uxmlName() { }

		[Address(RVA = "0x3296C40", Offset = "0x3296040", Length = "0x78")]
		[Token(Token = "0x6002286")]
		public virtual string get_uxmlQualifiedName() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200049E")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000F42")]
		private UxmlStringAttributeDescription m_Template; //Field offset: 0x90

		[Address(RVA = "0x32971F0", Offset = "0x32965F0", Length = "0x9D")]
		[Token(Token = "0x6002289")]
		public UxmlTraits() { }

		[Address(RVA = "0x3296CC0", Offset = "0x32960C0", Length = "0x523")]
		[Token(Token = "0x6002288")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000F3C")]
	internal static readonly BindingId templateIdProperty; //Field offset: 0x0
	[Token(Token = "0x4000F3E")]
	internal const string k_ElementName = "Instance"; //Field offset: 0x0
	[Token(Token = "0x4000F3D")]
	internal static readonly BindingId templateSourceProperty; //Field offset: 0x98
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x4000F3F")]
	private string <templateId>k__BackingField; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x4000F40")]
	private VisualElement m_ContentContainer; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x4000F41")]
	private VisualTreeAsset m_TemplateSource; //Field offset: 0x2E8

	[Token(Token = "0x1700092E")]
	public virtual VisualElement contentContainer
	{
		[Address(RVA = "0x3293200", Offset = "0x3292600", Length = "0xA")]
		[Token(Token = "0x6002282")]
		 get { } //Length: 10
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x1700092C")]
	public private string templateId
	{
		[Address(RVA = "0x3293210", Offset = "0x3292610", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600227B")]
		 get { } //Length: 8
		[Address(RVA = "0x3293230", Offset = "0x3292630", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600227C")]
		private set { } //Length: 19
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x1700092D")]
	public internal VisualTreeAsset templateSource
	{
		[Address(RVA = "0x3293220", Offset = "0x3292620", Length = "0x8")]
		[Token(Token = "0x600227D")]
		 get { } //Length: 8
		[Address(RVA = "0x3293250", Offset = "0x3292650", Length = "0x13")]
		[Token(Token = "0x600227E")]
		internal set { } //Length: 19
	}

	[Address(RVA = "0x3292ED0", Offset = "0x32922D0", Length = "0x1E2")]
	[Token(Token = "0x6002284")]
	private static TemplateContainer() { }

	[Address(RVA = "0x3293130", Offset = "0x3292530", Length = "0x5D")]
	[Token(Token = "0x600227F")]
	public TemplateContainer() { }

	[Address(RVA = "0x32930C0", Offset = "0x32924C0", Length = "0x66")]
	[Token(Token = "0x6002280")]
	public TemplateContainer(string templateId) { }

	[Address(RVA = "0x3293190", Offset = "0x3292590", Length = "0x70")]
	[Token(Token = "0x6002281")]
	internal TemplateContainer(string templateId, VisualTreeAsset templateSource) { }

	[Address(RVA = "0x3293200", Offset = "0x3292600", Length = "0xA")]
	[Token(Token = "0x6002282")]
	public virtual VisualElement get_contentContainer() { }

	[Address(RVA = "0x3293210", Offset = "0x3292610", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600227B")]
	public string get_templateId() { }

	[Address(RVA = "0x3293220", Offset = "0x3292620", Length = "0x8")]
	[Token(Token = "0x600227D")]
	public VisualTreeAsset get_templateSource() { }

	[Address(RVA = "0x3293230", Offset = "0x3292630", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600227C")]
	private void set_templateId(string value) { }

	[Address(RVA = "0x3293250", Offset = "0x3292650", Length = "0x13")]
	[Token(Token = "0x600227E")]
	internal void set_templateSource(VisualTreeAsset value) { }

	[Address(RVA = "0x3292EB0", Offset = "0x32922B0", Length = "0x13")]
	[Token(Token = "0x6002283")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void SetContentContainer(VisualElement content) { }

}

