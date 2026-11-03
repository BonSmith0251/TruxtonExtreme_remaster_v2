namespace UnityEngine.UIElements;

[Token(Token = "0x20000E4")]
public class Image : VisualElement
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000E5")]
	internal class UxmlFactory : UxmlFactory<Image, UxmlTraits>
	{

		[Address(RVA = "0x3391260", Offset = "0x3390660", Length = "0x39")]
		[Token(Token = "0x60006FE")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000E6")]
	internal class UxmlTraits : UxmlTraits
	{

		[Address(RVA = "0x3392720", Offset = "0x3391B20", Length = "0x7")]
		[Token(Token = "0x60006FF")]
		public UxmlTraits() { }

	}

	[Token(Token = "0x4000452")]
	internal static readonly BindingId sourceProperty; //Field offset: 0x0
	[Token(Token = "0x4000453")]
	internal static readonly BindingId imageProperty; //Field offset: 0x98
	[Token(Token = "0x4000454")]
	internal static readonly BindingId spriteProperty; //Field offset: 0x130
	[Token(Token = "0x4000455")]
	internal static readonly BindingId vectorImageProperty; //Field offset: 0x1C8
	[Token(Token = "0x4000456")]
	internal static readonly BindingId sourceRectProperty; //Field offset: 0x260
	[Token(Token = "0x4000457")]
	internal static readonly BindingId uvProperty; //Field offset: 0x2F8
	[Token(Token = "0x4000458")]
	internal static readonly BindingId scaleModeProperty; //Field offset: 0x390
	[Token(Token = "0x4000459")]
	internal static readonly BindingId tintColorProperty; //Field offset: 0x428
	[Token(Token = "0x4000461")]
	public static readonly string ussClassName; //Field offset: 0x4C0
	[Token(Token = "0x4000462")]
	private static CustomStyleProperty<Texture2D> s_ImageProperty; //Field offset: 0x4C8
	[Token(Token = "0x4000463")]
	private static CustomStyleProperty<Sprite> s_SpriteProperty; //Field offset: 0x4D0
	[Token(Token = "0x4000464")]
	private static CustomStyleProperty<VectorImage> s_VectorImageProperty; //Field offset: 0x4D8
	[Token(Token = "0x4000465")]
	private static CustomStyleProperty<String> s_ScaleModeProperty; //Field offset: 0x4E0
	[Token(Token = "0x4000466")]
	private static CustomStyleProperty<Color> s_TintColorProperty; //Field offset: 0x4E8
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x400045A")]
	private ScaleMode m_ScaleMode; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x400045B")]
	private object m_Image; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x400045C")]
	private Rect m_UV; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x400045D")]
	private Color m_TintColor; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x400045E")]
	internal bool m_ImageIsInline; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x2F9")]
	[Token(Token = "0x400045F")]
	internal bool m_ScaleModeIsInline; //Field offset: 0x2F9
	[FieldOffset(Offset = "0x2FA")]
	[Token(Token = "0x4000460")]
	internal bool m_TintColorIsInline; //Field offset: 0x2FA

	[CreateProperty]
	[Token(Token = "0x17000102")]
	public Texture image
	{
		[Address(RVA = "0x33833B0", Offset = "0x33827B0", Length = "0x75")]
		[Token(Token = "0x60006E1")]
		 get { } //Length: 117
		[Address(RVA = "0x3383530", Offset = "0x3382930", Length = "0x10F")]
		[Token(Token = "0x60006E2")]
		 set { } //Length: 271
	}

	[CreateProperty]
	[Token(Token = "0x17000107")]
	public ScaleMode scaleMode
	{
		[Address(RVA = "0x3383430", Offset = "0x3382830", Length = "0x7")]
		[Token(Token = "0x60006EB")]
		 get { } //Length: 7
		[Address(RVA = "0x3383640", Offset = "0x3382A40", Length = "0x21")]
		[Token(Token = "0x60006EC")]
		 set { } //Length: 33
	}

	[CreateProperty]
	[Token(Token = "0x17000101")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal object source
	{
		[Address(RVA = "0x1CE5A20", Offset = "0x1CE4E20", Length = "0x8")]
		[Token(Token = "0x60006DF")]
		internal get { } //Length: 8
		[Address(RVA = "0x3383840", Offset = "0x3382C40", Length = "0x3BE")]
		[Token(Token = "0x60006E0")]
		internal set { } //Length: 958
	}

	[CreateProperty]
	[Token(Token = "0x17000105")]
	public Rect sourceRect
	{
		[Address(RVA = "0x3383440", Offset = "0x3382840", Length = "0x25")]
		[Token(Token = "0x60006E7")]
		 get { } //Length: 37
		[Address(RVA = "0x3383670", Offset = "0x3382A70", Length = "0x1C7")]
		[Token(Token = "0x60006E8")]
		 set { } //Length: 455
	}

	[CreateProperty]
	[Token(Token = "0x17000103")]
	public Sprite sprite
	{
		[Address(RVA = "0x3383470", Offset = "0x3382870", Length = "0x47")]
		[Token(Token = "0x60006E3")]
		 get { } //Length: 71
		[Address(RVA = "0x3383C00", Offset = "0x3383000", Length = "0x10F")]
		[Token(Token = "0x60006E4")]
		 set { } //Length: 271
	}

	[CreateProperty]
	[Token(Token = "0x17000108")]
	public Color tintColor
	{
		[Address(RVA = "0x33834C0", Offset = "0x33828C0", Length = "0xE")]
		[Token(Token = "0x60006ED")]
		 get { } //Length: 14
		[Address(RVA = "0x3383D10", Offset = "0x3383110", Length = "0x98")]
		[Token(Token = "0x60006EE")]
		 set { } //Length: 152
	}

	[CreateProperty]
	[Token(Token = "0x17000106")]
	public Rect uv
	{
		[Address(RVA = "0x33834D0", Offset = "0x33828D0", Length = "0xE")]
		[Token(Token = "0x60006E9")]
		 get { } //Length: 14
		[Address(RVA = "0x3383DB0", Offset = "0x33831B0", Length = "0xF8")]
		[Token(Token = "0x60006EA")]
		 set { } //Length: 248
	}

	[CreateProperty]
	[Token(Token = "0x17000104")]
	public VectorImage vectorImage
	{
		[Address(RVA = "0x33834E0", Offset = "0x33828E0", Length = "0x47")]
		[Token(Token = "0x60006E5")]
		 get { } //Length: 71
		[Address(RVA = "0x3383EB0", Offset = "0x33832B0", Length = "0x10F")]
		[Token(Token = "0x60006E6")]
		 set { } //Length: 271
	}

	[Address(RVA = "0x3382900", Offset = "0x3381D00", Length = "0x8E0")]
	[Token(Token = "0x60006FD")]
	private static Image() { }

	[Address(RVA = "0x33831E0", Offset = "0x33825E0", Length = "0x1C3")]
	[Token(Token = "0x60006EF")]
	public Image() { }

	[Address(RVA = "0x3380CB0", Offset = "0x33800B0", Length = "0x237")]
	[Token(Token = "0x60006FB")]
	private void CalculateUV(Rect srcRect) { }

	[Address(RVA = "0x3380EF0", Offset = "0x33802F0", Length = "0x23")]
	[Token(Token = "0x60006F8")]
	private void ClearProperty() { }

	[Address(RVA = "0x3380F20", Offset = "0x3380320", Length = "0x471")]
	[Token(Token = "0x60006F2")]
	protected private virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	[Address(RVA = "0x33833B0", Offset = "0x33827B0", Length = "0x75")]
	[Token(Token = "0x60006E1")]
	public Texture get_image() { }

	[Address(RVA = "0x3383430", Offset = "0x3382830", Length = "0x7")]
	[Token(Token = "0x60006EB")]
	public ScaleMode get_scaleMode() { }

	[Address(RVA = "0x1CE5A20", Offset = "0x1CE4E20", Length = "0x8")]
	[Token(Token = "0x60006DF")]
	internal object get_source() { }

	[Address(RVA = "0x3383440", Offset = "0x3382840", Length = "0x25")]
	[Token(Token = "0x60006E7")]
	public Rect get_sourceRect() { }

	[Address(RVA = "0x3383470", Offset = "0x3382870", Length = "0x47")]
	[Token(Token = "0x60006E3")]
	public Sprite get_sprite() { }

	[Address(RVA = "0x33834C0", Offset = "0x33828C0", Length = "0xE")]
	[Token(Token = "0x60006ED")]
	public Color get_tintColor() { }

	[Address(RVA = "0x33834D0", Offset = "0x33828D0", Length = "0xE")]
	[Token(Token = "0x60006E9")]
	public Rect get_uv() { }

	[Address(RVA = "0x33834E0", Offset = "0x33828E0", Length = "0x47")]
	[Token(Token = "0x60006E5")]
	public VectorImage get_vectorImage() { }

	[Address(RVA = "0x33813A0", Offset = "0x33807A0", Length = "0x2D0")]
	[Token(Token = "0x60006FC")]
	private Rect GetSourceRect() { }

	[Address(RVA = "0x3381770", Offset = "0x3380B70", Length = "0x153")]
	[Token(Token = "0x60006F1")]
	private Vector2 GetTextureDisplaySize(Sprite sprite) { }

	[Address(RVA = "0x3381680", Offset = "0x3380A80", Length = "0xE4")]
	[Token(Token = "0x60006F0")]
	private Vector2 GetTextureDisplaySize(Texture texture) { }

	[Address(RVA = "0x33818D0", Offset = "0x3380CD0", Length = "0x33")]
	[Token(Token = "0x60006F4")]
	private void OnCustomStyleResolved(CustomStyleResolvedEvent e) { }

	[Address(RVA = "0x3381910", Offset = "0x3380D10", Length = "0x66A")]
	[Token(Token = "0x60006F3")]
	private void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	[Address(RVA = "0x3381F80", Offset = "0x3381380", Length = "0x6E9")]
	[Token(Token = "0x60006F5")]
	private void ReadCustomProperties(ICustomStyle customStyleProvider) { }

	[Address(RVA = "0x3383530", Offset = "0x3382930", Length = "0x10F")]
	[Token(Token = "0x60006E2")]
	public void set_image(Texture value) { }

	[Address(RVA = "0x3383640", Offset = "0x3382A40", Length = "0x21")]
	[Token(Token = "0x60006EC")]
	public void set_scaleMode(ScaleMode value) { }

	[Address(RVA = "0x3383840", Offset = "0x3382C40", Length = "0x3BE")]
	[Token(Token = "0x60006E0")]
	internal void set_source(object value) { }

	[Address(RVA = "0x3383670", Offset = "0x3382A70", Length = "0x1C7")]
	[Token(Token = "0x60006E8")]
	public void set_sourceRect(Rect value) { }

	[Address(RVA = "0x3383C00", Offset = "0x3383000", Length = "0x10F")]
	[Token(Token = "0x60006E4")]
	public void set_sprite(Sprite value) { }

	[Address(RVA = "0x3383D10", Offset = "0x3383110", Length = "0x98")]
	[Token(Token = "0x60006EE")]
	public void set_tintColor(Color value) { }

	[Address(RVA = "0x3383DB0", Offset = "0x33831B0", Length = "0xF8")]
	[Token(Token = "0x60006EA")]
	public void set_uv(Rect value) { }

	[Address(RVA = "0x3383EB0", Offset = "0x33832B0", Length = "0x10F")]
	[Token(Token = "0x60006E6")]
	public void set_vectorImage(VectorImage value) { }

	[Address(RVA = "0x3382670", Offset = "0x3381A70", Length = "0xF9")]
	[Token(Token = "0x60006F7")]
	private void SetCustomProperty(object value, BindingId binding) { }

	[Address(RVA = "0x82F9A0", Offset = "0x82EDA0", Length = "0x1C9")]
	[Token(Token = "0x60006F6")]
	private void SetInlineProperty(object value, BindingId binding) { }

	[Address(RVA = "0x3382770", Offset = "0x3381B70", Length = "0x8C")]
	[Token(Token = "0x60006F9")]
	private void SetScaleMode(ScaleMode mode) { }

	[Address(RVA = "0x3382800", Offset = "0x3381C00", Length = "0xFA")]
	[Token(Token = "0x60006FA")]
	private void SetTintColor(Color color) { }

}

