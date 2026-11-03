namespace UnityEngine.UIElements;

[Token(Token = "0x200026D")]
public class DynamicAtlasSettings
{
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400097E")]
	private int m_MinAtlasSize; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400097F")]
	private int m_MaxAtlasSize; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000980")]
	private int m_MaxSubTextureSize; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000981")]
	private DynamicAtlasFilters m_ActiveFilters; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000982")]
	private DynamicAtlasCustomFilter m_CustomFilter; //Field offset: 0x20

	[Token(Token = "0x17000328")]
	public DynamicAtlasFilters activeFilters
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x60010EB")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[Token(Token = "0x60010EC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700032A")]
	public DynamicAtlasCustomFilter customFilter
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60010EE")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60010EF")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000329")]
	public static DynamicAtlasFilters defaultFilters
	{
		[Address(RVA = "0x33E44B0", Offset = "0x33E38B0", Length = "0x7")]
		[Token(Token = "0x60010ED")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700032B")]
	public static DynamicAtlasSettings defaults
	{
		[Address(RVA = "0x33E44C0", Offset = "0x33E38C0", Length = "0x80")]
		[Token(Token = "0x60010F0")]
		 get { } //Length: 128
	}

	[Token(Token = "0x17000326")]
	public int maxAtlasSize
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x60010E7")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[Token(Token = "0x60010E8")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000327")]
	public int maxSubTextureSize
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x60010E9")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x60010EA")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000325")]
	public int minAtlasSize
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x60010E5")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x60010E6")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60010F1")]
	public DynamicAtlasSettings() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x60010EB")]
	public DynamicAtlasFilters get_activeFilters() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60010EE")]
	public DynamicAtlasCustomFilter get_customFilter() { }

	[Address(RVA = "0x33E44B0", Offset = "0x33E38B0", Length = "0x7")]
	[Token(Token = "0x60010ED")]
	public static DynamicAtlasFilters get_defaultFilters() { }

	[Address(RVA = "0x33E44C0", Offset = "0x33E38C0", Length = "0x80")]
	[Token(Token = "0x60010F0")]
	public static DynamicAtlasSettings get_defaults() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x60010E7")]
	public int get_maxAtlasSize() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x60010E9")]
	public int get_maxSubTextureSize() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x60010E5")]
	public int get_minAtlasSize() { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[Token(Token = "0x60010EC")]
	public void set_activeFilters(DynamicAtlasFilters value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60010EF")]
	public void set_customFilter(DynamicAtlasCustomFilter value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[Token(Token = "0x60010E8")]
	public void set_maxAtlasSize(int value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[Token(Token = "0x60010EA")]
	public void set_maxSubTextureSize(int value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x60010E6")]
	public void set_minAtlasSize(int value) { }

}

