namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x2000223")]
public class ObjectParameter : VolumeParameter<T>
{
	[CompilerGenerated]
	[Token(Token = "0x2000224")]
	private sealed class <>c
	{
		[Token(Token = "0x400099F")]
		public static readonly <>c<T> <>9; //Field offset: 0x0
		[Token(Token = "0x40009A0")]
		public static Func<FieldInfo, Boolean> <>9__9_0; //Field offset: 0x0
		[Token(Token = "0x40009A1")]
		public static Func<FieldInfo, Int32> <>9__9_1; //Field offset: 0x0

		[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
		[Token(Token = "0x6000F6C")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000F6D")]
		public <>c() { }

		[Address(RVA = "0xA505A0", Offset = "0xA4F9A0", Length = "0x9C")]
		[Token(Token = "0x6000F6E")]
		internal bool <set_value>b__9_0(FieldInfo t) { }

		[Address(RVA = "0xA50640", Offset = "0xA4FA40", Length = "0x2C")]
		[Token(Token = "0x6000F6F")]
		internal int <set_value>b__9_1(FieldInfo t) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400099E")]
	private ReadOnlyCollection<VolumeParameter> <parameters>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x170001FA")]
	public virtual bool overrideState
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000F65")]
		 get { } //Length: 3
		[Address(RVA = "0xE0B640", Offset = "0xE0AA40", Length = "0x5")]
		[Token(Token = "0x6000F66")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170001F9")]
	internal ReadOnlyCollection<VolumeParameter> parameters
	{
		[Address(RVA = "0xE0B560", Offset = "0xE0A960", Length = "0x26")]
		[CompilerGenerated]
		[Token(Token = "0x6000F63")]
		internal get { } //Length: 38
		[Address(RVA = "0xE0B650", Offset = "0xE0AA50", Length = "0x63")]
		[CompilerGenerated]
		[Token(Token = "0x6000F64")]
		private set { } //Length: 99
	}

	[Token(Token = "0x170001FB")]
	public virtual T value
	{
		[Address(RVA = "0xE0B590", Offset = "0xE0A990", Length = "0xA9")]
		[Token(Token = "0x6000F67")]
		 get { } //Length: 169
		[Address(RVA = "0xE0B6C0", Offset = "0xE0AAC0", Length = "0x5D6")]
		[Token(Token = "0x6000F68")]
		 set { } //Length: 1494
	}

	[Address(RVA = "0xE0B460", Offset = "0xE0A860", Length = "0xFB")]
	[Token(Token = "0x6000F69")]
	public ObjectParameter`1(T value) { }

	[Address(RVA = "0xE0B320", Offset = "0xE0A720", Length = "0x134")]
	[CompilerGenerated]
	[Token(Token = "0x6000F6B")]
	private VolumeParameter <set_value>b__9_2(FieldInfo t) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000F65")]
	public virtual bool get_overrideState() { }

	[Address(RVA = "0xE0B560", Offset = "0xE0A960", Length = "0x26")]
	[CompilerGenerated]
	[Token(Token = "0x6000F63")]
	internal ReadOnlyCollection<VolumeParameter> get_parameters() { }

	[Address(RVA = "0xE0B590", Offset = "0xE0A990", Length = "0xA9")]
	[Token(Token = "0x6000F67")]
	public virtual T get_value() { }

	[Address(RVA = "0xE0AF10", Offset = "0xE0A310", Length = "0x409")]
	[Token(Token = "0x6000F6A")]
	internal virtual void Interp(VolumeParameter from, VolumeParameter to, float t) { }

	[Address(RVA = "0xE0B640", Offset = "0xE0AA40", Length = "0x5")]
	[Token(Token = "0x6000F66")]
	public virtual void set_overrideState(bool value) { }

	[Address(RVA = "0xE0B650", Offset = "0xE0AA50", Length = "0x63")]
	[CompilerGenerated]
	[Token(Token = "0x6000F64")]
	private void set_parameters(ReadOnlyCollection<VolumeParameter> value) { }

	[Address(RVA = "0xE0B6C0", Offset = "0xE0AAC0", Length = "0x5D6")]
	[Token(Token = "0x6000F68")]
	public virtual void set_value(T value) { }

}

