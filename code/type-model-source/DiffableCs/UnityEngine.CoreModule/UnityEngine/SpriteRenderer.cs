namespace UnityEngine;

[NativeType("Runtime/Graphics/Mesh/SpriteRenderer.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x2000087")]
public sealed class SpriteRenderer : Renderer
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400012A")]
	private UnityEvent<SpriteRenderer> m_SpriteChangeEvent; //Field offset: 0x18

	[Token(Token = "0x1700002F")]
	public float adaptiveModeThreshold
	{
		[Address(RVA = "0x2FEAD30", Offset = "0x2FEA130", Length = "0x76")]
		[Token(Token = "0x60001A6")]
		 get { } //Length: 118
		[Address(RVA = "0x2FEB6A0", Offset = "0x2FEAAA0", Length = "0x86")]
		[Token(Token = "0x60001A7")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000031")]
	public Color color
	{
		[Address(RVA = "0x2FEAE00", Offset = "0x2FEA200", Length = "0x8E")]
		[Token(Token = "0x60001AA")]
		 get { } //Length: 142
		[Address(RVA = "0x2FEB780", Offset = "0x2FEAB80", Length = "0x85")]
		[Token(Token = "0x60001AB")]
		 set { } //Length: 133
	}

	[Token(Token = "0x1700002D")]
	public SpriteDrawMode drawMode
	{
		[Address(RVA = "0x2FEAED0", Offset = "0x2FEA2D0", Length = "0x76")]
		[Token(Token = "0x60001A2")]
		 get { } //Length: 118
		[Address(RVA = "0x2FEB850", Offset = "0x2FEAC50", Length = "0x83")]
		[Token(Token = "0x60001A3")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000033")]
	public bool flipX
	{
		[Address(RVA = "0x2FEAF90", Offset = "0x2FEA390", Length = "0x76")]
		[Token(Token = "0x60001AE")]
		 get { } //Length: 118
		[Address(RVA = "0x2FEB930", Offset = "0x2FEAD30", Length = "0x86")]
		[Token(Token = "0x60001AF")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000034")]
	public bool flipY
	{
		[Address(RVA = "0x2FEB050", Offset = "0x2FEA450", Length = "0x76")]
		[Token(Token = "0x60001B0")]
		 get { } //Length: 118
		[Address(RVA = "0x2FEBA10", Offset = "0x2FEAE10", Length = "0x86")]
		[Token(Token = "0x60001B1")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700002B")]
	internal bool hasSpriteChangeEvents
	{
		[Address(RVA = "0x2FEB110", Offset = "0x2FEA510", Length = "0x76")]
		[Token(Token = "0x600019E")]
		internal get { } //Length: 118
		[Address(RVA = "0x2FEBAF0", Offset = "0x2FEAEF0", Length = "0x86")]
		[Token(Token = "0x600019F")]
		internal set { } //Length: 134
	}

	[Token(Token = "0x17000032")]
	public SpriteMaskInteraction maskInteraction
	{
		[Address(RVA = "0x2FEB1D0", Offset = "0x2FEA5D0", Length = "0x76")]
		[Token(Token = "0x60001AC")]
		 get { } //Length: 118
		[Address(RVA = "0x2FEBBC0", Offset = "0x2FEAFC0", Length = "0x83")]
		[Token(Token = "0x60001AD")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700002A")]
	internal bool shouldSupportTiling
	{
		[Address(RVA = "0x2FEB290", Offset = "0x2FEA690", Length = "0x76")]
		[NativeMethod("ShouldSupportTiling")]
		[Token(Token = "0x600019D")]
		internal get { } //Length: 118
	}

	[Token(Token = "0x1700002E")]
	public Vector2 size
	{
		[Address(RVA = "0x2FEB360", Offset = "0x2FEA760", Length = "0x87")]
		[Token(Token = "0x60001A4")]
		 get { } //Length: 135
		[Address(RVA = "0x2FEBCA0", Offset = "0x2FEB0A0", Length = "0x80")]
		[Token(Token = "0x60001A5")]
		 set { } //Length: 128
	}

	[Token(Token = "0x1700002C")]
	public Sprite sprite
	{
		[Address(RVA = "0x2FEB4F0", Offset = "0x2FEA8F0", Length = "0x90")]
		[Token(Token = "0x60001A0")]
		 get { } //Length: 144
		[Address(RVA = "0x2FEBE50", Offset = "0x2FEB250", Length = "0xBA")]
		[Token(Token = "0x60001A1")]
		 set { } //Length: 186
	}

	[Token(Token = "0x17000035")]
	public SpriteSortPoint spriteSortPoint
	{
		[Address(RVA = "0x2FEB430", Offset = "0x2FEA830", Length = "0x76")]
		[Token(Token = "0x60001B2")]
		 get { } //Length: 118
		[Address(RVA = "0x2FEBD70", Offset = "0x2FEB170", Length = "0x83")]
		[Token(Token = "0x60001B3")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000030")]
	public SpriteTileMode tileMode
	{
		[Address(RVA = "0x2FEB5D0", Offset = "0x2FEA9D0", Length = "0x76")]
		[Token(Token = "0x60001A8")]
		 get { } //Length: 118
		[Address(RVA = "0x2FEBF50", Offset = "0x2FEB350", Length = "0x83")]
		[Token(Token = "0x60001A9")]
		 set { } //Length: 131
	}

	[Address(RVA = "0xE31DA0", Offset = "0xE311A0", Length = "0x7")]
	[Token(Token = "0x60001B9")]
	public SpriteRenderer() { }

	[Address(RVA = "0x2FEAD30", Offset = "0x2FEA130", Length = "0x76")]
	[Token(Token = "0x60001A6")]
	public float get_adaptiveModeThreshold() { }

	[Address(RVA = "0x2FEACF0", Offset = "0x2FEA0F0", Length = "0x33")]
	[Token(Token = "0x60001C3")]
	private static float get_adaptiveModeThreshold_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FEAE00", Offset = "0x2FEA200", Length = "0x8E")]
	[Token(Token = "0x60001AA")]
	public Color get_color() { }

	[Address(RVA = "0x2FEADB0", Offset = "0x2FEA1B0", Length = "0x42")]
	[Token(Token = "0x60001C7")]
	private static void get_color_Injected(IntPtr _unity_self, out Color ret) { }

	[Address(RVA = "0x2FEAED0", Offset = "0x2FEA2D0", Length = "0x76")]
	[Token(Token = "0x60001A2")]
	public SpriteDrawMode get_drawMode() { }

	[Address(RVA = "0x2FEAE90", Offset = "0x2FEA290", Length = "0x33")]
	[Token(Token = "0x60001BF")]
	private static SpriteDrawMode get_drawMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FEAF90", Offset = "0x2FEA390", Length = "0x76")]
	[Token(Token = "0x60001AE")]
	public bool get_flipX() { }

	[Address(RVA = "0x2FEAF50", Offset = "0x2FEA350", Length = "0x33")]
	[Token(Token = "0x60001CB")]
	private static bool get_flipX_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FEB050", Offset = "0x2FEA450", Length = "0x76")]
	[Token(Token = "0x60001B0")]
	public bool get_flipY() { }

	[Address(RVA = "0x2FEB010", Offset = "0x2FEA410", Length = "0x33")]
	[Token(Token = "0x60001CD")]
	private static bool get_flipY_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FEB110", Offset = "0x2FEA510", Length = "0x76")]
	[Token(Token = "0x600019E")]
	internal bool get_hasSpriteChangeEvents() { }

	[Address(RVA = "0x2FEB0D0", Offset = "0x2FEA4D0", Length = "0x33")]
	[Token(Token = "0x60001BB")]
	private static bool get_hasSpriteChangeEvents_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FEB1D0", Offset = "0x2FEA5D0", Length = "0x76")]
	[Token(Token = "0x60001AC")]
	public SpriteMaskInteraction get_maskInteraction() { }

	[Address(RVA = "0x2FEB190", Offset = "0x2FEA590", Length = "0x33")]
	[Token(Token = "0x60001C9")]
	private static SpriteMaskInteraction get_maskInteraction_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FEB290", Offset = "0x2FEA690", Length = "0x76")]
	[NativeMethod("ShouldSupportTiling")]
	[Token(Token = "0x600019D")]
	internal bool get_shouldSupportTiling() { }

	[Address(RVA = "0x2FEB250", Offset = "0x2FEA650", Length = "0x33")]
	[Token(Token = "0x60001BA")]
	private static bool get_shouldSupportTiling_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FEB360", Offset = "0x2FEA760", Length = "0x87")]
	[Token(Token = "0x60001A4")]
	public Vector2 get_size() { }

	[Address(RVA = "0x2FEB310", Offset = "0x2FEA710", Length = "0x42")]
	[Token(Token = "0x60001C1")]
	private static void get_size_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x2FEB4F0", Offset = "0x2FEA8F0", Length = "0x90")]
	[Token(Token = "0x60001A0")]
	public Sprite get_sprite() { }

	[Address(RVA = "0x2FEB4B0", Offset = "0x2FEA8B0", Length = "0x33")]
	[Token(Token = "0x60001BD")]
	private static IntPtr get_sprite_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FEB430", Offset = "0x2FEA830", Length = "0x76")]
	[Token(Token = "0x60001B2")]
	public SpriteSortPoint get_spriteSortPoint() { }

	[Address(RVA = "0x2FEB3F0", Offset = "0x2FEA7F0", Length = "0x33")]
	[Token(Token = "0x60001CF")]
	private static SpriteSortPoint get_spriteSortPoint_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FEB5D0", Offset = "0x2FEA9D0", Length = "0x76")]
	[Token(Token = "0x60001A8")]
	public SpriteTileMode get_tileMode() { }

	[Address(RVA = "0x2FEB590", Offset = "0x2FEA990", Length = "0x33")]
	[Token(Token = "0x60001C5")]
	private static SpriteTileMode get_tileMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FEA670", Offset = "0x2FE9A70", Length = "0xEB")]
	[Token(Token = "0x60001B5")]
	internal MeshDataArray GetCurrentMeshData() { }

	[Address(RVA = "0x2FEA5F0", Offset = "0x2FE99F0", Length = "0x76")]
	[Token(Token = "0x60001B4")]
	private IntPtr GetCurrentMeshDataPtr() { }

	[Address(RVA = "0x2FEA5B0", Offset = "0x2FE99B0", Length = "0x33")]
	[Token(Token = "0x60001D1")]
	private static IntPtr GetCurrentMeshDataPtr_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FEA7B0", Offset = "0x2FE9BB0", Length = "0xC7")]
	[Token(Token = "0x60001B7")]
	internal void GetSecondaryTextureProperties(MaterialPropertyBlock mbp) { }

	[Address(RVA = "0x2FEA760", Offset = "0x2FE9B60", Length = "0x42")]
	[Token(Token = "0x60001D3")]
	private static void GetSecondaryTextureProperties_Injected(IntPtr _unity_self, IntPtr mbp) { }

	[Address(RVA = "0x2FEA880", Offset = "0x2FE9C80", Length = "0x11C")]
	[Token(Token = "0x60001B8")]
	internal Bounds GetSpriteBounds() { }

	[Address(RVA = "0x2FEA9F0", Offset = "0x2FE9DF0", Length = "0xA3")]
	[NativeMethod(Name = "GetSpriteBounds")]
	[Token(Token = "0x60001B6")]
	internal Bounds Internal_GetSpriteBounds(SpriteDrawMode mode) { }

	[Address(RVA = "0x2FEA9A0", Offset = "0x2FE9DA0", Length = "0x50")]
	[Token(Token = "0x60001D2")]
	private static void Internal_GetSpriteBounds_Injected(IntPtr _unity_self, SpriteDrawMode mode, out Bounds ret) { }

	[Address(RVA = "0x2FEAAA0", Offset = "0x2FE9EA0", Length = "0x7E")]
	[RequiredByNativeCode]
	[Token(Token = "0x600019C")]
	private void InvokeSpriteChanged() { }

	[Address(RVA = "0x2FEAB20", Offset = "0x2FE9F20", Length = "0x100")]
	[Token(Token = "0x600019A")]
	public void RegisterSpriteChangeCallback(UnityAction<SpriteRenderer> callback) { }

	[Address(RVA = "0x2FEB6A0", Offset = "0x2FEAAA0", Length = "0x86")]
	[Token(Token = "0x60001A7")]
	public void set_adaptiveModeThreshold(float value) { }

	[Address(RVA = "0x2FEB650", Offset = "0x2FEAA50", Length = "0x43")]
	[Token(Token = "0x60001C4")]
	private static void set_adaptiveModeThreshold_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FEB780", Offset = "0x2FEAB80", Length = "0x85")]
	[Token(Token = "0x60001AB")]
	public void set_color(Color value) { }

	[Address(RVA = "0x2FEB730", Offset = "0x2FEAB30", Length = "0x42")]
	[Token(Token = "0x60001C8")]
	private static void set_color_Injected(IntPtr _unity_self, in Color value) { }

	[Address(RVA = "0x2FEB850", Offset = "0x2FEAC50", Length = "0x83")]
	[Token(Token = "0x60001A3")]
	public void set_drawMode(SpriteDrawMode value) { }

	[Address(RVA = "0x2FEB810", Offset = "0x2FEAC10", Length = "0x40")]
	[Token(Token = "0x60001C0")]
	private static void set_drawMode_Injected(IntPtr _unity_self, SpriteDrawMode value) { }

	[Address(RVA = "0x2FEB930", Offset = "0x2FEAD30", Length = "0x86")]
	[Token(Token = "0x60001AF")]
	public void set_flipX(bool value) { }

	[Address(RVA = "0x2FEB8E0", Offset = "0x2FEACE0", Length = "0x42")]
	[Token(Token = "0x60001CC")]
	private static void set_flipX_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FEBA10", Offset = "0x2FEAE10", Length = "0x86")]
	[Token(Token = "0x60001B1")]
	public void set_flipY(bool value) { }

	[Address(RVA = "0x2FEB9C0", Offset = "0x2FEADC0", Length = "0x42")]
	[Token(Token = "0x60001CE")]
	private static void set_flipY_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FEBAF0", Offset = "0x2FEAEF0", Length = "0x86")]
	[Token(Token = "0x600019F")]
	internal void set_hasSpriteChangeEvents(bool value) { }

	[Address(RVA = "0x2FEBAA0", Offset = "0x2FEAEA0", Length = "0x42")]
	[Token(Token = "0x60001BC")]
	private static void set_hasSpriteChangeEvents_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FEBBC0", Offset = "0x2FEAFC0", Length = "0x83")]
	[Token(Token = "0x60001AD")]
	public void set_maskInteraction(SpriteMaskInteraction value) { }

	[Address(RVA = "0x2FEBB80", Offset = "0x2FEAF80", Length = "0x40")]
	[Token(Token = "0x60001CA")]
	private static void set_maskInteraction_Injected(IntPtr _unity_self, SpriteMaskInteraction value) { }

	[Address(RVA = "0x2FEBCA0", Offset = "0x2FEB0A0", Length = "0x80")]
	[Token(Token = "0x60001A5")]
	public void set_size(Vector2 value) { }

	[Address(RVA = "0x2FEBC50", Offset = "0x2FEB050", Length = "0x42")]
	[Token(Token = "0x60001C2")]
	private static void set_size_Injected(IntPtr _unity_self, in Vector2 value) { }

	[Address(RVA = "0x2FEBE50", Offset = "0x2FEB250", Length = "0xBA")]
	[Token(Token = "0x60001A1")]
	public void set_sprite(Sprite value) { }

	[Address(RVA = "0x2FEBE00", Offset = "0x2FEB200", Length = "0x42")]
	[Token(Token = "0x60001BE")]
	private static void set_sprite_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x2FEBD70", Offset = "0x2FEB170", Length = "0x83")]
	[Token(Token = "0x60001B3")]
	public void set_spriteSortPoint(SpriteSortPoint value) { }

	[Address(RVA = "0x2FEBD30", Offset = "0x2FEB130", Length = "0x40")]
	[Token(Token = "0x60001D0")]
	private static void set_spriteSortPoint_Injected(IntPtr _unity_self, SpriteSortPoint value) { }

	[Address(RVA = "0x2FEBF50", Offset = "0x2FEB350", Length = "0x83")]
	[Token(Token = "0x60001A9")]
	public void set_tileMode(SpriteTileMode value) { }

	[Address(RVA = "0x2FEBF10", Offset = "0x2FEB310", Length = "0x40")]
	[Token(Token = "0x60001C6")]
	private static void set_tileMode_Injected(IntPtr _unity_self, SpriteTileMode value) { }

	[Address(RVA = "0x2FEAC30", Offset = "0x2FEA030", Length = "0xBE")]
	[Token(Token = "0x600019B")]
	public void UnregisterSpriteChangeCallback(UnityAction<SpriteRenderer> callback) { }

}

