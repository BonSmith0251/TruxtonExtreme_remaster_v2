namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x20001FB")]
public class VolumeParameter : VolumeParameter, IEquatable<VolumeParameter`1<T>>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400097E")]
	protected T m_Value; //Field offset: 0x0

	[Token(Token = "0x170001EA")]
	public override T value
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[Token(Token = "0x6000EFE")]
		 get { } //Length: 5
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[Token(Token = "0x6000EFF")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x14104C0", Offset = "0x140F8C0", Length = "0x32")]
	[Token(Token = "0x6000F00")]
	public VolumeParameter`1() { }

	[Address(RVA = "0x1410470", Offset = "0x140F870", Length = "0x4D")]
	[Token(Token = "0x6000F01")]
	protected VolumeParameter`1(T value, bool overrideState = false) { }

	[Address(RVA = "0x140B780", Offset = "0x140AB80", Length = "0xC9")]
	[Token(Token = "0x6000F0C")]
	public virtual object Clone() { }

	[Address(RVA = "0x140C4E0", Offset = "0x140B8E0", Length = "0x7C")]
	[Token(Token = "0x6000F0A")]
	public override bool Equals(VolumeParameter<T> other) { }

	[Address(RVA = "0x140C220", Offset = "0x140B620", Length = "0xDB")]
	[Token(Token = "0x6000F0B")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[Token(Token = "0x6000EFE")]
	public override T get_value() { }

	[Address(RVA = "0x140CBB0", Offset = "0x140BFB0", Length = "0x11D")]
	[Token(Token = "0x6000F06")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x140E2C0", Offset = "0x140D6C0", Length = "0x1F2")]
	[Token(Token = "0x6000F02")]
	internal virtual void Interp(VolumeParameter from, VolumeParameter to, float t) { }

	[Address(RVA = "0x140F170", Offset = "0x140E570", Length = "0x28")]
	[Token(Token = "0x6000F03")]
	public override void Interp(T from, T to, float t) { }

	[Address(RVA = "0x1410DE0", Offset = "0x14101E0", Length = "0xE5")]
	[Token(Token = "0x6000F08")]
	public static bool op_Equality(VolumeParameter<T> lhs, T rhs) { }

	[Address(RVA = "0x1411980", Offset = "0x1410D80", Length = "0x17")]
	[Token(Token = "0x6000F0D")]
	public static T op_Explicit(VolumeParameter<T> prop) { }

	[Address(RVA = "0x1411AA0", Offset = "0x1410EA0", Length = "0x109")]
	[Token(Token = "0x6000F09")]
	public static bool op_Inequality(VolumeParameter<T> lhs, T rhs) { }

	[Address(RVA = "0x140F470", Offset = "0x140E870", Length = "0x3E")]
	[Token(Token = "0x6000F04")]
	public void Override(T x) { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[Token(Token = "0x6000EFF")]
	public override void set_value(T value) { }

	[Address(RVA = "0x140F7B0", Offset = "0x140EBB0", Length = "0xD7")]
	[Token(Token = "0x6000F05")]
	public virtual void SetValue(VolumeParameter parameter) { }

	[Address(RVA = "0x140FC50", Offset = "0x140F050", Length = "0xAE")]
	[Token(Token = "0x6000F07")]
	public virtual string ToString() { }

}

